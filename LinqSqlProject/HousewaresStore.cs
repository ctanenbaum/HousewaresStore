using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqSqlProject
{
    public partial class HousewaresApp : Form
    {
        private String username;
        public HousewaresApp(string Username )
        {

            InitializeComponent();
            username = Username;
            using (var db = new DataClassesDataContext())
            {
                var listSaleItems = db.SalesItems.Where(s => s.ItemQuantity > 0).Select(s => s.ItemName + "  PRICE: $" + s.ItemPrice + "\n").ToList();
                foreach(string saleItem in listSaleItems)
                {
                    SaleItemListView.Items.Add(saleItem);
                }

            }

        }


        private void SaleItemListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            string selectedSaleItem = SaleItemListView.SelectedItems[0].Text;

            // Parse the item name and price from the selected sale item string
            string itemName = selectedSaleItem.Split(new string[] { "PRICE: $" }, StringSplitOptions.None)[0].Trim();
            decimal itemPrice = decimal.Parse(selectedSaleItem.Split(new string[] { "PRICE: $" }, StringSplitOptions.None)[1].Trim());

            using (var db = new DataClassesDataContext())
            {
                SalesItem saleItem = db.SalesItems.SingleOrDefault(s => s.ItemName == itemName && s.ItemPrice == itemPrice);

                // Subtract from the quantity of the sale item and save the changes to the database
                if (saleItem != null && saleItem.ItemQuantity >= quantityNumericUpDown.Value)
                {
                    decimal maxBalance = 400;                   
                    var user = db.UserDatas.FirstOrDefault(u => u.Username == username);
                    if (user != null)
                    {
                        if(user.Balance >= maxBalance)
                        {
                            MessageBox.Show("I'm sorry, your currrent balance if above the maximum balance of $400. " +
                                "\n You cannot make a purchase until you make a payment to your account.");
                        }
                        else
                        {
                            saleItem.ItemQuantity -= (int)quantityNumericUpDown.Value;
                            user.Balance += saleItem.ItemPrice * (int)quantityNumericUpDown.Value;
                            Random rnd = new Random();
                            String newPurchaseId;
                            do { newPurchaseId = rnd.Next(100, 999).ToString(); }

                            while (db.Purchases.Any(p => p.PurchaseID == newPurchaseId));
                            Purchase newPurchase = new Purchase()
                            {
                                PurchaseID = newPurchaseId,
                                PurchaseDate = DateTime.Now,
                                Username = username,
                                ItemID = saleItem.ItemID

                            };
                            db.Purchases.InsertOnSubmit(newPurchase);
                            db.SubmitChanges();
                        }
                        
                    }
                   

                }
                else
                {
                    MessageBox.Show("Insufficient quantity available for purchase.");
                }
            }
            MessageBox.Show("Thank you for your business! \nThe cost was added to your account balance.");
        }

        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            using (var db = new DataClassesDataContext())
            {
                var user = db.UserDatas.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    MessageBox.Show($"  {user.Username.ToString()} Balance: \n\n    \t    $ {user.Balance.ToString()}");
                }
            }

        }

        private void PayBalanceButton_Click(object sender, EventArgs e)
        {
            var payBalance = new PayBalance(username);
            payBalance.ShowDialog();
            
        }

        private void CheckPurchasesButton_Click(object sender, EventArgs e)
        {
            var checkPurchase = new PurchaseListForm(username);
            checkPurchase.ShowDialog();
           
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
