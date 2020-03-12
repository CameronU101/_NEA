using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class LoginFrm : Form
    {
        public bool UsernameTextEmpty = true;
        public bool PasswordTextEmpty = true;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username_input = UsernameTxt.Text;
            string password_input = PasswordTxt.Text;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cameron.unsted.COLLEGE\source\repos\CameronU101\_NEA\WindowsFormsApp1\Contribution Database.accdb";
            string strSQL = "SELECT * FROM User_Logins WHERE Username = '" + username_input + "' AND Password = '" + password_input + "'";

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            if (reader != null)
            {
                DatabaseFrm objDatabaseFrm = new DatabaseFrm();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void PasswordTxt_Entering(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text) || PasswordTextEmpty == true)  
            {
                PasswordTxt.Clear(); // When the text box is clicked on the sample text inside will disappear
            }
            PasswordTxt.PasswordChar = '*'; //This line make the User's input in the password textbox appear as *'s 
        }

        private void PasswordTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                PasswordTxt.PasswordChar = '\0';
                PasswordTxt.Text = "Password";
                PasswordTextEmpty = true;
            }

            else
            {
                PasswordTextEmpty = false;
            }
        }

        private void UsernameTxt_Entering(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text) || UsernameTextEmpty == true)
            {
                UsernameTxt.Clear(); // When the text box is clicked on the sample text inside will disappear
            }
        }

        private void UsernameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text))
            {
                UsernameTxt.PasswordChar = '\0';
                UsernameTxt.Text = "Username";
                UsernameTextEmpty = true;
            }

            else
            {
                UsernameTextEmpty = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
