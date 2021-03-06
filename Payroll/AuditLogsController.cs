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

        public void SearchDate(DateTime from, DateTime to, ComboBox cmbUser, DataGridView datagrid)
        {
            string searchLogs = "SELECT * FROM tbl_payroll_audit_logs where payroll_audit_logs_datetime >= '" + from.ToString("yyyyMMddHHmmss") + "' AND payroll_audit_logs_datetime < '" + to.ToString("yyyyMMddHHmmss") + "' AND payroll_audit_logs_user ='" + cmbUser.SelectedItem.ToString() + "'";
            payroll.FillDataGrid(searchLogs, datagrid);
            datagrid.Columns["payroll_audit_logs_id"].Visible = false;
            datagrid.Columns["payroll_audit_logs_archived"].Visible = false;
        }

        public void PassDataGridViewName(DataGridView datagridviewname)
        {
            string[] columname  = {"payroll_audit_logs_user",
                                  "payroll_audit_logs_changes",
                                  "payroll_audit_logs_datetime",
                                  "payroll_audit_logs_module"};
            string[] headerName = {"Username",
                                   "Description",
                                   "Date/Time",
                                   "Transaction"};
            payroll.SetHeaderText(columname, headerName, datagridviewname);
        }
    }

}

