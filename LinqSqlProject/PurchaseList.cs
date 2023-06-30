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
    public partial class PurchaseListForm : Form
    {
        private String username;
        public PurchaseListForm(String Username)
        {
            InitializeComponent();
            username = Username;
           
           
        }

        private void PurchaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void AllPurchases_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void byDatePurchases_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DisplayPurchasesButton_Click(object sender, EventArgs e)
        {
            PurchaseList.Items.Clear();
            using (var db = new DataClassesDataContext())
            {
                if (AllPurchases.Checked)
                {
                    var query = db.Purchases
                        .Where(p => p.Username == username)
                        .Select(p => new
                        { 
                            ItemName = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemName,
                            ItemPrice = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemPrice,
                            p.PurchaseDate
                        });

                    PurchaseList.Items.Add("Items Purchased: \n   ");
                    foreach (var item in query)
                    {
                        string itemInfo = $"{item.ItemName} - ${item.ItemPrice:F2} - {item.PurchaseDate.ToString("dd/MM/yyyy")}";
                        PurchaseList.Items.Add(itemInfo);
                    }
                }
                else if (byDatePurchases.Checked)
                {
                    DateTime fromDate = fromDatePicker.Value;
                    DateTime toDate = toDatePicker.Value;
                    var query = db.Purchases
                        .Where(p => p.Username == username && p.PurchaseDate >= fromDate && p.PurchaseDate <= toDate)
                        .Select(p => new
                        {
                            ItemName = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemName,
                            ItemPrice = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemPrice,
                            p.PurchaseDate
                        });

                    PurchaseList.Items.Add("Items Purchased: \n   ");
                    foreach (var item in query)
                    {
                        string itemNameAndDate = $"{item.ItemName} - ${item.ItemPrice:F2} - {item.PurchaseDate.ToString("dd/MM/yyyy")}";
                        PurchaseList.Items.Add(itemNameAndDate);
                    }
                }
                else if (ShowByPrice.Checked)
                {
                    decimal minPrice = decimal.Parse(MinPrice.Text);
                    decimal maxPrice = decimal.Parse(MaxPrice.Text);
                    var query = db.Purchases
                        .Where(p => p.Username == username && db.SalesItems.Any(s => s.ItemID == p.ItemID && s.ItemPrice >= minPrice && s.ItemPrice <= maxPrice))
                        .Select(p => new
                        {
                            ItemName = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemName,
                            ItemPrice = db.SalesItems.FirstOrDefault(s => s.ItemID == p.ItemID).ItemPrice,
                            p.PurchaseDate
                        })
                        .OrderBy(ps => ps.ItemPrice);

                    PurchaseList.Items.Add("Items Purchased: \n   ");
                    foreach (var item in query)
                    {
                        string itemNameAndPrice = $"{item.ItemName} - ${item.ItemPrice:F2} - {item.PurchaseDate.ToString("dd/MM/yyyy")}";
                        PurchaseList.Items.Add(itemNameAndPrice);
                    }
                }
            }
        }

        private void ShowByPrice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MinPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
