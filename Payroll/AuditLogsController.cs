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
    public class AuditLogsController
    {
        private Payroll payroll = new Payroll();
        public void LoadAuditLogs(DataGridView datagrid)
        {
            //load auditlogs to datagrid
            string auditlogs = "SELECT * from tbl_payroll_audit_logs where payroll_audit_logs_archived = 0";
            payroll.FillDataGrid(auditlogs, datagrid);
            datagrid.Columns["payroll_audit_logs_id"].Visible = false;
            datagrid.Columns["payroll_audit_logs_archived"].Visible = false;
        }

        public void SearchDate(DateTime from, DateTime to, DataGridView datagrid)
        {
            MessageBox.Show("aw");
            string searchLogs = "SELECT * FROM tbl_payroll_audit_logs where payroll_audit_logs_datetime between '"+from.ToString("yyyy-MM-dd hh:mm:ss")+"' and '"+to.ToString("yyyy-MM-dd hh:mm:ss") +"' ";
            payroll.FillDataGrid(searchLogs, datagrid);
            datagrid.Columns["payroll_audit_logs_id"].Visible = false;
            datagrid.Columns["payroll_audit_logs_archived"].Visible = false;
        }
    }

}

