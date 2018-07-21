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
        public static int[] emp_id;

        public Holiday()
        {
            InitializeComponent();
            dbcon = new db();
            payroll = new Payroll();
        }

        private void Holiday_Load(object sender, EventArgs e)
        {
            if (dbcon.OpenCon() == true)
            {
                Button box;

                string query = "SELECT * from tbl_payroll_company where payroll_company_archived=0";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.con);
                MySqlDataReader read = cmd.ExecuteReader();

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
                    int id = Convert.ToInt32(read["payroll_company_id"]);
                    box.Click += (se, ev) => payroll.TagEmployee(se, ev, id,"Holiday");
                    y += 29;
                }

                dbcon.CloseCon();
                
            }
         
        }
        
        public void GetEmployeeID(int[] employee_id)
        {
            emp_id = employee_id;
            MessageBox.Show(string.Join(Environment.NewLine, emp_id));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MessageBox.Show(string.Join(Environment.NewLine, emp_id));
        }
    }
}
