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
    public partial class TagEmployee : Form
    {
        private db dbcon;
        private int company_id;
        private Payroll payroll;
        private EmployeeController employeecontroller;
        private string dynamic_form;
        public int[] employee_id;
        public TagEmployee(int id,string form)
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
            employeecontroller = new EmployeeController();
            company_id = id;
            dynamic_form = form;
        }

        private void TagEmployee_Load(object sender, EventArgs e)
        {
            employeecontroller.LoadDepartment(payroll_filter_dept_tag);
            employeecontroller.LoadJobTitle(payroll_filter_job_tag, payroll_filter_dept_tag.SelectedValue.ToString());
            if (dbcon.OpenCon() == true)
            {
                CheckBox box;

                string query = "SELECT * from tbl_payroll_employee_basic where payroll_employee_company_id="+company_id+" ORDER by payroll_employee_last_name";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.con);
                MySqlDataReader read = cmd.ExecuteReader();

                int y = 3;
                while (read.Read())
                {
                    //initialize box
                    box = new CheckBox();
                    //set box properties
                    box.Location = new Point(6, y);
                    box.AutoSize = true;
                    box.Tag = read["payroll_employee_id"].ToString();
                    box.Text = read["payroll_employee_last_name"].ToString()+", "+read["payroll_employee_first_name"]+" "+read["payroll_employee_middle_name"];
                    //add box to panel
                    panelEmployee.Controls.Add(box);
                    
                    y += 23;
                }

                dbcon.CloseCon();

            }
        }

        private void payroll_filter_dept_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeecontroller.LoadJobTitle(payroll_filter_job_tag, payroll_filter_dept_tag.SelectedValue.ToString());
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            List<int> employee_id_list = new List<int>();
            foreach (Control c in panelEmployee.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        employee_id_list.Add(Convert.ToInt32(c.Tag));
                    }
                }
            }

            employee_id = employee_id_list.ToArray();

            var type = Type.GetType("Payroll." + dynamic_form);
            var form = Activator.CreateInstance(type) as Form;
            this.Close();

        }
    }
}
