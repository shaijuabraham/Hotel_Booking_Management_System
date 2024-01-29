using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class LoginInClass
    {
        private string connectString;

        public LoginInClass(string connectionString)
        {
            connectString = connectionString;
        }
        // Giving access based on the user login

        public void LoginAccess(string username, string password, Form userForm, Form employeeForm)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT UserName, Password, UserType FROM UserloginandPassword WHERE UserName = '{username}' AND Password = '{password}'";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string userType = reader["UserType"].ToString();

                                    if (userType == "E")
                                    {
                                        employeeForm.Show();
                                    }
                                    else if (userType == "U")
                                    {
                                        userForm.Show();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Login failed. No matching user found."); 
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
        }

        public void InsertUser(string userName, string Password, string userType)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = "INSERT INTO UserloginandPassword (UserName, [Password], UserType) " +
                                    "VALUES (@UserName, @Password, @UserType)";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        // Use parameters to avoid SQL injection
                        myCommand.Parameters.AddWithValue("@UserName", userName);
                        myCommand.Parameters.AddWithValue("@Password", Password);
                        myCommand.Parameters.AddWithValue("@UserType", userType);
        

                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
