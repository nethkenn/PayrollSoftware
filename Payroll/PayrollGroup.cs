using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class PayrollGroup : Form
    {
        public PayrollGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PayrollGrouptabs tabs = new PayrollGrouptabs();
            tabs.ShowDialog();
        }
    }
}
