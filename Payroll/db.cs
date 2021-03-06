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

namespace Payroll
{
    public class db
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader read;
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
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
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
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        public string CheckRecord(string table)
        {
            try
            {
                this.Initialize();
                con.Open();
                cmd = new MySqlCommand("SELECT count(*) FROM "+table+"", con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if(count > 0)
                {
                    return "Exist";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "No Data";
        }

        public int GetLastID(string table,string column)
        {
            try
            {
                this.Initialize();
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM "+table+" ORDER BY "+column+" DESC LIMIT 1", con);
                read = cmd.ExecuteReader();
                read.Read();
                return Convert.ToInt32(read[""+column+""]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        //string table -> table name
        //string[] columns -> column names
        //string[] values -> values 
        //Insert statement
        public void Insert(string table,string[] columns,string[] values, string picturecolumn, byte[] logo, bool showmessage)
        {
            try
            {
                this.Initialize();
                con.Open();
                cmd = new MySqlCommand("INSERT INTO " + table + "(" + string.Join(",", columns) +") VALUES('" + string.Join("','", values) + "')", con);

                if (picturecolumn != "")
                {
                    cmd = new MySqlCommand("INSERT INTO " + table + "(" + string.Join(",", columns) + "," + picturecolumn + ") VALUES('" + string.Join("','", values) + "',@picture)", con);
                    cmd.Parameters.AddWithValue("@picture", logo);
                }

                int check = cmd.ExecuteNonQuery();
                con.Close();

                if(showmessage == true)
                {
                    if (check == 0)
                    {
                        MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Successfully inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //string table -> table name
        //string[] columnandvalues -> column with values
        //string idvalue -> primaryvalue
        //string primarykey -> primary key column 
        //Update statement
        public void Update(string table,string[] columnandvalues,string idvalue,string primarykey, string picturecolumn, byte[] logo)
        {
            try
            {
                this.Initialize();
                con.Open();
                cmd = new MySqlCommand("UPDATE " + table + " SET " + string.Join(",", columnandvalues) + " WHERE " + primarykey + "=" + idvalue + "", con);
                if (picturecolumn != "")
                {
                    cmd = new MySqlCommand("UPDATE " + table + " SET " + string.Join(",", columnandvalues) + "," + picturecolumn + "=@picture WHERE " + primarykey + "=" + idvalue + "", con);
                    cmd.Parameters.AddWithValue("@picture", logo);
                }
                int check = cmd.ExecuteNonQuery();
                con.Close();

                if (check == 0)
                {
                    MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete(string table,string where)
        {
            try
            {
                this.Initialize();
                con.Open();
                cmd = new MySqlCommand("DELETE FROM "+table+" WHERE "+where+"", con);

                int check = cmd.ExecuteNonQuery();
                con.Close();

                /**if (check == 0)
                {
                    MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
