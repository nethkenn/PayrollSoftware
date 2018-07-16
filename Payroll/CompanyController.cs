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
    public class CompanyController
    {
        private Payroll payroll = new Payroll();

        public void LoadCompany(DataGridView datagrid)
        {
            //load company to datagrid
            string company = "SELECT * from tbl_payroll_company";
            payroll.FillDataGrid(company, datagrid);
            datagrid.Columns["payroll_company_logo"].Visible = false;
            datagrid.Columns["payroll_company_id"].Visible   = false;
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
            CompanyFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
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
    }
}
