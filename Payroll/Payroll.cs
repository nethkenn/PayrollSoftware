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
        MySqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

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
                adapter = new MySqlDataAdapter(query, dbcon.con);
                ds = new DataSet();
                adapter.Fill(ds, table);
                combobox.DisplayMember = displaymember;
                combobox.ValueMember = valuemember;
                combobox.DataSource = ds.Tables[table];
                dbcon.con.Close();
            }
        }

        public void FillDataGrid(string query,DataGridView gridview)
        {
            dbcon.Initialize();

            if (dbcon.OpenCon() == true)
            {
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, dbcon.con);
                adapter.Fill(dt);
                gridview.DataSource = dt;
                dbcon.con.Close();

            }

        }
        public void SetHeaderText(string[] columname, string[] headerName, DataGridView datagridviewname)
        {
            int count = 0;
            
            foreach(string column in columname)
            {
                datagridviewname.Columns[column].HeaderText = headerName[count];
                count++;

            }
        }
        public void TagEmployee(object sender, EventArgs e, int id,string form)
        {
            TagEmployee emptag = new TagEmployee(id,form);
            emptag.ShowDialog();
        }

    }
}
