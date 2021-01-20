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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            // Display User's FirstName 
            this.lblUserName.Text = LoginView.forwardFirstName;

            // Initialize Dashboard View

            //Nav-Button UI 
            pnlNavbar.Visible = true;
            pnlNavbar.Height = btnDashboard.Height;
            pnlNavbar.Top = btnDashboard.Top;
            pnlNavbar.Left = btnDashboard.Left;

            //Title Name
            lblTitleName.Text = "Dashboard";
            this.pnlViewLoader.Controls.Clear();

            //View Dashboard Form (Inside panel)
            Dashbord dashbord = new Dashbord()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashbord.FormBorderStyle = FormBorderStyle.None;
            this.pnlViewLoader.Controls.Add(dashbord);
            dashbord.Show();
        }

        private void OpenDashboard(object sender, EventArgs e)
        {
            //Nav-Button UI 
            pnlNavbar.Visible = true;
            pnlNavbar.Height = btnDashboard.Height;
            pnlNavbar.Top = btnDashboard.Top;
            pnlNavbar.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(255, 255, 255);

            //Title Name
            lblTitleName.Text = "Dashboard";
            this.pnlViewLoader.Controls.Clear();

            //View Dashboard Form (Inside panel)
            Dashbord dashbord = new Dashbord() { Dock = DockStyle.Fill, 
                TopLevel = false, TopMost = true};
            dashbord.FormBorderStyle = FormBorderStyle.None;
            this.pnlViewLoader.Controls.Add(dashbord);
            dashbord.Show();
        }

        private void OpenExpense(object sender, EventArgs e)
        {
            //Nav-Button UI 
            pnlNavbar.Height = btnExpense.Height;
            pnlNavbar.Top = btnExpense.Top;
            pnlNavbar.Left = btnExpense.Left;
            btnExpense.BackColor = Color.FromArgb(255, 255, 255);

            //Title Name
            lblTitleName.Text = "Expense";
            this.pnlViewLoader.Controls.Clear();

            //View Expense Form (Inside panel)
            ExpenseView expenseView = new ExpenseView() { Dock = DockStyle.Fill, 
                TopLevel = false, TopMost = true };
            expenseView.FormBorderStyle = FormBorderStyle.None;
            this.pnlViewLoader.Controls.Add(expenseView);
            expenseView.Show();
        }

        private void OpenIncome(object sender, EventArgs e)
        {
            //Nav-Button UI 
            pnlNavbar.Height = btnIncome.Height;
            pnlNavbar.Top = btnIncome.Top;
            pnlNavbar.Left = btnIncome.Left;
            btnIncome.BackColor = Color.FromArgb(255, 255, 255);

            //Title Name
            lblTitleName.Text = "Income";
            this.pnlViewLoader.Controls.Clear();

            //View Income Form
            IncomeView incomeView = new IncomeView()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            incomeView.FormBorderStyle = FormBorderStyle.None;
            this.pnlViewLoader.Controls.Add(incomeView);
            incomeView.Show();
        }

        private void OpenReport(object sender, EventArgs e)
        {
            //Nav-Button UI 
            pnlNavbar.Height = btnReport.Height;
            pnlNavbar.Top = btnReport.Top;
            pnlNavbar.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(255, 255, 255);

            //View Report Form
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
           
           var display = from dis in database.Expenses where dis.UserId.Equals(LoginView.forwardUserID) select dis;
            var display2 = from dis in database.Incomes where dis.UserId.Equals(LoginView.forwardUserID) select dis;

            if (!display.Any() || !display2.Any())
            {
                // tables are Empty
                MessageBox.Show("Please Enter Income And Expense Data");
            }
            else
            {
                ReportView report = new ReportView();
                report.ShowDialog();
                Console.WriteLine(!database.Incomes.Any());
                Console.WriteLine(!database.Expenses.Any());
            }
            

        }

        private void OpenPrediction(object sender, EventArgs e)
        {
            ExpensePrediction prediction = new ExpensePrediction();
            prediction.ShowDialog();

            //Nav-Button UI 
            pnlNavbar.Height = btnPredict.Height;
            pnlNavbar.Top = btnPredict.Top;
            pnlNavbar.Left = btnPredict.Left;
            btnPredict.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            SettingsView setting = new SettingsView();
            setting.ShowDialog();
            //Nav-Button UI 
            pnlNavbar.Height = btnSettings.Height;
            pnlNavbar.Top = btnSettings.Top;
            pnlNavbar.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void LogoutApp(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Log out? ",
                "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                LoginView loginView = new LoginView();
                loginView.ShowDialog();
                this.Close();
            }
                
            //Nav-Button UI 
            pnlNavbar.Height = btnLogout.Height;
            pnlNavbar.Top = btnLogout.Top;
            pnlNavbar.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnExpense_Leave(object sender, EventArgs e)
        {
            btnExpense.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnIncome_Leave(object sender, EventArgs e)
        {
            btnIncome.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnPredict_Leave(object sender, EventArgs e)
        {
            btnPredict.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(240, 242, 249);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(240, 242, 249);
        }
    }
}
