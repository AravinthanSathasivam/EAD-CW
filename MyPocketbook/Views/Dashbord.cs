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
        public Dashbord()
        {
            InitializeComponent();

            //lblExpTotal.Text = ExpenseView.totalExpense.ToString();
            lblIncomeTotal.Text = IncomeView.totalIncome.ToString();
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            var result = database.Expenses.GroupBy(o => o.UserId.Equals(LoginView.forwardUserID)).Select(
                g => new { Name = g.Key, total = g.Sum(i => i.Amount) });


            foreach (var group in result)
            {               
                if(group.Name == true)
                {
                    Console.WriteLine("Name = {0} Totalcost={1}", group.Name, group.total);
                    lblExpTotal.Text = group.total.ToString();
                }
            }
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            var display = from dis in database.Expenses
                          where dis.UserId.Equals(LoginView.forwardUserID)
                          select dis;

            if (!database.Incomes.Any() || !display.Any())
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
