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
    public partial class ExpensePrediction : Form
    {
        public ExpensePrediction()
        {
            InitializeComponent();
            //Settting Date limit to date fields
            startDate.MinDate = DateTime.Today;
            endDate.MinDate = DateTime.Today;

            // intilizing values to datepickers 
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today.AddDays(1);
        }

        private void predictExpense(object sender, EventArgs e)
        {
            
            // Getting date values
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;

            // Find the Date difference
            TimeSpan difference = end - start;

            // Expense amount from Dashboard view
            var expenseTotal = Dashbord.forwardExpenseTotal;

            // Expense row from database for particular user
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            var count = database.Expenses.Count(t => t.User.Id == LoginView.forwardUserID);

            //Average Calcuation
            Console.WriteLine(count);
            var average = expenseTotal / count;
            average = Math.Round(average,2);


            Console.WriteLine(average);
            int days = difference.Days;

            //Prediction
             var simplePredict = average * days;

            //Prediction with Expense Total
            var predictWithExpense = expenseTotal + simplePredict;

            if (days > 0)
            {
                lblPrediction.Text = simplePredict.ToString();
                lblPredictionExp.Text = predictWithExpense.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Entry,\n Please enter valid range", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                startDate.Value = DateTime.Today;
                endDate.Value = DateTime.Today.AddDays(1);

            }
            

        }
    }
}
