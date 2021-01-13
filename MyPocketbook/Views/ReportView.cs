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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.test.Expenses);
            // TODO: This line of code loads data into the 'test.Incomes' table. You can move, or remove it, as needed.
            this.incomesTableAdapter.Fill(this.test.Incomes);
            // TODO: This line of code loads data into the 'test.Incomes' table. You can move, or remove it, as needed.
            this.incomesTableAdapter.Fill(this.test.Incomes);

            this.reportViewer1.RefreshReport();
        }
    }
}
