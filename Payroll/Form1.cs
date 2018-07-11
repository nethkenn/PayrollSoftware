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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(201, 647);
            /* mySecondCustmControl1.Size = new Size(957, 406);
            firstCustomControl1.Size = new Size(811, 406);
            mySecondCustmControl1.Location = new Point(69, 156);
            firstCustomControl1.Location = new Point(69, 156);
            */

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(57, 647);
        }
    }
}
