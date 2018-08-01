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
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }

        private void btnCreateDeduction_Click(object sender, EventArgs e)
        {
            CreateDeductionDetails createDeduction = new CreateDeductionDetails();
            createDeduction.ShowDialog();
        }
    }
}
