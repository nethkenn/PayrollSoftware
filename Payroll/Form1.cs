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
    public partial class Form1 : Form
    {
        private db dbcon;

        public Form1()
        {
            InitializeComponent();
            dbcon = new db();
        }
    }
}
