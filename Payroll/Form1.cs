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
using System.IO;

namespace Payroll
{
    public partial class Form1 : Form
    {
        private db dbcon;
        private Payroll payroll;
        private CompanyController companycontroller;
        private AuditLogsController auditlogscontroller;
        private EmployeeController employeecontroller;

        public Form1()
        {
            InitializeComponent();
            dbcon   = new db();
            payroll = new Payroll();
            companycontroller = new CompanyController();
            auditlogscontroller = new AuditLogsController();
            employeecontroller = new EmployeeController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load rdo to combobox
            companycontroller.LoadRDO(payroll_company_rdo);
            //load bank to combobox
            companycontroller.LoadBDO(payroll_company_bank);
            //load company to datagrid
            companycontroller.LoadCompany(payroll_company_datagrid);
            //load auditlogs to datagrid
            auditlogscontroller.LoadAuditLogs(payroll_auditlogs_datagrid);
            //pass data grid view names
            auditlogscontroller.PassDataGridViewName(payroll_auditlogs_datagrid);
            companycontroller.PassDataGridViewName(payroll_company_datagrid);

            //combobox selectedIndex
            cmb_AuditlogsUsers.SelectedIndex = 0;

            //check if company is exist
            if (dbcon.CheckRecord("tbl_payroll_company") == "Exist")
            {
                btnCompanySave.Enabled = false;
                btnCompanyEdit.Enabled = false;
            }
    
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(201, 647);
            payroll_config_dropdown.Visible = false;
            if (btn_payroll_config.BackColor != Color.FromArgb(158, 158, 158))
            {
                btn_payroll_config.BackColor = Color.FromArgb(17, 33, 46);
            }
        }


        private void Form1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(34, 647);
            payroll_config_dropdown.Visible = false;
            if (btn_payroll_config.BackColor == Color.FromArgb(54, 153, 210))
            {
                btn_payroll_config.BackColor = Color.FromArgb(17, 33, 46);
            }
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            bool complete = true;

            foreach (Control c in CompanyPanel.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Name != "payroll_company_id")
                    {
                        MessageBox.Show(c.Tag.ToString() + " is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        complete = false;
                        c.Focus();
                        break;
                    }
                }
            }

