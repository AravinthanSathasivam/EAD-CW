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
    }
}
