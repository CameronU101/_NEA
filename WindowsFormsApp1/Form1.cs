using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginFrm : Form
    {
        public bool TextEmpty = true;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void PasswordTxt_Entering(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text) || TextEmpty == true)  
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
                TextEmpty = true;
            }

            else
            {
                TextEmpty = false;
            }
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_Entering(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text) || TextEmpty == true)
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
                TextEmpty = true;
            }

            else
            {
                TextEmpty = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
