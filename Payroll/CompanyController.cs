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
    public class CompanyController
    {
        private Payroll payroll = new Payroll();

        public void LoadCompany(DataGridView datagrid)
        {
            //load company to datagrid
            string company  = "SELECT company.* , bank.bank_name from tbl_payroll_company as company";
                   company += " LEFT JOIN tbl_payroll_bank_convertion as bank";
                   company += " ON company.payroll_company_bank = bank.payroll_bank_convertion_id";
            payroll.FillDataGrid(company, datagrid);
            datagrid.Columns["payroll_company_logo"].Visible = false;
            datagrid.Columns["payroll_company_id"].Visible   = false;
            datagrid.Columns["payroll_company_archived"].Visible = false;
            datagrid.Columns["payroll_company_bank"].Visible = false;
        }

        public void LoadRDO(ComboBox payroll_company_rdo)
        {
            //load rdo to combobox
            string rdo = "SELECT payroll_rdo_id, Concat(rdo_code, ' - ',rdo_location) AS rdocon from tbl_payroll_rdo";
            payroll.FillComboBox(rdo, payroll_company_rdo, "RDO", "rdocon", "payroll_rdo_id");
        }
        
        public void LoadBDO(ComboBox payroll_company_bank)
        {
            //load bank to combobox
            string bank = "SELECT * from tbl_payroll_bank_convertion";
            payroll.FillComboBox(bank, payroll_company_bank, "BANK", "bank_name", "payroll_bank_convertion_id");
        }

        public void ShowImage(OpenFileDialog CompanyFileDialog, PictureBox payroll_company_logo)
        {
            CompanyFileDialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            //show image
            if (CompanyFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image logo = Bitmap.FromFile(CompanyFileDialog.FileName);
                    payroll_company_logo.Image = logo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void PassDataGridViewName(DataGridView datagridviewname)
        {
            string[] columname = {"payroll_company_name",
                                  "payroll_company_address",
                                  "payroll_company_contact",
                                  "payroll_company_email",
                                  "payroll_company_nature_of_business",
                                  "payroll_company_rdo",
                                  "payroll_company_date_started",
                                  "payroll_company_tin",
                                  "payroll_company_sss",
                                  "payroll_company_philhealth",
                                  "payroll_company_pagibig",
                                  "payroll_company_code",
                                  "bank_name"};
            string[] headerName = {"Name",
                                   "Address",
                                   "Contact",
                                   "Email",
                                   "Nature of Business",
                                   "RDO",
                                   "Date Started",
                                   "TIN",
                                   "SSS",
                                   "Philhealth",
                                   "Pagibig",
                                   "Company Code",
                                   "Bank"};
            payroll.SetHeaderText(columname, headerName, datagridviewname);
        }
    }
}
