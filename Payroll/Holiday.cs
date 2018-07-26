using System;
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
    public partial class Holiday : Form
    {
        private db dbcon;
        private Payroll payroll;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        public static Dictionary<int, List<int>> employee_id = new Dictionary<int, List<int>>();

        public Holiday()
        {
            InitializeComponent();
            dbcon   = new db();
            payroll = new Payroll();
        }
        public void LoadActiveHoliday()
        {
            //load active holiday to datagrid
            string active = "SELECT payroll_holiday_id,payroll_holiday_name,payroll_holiday_date,payroll_holiday_category from tbl_payroll_holiday where payroll_holiday_archived=0";
            payroll.FillDataGrid(active, payroll_datagrid_holiday_active);
            payroll_datagrid_holiday_active.Columns["payroll_holiday_id"].Visible = false;
        }

        public void LoadArchiveHoliday()
        {
            //load active holiday to datagrid
            string archive = "SELECT payroll_holiday_id,payroll_holiday_name,payroll_holiday_date,payroll_holiday_category from tbl_payroll_holiday where payroll_holiday_archived=1";
            payroll.FillDataGrid(archive, payroll_holiday_holiday_archive);
            payroll_datagrid_holiday_active.Columns["payroll_holiday_id"].Visible = false;
        }

        private void Holiday_Load(object sender, EventArgs e)
        {
            this.LoadActiveHoliday();
            this.LoadArchiveHoliday();
            payroll_holiday_category.SelectedIndex = 0;

            if (dbcon.OpenCon() == true)
            {
                Button box;

                string query         = "SELECT * from tbl_payroll_company where payroll_company_archived=0";
                cmd     = new MySqlCommand(query, dbcon.con);
                read = cmd.ExecuteReader();

                int y = 6;
                while (read.Read())
                {
                    //initialize box
                    box = new Button();
                    //set box properties
                    box.Location = new Point(6, y);
                    box.AutoSize = true;
                    box.Tag = read["payroll_company_id"].ToString();
                    box.Text = read["payroll_company_name"].ToString();
                    //add box to groupbox
                    panelHoliday.Controls.Add(box);
                    //add event to checkbox
                    int id     = Convert.ToInt32(read["payroll_company_id"]);
                    box.Click += (se, ev) => payroll.TagEmployee(se, ev, id,"Holiday");

                    y += 29;
                }

                dbcon.CloseCon();
                
            }
         
        }
        
        public void GetEmployeeID(Dictionary<int,List<int>> emp_id)
        {
            employee_id = emp_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (payroll_holiday_name.Text != "")
            {
                if (dbcon.OpenCon() == true)
                {
                    //insert holiday
                    string table          =  "tbl_payroll_holiday";
                    string[] column_name  = {"payroll_holiday_name",
                                             "payroll_holiday_date",
                                             "payroll_holiday_category" };
                    string[] column_value = { payroll_holiday_name.Text,
                                              payroll_holiday_date.Value.ToString("yyyy-MM-dd"),
                                              payroll_holiday_category.SelectedItem.ToString() };
                    dbcon.Insert(table, column_name, column_value, "", null,true);

                    int holiday_id = dbcon.GetLastID(table,"payroll_holiday_id");

                    foreach (KeyValuePair<int, List<int>> item in employee_id)
                    {
                        foreach (int value in item.Value)
                        {
                            //insert employee
                             string table2          =  "tbl_payroll_holiday_employee";
                             string[] column_name2  = {"payroll_company_id",
                                                       "payroll_employee_id",
                                                       "holiday_company_id" };
                             string[] column_value2 = { item.Key.ToString(),
                                                        value.ToString(),
                                                        holiday_id.ToString() };
                             dbcon.Insert(table2, column_name2, column_value2, "", null,false);
                        }

                        //insert company
                        string table3          = "tbl_payroll_holiday_company";
                        string[] column_name3  = {"payroll_company_id",
                                                 "payroll_holiday_id" };
                        string[] column_value3 = {item.Key.ToString(),
                                                  holiday_id.ToString()};
                        dbcon.Insert(table3, column_name3, column_value3, "", null,false);

                    }

                    // insert audit logs
                    string table4          = "tbl_payroll_audit_logs";
                    string[] column_name4  = { "payroll_audit_logs_user",
                                              "payroll_audit_logs_changes",
                                              "payroll_audit_logs_datetime" };
                    string[] column_value4 = { "nethken",
                                               "Add new Holiday named " + payroll_holiday_name.Text + "",
                                               DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                    dbcon.Insert(table4, column_name4, column_value4, "", null, false);

                    //clear textbox
                    this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }
            }


            this.LoadActiveHoliday();
            this.LoadArchiveHoliday();
            TagEmployee.empid.Clear();
        }

        private void payroll_datagrid_holiday_active_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_datagrid_holiday_active.Rows[e.RowIndex];

                payroll_holiday_name.Text = row.Cells["payroll_holiday_name"].Value.ToString();
                payroll_holiday_id.Text = row.Cells["payroll_holiday_id"].Value.ToString();
                payroll_holiday_category.SelectedItem = row.Cells["payroll_holiday_category"].Value.ToString();
                payroll_holiday_date.Text = row.Cells["payroll_holiday_date"].Value.ToString();

                Dictionary<int, List<int>> empids = new Dictionary<int, List<int>>();

                if (dbcon.OpenCon() == true)
                {
                    string query = "SELECT * from tbl_payroll_holiday_employee where holiday_company_id=" + payroll_holiday_id.Text + "";
                    cmd = new MySqlCommand(query, dbcon.con);
                    read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        if (!empids.ContainsKey(Convert.ToInt32(read["payroll_company_id"])))
                        {
                            empids.Add(Convert.ToInt32(read["payroll_company_id"]), new List<int> { Convert.ToInt32(read["payroll_employee_id"]) });
                        }
                        else
                        {
                            empids[Convert.ToInt32(read["payroll_company_id"])].Add(Convert.ToInt32(read["payroll_employee_id"]));
                        }
                    }

                    TagEmployee.empid = empids;
                    dbcon.CloseCon();
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnArchived.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

                if (dbcon.OpenCon() == true)
                {

                    //update holiday
                    string table = "tbl_payroll_holiday";
                    string idvalue = payroll_holiday_id.Text;
                    string primarykey = "payroll_holiday_id";
                    string[] columnandvalues = { "payroll_holiday_name='" + payroll_holiday_name.Text + "'",
                                                 "payroll_holiday_date='" + payroll_holiday_date.Value.ToString("yyyy-MM-dd") + "'",
                                                  "payroll_holiday_category='" + payroll_holiday_category.SelectedItem.ToString() + "'" };
                    dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
                    
                    //delete the tagged employees in the database
                    string where1 = "payroll_holiday_id="+payroll_holiday_id.Text+"";
                    string where2 = "holiday_company_id="+payroll_holiday_id.Text+"";
                    dbcon.Delete("tbl_payroll_holiday_company", where1);
                    dbcon.Delete("tbl_payroll_holiday_employee", where2);
                    
                    //insert employees
                    foreach (KeyValuePair<int, List<int>> item in employee_id)
                    {
                        foreach (int value in item.Value)
                        {
                            //insert employee
                            string table2 = "tbl_payroll_holiday_employee";
                            string[] column_name2 = {"payroll_company_id",
                                                           "payroll_employee_id",
                                                           "holiday_company_id" };
                            string[] column_value2 = { item.Key.ToString(),
                                                            value.ToString(),
                                                            payroll_holiday_id.Text };
                            dbcon.Insert(table2, column_name2, column_value2, "", null, false);
                        }

                        //insert company
                        string table3 = "tbl_payroll_holiday_company";
                        string[] column_name3 = {"payroll_company_id",
                                                     "payroll_holiday_id" };
                        string[] column_value3 = {item.Key.ToString(),
                                                      payroll_holiday_id.Text};
                        dbcon.Insert(table3, column_name3, column_value3, "", null, false);

                    }

                // insert audit logs
                string table4 = "tbl_payroll_audit_logs";
                string[] column_name4 = { "payroll_audit_logs_user",
                                              "payroll_audit_logs_changes",
                                              "payroll_audit_logs_datetime" };
                string[] column_value4 = { "nethken",
                                               "Edit Holiday named " + payroll_holiday_name.Text + "",
                                               DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                dbcon.Insert(table4, column_name4, column_value4, "", null, false);

                //clear textbox
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }

                dbcon.CloseCon();
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnArchived.Enabled = false;
                this.LoadActiveHoliday();
                this.LoadArchiveHoliday();
                TagEmployee.empid.Clear();
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_holiday";
            string idvalue = payroll_holiday_id.Text;
            string primarykey = "payroll_holiday_id";
            string[] columnandvalues = { "payroll_holiday_archived='1'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveHoliday();
            this.LoadArchiveHoliday();

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = {"payroll_audit_logs_user",
                                      "payroll_audit_logs_changes",
                                      "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Archived Holiday named " + payroll_holiday_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null, false);

            payroll_holiday_name.Text = "";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnArchived.Enabled = false;
            TagEmployee.empid.Clear();
        }

        private void payroll_holiday_holiday_archive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.payroll_holiday_holiday_archive.Rows[e.RowIndex];

                payroll_holiday_name.Text = row.Cells["payroll_holiday_name"].Value.ToString();
                payroll_holiday_id.Text = row.Cells["payroll_holiday_id"].Value.ToString();
                payroll_holiday_category.SelectedItem = row.Cells["payroll_holiday_category"].Value.ToString();
                payroll_holiday_date.Text = row.Cells["payroll_holiday_date"].Value.ToString();
                
                btnRestore.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string table = "tbl_payroll_holiday";
            string idvalue = payroll_holiday_id.Text;
            string primarykey = "payroll_holiday_id";
            string[] columnandvalues = { "payroll_holiday_archived='0'" };
            dbcon.Update(table, columnandvalues, idvalue, primarykey, "", null);
            this.LoadActiveHoliday();
            this.LoadArchiveHoliday();

            // insert audit logs
            string table2 = "tbl_payroll_audit_logs";
            string[] column_name2 = {"payroll_audit_logs_user",
                                      "payroll_audit_logs_changes",
                                      "payroll_audit_logs_datetime" };
            string[] column_value2 = { "nethken", "Restore Holiday named " + payroll_holiday_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
            dbcon.Insert(table2, column_name2, column_value2, "", null, false);

            payroll_holiday_name.Text = "";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnArchived.Enabled = false;
            btnRestore.Enabled = false;
            TagEmployee.empid.Clear();
        }
    }
}
