namespace Payroll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_payroll_process = new System.Windows.Forms.Button();
            this.btn_timekeeping = new System.Windows.Forms.Button();
            this.btn_company_list = new System.Windows.Forms.Button();
            this.btn_employee_list = new System.Windows.Forms.Button();
            this.btn_payroll_config = new System.Windows.Forms.Button();
            this.CompanyPanel = new System.Windows.Forms.Panel();
            this.payroll_config_dropdown = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_job_title = new System.Windows.Forms.Button();
            this.btn_holiday = new System.Windows.Forms.Button();
            this.btn_allowances = new System.Windows.Forms.Button();
            this.btn_deduction = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_payroll_group = new System.Windows.Forms.Button();
            this.btn_shift_template = new System.Windows.Forms.Button();
            this.btn_tax_period = new System.Windows.Forms.Button();
            this.btn_tax_table = new System.Windows.Forms.Button();
            this.btn_sss_table = new System.Windows.Forms.Button();
            this.btn_philhealth_table = new System.Windows.Forms.Button();
            this.btn_pagibig_hdmf = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.payroll_company_id = new System.Windows.Forms.TextBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.payroll_company_account_no = new System.Windows.Forms.TextBox();
            this.payroll_company_date_started = new System.Windows.Forms.DateTimePicker();
            this.lblNatureOfBusiness = new System.Windows.Forms.Label();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.lblCompanyPhilhealth = new System.Windows.Forms.Label();
            this.lblCompanyContact = new System.Windows.Forms.Label();
            this.lblCompanySss = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblCompanyRdo = new System.Windows.Forms.Label();
            this.lblCompanyTin = new System.Windows.Forms.Label();
            this.lblCompanyPagibig = new System.Windows.Forms.Label();
            this.lblCompanyCode = new System.Windows.Forms.Label();
            this.lblCompanyDateStarted = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCompanyHeader = new System.Windows.Forms.Label();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.btnCompanyEdit = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.GroupBox();
            this.payroll_company_logo_default = new System.Windows.Forms.PictureBox();
            this.btnCompanyUpload = new System.Windows.Forms.Button();
            this.payroll_company_logo = new System.Windows.Forms.PictureBox();
            this.payroll_company_nature_of_business = new System.Windows.Forms.TextBox();
            this.payroll_company_philhealth = new System.Windows.Forms.TextBox();
            this.payroll_company_email = new System.Windows.Forms.TextBox();
            this.payroll_company_sss = new System.Windows.Forms.TextBox();
            this.payroll_company_contact = new System.Windows.Forms.TextBox();
            this.payroll_company_bank = new System.Windows.Forms.ComboBox();
            this.payroll_company_rdo = new System.Windows.Forms.ComboBox();
            this.payroll_company_tin = new System.Windows.Forms.TextBox();
            this.payroll_company_address = new System.Windows.Forms.TextBox();
            this.payroll_company_pagibig = new System.Windows.Forms.TextBox();
            this.payroll_company_code = new System.Windows.Forms.TextBox();
            this.payroll_company_name = new System.Windows.Forms.TextBox();
            this.payroll_company_datagrid = new System.Windows.Forms.DataGridView();
            this.CompanyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.CompanyPanel.SuspendLayout();
            this.payroll_config_dropdown.SuspendLayout();
            this.panel2.SuspendLayout();
            this.b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo_default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_payroll_process);
            this.panel1.Controls.Add(this.btn_timekeeping);
            this.panel1.Controls.Add(this.btn_company_list);
            this.panel1.Controls.Add(this.btn_employee_list);
            this.panel1.Controls.Add(this.btn_payroll_config);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 647);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.Image")));
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(0, 313);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(197, 40);
            this.btn_reports.TabIndex = 8;
            this.btn_reports.Text = "            Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.push_button);
            this.btn_reports.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_payroll_process
            // 
            this.btn_payroll_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_process.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_process.FlatAppearance.BorderSize = 0;
            this.btn_payroll_process.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_process.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_payroll_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payroll_process.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_payroll_process.Image = ((System.Drawing.Image)(resources.GetObject("btn_payroll_process.Image")));
            this.btn_payroll_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_process.Location = new System.Drawing.Point(4, 267);
            this.btn_payroll_process.Name = "btn_payroll_process";
            this.btn_payroll_process.Size = new System.Drawing.Size(197, 40);
            this.btn_payroll_process.TabIndex = 7;
            this.btn_payroll_process.Text = "            Payroll Process";
            this.btn_payroll_process.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_process.UseVisualStyleBackColor = false;
            this.btn_payroll_process.Click += new System.EventHandler(this.push_button);
            this.btn_payroll_process.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_timekeeping
            // 
            this.btn_timekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_timekeeping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_timekeeping.FlatAppearance.BorderSize = 0;
            this.btn_timekeeping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_timekeeping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_timekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timekeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timekeeping.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_timekeeping.Image = ((System.Drawing.Image)(resources.GetObject("btn_timekeeping.Image")));
            this.btn_timekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timekeeping.Location = new System.Drawing.Point(4, 221);
            this.btn_timekeeping.Name = "btn_timekeeping";
            this.btn_timekeeping.Size = new System.Drawing.Size(197, 40);
            this.btn_timekeeping.TabIndex = 5;
            this.btn_timekeeping.Text = "            Timekeeping";
            this.btn_timekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timekeeping.UseVisualStyleBackColor = false;
            this.btn_timekeeping.Click += new System.EventHandler(this.push_button);
            this.btn_timekeeping.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_company_list
            // 
            this.btn_company_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_company_list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_company_list.FlatAppearance.BorderSize = 0;
            this.btn_company_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_company_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_company_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_company_list.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_company_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_company_list.Image")));
            this.btn_company_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company_list.Location = new System.Drawing.Point(0, 83);
            this.btn_company_list.Name = "btn_company_list";
            this.btn_company_list.Size = new System.Drawing.Size(197, 40);
            this.btn_company_list.TabIndex = 4;
            this.btn_company_list.Text = "            Company List";
            this.btn_company_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company_list.UseVisualStyleBackColor = false;
            this.btn_company_list.Click += new System.EventHandler(this.btn_company_list_Click);
            this.btn_company_list.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_employee_list
            // 
            this.btn_employee_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_employee_list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_employee_list.FlatAppearance.BorderSize = 0;
            this.btn_employee_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_employee_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_employee_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_list.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_employee_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_employee_list.Image")));
            this.btn_employee_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee_list.Location = new System.Drawing.Point(1, 129);
            this.btn_employee_list.Name = "btn_employee_list";
            this.btn_employee_list.Size = new System.Drawing.Size(197, 40);
            this.btn_employee_list.TabIndex = 3;
            this.btn_employee_list.Text = "            Employee List";
            this.btn_employee_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee_list.UseVisualStyleBackColor = false;
            this.btn_employee_list.Click += new System.EventHandler(this.btn_employee_list_Click);
            this.btn_employee_list.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_payroll_config
            // 
            this.btn_payroll_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_config.FlatAppearance.BorderSize = 0;
            this.btn_payroll_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_payroll_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payroll_config.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_payroll_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_payroll_config.Image")));
            this.btn_payroll_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_config.Location = new System.Drawing.Point(4, 175);
            this.btn_payroll_config.Name = "btn_payroll_config";
            this.btn_payroll_config.Size = new System.Drawing.Size(197, 40);
            this.btn_payroll_config.TabIndex = 1;
            this.btn_payroll_config.Text = "            Payroll Config";
            this.btn_payroll_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_config.UseVisualStyleBackColor = false;
            this.btn_payroll_config.Click += new System.EventHandler(this.push_button);
            this.btn_payroll_config.MouseHover += new System.EventHandler(this.show_payroll_config_dropdown);
            // 
            // CompanyPanel
            // 
            this.CompanyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompanyPanel.Controls.Add(this.payroll_config_dropdown);
            this.CompanyPanel.Controls.Add(this.payroll_company_id);
            this.CompanyPanel.Controls.Add(this.lblBankAccount);
            this.CompanyPanel.Controls.Add(this.payroll_company_account_no);
            this.CompanyPanel.Controls.Add(this.payroll_company_date_started);
            this.CompanyPanel.Controls.Add(this.lblNatureOfBusiness);
            this.CompanyPanel.Controls.Add(this.lblCompanyEmail);
            this.CompanyPanel.Controls.Add(this.lblCompanyPhilhealth);
            this.CompanyPanel.Controls.Add(this.lblCompanyContact);
            this.CompanyPanel.Controls.Add(this.lblCompanySss);
            this.CompanyPanel.Controls.Add(this.lblCompanyAddress);
            this.CompanyPanel.Controls.Add(this.lblBank);
            this.CompanyPanel.Controls.Add(this.lblCompanyRdo);
            this.CompanyPanel.Controls.Add(this.lblCompanyTin);
            this.CompanyPanel.Controls.Add(this.lblCompanyPagibig);
            this.CompanyPanel.Controls.Add(this.lblCompanyCode);
            this.CompanyPanel.Controls.Add(this.lblCompanyDateStarted);
            this.CompanyPanel.Controls.Add(this.lblCompanyName);
            this.CompanyPanel.Controls.Add(this.panel2);
            this.CompanyPanel.Controls.Add(this.btnCompanySave);
            this.CompanyPanel.Controls.Add(this.btnCompanyEdit);
            this.CompanyPanel.Controls.Add(this.b);
            this.CompanyPanel.Controls.Add(this.payroll_company_nature_of_business);
            this.CompanyPanel.Controls.Add(this.payroll_company_philhealth);
            this.CompanyPanel.Controls.Add(this.payroll_company_email);
            this.CompanyPanel.Controls.Add(this.payroll_company_sss);
            this.CompanyPanel.Controls.Add(this.payroll_company_contact);
            this.CompanyPanel.Controls.Add(this.payroll_company_bank);
            this.CompanyPanel.Controls.Add(this.payroll_company_rdo);
            this.CompanyPanel.Controls.Add(this.payroll_company_tin);
            this.CompanyPanel.Controls.Add(this.payroll_company_address);
            this.CompanyPanel.Controls.Add(this.payroll_company_pagibig);
            this.CompanyPanel.Controls.Add(this.payroll_company_code);
            this.CompanyPanel.Controls.Add(this.payroll_company_name);
            this.CompanyPanel.Controls.Add(this.payroll_company_datagrid);
            this.CompanyPanel.Location = new System.Drawing.Point(72, 12);
            this.CompanyPanel.Name = "CompanyPanel";
            this.CompanyPanel.Size = new System.Drawing.Size(1038, 623);
            this.CompanyPanel.TabIndex = 1;
            this.CompanyPanel.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_config_dropdown
            // 
            this.payroll_config_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.payroll_config_dropdown.Controls.Add(this.btn_department);
            this.payroll_config_dropdown.Controls.Add(this.btn_job_title);
            this.payroll_config_dropdown.Controls.Add(this.btn_holiday);
            this.payroll_config_dropdown.Controls.Add(this.btn_allowances);
            this.payroll_config_dropdown.Controls.Add(this.btn_deduction);
            this.payroll_config_dropdown.Controls.Add(this.btn_leave);
            this.payroll_config_dropdown.Controls.Add(this.btn_payroll_group);
            this.payroll_config_dropdown.Controls.Add(this.btn_shift_template);
            this.payroll_config_dropdown.Controls.Add(this.btn_tax_period);
            this.payroll_config_dropdown.Controls.Add(this.btn_tax_table);
            this.payroll_config_dropdown.Controls.Add(this.btn_sss_table);
            this.payroll_config_dropdown.Controls.Add(this.btn_philhealth_table);
            this.payroll_config_dropdown.Controls.Add(this.btn_pagibig_hdmf);
            this.payroll_config_dropdown.Controls.Add(this.btn_reset);
            this.payroll_config_dropdown.Location = new System.Drawing.Point(127, 1);
            this.payroll_config_dropdown.Name = "payroll_config_dropdown";
            this.payroll_config_dropdown.Size = new System.Drawing.Size(200, 630);
            this.payroll_config_dropdown.TabIndex = 9;
            this.payroll_config_dropdown.Visible = false;
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_department.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_department.FlatAppearance.BorderSize = 0;
            this.btn_department.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_department.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_department.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_department.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_department.Image = ((System.Drawing.Image)(resources.GetObject("btn_department.Image")));
            this.btn_department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_department.Location = new System.Drawing.Point(3, 3);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(197, 38);
            this.btn_department.TabIndex = 0;
            this.btn_department.Text = "            Department";
            this.btn_department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_department.UseVisualStyleBackColor = false;
            // 
            // btn_job_title
            // 
            this.btn_job_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_job_title.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_job_title.FlatAppearance.BorderSize = 0;
            this.btn_job_title.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_job_title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_job_title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_job_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_job_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_job_title.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_job_title.Image = ((System.Drawing.Image)(resources.GetObject("btn_job_title.Image")));
            this.btn_job_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_job_title.Location = new System.Drawing.Point(3, 47);
            this.btn_job_title.Name = "btn_job_title";
            this.btn_job_title.Size = new System.Drawing.Size(197, 38);
            this.btn_job_title.TabIndex = 1;
            this.btn_job_title.Text = "            Job Title";
            this.btn_job_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_job_title.UseVisualStyleBackColor = false;
            // 
            // btn_holiday
            // 
            this.btn_holiday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_holiday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_holiday.FlatAppearance.BorderSize = 0;
            this.btn_holiday.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_holiday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_holiday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_holiday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_holiday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_holiday.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_holiday.Image = ((System.Drawing.Image)(resources.GetObject("btn_holiday.Image")));
            this.btn_holiday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_holiday.Location = new System.Drawing.Point(3, 91);
            this.btn_holiday.Name = "btn_holiday";
            this.btn_holiday.Size = new System.Drawing.Size(197, 38);
            this.btn_holiday.TabIndex = 2;
            this.btn_holiday.Text = "            Holiday";
            this.btn_holiday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_holiday.UseVisualStyleBackColor = false;
            // 
            // btn_allowances
            // 
            this.btn_allowances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_allowances.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_allowances.FlatAppearance.BorderSize = 0;
            this.btn_allowances.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_allowances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_allowances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_allowances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allowances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allowances.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_allowances.Image = ((System.Drawing.Image)(resources.GetObject("btn_allowances.Image")));
            this.btn_allowances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_allowances.Location = new System.Drawing.Point(3, 135);
            this.btn_allowances.Name = "btn_allowances";
            this.btn_allowances.Size = new System.Drawing.Size(197, 38);
            this.btn_allowances.TabIndex = 3;
            this.btn_allowances.Text = "            Allowances";
            this.btn_allowances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_allowances.UseVisualStyleBackColor = false;
            // 
            // btn_deduction
            // 
            this.btn_deduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_deduction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_deduction.FlatAppearance.BorderSize = 0;
            this.btn_deduction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_deduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_deduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_deduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deduction.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_deduction.Image = ((System.Drawing.Image)(resources.GetObject("btn_deduction.Image")));
            this.btn_deduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deduction.Location = new System.Drawing.Point(3, 179);
            this.btn_deduction.Name = "btn_deduction";
            this.btn_deduction.Size = new System.Drawing.Size(197, 38);
            this.btn_deduction.TabIndex = 4;
            this.btn_deduction.Text = "            Deduction";
            this.btn_deduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deduction.UseVisualStyleBackColor = false;
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_leave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_leave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leave.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_leave.Image = ((System.Drawing.Image)(resources.GetObject("btn_leave.Image")));
            this.btn_leave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leave.Location = new System.Drawing.Point(3, 223);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(197, 38);
            this.btn_leave.TabIndex = 5;
            this.btn_leave.Text = "            Leave";
            this.btn_leave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leave.UseVisualStyleBackColor = false;
            // 
            // btn_payroll_group
            // 
            this.btn_payroll_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_group.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_group.FlatAppearance.BorderSize = 0;
            this.btn_payroll_group.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_group.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_group.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_payroll_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payroll_group.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_payroll_group.Image = ((System.Drawing.Image)(resources.GetObject("btn_payroll_group.Image")));
            this.btn_payroll_group.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_group.Location = new System.Drawing.Point(3, 267);
            this.btn_payroll_group.Name = "btn_payroll_group";
            this.btn_payroll_group.Size = new System.Drawing.Size(197, 38);
            this.btn_payroll_group.TabIndex = 6;
            this.btn_payroll_group.Text = "            Payroll Group";
            this.btn_payroll_group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_group.UseVisualStyleBackColor = false;
            // 
            // btn_shift_template
            // 
            this.btn_shift_template.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_shift_template.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_shift_template.FlatAppearance.BorderSize = 0;
            this.btn_shift_template.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_shift_template.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_shift_template.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_shift_template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shift_template.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shift_template.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_shift_template.Image = ((System.Drawing.Image)(resources.GetObject("btn_shift_template.Image")));
            this.btn_shift_template.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_shift_template.Location = new System.Drawing.Point(3, 311);
            this.btn_shift_template.Name = "btn_shift_template";
            this.btn_shift_template.Size = new System.Drawing.Size(197, 38);
            this.btn_shift_template.TabIndex = 7;
            this.btn_shift_template.Text = "            Shift Template";
            this.btn_shift_template.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_shift_template.UseVisualStyleBackColor = false;
            // 
            // btn_tax_period
            // 
            this.btn_tax_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_tax_period.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_tax_period.FlatAppearance.BorderSize = 0;
            this.btn_tax_period.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_tax_period.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tax_period.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_tax_period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tax_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tax_period.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_tax_period.Image = ((System.Drawing.Image)(resources.GetObject("btn_tax_period.Image")));
            this.btn_tax_period.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tax_period.Location = new System.Drawing.Point(3, 355);
            this.btn_tax_period.Name = "btn_tax_period";
            this.btn_tax_period.Size = new System.Drawing.Size(197, 38);
            this.btn_tax_period.TabIndex = 8;
            this.btn_tax_period.Text = "            Tax Period";
            this.btn_tax_period.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tax_period.UseVisualStyleBackColor = false;
            // 
            // btn_tax_table
            // 
            this.btn_tax_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_tax_table.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_tax_table.FlatAppearance.BorderSize = 0;
            this.btn_tax_table.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_tax_table.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tax_table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_tax_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tax_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tax_table.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_tax_table.Image = ((System.Drawing.Image)(resources.GetObject("btn_tax_table.Image")));
            this.btn_tax_table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tax_table.Location = new System.Drawing.Point(3, 399);
            this.btn_tax_table.Name = "btn_tax_table";
            this.btn_tax_table.Size = new System.Drawing.Size(197, 38);
            this.btn_tax_table.TabIndex = 9;
            this.btn_tax_table.Text = "            Tax Table";
            this.btn_tax_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tax_table.UseVisualStyleBackColor = false;
            // 
            // btn_sss_table
            // 
            this.btn_sss_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_sss_table.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_sss_table.FlatAppearance.BorderSize = 0;
            this.btn_sss_table.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_sss_table.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sss_table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_sss_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sss_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sss_table.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_sss_table.Image = ((System.Drawing.Image)(resources.GetObject("btn_sss_table.Image")));
            this.btn_sss_table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sss_table.Location = new System.Drawing.Point(3, 443);
            this.btn_sss_table.Name = "btn_sss_table";
            this.btn_sss_table.Size = new System.Drawing.Size(197, 38);
            this.btn_sss_table.TabIndex = 10;
            this.btn_sss_table.Text = "            SSS Table";
            this.btn_sss_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sss_table.UseVisualStyleBackColor = false;
            // 
            // btn_philhealth_table
            // 
            this.btn_philhealth_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_philhealth_table.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_philhealth_table.FlatAppearance.BorderSize = 0;
            this.btn_philhealth_table.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_philhealth_table.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_philhealth_table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_philhealth_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_philhealth_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_philhealth_table.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_philhealth_table.Image = ((System.Drawing.Image)(resources.GetObject("btn_philhealth_table.Image")));
            this.btn_philhealth_table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_philhealth_table.Location = new System.Drawing.Point(3, 487);
            this.btn_philhealth_table.Name = "btn_philhealth_table";
            this.btn_philhealth_table.Size = new System.Drawing.Size(197, 38);
            this.btn_philhealth_table.TabIndex = 11;
            this.btn_philhealth_table.Text = "            Philhealth Table";
            this.btn_philhealth_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_philhealth_table.UseVisualStyleBackColor = false;
            // 
            // btn_pagibig_hdmf
            // 
            this.btn_pagibig_hdmf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_pagibig_hdmf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_pagibig_hdmf.FlatAppearance.BorderSize = 0;
            this.btn_pagibig_hdmf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_pagibig_hdmf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pagibig_hdmf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_pagibig_hdmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagibig_hdmf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagibig_hdmf.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_pagibig_hdmf.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagibig_hdmf.Image")));
            this.btn_pagibig_hdmf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagibig_hdmf.Location = new System.Drawing.Point(3, 531);
            this.btn_pagibig_hdmf.Name = "btn_pagibig_hdmf";
            this.btn_pagibig_hdmf.Size = new System.Drawing.Size(197, 38);
            this.btn_pagibig_hdmf.TabIndex = 12;
            this.btn_pagibig_hdmf.Text = "            Pagibig / HDMF";
            this.btn_pagibig_hdmf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagibig_hdmf.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(3, 575);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(197, 38);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "            Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // payroll_company_id
            // 
            this.payroll_company_id.Location = new System.Drawing.Point(12, 341);
            this.payroll_company_id.Name = "payroll_company_id";
            this.payroll_company_id.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_id.TabIndex = 36;
            this.payroll_company_id.Tag = "";
            this.payroll_company_id.Visible = false;
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(347, 403);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(115, 13);
            this.lblBankAccount.TabIndex = 35;
            this.lblBankAccount.Text = "Bank Account Number";
            this.lblBankAccount.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_account_no
            // 
            this.payroll_company_account_no.Location = new System.Drawing.Point(348, 419);
            this.payroll_company_account_no.Name = "payroll_company_account_no";
            this.payroll_company_account_no.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_account_no.TabIndex = 9;
            this.payroll_company_account_no.Tag = "Bank Account Number";
            this.payroll_company_account_no.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_date_started
            // 
            this.payroll_company_date_started.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_company_date_started.Location = new System.Drawing.Point(348, 338);
            this.payroll_company_date_started.Name = "payroll_company_date_started";
            this.payroll_company_date_started.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_date_started.TabIndex = 17;
            this.payroll_company_date_started.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblNatureOfBusiness
            // 
            this.lblNatureOfBusiness.AutoSize = true;
            this.lblNatureOfBusiness.Location = new System.Drawing.Point(10, 565);
            this.lblNatureOfBusiness.Name = "lblNatureOfBusiness";
            this.lblNatureOfBusiness.Size = new System.Drawing.Size(96, 13);
            this.lblNatureOfBusiness.TabIndex = 33;
            this.lblNatureOfBusiness.Text = "Nature of Business";
            this.lblNatureOfBusiness.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Location = new System.Drawing.Point(10, 523);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(79, 13);
            this.lblCompanyEmail.TabIndex = 31;
            this.lblCompanyEmail.Text = "Company Email";
            this.lblCompanyEmail.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyPhilhealth
            // 
            this.lblCompanyPhilhealth.AutoSize = true;
            this.lblCompanyPhilhealth.Location = new System.Drawing.Point(347, 523);
            this.lblCompanyPhilhealth.Name = "lblCompanyPhilhealth";
            this.lblCompanyPhilhealth.Size = new System.Drawing.Size(100, 13);
            this.lblCompanyPhilhealth.TabIndex = 30;
            this.lblCompanyPhilhealth.Text = "Company Philhealth";
            this.lblCompanyPhilhealth.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyContact
            // 
            this.lblCompanyContact.AutoSize = true;
            this.lblCompanyContact.Location = new System.Drawing.Point(10, 482);
            this.lblCompanyContact.Name = "lblCompanyContact";
            this.lblCompanyContact.Size = new System.Drawing.Size(91, 13);
            this.lblCompanyContact.TabIndex = 29;
            this.lblCompanyContact.Text = "Company Contact";
            this.lblCompanyContact.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanySss
            // 
            this.lblCompanySss.AutoSize = true;
            this.lblCompanySss.Location = new System.Drawing.Point(347, 482);
            this.lblCompanySss.Name = "lblCompanySss";
            this.lblCompanySss.Size = new System.Drawing.Size(75, 13);
            this.lblCompanySss.TabIndex = 28;
            this.lblCompanySss.Text = "Company SSS";
            this.lblCompanySss.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(10, 442);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(92, 13);
            this.lblCompanyAddress.TabIndex = 27;
            this.lblCompanyAddress.Text = "Company Address";
            this.lblCompanyAddress.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(347, 364);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 26;
            this.lblBank.Text = "Bank";
            this.lblBank.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyRdo
            // 
            this.lblCompanyRdo.AutoSize = true;
            this.lblCompanyRdo.Location = new System.Drawing.Point(10, 403);
            this.lblCompanyRdo.Name = "lblCompanyRdo";
            this.lblCompanyRdo.Size = new System.Drawing.Size(78, 13);
            this.lblCompanyRdo.TabIndex = 25;
            this.lblCompanyRdo.Text = "Company RDO";
            this.lblCompanyRdo.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyTin
            // 
            this.lblCompanyTin.AutoSize = true;
            this.lblCompanyTin.Location = new System.Drawing.Point(347, 442);
            this.lblCompanyTin.Name = "lblCompanyTin";
            this.lblCompanyTin.Size = new System.Drawing.Size(72, 13);
            this.lblCompanyTin.TabIndex = 24;
            this.lblCompanyTin.Text = "Company TIN";
            this.lblCompanyTin.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyPagibig
            // 
            this.lblCompanyPagibig.AutoSize = true;
            this.lblCompanyPagibig.Location = new System.Drawing.Point(347, 565);
            this.lblCompanyPagibig.Name = "lblCompanyPagibig";
            this.lblCompanyPagibig.Size = new System.Drawing.Size(97, 13);
            this.lblCompanyPagibig.TabIndex = 23;
            this.lblCompanyPagibig.Text = "Company PAGIBIG";
            this.lblCompanyPagibig.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyCode
            // 
            this.lblCompanyCode.AutoSize = true;
            this.lblCompanyCode.Location = new System.Drawing.Point(10, 364);
            this.lblCompanyCode.Name = "lblCompanyCode";
            this.lblCompanyCode.Size = new System.Drawing.Size(79, 13);
            this.lblCompanyCode.TabIndex = 22;
            this.lblCompanyCode.Text = "Company Code";
            this.lblCompanyCode.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyDateStarted
            // 
            this.lblCompanyDateStarted.AutoSize = true;
            this.lblCompanyDateStarted.Location = new System.Drawing.Point(347, 325);
            this.lblCompanyDateStarted.Name = "lblCompanyDateStarted";
            this.lblCompanyDateStarted.Size = new System.Drawing.Size(114, 13);
            this.lblCompanyDateStarted.TabIndex = 21;
            this.lblCompanyDateStarted.Text = "Company Date Started";
            this.lblCompanyDateStarted.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(10, 325);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 20;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblCompanyHeader);
            this.panel2.Location = new System.Drawing.Point(13, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 71);
            this.panel2.TabIndex = 19;
            this.panel2.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompanyHeader
            // 
            this.lblCompanyHeader.AutoSize = true;
            this.lblCompanyHeader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyHeader.Location = new System.Drawing.Point(48, 25);
            this.lblCompanyHeader.Name = "lblCompanyHeader";
            this.lblCompanyHeader.Size = new System.Drawing.Size(91, 22);
            this.lblCompanyHeader.TabIndex = 0;
            this.lblCompanyHeader.Text = "Company";
            this.lblCompanyHeader.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Location = new System.Drawing.Point(860, 553);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(128, 23);
            this.btnCompanySave.TabIndex = 18;
            this.btnCompanySave.Text = "Save";
            this.btnCompanySave.UseVisualStyleBackColor = true;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            this.btnCompanySave.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnCompanyEdit
            // 
            this.btnCompanyEdit.Location = new System.Drawing.Point(704, 553);
            this.btnCompanyEdit.Name = "btnCompanyEdit";
            this.btnCompanyEdit.Size = new System.Drawing.Size(128, 23);
            this.btnCompanyEdit.TabIndex = 17;
            this.btnCompanyEdit.Text = "Edit";
            this.btnCompanyEdit.UseVisualStyleBackColor = true;
            this.btnCompanyEdit.Click += new System.EventHandler(this.btnCompanyEdit_Click);
            this.btnCompanyEdit.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Controls.Add(this.payroll_company_logo_default);
            this.b.Controls.Add(this.btnCompanyUpload);
            this.b.Controls.Add(this.payroll_company_logo);
            this.b.Location = new System.Drawing.Point(698, 323);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(296, 210);
            this.b.TabIndex = 16;
            this.b.TabStop = false;
            this.b.Text = "Company Logo";
            this.b.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_logo_default
            // 
            this.payroll_company_logo_default.BackColor = System.Drawing.Color.Transparent;
            this.payroll_company_logo_default.Location = new System.Drawing.Point(6, 15);
            this.payroll_company_logo_default.Name = "payroll_company_logo_default";
            this.payroll_company_logo_default.Size = new System.Drawing.Size(284, 154);
            this.payroll_company_logo_default.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payroll_company_logo_default.TabIndex = 36;
            this.payroll_company_logo_default.TabStop = false;
            this.payroll_company_logo_default.Visible = false;
            this.payroll_company_logo_default.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnCompanyUpload
            // 
            this.btnCompanyUpload.Location = new System.Drawing.Point(89, 178);
            this.btnCompanyUpload.Name = "btnCompanyUpload";
            this.btnCompanyUpload.Size = new System.Drawing.Size(128, 23);
            this.btnCompanyUpload.TabIndex = 16;
            this.btnCompanyUpload.Text = "Upload Logo";
            this.btnCompanyUpload.UseVisualStyleBackColor = true;
            this.btnCompanyUpload.Click += new System.EventHandler(this.btnCompanyUpload_Click);
            this.btnCompanyUpload.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_logo
            // 
            this.payroll_company_logo.Location = new System.Drawing.Point(6, 15);
            this.payroll_company_logo.Name = "payroll_company_logo";
            this.payroll_company_logo.Size = new System.Drawing.Size(284, 154);
            this.payroll_company_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payroll_company_logo.TabIndex = 15;
            this.payroll_company_logo.TabStop = false;
            // 
            // payroll_company_nature_of_business
            // 
            this.payroll_company_nature_of_business.Location = new System.Drawing.Point(11, 581);
            this.payroll_company_nature_of_business.Name = "payroll_company_nature_of_business";
            this.payroll_company_nature_of_business.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_nature_of_business.TabIndex = 7;
            this.payroll_company_nature_of_business.Tag = "Nature of Business";
            this.payroll_company_nature_of_business.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_philhealth
            // 
            this.payroll_company_philhealth.Location = new System.Drawing.Point(348, 542);
            this.payroll_company_philhealth.Name = "payroll_company_philhealth";
            this.payroll_company_philhealth.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_philhealth.TabIndex = 12;
            this.payroll_company_philhealth.Tag = "Company Philhealth";
            this.payroll_company_philhealth.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_email
            // 
            this.payroll_company_email.Location = new System.Drawing.Point(11, 542);
            this.payroll_company_email.Name = "payroll_company_email";
            this.payroll_company_email.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_email.TabIndex = 6;
            this.payroll_company_email.Tag = "Company Email";
            this.payroll_company_email.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_sss
            // 
            this.payroll_company_sss.Location = new System.Drawing.Point(348, 500);
            this.payroll_company_sss.Name = "payroll_company_sss";
            this.payroll_company_sss.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_sss.TabIndex = 11;
            this.payroll_company_sss.Tag = "Company SSS";
            this.payroll_company_sss.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_contact
            // 
            this.payroll_company_contact.Location = new System.Drawing.Point(11, 500);
            this.payroll_company_contact.Name = "payroll_company_contact";
            this.payroll_company_contact.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_contact.TabIndex = 5;
            this.payroll_company_contact.Tag = "Company Contact";
            this.payroll_company_contact.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_bank
            // 
            this.payroll_company_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_company_bank.FormattingEnabled = true;
            this.payroll_company_bank.Location = new System.Drawing.Point(348, 380);
            this.payroll_company_bank.Name = "payroll_company_bank";
            this.payroll_company_bank.Size = new System.Drawing.Size(319, 21);
            this.payroll_company_bank.TabIndex = 8;
            this.payroll_company_bank.Tag = "";
            this.payroll_company_bank.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_rdo
            // 
            this.payroll_company_rdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_company_rdo.FormattingEnabled = true;
            this.payroll_company_rdo.Location = new System.Drawing.Point(13, 419);
            this.payroll_company_rdo.Name = "payroll_company_rdo";
            this.payroll_company_rdo.Size = new System.Drawing.Size(317, 21);
            this.payroll_company_rdo.TabIndex = 3;
            this.payroll_company_rdo.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_tin
            // 
            this.payroll_company_tin.Location = new System.Drawing.Point(348, 458);
            this.payroll_company_tin.Name = "payroll_company_tin";
            this.payroll_company_tin.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_tin.TabIndex = 10;
            this.payroll_company_tin.Tag = "Company TIN";
            this.payroll_company_tin.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_address
            // 
            this.payroll_company_address.Location = new System.Drawing.Point(13, 458);
            this.payroll_company_address.Name = "payroll_company_address";
            this.payroll_company_address.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_address.TabIndex = 4;
            this.payroll_company_address.Tag = "Company Address";
            this.payroll_company_address.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_pagibig
            // 
            this.payroll_company_pagibig.Location = new System.Drawing.Point(349, 581);
            this.payroll_company_pagibig.Name = "payroll_company_pagibig";
            this.payroll_company_pagibig.Size = new System.Drawing.Size(319, 20);
            this.payroll_company_pagibig.TabIndex = 13;
            this.payroll_company_pagibig.Tag = "Company Pagibig";
            this.payroll_company_pagibig.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_code
            // 
            this.payroll_company_code.Location = new System.Drawing.Point(12, 380);
            this.payroll_company_code.Name = "payroll_company_code";
            this.payroll_company_code.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_code.TabIndex = 2;
            this.payroll_company_code.Tag = "Company Code";
            this.payroll_company_code.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_name
            // 
            this.payroll_company_name.Location = new System.Drawing.Point(13, 341);
            this.payroll_company_name.Name = "payroll_company_name";
            this.payroll_company_name.Size = new System.Drawing.Size(317, 20);
            this.payroll_company_name.TabIndex = 1;
            this.payroll_company_name.Tag = "Company Name";
            this.payroll_company_name.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_company_datagrid
            // 
            this.payroll_company_datagrid.AllowUserToAddRows = false;
            this.payroll_company_datagrid.AllowUserToResizeColumns = false;
            this.payroll_company_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_company_datagrid.Location = new System.Drawing.Point(13, 108);
            this.payroll_company_datagrid.Name = "payroll_company_datagrid";
            this.payroll_company_datagrid.ReadOnly = true;
            this.payroll_company_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_company_datagrid.Size = new System.Drawing.Size(1012, 190);
            this.payroll_company_datagrid.TabIndex = 0;
            this.payroll_company_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payroll_company_datagrid_CellClick);
            this.payroll_company_datagrid.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // CompanyFileDialog
            // 
            this.CompanyFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1122, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CompanyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.panel1.ResumeLayout(false);
            this.CompanyPanel.ResumeLayout(false);
            this.CompanyPanel.PerformLayout();
            this.payroll_config_dropdown.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.b.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo_default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_payroll_config;
        private System.Windows.Forms.Button btn_payroll_process;
        private System.Windows.Forms.Button btn_timekeeping;
        private System.Windows.Forms.Button btn_employee_list;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Panel CompanyPanel;
        private System.Windows.Forms.Button btnCompanySave;
        private System.Windows.Forms.Button btnCompanyEdit;
        private System.Windows.Forms.GroupBox b;
        private System.Windows.Forms.Button btnCompanyUpload;
        private System.Windows.Forms.PictureBox payroll_company_logo;
        private System.Windows.Forms.TextBox payroll_company_nature_of_business;
        private System.Windows.Forms.TextBox payroll_company_philhealth;
        private System.Windows.Forms.TextBox payroll_company_email;
        private System.Windows.Forms.TextBox payroll_company_sss;
        private System.Windows.Forms.TextBox payroll_company_contact;
        private System.Windows.Forms.ComboBox payroll_company_bank;
        private System.Windows.Forms.TextBox payroll_company_tin;
        private System.Windows.Forms.TextBox payroll_company_address;
        private System.Windows.Forms.TextBox payroll_company_pagibig;
        private System.Windows.Forms.TextBox payroll_company_code;
        private System.Windows.Forms.TextBox payroll_company_name;
        private System.Windows.Forms.DataGridView payroll_company_datagrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCompanyHeader;
        private System.Windows.Forms.Label lblCompanyRdo;
        private System.Windows.Forms.Label lblCompanyTin;
        private System.Windows.Forms.Label lblCompanyPagibig;
        private System.Windows.Forms.Label lblCompanyCode;
        private System.Windows.Forms.Label lblCompanyDateStarted;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblNatureOfBusiness;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.Label lblCompanyPhilhealth;
        private System.Windows.Forms.Label lblCompanyContact;
        private System.Windows.Forms.Label lblCompanySss;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.DateTimePicker payroll_company_date_started;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.TextBox payroll_company_account_no;
        internal System.Windows.Forms.ComboBox payroll_company_rdo;
        private System.Windows.Forms.OpenFileDialog CompanyFileDialog;
        private System.Windows.Forms.PictureBox payroll_company_logo_default;
        private System.Windows.Forms.Button btn_company_list;
        private System.Windows.Forms.TextBox payroll_company_id;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Button btn_job_title;
        private System.Windows.Forms.Button btn_holiday;
        private System.Windows.Forms.Button btn_allowances;
        private System.Windows.Forms.Button btn_deduction;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_payroll_group;
        private System.Windows.Forms.Button btn_shift_template;
        private System.Windows.Forms.Button btn_tax_period;
        private System.Windows.Forms.Button btn_tax_table;
        private System.Windows.Forms.Button btn_sss_table;
        private System.Windows.Forms.Button btn_philhealth_table;
        private System.Windows.Forms.Button btn_pagibig_hdmf;
        private System.Windows.Forms.FlowLayoutPanel payroll_config_dropdown;
        private System.Windows.Forms.Button btn_reset;
    }
}

