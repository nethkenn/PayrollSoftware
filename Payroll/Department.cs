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
    public partial class Department : Form
    {
        private db dbcon;
        private Payroll payroll;

        public Department()
        {
            InitializeComponent();
            dbcon   = new db();
            payroll = new Payroll();
        }

        private void btnDeptSave_Click(object sender, EventArgs e)
        {
            if(payroll_department_name.Text != "")
            {
                string table           = "tbl_payroll_department";
                string[] column_name   = {"payroll_department_name"};
                string[] column_value  = {payroll_department_name.Text};
                dbcon.Insert(table, column_name, column_value, "", null,true);
                this.LoadActiveCompany();
                this.LoadArchiveCompany();


                // insert audit logs
                string table2 = "tbl_payroll_audit_logs";
                string[] column_name2 = { "payroll_audit_logs_user",
                                          "payroll_audit_logs_changes",
                                          "payroll_audit_logs_datetime" };
                string[] column_value2 = { "nethken", "Add new Department named " + payroll_department_name.Text + "",
                                            DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                dbcon.Insert(table2, column_name2, column_value2, "", null,false);

                payroll_department_name.Text = "";
                btnDeptArchived.Enabled      = false;
                btnDeptEdit.Enabled          = false;
            }
            else
            {
                MessageBox.Show("Please input a Department Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Department_Load(object sender, EventArgs e)
        {
            this.LoadActiveCompany();
            this.LoadArchiveCompany();
        }

        public void LoadActiveCompany()
        {
            //load active department to datagrid
            string active = "SELECT * from tbl_payroll_department where payroll_department_archived=0";
            payroll.FillDataGrid(active, payroll_department_datagrid_active);
            payroll_department_datagrid_active.Columns["payroll_department_id"].Visible = false;
            payroll_department_datagrid_active.Columns["payroll_department_archived"].Visible = false;
        }

        public void LoadArchiveCompany()
        {
            //load archive department to datagrid
            string archive = "SELECT * from tbl_payroll_department where payroll_department_archived=1";
            payroll.FillDataGrid(archive, payroll_department_datagrid_archive);
            payroll_department_datagrid_archive.Columns["payroll_department_id"].Visible = false;
            payroll_department_datagrid_archive.Columns["payroll_department_archived"].Visible = false;
        }

        private void btnDeptArchived_Click(object sender, EventArgs e)
        {
            string table             = "tbl_payroll_department";
            string idvalue           = payroll_department_id.Text;
            string primarykey        = "payroll_department_id";
            string[] columnandvalues = { "payroll_department_archived='1'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveCompany();
            this.LoadArchiveCompany();
            btnDeptArchived.Enabled = false;
            btnDeptSave.Enabled = true;
            btnDeptEdit.Enabled = false;

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user",
                                      "payroll_audit_logs_changes",
                                      "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Archived Department named " + payroll_department_name.Text + "",
                                        DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null,false);

            payroll_department_name.Text = "";
        }

        private void payroll_department_datagrid_archive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_department_datagrid_archive.Rows[e.RowIndex];

                payroll_department_name.Text = row.Cells["payroll_department_name"].Value.ToString();
                payroll_department_id.Text = row.Cells["payroll_department_id"].Value.ToString();
                btnDeptArchived.Enabled    = false;
                btnDeptRestore.Enabled     = true;
                btnDeptSave.Enabled        = false;


            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payroll_department_datagrid_active_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_department_datagrid_active.Rows[e.RowIndex];

                payroll_department_name.Text = row.Cells["payroll_department_name"].Value.ToString();
                payroll_department_id.Text   = row.Cells["payroll_department_id"].Value.ToString();
                btnDeptArchived.Enabled      = true;
                btnDeptRestore.Enabled       = false;
                btnDeptEdit.Enabled          = true;
                btnDeptSave.Enabled          = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabDept_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(tabDept.SelectedTab == tabDept.TabPages["activedepartment"])
           {
                btnDeptRestore.Enabled = false;
                btnDeptEdit.Enabled = false;
                btnDeptSave.Enabled = true;
            }
           else
           {
                btnDeptArchived.Enabled = false;
                btnDeptEdit.Enabled = false;
            }

            payroll_department_name.Text = "";
        }

        private void btnDeptRestore_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_department";
            string idvalue = payroll_department_id.Text;
            string primarykey = "payroll_department_id";
            string[] columnandvalues = { "payroll_department_archived='0'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveCompany();
            this.LoadArchiveCompany();
            btnDeptRestore.Enabled = false;
            btnDeptSave.Enabled = true;
            btnDeptEdit.Enabled = false;

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user",
                                      "payroll_audit_logs_changes",
                                      "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Restored Department named " + payroll_department_name.Text + "",
                                       DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null,false);

            payroll_department_name.Text = "";
        }

        private void btnDeptEdit_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_department";
            string idvalue = payroll_department_id.Text;
            string primarykey = "payroll_department_id";
            string[] columnandvalues = { "payroll_department_name='"+payroll_department_name.Text+"'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveCompany();
            this.LoadArchiveCompany();
            btnDeptArchived.Enabled = false;
            btnDeptEdit.Enabled = false;
            btnDeptSave.Enabled = true;

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user",
                                      "payroll_audit_logs_changes",
                                      "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Edited Department named " + payroll_department_name.Text + "",
                                        DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null,false);

            payroll_department_name.Text = "";
        }
    }
}
