﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Payroll
{
    public partial class Leave : Form
    {
        private db dbcon;
        private Payroll payroll;
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public Leave()
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
        }

        private void Leave_Load(object sender, EventArgs e)
        {
            payroll_leave_temp_name.SelectedIndex = 0;
            dgvTaggedEmployee.Columns["leaveHours"].DefaultCellStyle.Format = "n2";
        }

        private void btnTagEmployee_Click(object sender, EventArgs e)
        {
            TagEmployee emptag = new TagEmployee(0, "Leave");
            emptag.leave = this;
            emptag.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TagEmployee.empid.Clear();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dbcon.OpenCon() == true)
            {
                //insert leave temp
                string table         =  "tbl_payroll_leave_temp";
                string[] column_name = {"payroll_leave_temp_is_cummulative",
                                        "payroll_leave_temp_name"};

                string[] column_value = { rdnYes.Checked == true ? "1" : "0",
                                          payroll_leave_temp_name.SelectedItem.ToString()};
                dbcon.Insert(table, column_name, column_value, "", null, true);

                //get leave temp id
                int leave_temp_id = dbcon.GetLastID(table, "payroll_leave_temp_id");
                for (int i = 0; i < dgvTaggedEmployee.Rows.Count; i++)
                {
                    Double leave_hours = Convert.ToDouble(dgvTaggedEmployee.Rows[i].Cells["leaveHours"].Value);
                    string table2 = "tbl_payroll_leave_employee";
                    string[] column_name2 = {"payroll_leave_temp_id",
                                         "payroll_employee_id",
                                         "payroll_leave_temp_hours"};

                    string[] column_value2 = { leave_temp_id.ToString(),
                                           dgvTaggedEmployee.Rows[i].Cells["empID"].Value.ToString(),
                                           leave_hours.ToString()};

                    dbcon.Insert(table2, column_name2, column_value2, "", null, false);

                }
            }

        }

        private void Leave_FormClosing(object sender, FormClosingEventArgs e)
        {
            TagEmployee.empid.Clear();
        }
    }
}