            if (complete == true)
            {
                if(dbcon.OpenCon() == true)
                {
                    MemoryStream stream = new MemoryStream();

                    if (payroll_company_logo.Image != null)
                    {
                        payroll_company_logo.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    byte[] picturevalue   = stream.ToArray();

                    string[] column_name  = { "payroll_company_name",
                                              "payroll_company_code",
                                              "payroll_company_address",
                                              "payroll_company_contact",
                                              "payroll_company_email",
                                              "payroll_company_nature_of_business",
                                              "payroll_company_account_no",
                                              "payroll_company_tin",
                                              "payroll_company_sss",
                                              "payroll_company_philhealth",
                                              "payroll_company_pagibig",
                                              "payroll_company_archived",
                                              "payroll_company_rdo",
                                              "payroll_company_bank",
                                              "payroll_company_date_started" };
                    string table =          "tbl_payroll_company";
                    string[] column_value = {payroll_company_name.Text,
                                             payroll_company_code.Text,
                                             payroll_company_address.Text,
                                             payroll_company_code.Text,
                                             payroll_company_email.Text,
                                             payroll_company_nature_of_business.Text,
                                             payroll_company_account_no.Text,
                                             payroll_company_tin.Text,
                                             payroll_company_sss.Text,
                                             payroll_company_philhealth.Text,
                                             payroll_company_pagibig.Text,
                                             "0",
                                             payroll_company_rdo.SelectedValue.ToString(),
                                             payroll_company_bank.SelectedValue.ToString(),
                                             payroll_company_date_started.Value.ToString("yyyy-MM-dd")};
                    string picturecolumn  =  "payroll_company_logo";

                    if (dbcon.CheckRecord(table) != "Exist")
                    {
                        //insert company
                        dbcon.Insert(table, column_name, column_value, picturecolumn, picturevalue);

                        // insert audit logs
                        string table2 = "tbl_payroll_audit_logs";
                        string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
                        string[] column_value2 = { "nethken", "Add new Company named " + payroll_company_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                        dbcon.Insert(table2, column_name2, column_value2, "", null);

                        //load company to datagrid
                        companycontroller.LoadCompany(payroll_company_datagrid);
                        //clear textboxes and picture   
                        CompanyPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                        payroll_company_logo.Image = null;
                        btnCompanySave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Only one Company is allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCompanyUpload_Click(object sender, EventArgs e)
        {
            //show image
            companycontroller.ShowImage(CompanyFileDialog, payroll_company_logo);
        }

        private void payroll_company_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    DataGridViewRow row = this.payroll_company_datagrid.Rows[e.RowIndex];
                    
                    payroll_company_id.Text                       = row.Cells["payroll_company_id"].Value.ToString();
                    payroll_company_name.Text                     = row.Cells["payroll_company_name"].Value.ToString();
                    payroll_company_code.Text                     = row.Cells["payroll_company_code"].Value.ToString();
                    payroll_company_address.Text                  = row.Cells["payroll_company_address"].Value.ToString();
                    payroll_company_contact.Text                  = row.Cells["payroll_company_contact"].Value.ToString();
                    payroll_company_email.Text                    = row.Cells["payroll_company_email"].Value.ToString();
                    payroll_company_nature_of_business.Text       = row.Cells["payroll_company_nature_of_business"].Value.ToString();
                    payroll_company_account_no.Text               = row.Cells["payroll_company_account_no"].Value.ToString();
                    payroll_company_tin.Text                      = row.Cells["payroll_company_tin"].Value.ToString();
                    payroll_company_sss.Text                      = row.Cells["payroll_company_sss"].Value.ToString();
                    payroll_company_philhealth.Text               = row.Cells["payroll_company_philhealth"].Value.ToString();
                    payroll_company_pagibig.Text                  = row.Cells["payroll_company_pagibig"].Value.ToString();
                    payroll_company_rdo.SelectedValue             = row.Cells["payroll_company_rdo"].Value.ToString();
                    payroll_company_bank.SelectedValue            = row.Cells["payroll_company_bank"].Value.ToString();
                    payroll_company_date_started.Text             = row.Cells["payroll_company_date_started"].Value.ToString();

                    if (row.Cells["payroll_company_logo"].Value.GetType().ToString() != "System.DBNull")
                    {
                        MemoryStream str = new MemoryStream((byte[])row.Cells["payroll_company_logo"].Value);
                        payroll_company_logo.Image = Image.FromStream(str);
                        payroll_company_logo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        payroll_company_logo.Image = Properties.Resources.download;
                    }

                    btnCompanyEdit.Enabled = true;
            
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void btnCompanyEdit_Click(object sender, EventArgs e)
        {
            if (dbcon.OpenCon() == true)
            {
                MemoryStream stream = new MemoryStream();

                if (payroll_company_logo.Image != null)
                {
                    payroll_company_logo.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                byte[] picturevalue      = stream.ToArray();
                string picturecolumn     = "payroll_company_logo";
                string table             = "tbl_payroll_company";
                string idvalue           = payroll_company_id.Text;
                string primarykey        = "payroll_company_id";
                string[] columnandvalues = {"payroll_company_name='"+ payroll_company_name.Text + "'","payroll_company_code='"+payroll_company_code.Text+"'",
                                            "payroll_company_address='"+payroll_company_address.Text+"'","payroll_company_contact='"+payroll_company_contact.Text+"'",
                                            "payroll_company_email='"+payroll_company_email.Text+"'","payroll_company_nature_of_business='"+payroll_company_nature_of_business.Text+"'",
                                            "payroll_company_account_no='"+payroll_company_account_no.Text+"'","payroll_company_tin='"+payroll_company_tin.Text+"'",
                                            "payroll_company_sss='"+payroll_company_sss.Text+"'","payroll_company_philhealth='"+payroll_company_philhealth.Text+"'",
                                            "payroll_company_pagibig='"+payroll_company_pagibig.Text+"'","payroll_company_archived='0'","payroll_company_rdo='"+payroll_company_rdo.SelectedValue.ToString()+"'",
                                            "payroll_company_bank='"+payroll_company_bank.SelectedValue.ToString()+"'","payroll_company_date_started='"+payroll_company_date_started.Value.ToString("yyyy-MM-dd")+"'"};
                dbcon.Update(table, columnandvalues,idvalue, primarykey, picturecolumn,picturevalue);


                // insert audit logs
                string table2 = "tbl_payroll_audit_logs";
                string[] column_name2 = { "payroll_audit_logs_user", "payroll_audit_logs_changes", "payroll_audit_logs_datetime" };
                string[] column_value2 = { "nethken", "Edited Company named " + payroll_company_name.Text + "", DateTime.Now.ToString("yyyyMMddHHmmss").ToString() };
                dbcon.Insert(table2, column_name2, column_value2, "", null);

                companycontroller.LoadCompany(payroll_company_datagrid);
                //clear textboxes and picture   
                CompanyPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                payroll_company_logo.Image = null;
                btnCompanyEdit.Enabled = false;

            }
        }

        private void show_payroll_config_dropdown(object sender, EventArgs e)
        {
            panel1.Size = new Size(201, 647);
            payroll_config_dropdown.Visible = true;
            btn_payroll_config.BackColor = Color.FromArgb(54, 153, 210);
        }

        private void push_button(object sender, EventArgs e)
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    if (c.BackColor == Color.FromArgb(158, 158, 158))
                    {
                        c.BackColor = Color.FromArgb(41, 39, 40);
                    }
                }
            }

            this.ActiveControl.BackColor = Color.FromArgb(158, 158, 158);
        }

        private void btn_company_list_Click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.FromArgb(17, 33, 46);
            this.HideAllPanel(Controls);
            this.push_button(sender,e);
            CompanyPanel.Visible = true;
        }

        private void btn_employee_list_Click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.FromArgb(17, 33, 46);
            this.HideAllPanel(Controls);
            this.push_button(sender, e);
            EmployeePanel.Visible = true;
            employeecontroller.LoadCountry(payroll_employee_country_emp);
            employeecontroller.LoadCompany(payroll_employee_company_id_emp);
            employeecontroller.LoadTaxStatus(payroll_employee_tax_status_emp);
            employeecontroller.LoadEmploymentStatus(payroll_employee_contract_status_emp);
            employeecontroller.LoadDepartment(payroll_department_id_emp);
            employeecontroller.LoadEmploymentStatus(payroll_employee_filter_status);
            employeecontroller.LoadDepartment(payroll_employee_filter_dept);
            employeecontroller.LoadEmploymentStatus(payroll_employee_filter_status_sep);
            employeecontroller.LoadDepartment(payroll_employee_filter_dept_sep);
            employeecontroller.LoadJobTitle(payroll_jobtitle_id_emp,payroll_department_id_emp.SelectedValue.ToString());
            employeecontroller.LoadEmployeeActive(payroll_employee_datagrid_active);
            payroll_employee_gender_emp.SelectedIndex = 0;
        }

        public void HideAllPanel(Control.ControlCollection Controls)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    if (c.Name != "panel1")
                    {
                        c.Visible = false;
                    }

                }
            }
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.ShowDialog();
        }

        private void btn_job_title_Click(object sender, EventArgs e)
        {
            Jobtitle job = new Jobtitle();
            job.ShowDialog();
        }



        private void AuditDateChanged(object sender, EventArgs e)
        {
            auditlogscontroller.SearchDate(dateTimePickerAuditLogFrom.Value,dateTimePickerAuditLogTo.Value, cmb_AuditlogsUsers, payroll_auditlogs_datagrid);
        }

        private void btn_audit_trail_Click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.FromArgb(17, 33, 46);
            this.HideAllPanel(Controls);
            this.push_button(sender, e);
            AuditlogsPanel.Visible = true;
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            bool complete = true;

            string[] required = { "payroll_employee_first_name_emp", "payroll_employee_middle_name_emp", "payroll_employee_last_name_emp",
                                         "payroll_employee_number_emp", "payroll_employee_biometric_number_emp", "payroll_employee_contact_emp",
                                         "payroll_employee_company_id_emp","payroll_employee_email_emp","payroll_department_id_emp","payroll_jobtitle_id_emp",
                                        "payroll_group_id_emp","payroll_employee_contract_status_emp"};

            foreach (Control c in grpCreateEmployee.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (required.Contains(c.Name) && c.Text == "")
                    {
                        MessageBox.Show(c.Tag.ToString() + " is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        complete = false;
                        c.Focus();
                        break;
                    }
                }
            }

            if (complete == true)
            {
                if (dbcon.OpenCon() == true)
                {
                    string shift = (shift_code_id_emp.SelectedItem != null) ? shift_code_id_emp.SelectedValue.ToString() : "0";

                    string[] column_name = { "payroll_employee_company_id",
                                     "payroll_employee_first_name",
                                     "payroll_employee_middle_name",
                                     "payroll_employee_last_name",
                                     "payroll_employee_suffix_name",
                                     "payroll_employee_display_name",
                                     "payroll_employee_contact",
                                     "payroll_employee_email",
                                     "payroll_employee_birthdate",
                                     "payroll_employee_gender",
                                     "payroll_employee_number",
                                     "payroll_employee_biometric_number",
                                     "payroll_employee_atm_number",
                                     "payroll_employee_street",
                                     "payroll_employee_city",
                                     "payroll_employee_state",
                                     "payroll_employee_zipcode",
                                     "payroll_employee_country",
                                     "payroll_employee_tax_status",
                                     "payroll_employee_tin",
                                     "payroll_employee_sss",
                                     "payroll_employee_pagibig",
                                     "payroll_employee_philhealth",
                                     "shift_code_id"};
                    string table = "tbl_payroll_employee_basic";
                    string[] column_value = {payroll_employee_company_id_emp.SelectedValue.ToString(),
                                     payroll_employee_first_name_emp.Text,
                                     payroll_employee_middle_name_emp.Text,
                                     payroll_employee_last_name_emp.Text,
                                     payroll_employee_suffix_name_emp.Text,
                                     payroll_employee_display_name_emp.Text,
                                     payroll_employee_contact_emp.Text,
                                     payroll_employee_email_emp.Text,
                                     payroll_employee_birthdate_emp.Value.ToString("yyyy-MM-dd"),
                                     payroll_employee_gender_emp.SelectedItem.ToString(),
                                     payroll_employee_number_emp.Text,
                                     payroll_employee_biometric_number_emp.Text,
                                     payroll_employee_atm_number_emp.Text,
                                     payroll_employee_street_emp.Text,
                                     payroll_employee_city_emp.Text,
                                     payroll_employee_state_emp.Text,
                                     payroll_employee_zipcode_emp.Text,
                                     payroll_employee_country_emp.SelectedValue.ToString(),
                                     payroll_employee_tax_status_emp.Text,
                                     payroll_employee_tin_emp.Text,
                                     payroll_employee_sss_emp.Text,
                                     payroll_employee_pagibig_emp.Text,
                                     payroll_employee_philhealth_emp.Text,
                                     shift};

                    dbcon.Insert(table, column_name, column_value, "", null);
                    employeecontroller.LoadEmployeeActive(payroll_employee_datagrid_active);
                    grpCreateEmployee.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    addressTab.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }
            }
            /*if(complete != false)
            {
                foreach(Control b in companyTab.Controls)
                {
                    if (b is TextBox || b is ComboBox)
                    {
                        if (required.Contains(b.Name) && b.Text == "")
                        {
                            MessageBox.Show(b.Tag.ToString() + " is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            complete = false;
                            CreateEmployeeTabControl.SelectedTab = companyTab;
                            b.Focus();
                            break;
                        }
                    }
                }
            }*/



        }

        private void payroll_department_id_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeecontroller.LoadJobTitle(payroll_jobtitle_id_emp, payroll_department_id_emp.SelectedValue.ToString());
        }

        private void btn_holiday_Click(object sender, EventArgs e)
        {

        }

        private void btn_allowances_Click(object sender, EventArgs e)
        {

        }

        private void btn_deduction_Click(object sender, EventArgs e)
        {

        }

        private void btn_leave_Click(object sender, EventArgs e)
        {

        }

        private void btn_payroll_group_Click(object sender, EventArgs e)
        {

        }

        private void payroll_config_dropdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tax_period_Click(object sender, EventArgs e)
        {

        }

        private void btn_tax_table_Click(object sender, EventArgs e)
        {

        }
    }
}
    