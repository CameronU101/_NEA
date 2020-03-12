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
    public partial class DatabaseFrm : Form
    {
        public DatabaseFrm()
        {
            InitializeComponent();
        }

        private void DatabaseFrm_Shown(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cameron.unsted.COLLEGE\source\repos\CameronU101\_NEA\WindowsFormsApp1\Contribution Database.accdb";
            string strSQL = "SELECT (PledgeID, Contribution(£), FirstName, LastName, PledgeDate, Email, Mobile Number) FROM Contributers, Pledges;"//look at moodle powerpoint t3
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatabaseFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
