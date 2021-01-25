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
            if (ExpenseView.totalExpense != 0)
            {
                lblPrediction.Text = (ExpenseView.totalExpense / 12).ToString();
            }
            
        }

        private void predictExpense(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
        }
    }
}
