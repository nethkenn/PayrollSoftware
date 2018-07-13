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

        public Form1()
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load rdo to combobox
            string rdo = "SELECT payroll_rdo_id, Concat(rdo_code, ' - ',rdo_location) AS rdocon from tbl_payroll_rdo";
            payroll.FillComboBox(rdo, payroll_company_rdo,"RDO","rdocon","payroll_rdo_id");

            //load rdo to combobox
            string bank = "SELECT * from tbl_payroll_bank_convertion";
            payroll.FillComboBox(bank, payroll_company_bank, "BANK", "bank_name", "payroll_bank_convertion_id");
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
                    if (c.Text == "")
                    {
                        MessageBox.Show(c.Tag.ToString() + " is Required");
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

                    byte[] logo = stream.ToArray();

                    string[] column_name = { "payroll_company_name","payroll_company_code","payroll_company_address", "payroll_company_contact",
                                             "payroll_company_email","payroll_company_nature_of_business","payroll_company_account_no",
                                              "payroll_company_tin","payroll_company_sss","payroll_company_philhealth","payroll_company_pagibig",
                                               "payroll_company_archived","payroll_company_rdo","payroll_company_bank","payroll_company_date_started","payroll_company_logo"};
                    string table = "tbl_payroll_company";
                    string[] column_value = {payroll_company_name.Text,payroll_company_code.Text,payroll_company_address.Text,payroll_company_code.Text
                                            ,payroll_company_email.Text,payroll_company_nature_of_business.Text,payroll_company_account_no.Text,
                                            payroll_company_tin.Text,payroll_company_sss.Text,payroll_company_philhealth.Text,payroll_company_pagibig.Text,
                                            "0",payroll_company_rdo.SelectedValue.ToString(),payroll_company_bank.SelectedValue.ToString(),
                                             payroll_company_date_started.Value.ToString("yyyy-MM-dd"),logo.ToString()};

                    dbcon.Insert(table,column_name,column_value);
                }
            }
        }

        private void btnCompanyUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog CompanyFileDialog = new OpenFileDialog();

            if(CompanyFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image logo = Bitmap.FromFile(CompanyFileDialog.FileName);
                    payroll_company_logo.Image = logo;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
