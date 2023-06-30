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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            using (var db = new DataClassesDataContext())
            {
                var listUsernames = db.UserDatas.Select(u => u.Username).ToList();
                UsernameDropdown.DataSource = listUsernames;

            }
        }

        private void UsernameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string selectedUsername = UsernameDropdown.SelectedItem.ToString();
            string enteredPassword = PasswordTextbox.Text;

            using (var db = new DataClassesDataContext())
            {
                var userData = db.UserDatas.FirstOrDefault(u => u.Username == selectedUsername);

                if (userData != null && userData.Password == enteredPassword)
                {
                    var store = new HousewaresApp(selectedUsername);
                    store.ShowDialog();
                    this.Hide();
                }
                else
                {
                    // Password doesn't match, show an error message
                    MessageBox.Show("Incorrect password. Please try again.");
                }
            }
        }
    }
}
