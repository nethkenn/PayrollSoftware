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
    public class EmployeeController
    {
        private db dbcon = new db();
        private Payroll payroll = new Payroll();
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public void LoadCountry(ComboBox payroll_country)
        {
            //load country to combobox
            string country = "SELECT * from tbl_country";
            payroll.FillComboBox(country, payroll_country, "COUNTRY", "country_name", "country_id");
        }

        public void LoadCompany(ComboBox payroll_company)
        {
            //load company to combobox
            string company = "SELECT * from tbl_payroll_company";
            payroll.FillComboBox(company, payroll_company, "COMPANY", "payroll_company_name", "payroll_company_id");
        }

        public void LoadTaxStatus(ComboBox payroll_tax)
        {
            //load tax to combobox
            string tax = "SELECT * from tbl_payroll_tax_status";
            payroll.FillComboBox(tax, payroll_tax, "TAX", "payroll_tax_status_name", "payroll_tax_status_name");
        }

        public void LoadEmploymentStatus(ComboBox payroll_employment)
        {
            //load employment_status to combobox
            string emp_status = "SELECT * from tbl_payroll_employment_status";
            payroll.FillComboBox(emp_status, payroll_employment, "EMPLOYMENT", "employment_status", "payroll_employment_status_id");
        }

        public void LoadDepartment(ComboBox payroll_department)
        {
            //load department to combobox
            string department = "SELECT * from tbl_payroll_department";
            payroll.FillComboBox(department, payroll_department, "DEPARTMENT", "payroll_department_name", "payroll_department_id");
        }

        public void LoadEmployeeActive(DataGridView payroll_active_grid)
        {
            //load employee to datagrid
            string active = "SELECT * from tbl_payroll_employee_basic";
            payroll.FillDataGrid(active, payroll_active_grid);
        }

        public void LoadJobTitle(ComboBox payroll_job, string department)
        {
            if(department != "")
            {
                //load jobtitle to combobox
                string jobtitle = "SELECT * from tbl_payroll_jobtitle where payroll_jobtitle_department_id='"+department+"'";
                payroll.FillComboBox(jobtitle, payroll_job, "JOBTITLE", "payroll_jobtitle_name", "payroll_jobtitle_id");
            }

        }

        public MySqlDataReader GetEmployeeDetails(string empid)
        {
            if (dbcon.OpenCon() == true)
            {
                string query = "SELECT * from tbl_payroll_employee_basic where payroll_employee_id=" + empid + "";
                cmd = new MySqlCommand(query, dbcon.con);
                read = cmd.ExecuteReader();
                read.Read();
                return read;
            }

            return read;
        }

    }
}
