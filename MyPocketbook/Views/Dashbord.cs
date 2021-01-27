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
    public partial class Dashbord : Form
    {
        public static double forwardExpenseTotal = 1;
        public Dashbord()
        {
            InitializeComponent();

            //lblExpTotal.Text = ExpenseView.totalExpense.ToString();
            //lblIncomeTotal.Text = IncomeView.totalIncome.ToString();
            
            //Add total Expense for particular user
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            var value1 = database.Expenses.GroupBy(o => o.UserId.Equals(LoginView.forwardUserID)).Select(
                g => new { ID = g.Key, total = g.Sum(i => i.Amount) });

            foreach (var exp in value1)
            {               
                if(exp.ID == true)
                {
                    Console.WriteLine("ID = {0} TotalExpense = {1}", exp.ID, exp.total);
                    lblExpTotal.Text = exp.total.ToString();
                    forwardExpenseTotal = exp.total;
                }
            }

            //Add total Income for particular user
            var value2 = database.Incomes.GroupBy(o => o.UserId.Equals(LoginView.forwardUserID)).Select(
                g => new { ID = g.Key, total = g.Sum(i => i.Amount) });

            foreach (var inc in value2)
            {
                if (inc.ID == true)
                {
                    Console.WriteLine("ID = {0} TotalExpense = {1}", inc.ID, inc.total);
                    lblIncomeTotal.Text = inc.total.ToString();
                }
            }

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            // Check database
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            var display1 = from dis in database.Expenses
                          where dis.UserId.Equals(LoginView.forwardUserID)
                          select dis;

            var display2 = from dis in database.Incomes
                           where dis.UserId.Equals(LoginView.forwardUserID)
                           select dis;

            if (!display2.Any() && !display1.Any())
            {
                lblNoData01.Visible = true;
                lblNoData02.Visible = true;
                lblNoData03.Visible = true;
                lblNoData04.Visible = true;
                picChart.Visible = false;
                picGraph.Visible = false;
            }
            else
            {
                picChart.Visible = true;
                picGraph.Visible = true;
                lblNoData01.Visible = false;
                lblNoData02.Visible = false;
                lblNoData03.Visible = false;
                lblNoData04.Visible = false;
            }
        }
    }
}
