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
        }

        private void predictExpense(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            TimeSpan difference = date2 - date1;
            int days = difference.Days;
            if (days > 0)
            {
                lblPrediction.Text = days.ToString();
            }
            else
            {
                lblPrediction.Text = " Invalid Entry, Please enter valid range";
            }
            

        }
    }
}
