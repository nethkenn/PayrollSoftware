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

        public Form1()
        {
            InitializeComponent();
            dbcon   = new db();
            payroll = new Payroll();
            companycontroller = new CompanyController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load rdo to combobox
            companycontroller.LoadRDO(payroll_company_rdo);
            //load bank to combobox
            companycontroller.LoadBDO(payroll_company_bank);
            //load company to datagrid
            companycontroller.LoadCompany(payroll_company_datagrid);

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
            /* mySecondCustmControl1.Size = new Size(957, 406);
            firstCustomControl1.Size = new Size(811, 406);
            mySecondCustmControl1.Location = new Point(69, 156);
            firstCustomControl1.Location = new Point(69, 156);
            */

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(57, 647);
        }

        private void t_Paint(object sender, PaintEventArgs e)
        {

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
                        dbcon.Insert(table, column_name, column_value, picturecolumn, picturevalue);
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
                    DataGridViewRow row = this.payroll_company_datagrid.SelectedRows[e.RowIndex];
                    
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

                companycontroller.LoadCompany(payroll_company_datagrid);
                //clear textboxes and picture   
                CompanyPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                payroll_company_logo.Image = null;
                btnCompanyEdit.Enabled = false;
            }
        }
    }
}
