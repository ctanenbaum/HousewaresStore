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
    public partial class PayBalance : Form
    {
        private String username;
        public PayBalance(String Username)
        {
           username = Username;
            InitializeComponent();
        }


        private void PayButton_Click(object sender, EventArgs e)
        {
            using (var db = new DataClassesDataContext())
            {
                var user = db.UserDatas.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    string rawValue = EnterAmountMaskTextbox.Text;
                    if (decimal.TryParse(rawValue, out decimal amount))
                    {
                        user.Balance -= amount;
                        db.SubmitChanges();
                        MessageBox.Show("Recieved...thank you for shopping!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    MessageBox.Show("not working...");
                }
                
            }
                
        }

        private void EnterAmountMaskTextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
