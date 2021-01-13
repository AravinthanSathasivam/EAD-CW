using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyPocketbook.Views
{
    public partial class SignupView : Form
    {
        public static int userID = 0;
        TempData temp = new TempData();
        public SignupView()
        {
            InitializeComponent();
   
        }

        private void OpenLogin(object sender, EventArgs e)
        {
            this.Hide();
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
            this.Close();
            

        }

        private void CreateAccount(object sender, EventArgs e)
        {
            StoreDatabase();
            MessageBox.Show(" Created An Account Successfully !!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
            this.Close();
           
        }

        void StoreDatabase()
        {
            temp.User.AddUserRow(this.txtUserID.Text, this.txtPassword.Text,
                this.txtFirstName.Text, this.txtLastName.Text);

            //Store data into file
            temp.WriteXml(@"D:\Database\TempData.xml");

            //Forward data to database
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            User user = new User();
            user.UserName = this.txtUserID.Text;
            user.Password = this.txtPassword.Text;
            user.FirstName = this.txtFirstName.Text;
            user.LastName = this.txtLastName.Text;
            database.Users.Add(user);
            database.SaveChanges();
            userID = user.Id;
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

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name";
                txtFirstName.ForeColor = Color.Silver;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name";
                txtLastName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "Re-type Password")
            {
                txtRePassword.Text = "";
                txtRePassword.ForeColor = Color.Black;
            }
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "")
            {
                txtRePassword.Text = "Re-type Password";
                txtRePassword.ForeColor = Color.Silver;
            }
        }

        // Validating text Boxes
   
    }
}
