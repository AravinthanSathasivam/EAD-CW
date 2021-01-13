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
        public MultiDataEntryRow()
        {
            InitializeComponent();
        }

        void ClearText()
        {
            this.txtExpName.Text = this.txtExpAmount.Text = this.txtExpDescription.Text = "";
        }
    }
}
