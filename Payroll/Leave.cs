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
    public partial class Leave : Form
    {
        private db dbcon;
        private Payroll payroll;
        public static Dictionary<int, List<int>> employee_id = new Dictionary<int, List<int>>();

        public Leave()
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
        }

        public void GetEmployeeID(Dictionary<int, List<int>> emp_id)
        {
            employee_id = emp_id;

            int count = 0;
            foreach (KeyValuePair<int, List<int>> item in employee_id)
            {
                foreach (int value in item.Value)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvTaggedEmployee.Rows[count].Clone();
                    row.Cells[0].Value = item.Key.ToString();
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = value.ToString();
                    dgvTaggedEmployee.Rows.Add(row);

                    count++;
                }

            }
        }

        private void Leave_Load(object sender, EventArgs e)
        {
            payroll_leave_temp_name.SelectedIndex = 0;
        }

        private void btnTagEmployee_Click(object sender, EventArgs e)
        {
            payroll.TagEmployee(sender, e, 0, "Leave");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
