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
using System.IO;

namespace Payroll
{
    public partial class Form1 : Form
    {
        private db dbcon;
        private Payroll payroll;
        private CompanyController companycontroller;
        private AuditLogsController auditlogscontroller;

        public Form1()
        {
            InitializeComponent();
            dbcon   = new db();
            payroll = new Payroll();
            companycontroller = new CompanyController();
            auditlogscontroller = new AuditLogsController();
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
                btn_payroll_config.BackColor = Color.FromArgb(41, 39, 40);
            }
        }


        private void Form1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(57, 647);
            payroll_config_dropdown.Visible = false;
            if (btn_payroll_config.BackColor == Color.FromArgb(54, 153, 210))
            {
                btn_payroll_config.BackColor = Color.FromArgb(41, 39, 40);
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

                    string[] column_name  = { "payroll_company_name","payroll_company_code","payroll_company_address", "payroll_company_contact",
                                             "payroll_company_email","payroll_company_nature_of_business","payroll_company_account_no",
                                              "payroll_company_tin","payroll_company_sss","payroll_company_philhealth","payroll_company_pagibig",
                                               "payroll_company_archived","payroll_company_rdo","payroll_company_bank","payroll_company_date_started"};
                    string table =          "tbl_payroll_company";
                    string[] column_value = {payroll_company_name.Text,payroll_company_code.Text,payroll_company_address.Text,payroll_company_code.Text
                                            ,payroll_company_email.Text,payroll_company_nature_of_business.Text,payroll_company_account_no.Text,
                                            payroll_company_tin.Text,payroll_company_sss.Text,payroll_company_philhealth.Text,payroll_company_pagibig.Text,
                                            "0",payroll_company_rdo.SelectedValue.ToString(),payroll_company_bank.SelectedValue.ToString(),
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
            this.ActiveControl.BackColor = Color.FromArgb(49, 46, 48);
            this.HideAllPanel(Controls);
            this.push_button(sender,e);
            CompanyPanel.Visible = true;
        }

        private void btn_employee_list_Click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.FromArgb(49, 46, 48);
            this.HideAllPanel(Controls);
            this.push_button(sender, e);
            CompanyPanel.Visible = true;
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
            auditlogscontroller.SearchDate(dateTimePickerAuditLogFrom.Value,dateTimePickerAuditLogTo.Value, payroll_auditlogs_datagrid);
        }
    }
}
    