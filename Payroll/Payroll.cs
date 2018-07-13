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
    public class Payroll
    {
        db dbcon = new db();

        //string query -> query
        //ComboBox combobox -> combobox
        //string tables -> table 
        //string displaymember -> display text
        // string valuemember  -> value combobox
        public void FillComboBox(string query,ComboBox combobox,string table, string displaymember, string valuemember)
        {
            dbcon.Initialize();

            if (dbcon.OpenCon() == true)
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbcon.con);
                DataSet ds = new DataSet();
                da.Fill(ds, table);
                combobox.DisplayMember = displaymember;
                combobox.ValueMember = valuemember;
                combobox.DataSource = ds.Tables[table];
                dbcon.con.Close();
            }
        }
    }
}
