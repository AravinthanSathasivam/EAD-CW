using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Controls
{
    public partial class MultiDataEntryRow : UserControl
    {
        TempData temp = new TempData();
        public MultiDataEntryRow()
        {
            InitializeComponent();
        }

        public String GetExpenseName()
        {
            return this.txtExpName.Text;
        }

        public String GetExpenseAmount()
        {
            return this.txtExpAmount.Text;
        }

        public String GetExpenseCategort()
        {
            return this.txtExpCategory.Text;
        }

        public DateTime GetDate()
        {
            return this.txtExpDate.Value;
        }

        public String GetDescrption()
        {
            return this.txtExpDescription.Text;
        }

        private void AmountValidation(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            //Validate Digit input field

            // Validate extra dot(.)
            if (input == 46 && txtExpAmount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            //Validate ( 8-Backspace 46-Shift Out )
            if (!Char.IsDigit(input) && input != 8 && input != 46)
            {
                e.Handled = true;
            }

        }

        private void MultiDataEntryRow_Load(object sender, EventArgs e)
        {
            //Adding Expense catagories to ComboBox
            txtExpCategory.Items.Add("Travel");
            txtExpCategory.Items.Add("Food");
            txtExpCategory.Items.Add("Entertainment");
            txtExpCategory.Items.Add("Loan");
            txtExpCategory.Items.Add("Others");
            txtExpCategory.SelectedIndex = 4;
        }
    }
}
