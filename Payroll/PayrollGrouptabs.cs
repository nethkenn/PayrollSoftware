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
    public partial class PayrollGrouptabs : Form
    {
        private Payroll payroll;
        public PayrollGrouptabs()
        {
            InitializeComponent();
            payroll = new Payroll();
        }

        private void CustomChecked(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ((RadioButton)sender).Parent.Size = new Size(568, 91);
            }
            else
            {
                ((RadioButton)sender).Parent.Size = new Size(568, 48);
            }          
        }

        private void PayrollGrouptabs_Load(object sender, EventArgs e)
        {
            ComboBox[] contribution = {philhealth_reference,sss_reference,tax_reference};
            ComboBox[] shiftingrules = { grace_time_rule_late, grace_time_rule_overtime };
            combobox_setvalues(contribution, "Reference");
            combobox_setvalues(shiftingrules, "shiftingrules");
        }

        private void combobox_setvalues(ComboBox[] _combobox, String reference)
        {
            if(reference == "Reference")
            {
                string[] name = { "Philhealth", "SSS", "Tax" };
                int count = 0;
                foreach (ComboBox combobox in _combobox)
                {
                    Dictionary<string, string> values = new Dictionary<string, string>();
                    values.Add("declared", "Declared " + name[count] + "Salary");
                    values.Add("gross_basic", "Computed Taxable Salary");
                    values.Add("net_basic", "Net Basic");
                    combobox.DataSource = new BindingSource(values, null);
                    combobox.DisplayMember = "Value";
                    combobox.ValueMember = "Key";
                    combobox.SelectedIndex = 0;
                    count++;
                }
            }
            else if(reference == "shiftingrules")
            {
                foreach(ComboBox combobox in _combobox)
                {
                    if(combobox == grace_time_rule_late)
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();
                        values.Add("per_shift", "Per Shift");
                        values.Add("accumulative", "Accumulative");
                        values.Add("first", "First Shift Only");
                        values.Add("last", "Last Shift Only");
                        combobox.DataSource = new BindingSource(values, null);
                        combobox.DisplayMember = "Value";
                        combobox.ValueMember = "Key";
                        combobox.SelectedIndex = 0;
                    }
                    else if(combobox == grace_time_rule_overtime)
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();
                        values.Add("per_shift", "Per Shift");
                        values.Add("accumulative", "Accumulative");
                        combobox.DataSource = new BindingSource(values, null);
                        combobox.DisplayMember = "Value";
                        combobox.ValueMember = "Key";
                        combobox.SelectedIndex = 0;
                    }
                }
            }

        }
        private void Grace_Time_Rule(ComboBox combobox, string[] values)
        {
            
        }

        private void tag_payroll_group_employee_Click(object sender, EventArgs e)
        {
            payroll.TagEmployee(sender, e, 0, "PayrollGrouptabs");
        }
    }
}
