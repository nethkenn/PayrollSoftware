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
        public Leave leave { get; set; }

        private db dbcon;
        private int company_id;
        private Payroll payroll;
        private EmployeeController employeecontroller;
        private string dynamic_form;
        public static Dictionary<int, List<int>> empid = new Dictionary<int, List<int>>();
        public static List<int> untagempid = new List<int>();
        private MySqlDataReader read;
        private bool exist;

        public TagEmployee(int id,string form)
        {
            InitializeComponent();
            dbcon              = new db();
            payroll            = new Payroll();
            employeecontroller = new EmployeeController();
            company_id         = id;
            dynamic_form       = form;
        }

        private void TagEmployee_Load(object sender, EventArgs e)
        {
            employeecontroller.LoadDepartment(payroll_filter_dept_tag);
            employeecontroller.LoadJobTitle(payroll_filter_job_tag, payroll_filter_dept_tag.SelectedValue.ToString());
            if (dbcon.OpenCon() == true)
            {
                CheckBox box;
                MySqlDataReader read;
                if (company_id != 0)
                {
                    string query = "SELECT * from tbl_payroll_employee_basic where payroll_employee_company_id=" + company_id + " ORDER by payroll_employee_last_name";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.con);
                    read = cmd.ExecuteReader();
                }
                else
                {
                    string query = "SELECT * from tbl_payroll_employee_basic ORDER by payroll_employee_last_name";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.con);
                    read = cmd.ExecuteReader();
                }

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

            //mark check the checkbox if found in dictionary(array)
            if (empid.Count != 0)
            {
                //loop the checkbox
                foreach (Control c in panelEmployee.Controls)
                {
                    if (c is CheckBox)
                    {
                        //if company exist in dictionary
                        if(empid.ContainsKey(company_id))
                        {
                            //if employee found in the dictionary
                            if (empid[company_id].Contains(Convert.ToInt32(c.Tag)))
                            {
                                 ((CheckBox)c).CheckState = CheckState.Checked;
                            }
                        }
             
                    }
                }
            }

        }

        private void payroll_filter_dept_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeecontroller.LoadJobTitle(payroll_filter_job_tag, payroll_filter_dept_tag.SelectedValue.ToString());
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            int check = 0;

            //remove all the value of the dictionary
            empid.Clear();

            // push/refill the value of the dictionary with the checked values
            foreach (Control c in panelEmployee.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        //if companyid doesn't exist in dictionary add it
                        if (!empid.ContainsKey(company_id))
                        {
                            empid.Add(company_id, new List<int> { Convert.ToInt32(c.Tag) });
                        }
                        else
                        {
                            //add again the checked value
                            empid[company_id].Add(Convert.ToInt32(c.Tag));
                        }

                        check++;
                    }
                }
            }

            switch (dynamic_form)
            {
                case "Leave":
                    if(empid.Count != 0)
                    {
                        payroll.RemoveUntaggedEmployee(empid,leave.dgvTaggedEmployee);

                        foreach (KeyValuePair<int, List<int>> item in empid)
                        {
                            foreach (int value in item.Value)
                            {
                                read = employeecontroller.GetEmployeeDetails(value.ToString());

                                if (read.HasRows == true)
                                {
                                    exist = payroll.CheckIfValueExistInDataGrid(leave.dgvTaggedEmployee, read["payroll_employee_id"].ToString());

                                    if (exist == false)
                                    {
                                        leave.dgvTaggedEmployee.Rows.Add(read["payroll_employee_last_name"].ToString() + ", " + read["payroll_employee_first_name"].ToString() + read["payroll_employee_middle_name"].ToString(),
                                                                        read["payroll_employee_id"],
                                                                        "0.00");
                                    }

                                }

                                read.Close();
                                dbcon.CloseCon();
                            }

                        }
                    }
                    else
                    {
                        leave.dgvTaggedEmployee.Rows.Clear();
                    }
                    this.Close();
                    break;

                default:
                    this.Close();
                    var type = Type.GetType("Payroll." + dynamic_form);
                    dynamic form = Activator.CreateInstance(type) as Form;
                    form.GetEmployeeID(empid);
                    break;
            }


        }

        private void Checkall_CheckStateChanged(object sender, EventArgs e)
        {
            if(Checkall.Checked)
            {
                //loop the checkbox
                foreach (Control c in panelEmployee.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).CheckState = CheckState.Checked;
                    }
                }
            }
            else
            {
                //loop the checkbox
                foreach (Control c in panelEmployee.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).CheckState = CheckState.Unchecked;
                        
                    }
                }
            }
        }
    }
}
