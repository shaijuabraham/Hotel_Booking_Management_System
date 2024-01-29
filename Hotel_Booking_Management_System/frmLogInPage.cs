using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace Hotel_Booking_Management_System
{
    public partial class frmLogInPage : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";

        public frmLogInPage()
        {
            InitializeComponent();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            frmEmployee frmEmp = new frmEmployee();
            frmClient frmClient = new frmClient();
            LoginInClass loginInClass = new LoginInClass(connectString);
            frmLogInPage frmLogIn = new frmLogInPage();

            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username != null)
            {
               this.Hide();
              loginInClass.LoginAccess(username, password, frmClient, frmEmp);

            }
            else
            {
                MessageBox.Show("Enter the UserName");
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignup = new frmSignUp();
            this.Hide();
            frmSignup.StartPosition = FormStartPosition.CenterScreen;
            frmSignup.Show();

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient frmClient = new frmClient();
            frmClient.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp help = new frmHelp();
            help.Show();   
        }
    }
}
