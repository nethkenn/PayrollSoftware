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
    public class db
    {
        public MySqlConnection con;
        //Constructor
        public db()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            con = new MySqlConnection("server=localhost;user id=root;database=payroll;password=water123");
        }

        public bool OpenCon()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseCon()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //string table -> table name
        //string[] columns -> column names
        //string[] values -> values 
        //Insert statement
        public void Insert(string table,string[] columns,string[] values)
        {
            try
            {
                this.Initialize();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO " + table + "(" + string.Join(",", columns) + ") VALUES('" + string.Join("','", values) + "')", con);
                int check = cmd.ExecuteNonQuery();
                con.Close();

                if (check == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
        }

        //string table -> table name
        //string[] columnandvalues -> column with values
        //string idvalue -> primaryvalue
        //string primarykey -> primary key column 
        //Update statement
        public void Update(string table,string[] columnandvalues,string idvalue,string primarykey)
        {
            this.Initialize();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE " + table + " SET " + string.Join(",", columnandvalues) + " WHERE " + primarykey + "=" + idvalue + "", con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

    }
}
