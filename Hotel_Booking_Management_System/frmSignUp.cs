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
    public partial class frmSignUp : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string userType = "U";

            LoginInClass loginClass = new LoginInClass(connectString);
            loginClass.InsertUser(userName,password, userType);
            
            this.Hide();
            frmLogInPage frmLogin = new frmLogInPage();
            frmLogin.Show();
        }
    }
}
