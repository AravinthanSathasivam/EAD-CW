using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Views
{
    public partial class LoginView : Form
    {
        userNamePassword remember = new userNamePassword();
        // Variable to forward the user ID to other Forms
        public static int forwardUserID = 1;

        // Variable to forward the user ID to other Forms
        public static String forwardFirstName = "User Name";

        public LoginView()
        {
            InitializeComponent();

            //Reading File
            if(File.Exists(@"D:\UserTdTemp.xml") == true){
                remember.ReadXml(@"D:\UserTdTemp.xml");
                userNamePassword.LoginRow logindata = remember.Login[0];
                this.txtUserID.Text = logindata.userID;
                this.txtPassword.Text = logindata.password;
            }
        }

        private void OpenSignup(object sender, EventArgs e)
        {
            // Open Singup Form
            this.Hide();
            SignupView signupView = new SignupView();
            signupView.ShowDialog();
            this.Close();

   
        }

        private void LoginApp(object sender, EventArgs e)
        {
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            if (database != null)
            {
                var validateUser = database.Users.FirstOrDefault(u => u.UserName == txtUserID.Text);
                if (validateUser != null)
                {
                    if(validateUser.Password == txtPassword.Text)
                    {
                        Console.WriteLine("Login Successful!! ");
                        forwardUserID = validateUser.Id;
                        forwardFirstName = validateUser.FirstName;
                        Console.WriteLine(forwardUserID);
                        MessageBox.Show(" Login Successful!! \n Welcome " + forwardFirstName);
                        //Storing user name and password in a file
                        remember.Clear();
                        remember.Login.AddLoginRow(this.txtUserID.Text, this.txtPassword.Text);
                        remember.WriteXml(@"D:\UserTdTemp.xml");
                        this.Hide();
                        MainView main = new MainView();
                        main.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(" Wrong Password!!");
                        Console.WriteLine("Wrong Pasword");                      
                    }
                    
                }

                else
                {
                    MessageBox.Show("Invalid User Credentials");
                    Console.WriteLine(this.txtUserID);                  
                }
            }
            else
            {
                MessageBox.Show("Please Create a Profile");
                Console.WriteLine( "Issues");         
            } 
        }
         //PlaceHolder text
        private void txtUserID_Enter(object sender, EventArgs e)
        {
            if (txtUserID.Text == "User Name")
            {
                txtUserID.Text = "";
                txtUserID.ForeColor = Color.Black;
            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                txtUserID.Text = "User Name";
                txtUserID.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                ;
                txtPassword.ForeColor = Color.Silver;
            }
        }
    }
}
