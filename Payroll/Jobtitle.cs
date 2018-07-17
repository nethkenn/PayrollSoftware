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
    public partial class Jobtitle : Form
    {
        private db dbcon;
        private Payroll payroll;

        public Jobtitle()
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
        }

        private void Jobtitle_Load(object sender, EventArgs e)
        {
            this.LoadActiveJob();
            this.LoadArchiveJob();

            //load department to combobox
            string department = "SELECT * from tbl_payroll_department where payroll_department_archived=0";
            payroll.FillComboBox(department, payroll_jobtitle_department_id, "DEPARTMENT", "payroll_department_name", "payroll_department_id");
        }

        private void btnJobSave_Click(object sender, EventArgs e)
        {
            if(payroll_jobtitle_department_id.SelectedItem != null)
            {
                string table = "tbl_payroll_jobtitle";
                string[] column_name = { "payroll_jobtitle_department_id", "payroll_jobtitle_name" };
                string[] column_value = { payroll_jobtitle_department_id.SelectedValue.ToString(), payroll_jobtitle_name.Text };
                dbcon.Insert(table, column_name, column_value, "", null);
                this.LoadActiveJob();
                this.LoadArchiveJob();

                // insert audit logs
                string table2 = "tbl_payroll_audit_logs";
                string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
                string[] column_value2 = { "nethken", "Add new Job Title named " + payroll_jobtitle_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                dbcon.Insert(table2, column_name2, column_value2, "", null);

                payroll_jobtitle_name.Text = "";
                btnJobArchived.Enabled = false;
                btnJobEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a Department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadActiveJob()
        {
            //load active job to datagrid
            string active = "SELECT tbl_payroll_jobtitle.payroll_jobtitle_id, tbl_payroll_jobtitle.payroll_jobtitle_name, tbl_payroll_department.payroll_department_name, tbl_payroll_jobtitle.payroll_jobtitle_department_id  from tbl_payroll_jobtitle LEFT JOIN tbl_payroll_department ON tbl_payroll_jobtitle.payroll_jobtitle_department_id = tbl_payroll_department.payroll_department_id where payroll_jobtitle_archived=0";
            payroll.FillDataGrid(active, payroll_job_datagrid_active);
            payroll_job_datagrid_active.Columns["payroll_jobtitle_id"].Visible = false;
            payroll_job_datagrid_active.Columns["payroll_jobtitle_department_id"].Visible = false;
        }
         
        public void LoadArchiveJob()
        {
            //load archive job to datagrid
            string archive = "SELECT tbl_payroll_jobtitle.payroll_jobtitle_id, tbl_payroll_jobtitle.payroll_jobtitle_name, tbl_payroll_department.payroll_department_name, tbl_payroll_jobtitle.payroll_jobtitle_department_id from tbl_payroll_jobtitle LEFT JOIN tbl_payroll_department ON tbl_payroll_jobtitle.payroll_jobtitle_department_id = tbl_payroll_department.payroll_department_id where payroll_jobtitle_archived=1";
            payroll.FillDataGrid(archive, payroll_job_datagrid_archive);
            payroll_job_datagrid_archive.Columns["payroll_jobtitle_id"].Visible = false;
            payroll_job_datagrid_archive.Columns["payroll_jobtitle_department_id"].Visible = false;
        }

        private void tabJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabJob.SelectedTab == tabJob.TabPages["activejobtitle"])
            {
                btnJobRestore.Enabled = false;
                btnJobEdit.Enabled = false;
                btnJobSave.Enabled = true;
            }
            else
            {
                btnJobArchived.Enabled = false;
                btnJobEdit.Enabled = false;
            }

            payroll_jobtitle_name.Text = "";
        }

        private void btnJobEdit_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_jobtitle";
            string idvalue = payroll_jobtitle_id.Text;
            string primarykey = "payroll_jobtitle_id";
            string[] columnandvalues = { "payroll_jobtitle_department_id='" + payroll_jobtitle_department_id.SelectedValue.ToString() + "'", "payroll_jobtitle_name='" + payroll_jobtitle_name.Text + "'"};
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveJob();
            this.LoadArchiveJob();
            btnJobArchived.Enabled = false;
            btnJobEdit.Enabled = false;
            btnJobSave.Enabled = true;

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Edited Job Title named " + payroll_jobtitle_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null);

            payroll_jobtitle_name.Text = "";

        }

        private void payroll_job_datagrid_active_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_job_datagrid_active.Rows[e.RowIndex];

                payroll_jobtitle_name.Text = row.Cells["payroll_jobtitle_name"].Value.ToString();
                payroll_jobtitle_id.Text = row.Cells["payroll_jobtitle_id"].Value.ToString();
                payroll_jobtitle_department_id.SelectedValue = row.Cells["payroll_jobtitle_department_id"].Value.ToString();
                btnJobArchived.Enabled = true;
                btnJobRestore.Enabled = false;
                btnJobEdit.Enabled = true;
                btnJobSave.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payroll_job_datagrid_archive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_job_datagrid_archive.Rows[e.RowIndex];

                payroll_jobtitle_name.Text = row.Cells["payroll_jobtitle_name"].Value.ToString();
                payroll_jobtitle_id.Text = row.Cells["payroll_jobtitle_id"].Value.ToString();
                payroll_jobtitle_department_id.SelectedValue = row.Cells["payroll_jobtitle_department_id"].Value.ToString();
                btnJobArchived.Enabled = false;
                btnJobSave.Enabled = false;
                btnJobRestore.Enabled = true; 

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJobArchived_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_jobtitle";
            string idvalue = payroll_jobtitle_id.Text;
            string primarykey = "payroll_jobtitle_id";
            string[] columnandvalues = { "payroll_jobtitle_archived='1'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveJob();
            this.LoadArchiveJob();
            btnJobArchived.Enabled = false;

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Archived Job Title named " + payroll_jobtitle_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null);

            payroll_jobtitle_name.Text = "";
            btnJobSave.Enabled = true;
            btnJobEdit.Enabled = false;
        }

        private void btnJobRestore_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_jobtitle";
            string idvalue = payroll_jobtitle_id.Text;
            string primarykey = "payroll_jobtitle_id";
            string[] columnandvalues = { "payroll_jobtitle_archived='0'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveJob();
            this.LoadArchiveJob();
            btnJobRestore.Enabled = false;


            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Restored Job Title named " + payroll_jobtitle_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null);


            payroll_jobtitle_name.Text = "";
            btnJobSave.Enabled = true;
            btnJobEdit.Enabled = false;
        }
    }
}
