using MyPocketbook.Controls;
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
    public partial class MultipleExpenseEntryView : Form
    {
        public MultipleExpenseEntryView()
        {
            InitializeComponent();
        }

        MultiDataEntryRow[] arrEntryRow;
        
        private void AddExpanseRow(object sender, EventArgs e)
        {
            int numRows = Convert.ToInt32(this.txtEntryNum.Value);

            arrEntryRow = new MultiDataEntryRow[numRows];


            for (int i = 0; i < numRows; i++)
            {
                this.arrEntryRow[i] = new MultiDataEntryRow();
                this.arrEntryRow[i].Location = new Point(6, 140 + i * 45);
                this.Controls.Add(this.arrEntryRow[i]);
            }
        }


    }
}
