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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_audit_trail = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_payroll_process = new System.Windows.Forms.Button();
            this.btn_timekeeping = new System.Windows.Forms.Button();
            this.btn_company_list = new System.Windows.Forms.Button();
            this.btn_employee_list = new System.Windows.Forms.Button();
            this.btn_payroll_config = new System.Windows.Forms.Button();
            this.CompanyPanel = new System.Windows.Forms.Panel();
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
            this.CompanyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AuditlogsPanel = new System.Windows.Forms.Panel();
            this.dateTimePickerAuditLogTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAuditLogFrom = new System.Windows.Forms.DateTimePicker();
            this.cmb_AuditlogsUsers = new System.Windows.Forms.ComboBox();
            this.labelAuditLogTo = new System.Windows.Forms.Label();
            this.labelAuditLogFrom = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelAuditLog = new System.Windows.Forms.Label();
            this.payroll_auditlogs_datagrid = new System.Windows.Forms.DataGridView();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.EmployeeTabControl = new System.Windows.Forms.TabControl();
            this.activeemployee = new System.Windows.Forms.TabPage();
            this.lblSearchEmp = new System.Windows.Forms.Label();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.lblFilterDept = new System.Windows.Forms.Label();
            this.payroll_employee_search = new System.Windows.Forms.TextBox();
            this.payroll_employee_filter_status = new System.Windows.Forms.ComboBox();
            this.payroll_employee_filter_dept = new System.Windows.Forms.ComboBox();
            this.payroll_employee_datagrid_active = new System.Windows.Forms.DataGridView();
            this.separatedemployee = new System.Windows.Forms.TabPage();
            this.payroll_employee_datagrid_archive = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.payroll_employee_search_sep = new System.Windows.Forms.TextBox();
            this.payroll_employee_filter_status_sep = new System.Windows.Forms.ComboBox();
            this.payroll_employee_filter_dept_sep = new System.Windows.Forms.ComboBox();
            this.grpCreateEmployee = new System.Windows.Forms.GroupBox();
            this.check_as_print_name = new System.Windows.Forms.CheckBox();
            this.payroll_employee_birthdate_emp = new System.Windows.Forms.DateTimePicker();
            this.payroll_employee_company_id_emp = new System.Windows.Forms.ComboBox();
            this.btnCompanyClear = new System.Windows.Forms.Button();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.CreateEmployeeTabControl = new System.Windows.Forms.TabControl();
            this.addressTab = new System.Windows.Forms.TabPage();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.payroll_employee_country_emp = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCityTown = new System.Windows.Forms.Label();
            this.payroll_employee_zipcode_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_state_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_city_emp = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.payroll_employee_street_emp = new System.Windows.Forms.TextBox();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.payroll_employee_contract_status_emp = new System.Windows.Forms.ComboBox();
            this.lblEmploymentStatus = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblPayrollGroup = new System.Windows.Forms.Label();
            this.lblDateHired = new System.Windows.Forms.Label();
            this.btnCompanyDetails = new System.Windows.Forms.Button();
            this.btnNewCompanyDetails = new System.Windows.Forms.Button();
            this.payroll_group_id_emp = new System.Windows.Forms.ComboBox();
            this.payroll_employee_contract_date_end_emp = new System.Windows.Forms.DateTimePicker();
            this.payroll_employee_contract_date_hired_emp = new System.Windows.Forms.DateTimePicker();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.payroll_jobtitle_id_emp = new System.Windows.Forms.ComboBox();
            this.payroll_department_id_emp = new System.Windows.Forms.ComboBox();
            this.governmentTab = new System.Windows.Forms.TabPage();
            this.lblPagibigNumber = new System.Windows.Forms.Label();
            this.payroll_employee_pagibig_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_tax_status_emp = new System.Windows.Forms.ComboBox();
            this.lblTaxIdentificationNumber = new System.Windows.Forms.Label();
            this.lblTaxStatus = new System.Windows.Forms.Label();
            this.payroll_employee_tin_emp = new System.Windows.Forms.TextBox();
            this.lblPhilhealthNumber = new System.Windows.Forms.Label();
            this.lblSSSNumber = new System.Windows.Forms.Label();
            this.payroll_employee_philhealth_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_sss_emp = new System.Windows.Forms.TextBox();
            this.salaryTab = new System.Windows.Forms.TabPage();
            this.payroll_employee_declare_emp = new System.Windows.Forms.CheckBox();
            this.payroll_employee_salary_minimum_wage_emp = new System.Windows.Forms.CheckBox();
            this.payroll_employee_salary_cola_emp = new System.Windows.Forms.TextBox();
            this.lblColaDaily = new System.Windows.Forms.Label();
            this.lblPhilhealthSalary = new System.Windows.Forms.Label();
            this.monthly_cola_emp = new System.Windows.Forms.TextBox();
            this.lblColaMonthly = new System.Windows.Forms.Label();
            this.payroll_employee_salary_philhealth_emp = new System.Windows.Forms.TextBox();
            this.lblSSSSalary = new System.Windows.Forms.Label();
            this.payroll_employee_salary_hourly_emp = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.payroll_employee_salary_sss_emp = new System.Windows.Forms.TextBox();
            this.lblMonthlyRate = new System.Windows.Forms.Label();
            this.payroll_employee_salary_monthly_emp = new System.Windows.Forms.TextBox();
            this.lblTaxableSalary = new System.Windows.Forms.Label();
            this.payroll_employee_salary_daily_emp = new System.Windows.Forms.TextBox();
            this.lblPagibigContri = new System.Windows.Forms.Label();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.payroll_employee_salary_taxable_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_salary_pagibig_emp = new System.Windows.Forms.TextBox();
            this.requirementTab = new System.Windows.Forms.TabPage();
            this.has_valid_id = new System.Windows.Forms.CheckBox();
            this.has_health_certificate = new System.Windows.Forms.CheckBox();
            this.has_school_credentials = new System.Windows.Forms.CheckBox();
            this.has_nbi = new System.Windows.Forms.CheckBox();
            this.has_police_clearance = new System.Windows.Forms.CheckBox();
            this.has_resume = new System.Windows.Forms.CheckBox();
            this.dependentTab = new System.Windows.Forms.TabPage();
            this.payroll_dependent_relationship1_emp = new System.Windows.Forms.ComboBox();
            this.payroll_dependent_birthdate1_emp = new System.Windows.Forms.DateTimePicker();
            this.lblRelationship1 = new System.Windows.Forms.Label();
            this.lblDependentFullName1 = new System.Windows.Forms.Label();
            this.lblBirthDateDependent1 = new System.Windows.Forms.Label();
            this.payroll_dependent_name1_emp = new System.Windows.Forms.TextBox();
            this.payroll_dependent_relationship2_emp = new System.Windows.Forms.ComboBox();
            this.payroll_dependent_birthdate2_emp = new System.Windows.Forms.DateTimePicker();
            this.lblRelationship2 = new System.Windows.Forms.Label();
            this.lblDependentFullName2 = new System.Windows.Forms.Label();
            this.lblBirthDateDependent2 = new System.Windows.Forms.Label();
            this.payroll_dependent_name2_emp = new System.Windows.Forms.TextBox();
            this.payroll_dependent_relationship3_emp = new System.Windows.Forms.ComboBox();
            this.payroll_dependent_birthdate3_emp = new System.Windows.Forms.DateTimePicker();
            this.lblRelationship3 = new System.Windows.Forms.Label();
            this.lblDependentFullName3 = new System.Windows.Forms.Label();
            this.lblBirthDateDependent3 = new System.Windows.Forms.Label();
            this.payroll_dependent_name3_emp = new System.Windows.Forms.TextBox();
            this.payroll_dependent_relationship4_emp = new System.Windows.Forms.ComboBox();
            this.payroll_dependent_birthdate4_emp = new System.Windows.Forms.DateTimePicker();
            this.lblRelationship4 = new System.Windows.Forms.Label();
            this.lblDependentFullName4 = new System.Windows.Forms.Label();
            this.lblBirthDateDependent4 = new System.Windows.Forms.Label();
            this.payroll_dependent_name4_emp = new System.Windows.Forms.TextBox();
            this.shiftTab = new System.Windows.Forms.TabPage();
            this.payroll_datagrid_shift_emp = new System.Windows.Forms.DataGridView();
            this.shift_code_id_emp = new System.Windows.Forms.ComboBox();
            this.lblChooseShift = new System.Windows.Forms.Label();
            this.otherTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allowanceTab = new System.Windows.Forms.TabPage();
            this.leaveTab = new System.Windows.Forms.TabPage();
            this.deductionTab = new System.Windows.Forms.TabPage();
            this.journalTab = new System.Windows.Forms.TabPage();
            this.remarkTab = new System.Windows.Forms.TabPage();
            this.payroll_employee_gender_emp = new System.Windows.Forms.ComboBox();
            this.lblPrintName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.payroll_employee_display_name_emp = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.payroll_employee_email_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_contact_emp = new System.Windows.Forms.TextBox();
            this.lblAtmNumber = new System.Windows.Forms.Label();
            this.lblBiometricNumber = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.payroll_employee_atm_number_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_biometric_number_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_number_emp = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.payroll_employee_suffix_name_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_middle_name_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_first_name_emp = new System.Windows.Forms.TextBox();
            this.payroll_employee_last_name_emp = new System.Windows.Forms.TextBox();
            this.grpExportEmployee = new System.Windows.Forms.GroupBox();
            this.btnExportEmployeePDF = new System.Windows.Forms.Button();
            this.grpImportEmployee = new System.Windows.Forms.GroupBox();
            this.btnUpdateEmployeeExcelFile = new System.Windows.Forms.Button();
            this.btnImportEmployeeExcelFile = new System.Windows.Forms.Button();
            this.btnChooseEmployeeExcelFile = new System.Windows.Forms.Button();
            this.btnDownloadEmployeeTemplate = new System.Windows.Forms.Button();
            this.lblNumberofEmployee = new System.Windows.Forms.Label();
            this.number_of_emp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CompanyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo_default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_datagrid)).BeginInit();
            this.payroll_config_dropdown.SuspendLayout();
            this.AuditlogsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_auditlogs_datagrid)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            this.EmployeeTabControl.SuspendLayout();
            this.activeemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_employee_datagrid_active)).BeginInit();
            this.separatedemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_employee_datagrid_archive)).BeginInit();
            this.grpCreateEmployee.SuspendLayout();
            this.CreateEmployeeTabControl.SuspendLayout();
            this.addressTab.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.governmentTab.SuspendLayout();
            this.salaryTab.SuspendLayout();
            this.requirementTab.SuspendLayout();
            this.dependentTab.SuspendLayout();
            this.shiftTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_shift_emp)).BeginInit();
            this.otherTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.grpExportEmployee.SuspendLayout();
            this.grpImportEmployee.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btn_audit_trail);
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
            this.panel1.Size = new System.Drawing.Size(34, 677);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_audit_trail
            // 
            this.btn_audit_trail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_audit_trail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_audit_trail.FlatAppearance.BorderSize = 0;
            this.btn_audit_trail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_audit_trail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_audit_trail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_audit_trail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audit_trail.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_audit_trail.Image = ((System.Drawing.Image)(resources.GetObject("btn_audit_trail.Image")));
            this.btn_audit_trail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_audit_trail.Location = new System.Drawing.Point(1, 359);
            this.btn_audit_trail.Name = "btn_audit_trail";
            this.btn_audit_trail.Size = new System.Drawing.Size(197, 40);
            this.btn_audit_trail.TabIndex = 9;
            this.btn_audit_trail.Text = "       Audit Trail";
            this.btn_audit_trail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_audit_trail.UseVisualStyleBackColor = false;
            this.btn_audit_trail.Click += new System.EventHandler(this.btn_audit_trail_Click);
            this.btn_audit_trail.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.Image")));
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(1, 313);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(197, 40);
            this.btn_reports.TabIndex = 8;
            this.btn_reports.Text = "       Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.push_button);
            this.btn_reports.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_payroll_process
            // 
            this.btn_payroll_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_payroll_process.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_process.FlatAppearance.BorderSize = 0;
            this.btn_payroll_process.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_process.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_payroll_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payroll_process.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_payroll_process.Image = ((System.Drawing.Image)(resources.GetObject("btn_payroll_process.Image")));
            this.btn_payroll_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_process.Location = new System.Drawing.Point(1, 267);
            this.btn_payroll_process.Name = "btn_payroll_process";
            this.btn_payroll_process.Size = new System.Drawing.Size(197, 40);
            this.btn_payroll_process.TabIndex = 7;
            this.btn_payroll_process.Text = "       Payroll Process";
            this.btn_payroll_process.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_process.UseVisualStyleBackColor = false;
            this.btn_payroll_process.Click += new System.EventHandler(this.push_button);
            this.btn_payroll_process.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_timekeeping
            // 
            this.btn_timekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_timekeeping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_timekeeping.FlatAppearance.BorderSize = 0;
            this.btn_timekeeping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_timekeeping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_timekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timekeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timekeeping.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_timekeeping.Image = ((System.Drawing.Image)(resources.GetObject("btn_timekeeping.Image")));
            this.btn_timekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timekeeping.Location = new System.Drawing.Point(1, 221);
            this.btn_timekeeping.Name = "btn_timekeeping";
            this.btn_timekeeping.Size = new System.Drawing.Size(197, 40);
            this.btn_timekeeping.TabIndex = 5;
            this.btn_timekeeping.Text = "       Timekeeping";
            this.btn_timekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timekeeping.UseVisualStyleBackColor = false;
            this.btn_timekeeping.Click += new System.EventHandler(this.push_button);
            this.btn_timekeeping.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_company_list
            // 
            this.btn_company_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_company_list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_company_list.FlatAppearance.BorderSize = 0;
            this.btn_company_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_company_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_company_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_company_list.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_company_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_company_list.Image")));
            this.btn_company_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company_list.Location = new System.Drawing.Point(1, 83);
            this.btn_company_list.Name = "btn_company_list";
            this.btn_company_list.Size = new System.Drawing.Size(197, 40);
            this.btn_company_list.TabIndex = 4;
            this.btn_company_list.Text = "       Company List";
            this.btn_company_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company_list.UseVisualStyleBackColor = false;
            this.btn_company_list.Click += new System.EventHandler(this.btn_company_list_Click);
            this.btn_company_list.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_employee_list
            // 
            this.btn_employee_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_employee_list.Text = "       Employee List";
            this.btn_employee_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee_list.UseVisualStyleBackColor = false;
            this.btn_employee_list.Click += new System.EventHandler(this.btn_employee_list_Click);
            this.btn_employee_list.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_payroll_config
            // 
            this.btn_payroll_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.btn_payroll_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_payroll_config.FlatAppearance.BorderSize = 0;
            this.btn_payroll_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_payroll_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_payroll_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payroll_config.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_payroll_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_payroll_config.Image")));
            this.btn_payroll_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_config.Location = new System.Drawing.Point(1, 175);
            this.btn_payroll_config.Name = "btn_payroll_config";
            this.btn_payroll_config.Size = new System.Drawing.Size(197, 40);
            this.btn_payroll_config.TabIndex = 1;
            this.btn_payroll_config.Text = "       Payroll Config";
            this.btn_payroll_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_config.UseVisualStyleBackColor = false;
            this.btn_payroll_config.Click += new System.EventHandler(this.push_button);
            this.btn_payroll_config.MouseHover += new System.EventHandler(this.show_payroll_config_dropdown);
            // 
            // CompanyPanel
            // 
            this.CompanyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.CompanyPanel.Location = new System.Drawing.Point(40, 12);
            this.CompanyPanel.Name = "CompanyPanel";
            this.CompanyPanel.Size = new System.Drawing.Size(1039, 623);
            this.CompanyPanel.TabIndex = 1;
            this.CompanyPanel.MouseHover += new System.EventHandler(this.Form1_MouseHover);
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
            // payroll_config_dropdown
            // 
            this.payroll_config_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.payroll_config_dropdown.Location = new System.Drawing.Point(199, 0);
            this.payroll_config_dropdown.Name = "payroll_config_dropdown";
            this.payroll_config_dropdown.Size = new System.Drawing.Size(200, 630);
            this.payroll_config_dropdown.TabIndex = 9;
            this.payroll_config_dropdown.Visible = false;
            this.payroll_config_dropdown.Paint += new System.Windows.Forms.PaintEventHandler(this.payroll_config_dropdown_Paint);
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // btn_job_title
            // 
            this.btn_job_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_job_title.Click += new System.EventHandler(this.btn_job_title_Click);
            // 
            // btn_holiday
            // 
            this.btn_holiday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_holiday.Click += new System.EventHandler(this.btn_holiday_Click);
            // 
            // btn_allowances
            // 
            this.btn_allowances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_allowances.Click += new System.EventHandler(this.btn_allowances_Click);
            // 
            // btn_deduction
            // 
            this.btn_deduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_deduction.Click += new System.EventHandler(this.btn_deduction_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_payroll_group
            // 
            this.btn_payroll_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_payroll_group.Click += new System.EventHandler(this.btn_payroll_group_Click);
            // 
            // btn_shift_template
            // 
            this.btn_shift_template.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_tax_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_tax_period.Click += new System.EventHandler(this.btn_tax_period_Click);
            // 
            // btn_tax_table
            // 
            this.btn_tax_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_tax_table.Click += new System.EventHandler(this.btn_tax_table_Click);
            // 
            // btn_sss_table
            // 
            this.btn_sss_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_philhealth_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_pagibig_hdmf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
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
            // CompanyFileDialog
            // 
            this.CompanyFileDialog.FileName = "openFileDialog1";
            // 
            // AuditlogsPanel
            // 
            this.AuditlogsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.AuditlogsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuditlogsPanel.Controls.Add(this.dateTimePickerAuditLogTo);
            this.AuditlogsPanel.Controls.Add(this.dateTimePickerAuditLogFrom);
            this.AuditlogsPanel.Controls.Add(this.cmb_AuditlogsUsers);
            this.AuditlogsPanel.Controls.Add(this.labelAuditLogTo);
            this.AuditlogsPanel.Controls.Add(this.labelAuditLogFrom);
            this.AuditlogsPanel.Controls.Add(this.panel4);
            this.AuditlogsPanel.Controls.Add(this.payroll_auditlogs_datagrid);
            this.AuditlogsPanel.Location = new System.Drawing.Point(34, 0);
            this.AuditlogsPanel.Name = "AuditlogsPanel";
            this.AuditlogsPanel.Size = new System.Drawing.Size(1057, 677);
            this.AuditlogsPanel.TabIndex = 10;
            this.AuditlogsPanel.Visible = false;
            this.AuditlogsPanel.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // dateTimePickerAuditLogTo
            // 
            this.dateTimePickerAuditLogTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAuditLogTo.Location = new System.Drawing.Point(243, 138);
            this.dateTimePickerAuditLogTo.Name = "dateTimePickerAuditLogTo";
            this.dateTimePickerAuditLogTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAuditLogTo.TabIndex = 24;
            this.dateTimePickerAuditLogTo.ValueChanged += new System.EventHandler(this.AuditDateChanged);
            this.dateTimePickerAuditLogTo.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // dateTimePickerAuditLogFrom
            // 
            this.dateTimePickerAuditLogFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAuditLogFrom.Location = new System.Drawing.Point(15, 138);
            this.dateTimePickerAuditLogFrom.Name = "dateTimePickerAuditLogFrom";
            this.dateTimePickerAuditLogFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAuditLogFrom.TabIndex = 1;
            this.dateTimePickerAuditLogFrom.ValueChanged += new System.EventHandler(this.AuditDateChanged);
            this.dateTimePickerAuditLogFrom.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // cmb_AuditlogsUsers
            // 
            this.cmb_AuditlogsUsers.DisplayMember = "Zedek";
            this.cmb_AuditlogsUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AuditlogsUsers.FormattingEnabled = true;
            this.cmb_AuditlogsUsers.Items.AddRange(new object[] {
            "Paul",
            "Zedek",
            "nethken",
            "Ryann",
            "Derrek",
            "Timo"});
            this.cmb_AuditlogsUsers.Location = new System.Drawing.Point(489, 138);
            this.cmb_AuditlogsUsers.Name = "cmb_AuditlogsUsers";
            this.cmb_AuditlogsUsers.Size = new System.Drawing.Size(179, 21);
            this.cmb_AuditlogsUsers.TabIndex = 23;
            this.cmb_AuditlogsUsers.SelectedIndexChanged += new System.EventHandler(this.AuditDateChanged);
            this.cmb_AuditlogsUsers.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // labelAuditLogTo
            // 
            this.labelAuditLogTo.AutoSize = true;
            this.labelAuditLogTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.labelAuditLogTo.Location = new System.Drawing.Point(241, 118);
            this.labelAuditLogTo.Name = "labelAuditLogTo";
            this.labelAuditLogTo.Size = new System.Drawing.Size(23, 13);
            this.labelAuditLogTo.TabIndex = 22;
            this.labelAuditLogTo.Text = "To:";
            this.labelAuditLogTo.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // labelAuditLogFrom
            // 
            this.labelAuditLogFrom.AutoSize = true;
            this.labelAuditLogFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.labelAuditLogFrom.Location = new System.Drawing.Point(17, 118);
            this.labelAuditLogFrom.Name = "labelAuditLogFrom";
            this.labelAuditLogFrom.Size = new System.Drawing.Size(33, 13);
            this.labelAuditLogFrom.TabIndex = 21;
            this.labelAuditLogFrom.Text = "From:";
            this.labelAuditLogFrom.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.labelAuditLog);
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 71);
            this.panel4.TabIndex = 19;
            this.panel4.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // labelAuditLog
            // 
            this.labelAuditLog.AutoSize = true;
            this.labelAuditLog.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuditLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.labelAuditLog.Location = new System.Drawing.Point(48, 25);
            this.labelAuditLog.Name = "labelAuditLog";
            this.labelAuditLog.Size = new System.Drawing.Size(101, 22);
            this.labelAuditLog.TabIndex = 0;
            this.labelAuditLog.Text = "Audit Logs";
            this.labelAuditLog.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_auditlogs_datagrid
            // 
            this.payroll_auditlogs_datagrid.AllowUserToAddRows = false;
            this.payroll_auditlogs_datagrid.AllowUserToDeleteRows = false;
            this.payroll_auditlogs_datagrid.AllowUserToResizeColumns = false;
            this.payroll_auditlogs_datagrid.AllowUserToResizeRows = false;
            this.payroll_auditlogs_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_auditlogs_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.payroll_auditlogs_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
            this.payroll_auditlogs_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payroll_auditlogs_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.payroll_auditlogs_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payroll_auditlogs_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.payroll_auditlogs_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payroll_auditlogs_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.payroll_auditlogs_datagrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payroll_auditlogs_datagrid.Location = new System.Drawing.Point(13, 182);
            this.payroll_auditlogs_datagrid.Name = "payroll_auditlogs_datagrid";
            this.payroll_auditlogs_datagrid.ReadOnly = true;
            this.payroll_auditlogs_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_auditlogs_datagrid.Size = new System.Drawing.Size(1025, 472);
            this.payroll_auditlogs_datagrid.TabIndex = 0;
            this.payroll_auditlogs_datagrid.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeePanel.Controls.Add(this.EmployeeTabControl);
            this.EmployeePanel.Controls.Add(this.grpCreateEmployee);
            this.EmployeePanel.Controls.Add(this.grpExportEmployee);
            this.EmployeePanel.Controls.Add(this.grpImportEmployee);
            this.EmployeePanel.Controls.Add(this.panel3);
            this.EmployeePanel.Location = new System.Drawing.Point(41, 7);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1038, 663);
            this.EmployeePanel.TabIndex = 10;
            this.EmployeePanel.Visible = false;
            // 
            // EmployeeTabControl
            // 
            this.EmployeeTabControl.Controls.Add(this.activeemployee);
            this.EmployeeTabControl.Controls.Add(this.separatedemployee);
            this.EmployeeTabControl.Location = new System.Drawing.Point(13, 91);
            this.EmployeeTabControl.Name = "EmployeeTabControl";
            this.EmployeeTabControl.SelectedIndex = 0;
            this.EmployeeTabControl.Size = new System.Drawing.Size(1016, 223);
            this.EmployeeTabControl.TabIndex = 22;
            this.EmployeeTabControl.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // activeemployee
            // 
            this.activeemployee.Controls.Add(this.lblSearchEmp);
            this.activeemployee.Controls.Add(this.lblFilterStatus);
            this.activeemployee.Controls.Add(this.lblFilterDept);
            this.activeemployee.Controls.Add(this.payroll_employee_search);
            this.activeemployee.Controls.Add(this.payroll_employee_filter_status);
            this.activeemployee.Controls.Add(this.payroll_employee_filter_dept);
            this.activeemployee.Controls.Add(this.payroll_employee_datagrid_active);
            this.activeemployee.Location = new System.Drawing.Point(4, 22);
            this.activeemployee.Name = "activeemployee";
            this.activeemployee.Padding = new System.Windows.Forms.Padding(3);
            this.activeemployee.Size = new System.Drawing.Size(1008, 197);
            this.activeemployee.TabIndex = 0;
            this.activeemployee.Text = "Active Employee";
            this.activeemployee.UseVisualStyleBackColor = true;
            this.activeemployee.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblSearchEmp
            // 
            this.lblSearchEmp.AutoSize = true;
            this.lblSearchEmp.Location = new System.Drawing.Point(805, 9);
            this.lblSearchEmp.Name = "lblSearchEmp";
            this.lblSearchEmp.Size = new System.Drawing.Size(90, 13);
            this.lblSearchEmp.TabIndex = 6;
            this.lblSearchEmp.Text = "Search Employee";
            this.lblSearchEmp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(143, 9);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(76, 13);
            this.lblFilterStatus.TabIndex = 5;
            this.lblFilterStatus.Text = "Filter by Status";
            // 
            // lblFilterDept
            // 
            this.lblFilterDept.AutoSize = true;
            this.lblFilterDept.Location = new System.Drawing.Point(6, 9);
            this.lblFilterDept.Name = "lblFilterDept";
            this.lblFilterDept.Size = new System.Drawing.Size(87, 13);
            this.lblFilterDept.TabIndex = 4;
            this.lblFilterDept.Text = "Filter Department";
            this.lblFilterDept.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_search
            // 
            this.payroll_employee_search.Location = new System.Drawing.Point(808, 26);
            this.payroll_employee_search.Name = "payroll_employee_search";
            this.payroll_employee_search.Size = new System.Drawing.Size(194, 20);
            this.payroll_employee_search.TabIndex = 3;
            this.payroll_employee_search.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_filter_status
            // 
            this.payroll_employee_filter_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_filter_status.FormattingEnabled = true;
            this.payroll_employee_filter_status.Location = new System.Drawing.Point(146, 25);
            this.payroll_employee_filter_status.Name = "payroll_employee_filter_status";
            this.payroll_employee_filter_status.Size = new System.Drawing.Size(121, 21);
            this.payroll_employee_filter_status.TabIndex = 2;
            // 
            // payroll_employee_filter_dept
            // 
            this.payroll_employee_filter_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_filter_dept.FormattingEnabled = true;
            this.payroll_employee_filter_dept.Location = new System.Drawing.Point(6, 25);
            this.payroll_employee_filter_dept.Name = "payroll_employee_filter_dept";
            this.payroll_employee_filter_dept.Size = new System.Drawing.Size(121, 21);
            this.payroll_employee_filter_dept.TabIndex = 1;
            this.payroll_employee_filter_dept.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_datagrid_active
            // 
            this.payroll_employee_datagrid_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_employee_datagrid_active.Location = new System.Drawing.Point(6, 52);
            this.payroll_employee_datagrid_active.Name = "payroll_employee_datagrid_active";
            this.payroll_employee_datagrid_active.ReadOnly = true;
            this.payroll_employee_datagrid_active.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_employee_datagrid_active.Size = new System.Drawing.Size(996, 139);
            this.payroll_employee_datagrid_active.TabIndex = 0;
            this.payroll_employee_datagrid_active.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // separatedemployee
            // 
            this.separatedemployee.Controls.Add(this.payroll_employee_datagrid_archive);
            this.separatedemployee.Controls.Add(this.label1);
            this.separatedemployee.Controls.Add(this.label2);
            this.separatedemployee.Controls.Add(this.label3);
            this.separatedemployee.Controls.Add(this.payroll_employee_search_sep);
            this.separatedemployee.Controls.Add(this.payroll_employee_filter_status_sep);
            this.separatedemployee.Controls.Add(this.payroll_employee_filter_dept_sep);
            this.separatedemployee.Location = new System.Drawing.Point(4, 22);
            this.separatedemployee.Name = "separatedemployee";
            this.separatedemployee.Padding = new System.Windows.Forms.Padding(3);
            this.separatedemployee.Size = new System.Drawing.Size(1008, 197);
            this.separatedemployee.TabIndex = 1;
            this.separatedemployee.Text = "Separated Employee";
            this.separatedemployee.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_datagrid_archive
            // 
            this.payroll_employee_datagrid_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_employee_datagrid_archive.Location = new System.Drawing.Point(6, 52);
            this.payroll_employee_datagrid_archive.Name = "payroll_employee_datagrid_archive";
            this.payroll_employee_datagrid_archive.Size = new System.Drawing.Size(996, 139);
            this.payroll_employee_datagrid_archive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter by Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter Department";
            // 
            // payroll_employee_search_sep
            // 
            this.payroll_employee_search_sep.Location = new System.Drawing.Point(808, 25);
            this.payroll_employee_search_sep.Name = "payroll_employee_search_sep";
            this.payroll_employee_search_sep.Size = new System.Drawing.Size(194, 20);
            this.payroll_employee_search_sep.TabIndex = 9;
            // 
            // payroll_employee_filter_status_sep
            // 
            this.payroll_employee_filter_status_sep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_filter_status_sep.FormattingEnabled = true;
            this.payroll_employee_filter_status_sep.Location = new System.Drawing.Point(146, 25);
            this.payroll_employee_filter_status_sep.Name = "payroll_employee_filter_status_sep";
            this.payroll_employee_filter_status_sep.Size = new System.Drawing.Size(121, 21);
            this.payroll_employee_filter_status_sep.TabIndex = 8;
            // 
            // payroll_employee_filter_dept_sep
            // 
            this.payroll_employee_filter_dept_sep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_filter_dept_sep.FormattingEnabled = true;
            this.payroll_employee_filter_dept_sep.Location = new System.Drawing.Point(6, 25);
            this.payroll_employee_filter_dept_sep.Name = "payroll_employee_filter_dept_sep";
            this.payroll_employee_filter_dept_sep.Size = new System.Drawing.Size(121, 21);
            this.payroll_employee_filter_dept_sep.TabIndex = 7;
            // 
            // grpCreateEmployee
            // 
            this.grpCreateEmployee.Controls.Add(this.check_as_print_name);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_birthdate_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_company_id_emp);
            this.grpCreateEmployee.Controls.Add(this.btnCompanyClear);
            this.grpCreateEmployee.Controls.Add(this.btnEmployeeSave);
            this.grpCreateEmployee.Controls.Add(this.CreateEmployeeTabControl);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_gender_emp);
            this.grpCreateEmployee.Controls.Add(this.lblPrintName);
            this.grpCreateEmployee.Controls.Add(this.lblBirthDate);
            this.grpCreateEmployee.Controls.Add(this.lblGender);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_display_name_emp);
            this.grpCreateEmployee.Controls.Add(this.lblEmailAddress);
            this.grpCreateEmployee.Controls.Add(this.lblCompany);
            this.grpCreateEmployee.Controls.Add(this.lblContactNumber);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_email_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_contact_emp);
            this.grpCreateEmployee.Controls.Add(this.lblAtmNumber);
            this.grpCreateEmployee.Controls.Add(this.lblBiometricNumber);
            this.grpCreateEmployee.Controls.Add(this.lblEmployeeNumber);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_atm_number_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_biometric_number_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_number_emp);
            this.grpCreateEmployee.Controls.Add(this.lblSuffix);
            this.grpCreateEmployee.Controls.Add(this.lblMiddleName);
            this.grpCreateEmployee.Controls.Add(this.lblFirstName);
            this.grpCreateEmployee.Controls.Add(this.lblLastName);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_suffix_name_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_middle_name_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_first_name_emp);
            this.grpCreateEmployee.Controls.Add(this.payroll_employee_last_name_emp);
            this.grpCreateEmployee.Location = new System.Drawing.Point(13, 324);
            this.grpCreateEmployee.Name = "grpCreateEmployee";
            this.grpCreateEmployee.Size = new System.Drawing.Size(770, 332);
            this.grpCreateEmployee.TabIndex = 21;
            this.grpCreateEmployee.TabStop = false;
            this.grpCreateEmployee.Text = "Create Employee";
            this.grpCreateEmployee.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // check_as_print_name
            // 
            this.check_as_print_name.AutoSize = true;
            this.check_as_print_name.Location = new System.Drawing.Point(547, 131);
            this.check_as_print_name.Name = "check_as_print_name";
            this.check_as_print_name.Size = new System.Drawing.Size(111, 17);
            this.check_as_print_name.TabIndex = 33;
            this.check_as_print_name.Text = "Use Display name";
            this.check_as_print_name.UseVisualStyleBackColor = true;
            this.check_as_print_name.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_birthdate_emp
            // 
            this.payroll_employee_birthdate_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_employee_birthdate_emp.Location = new System.Drawing.Point(229, 149);
            this.payroll_employee_birthdate_emp.Name = "payroll_employee_birthdate_emp";
            this.payroll_employee_birthdate_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_birthdate_emp.TabIndex = 32;
            this.payroll_employee_birthdate_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_company_id_emp
            // 
            this.payroll_employee_company_id_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_company_id_emp.FormattingEnabled = true;
            this.payroll_employee_company_id_emp.Location = new System.Drawing.Point(229, 110);
            this.payroll_employee_company_id_emp.Name = "payroll_employee_company_id_emp";
            this.payroll_employee_company_id_emp.Size = new System.Drawing.Size(213, 21);
            this.payroll_employee_company_id_emp.TabIndex = 31;
            this.payroll_employee_company_id_emp.Tag = "Company";
            this.payroll_employee_company_id_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnCompanyClear
            // 
            this.btnCompanyClear.Location = new System.Drawing.Point(644, 226);
            this.btnCompanyClear.Name = "btnCompanyClear";
            this.btnCompanyClear.Size = new System.Drawing.Size(120, 23);
            this.btnCompanyClear.TabIndex = 30;
            this.btnCompanyClear.Text = "Clear";
            this.btnCompanyClear.UseVisualStyleBackColor = true;
            this.btnCompanyClear.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.Location = new System.Drawing.Point(644, 197);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(120, 23);
            this.btnEmployeeSave.TabIndex = 29;
            this.btnEmployeeSave.Text = "Save";
            this.btnEmployeeSave.UseVisualStyleBackColor = true;
            this.btnEmployeeSave.Click += new System.EventHandler(this.btnEmployeeSave_Click);
            this.btnEmployeeSave.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // CreateEmployeeTabControl
            // 
            this.CreateEmployeeTabControl.Controls.Add(this.addressTab);
            this.CreateEmployeeTabControl.Controls.Add(this.companyTab);
            this.CreateEmployeeTabControl.Controls.Add(this.governmentTab);
            this.CreateEmployeeTabControl.Controls.Add(this.salaryTab);
            this.CreateEmployeeTabControl.Controls.Add(this.requirementTab);
            this.CreateEmployeeTabControl.Controls.Add(this.dependentTab);
            this.CreateEmployeeTabControl.Controls.Add(this.shiftTab);
            this.CreateEmployeeTabControl.Controls.Add(this.otherTab);
            this.CreateEmployeeTabControl.Location = new System.Drawing.Point(10, 175);
            this.CreateEmployeeTabControl.Name = "CreateEmployeeTabControl";
            this.CreateEmployeeTabControl.SelectedIndex = 0;
            this.CreateEmployeeTabControl.Size = new System.Drawing.Size(628, 151);
            this.CreateEmployeeTabControl.TabIndex = 28;
            this.CreateEmployeeTabControl.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // addressTab
            // 
            this.addressTab.Controls.Add(this.lblCountry);
            this.addressTab.Controls.Add(this.lblZipCode);
            this.addressTab.Controls.Add(this.payroll_employee_country_emp);
            this.addressTab.Controls.Add(this.lblState);
            this.addressTab.Controls.Add(this.lblCityTown);
            this.addressTab.Controls.Add(this.payroll_employee_zipcode_emp);
            this.addressTab.Controls.Add(this.payroll_employee_state_emp);
            this.addressTab.Controls.Add(this.payroll_employee_city_emp);
            this.addressTab.Controls.Add(this.lblStreet);
            this.addressTab.Controls.Add(this.payroll_employee_street_emp);
            this.addressTab.Location = new System.Drawing.Point(4, 22);
            this.addressTab.Name = "addressTab";
            this.addressTab.Padding = new System.Windows.Forms.Padding(3);
            this.addressTab.Size = new System.Drawing.Size(620, 125);
            this.addressTab.TabIndex = 0;
            this.addressTab.Text = "Address";
            this.addressTab.UseVisualStyleBackColor = true;
            this.addressTab.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(305, 83);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 43;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(6, 83);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 42;
            this.lblZipCode.Text = "Zip Code";
            this.lblZipCode.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_country_emp
            // 
            this.payroll_employee_country_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_country_emp.FormattingEnabled = true;
            this.payroll_employee_country_emp.Location = new System.Drawing.Point(308, 99);
            this.payroll_employee_country_emp.Name = "payroll_employee_country_emp";
            this.payroll_employee_country_emp.Size = new System.Drawing.Size(306, 21);
            this.payroll_employee_country_emp.TabIndex = 41;
            this.payroll_employee_country_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(305, 44);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 40;
            this.lblState.Text = "State";
            // 
            // lblCityTown
            // 
            this.lblCityTown.AutoSize = true;
            this.lblCityTown.Location = new System.Drawing.Point(6, 44);
            this.lblCityTown.Name = "lblCityTown";
            this.lblCityTown.Size = new System.Drawing.Size(56, 13);
            this.lblCityTown.TabIndex = 39;
            this.lblCityTown.Text = "City/Town";
            this.lblCityTown.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_zipcode_emp
            // 
            this.payroll_employee_zipcode_emp.Location = new System.Drawing.Point(6, 99);
            this.payroll_employee_zipcode_emp.Name = "payroll_employee_zipcode_emp";
            this.payroll_employee_zipcode_emp.Size = new System.Drawing.Size(296, 20);
            this.payroll_employee_zipcode_emp.TabIndex = 38;
            this.payroll_employee_zipcode_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_state_emp
            // 
            this.payroll_employee_state_emp.Location = new System.Drawing.Point(308, 60);
            this.payroll_employee_state_emp.Name = "payroll_employee_state_emp";
            this.payroll_employee_state_emp.Size = new System.Drawing.Size(306, 20);
            this.payroll_employee_state_emp.TabIndex = 36;
            // 
            // payroll_employee_city_emp
            // 
            this.payroll_employee_city_emp.Location = new System.Drawing.Point(6, 60);
            this.payroll_employee_city_emp.Name = "payroll_employee_city_emp";
            this.payroll_employee_city_emp.Size = new System.Drawing.Size(296, 20);
            this.payroll_employee_city_emp.TabIndex = 35;
            this.payroll_employee_city_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 5);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 34;
            this.lblStreet.Text = "Street";
            this.lblStreet.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_street_emp
            // 
            this.payroll_employee_street_emp.Location = new System.Drawing.Point(6, 21);
            this.payroll_employee_street_emp.Name = "payroll_employee_street_emp";
            this.payroll_employee_street_emp.Size = new System.Drawing.Size(608, 20);
            this.payroll_employee_street_emp.TabIndex = 0;
            this.payroll_employee_street_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // companyTab
            // 
            this.companyTab.Controls.Add(this.payroll_employee_contract_status_emp);
            this.companyTab.Controls.Add(this.lblEmploymentStatus);
            this.companyTab.Controls.Add(this.lblDateEnd);
            this.companyTab.Controls.Add(this.lblPayrollGroup);
            this.companyTab.Controls.Add(this.lblDateHired);
            this.companyTab.Controls.Add(this.btnCompanyDetails);
            this.companyTab.Controls.Add(this.btnNewCompanyDetails);
            this.companyTab.Controls.Add(this.payroll_group_id_emp);
            this.companyTab.Controls.Add(this.payroll_employee_contract_date_end_emp);
            this.companyTab.Controls.Add(this.payroll_employee_contract_date_hired_emp);
            this.companyTab.Controls.Add(this.lblJobTitle);
            this.companyTab.Controls.Add(this.lblDepartment);
            this.companyTab.Controls.Add(this.payroll_jobtitle_id_emp);
            this.companyTab.Controls.Add(this.payroll_department_id_emp);
            this.companyTab.Location = new System.Drawing.Point(4, 22);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyTab.Size = new System.Drawing.Size(620, 125);
            this.companyTab.TabIndex = 1;
            this.companyTab.Text = "Company Details";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_contract_status_emp
            // 
            this.payroll_employee_contract_status_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_contract_status_emp.FormattingEnabled = true;
            this.payroll_employee_contract_status_emp.Location = new System.Drawing.Point(469, 68);
            this.payroll_employee_contract_status_emp.Name = "payroll_employee_contract_status_emp";
            this.payroll_employee_contract_status_emp.Size = new System.Drawing.Size(131, 21);
            this.payroll_employee_contract_status_emp.TabIndex = 44;
            this.payroll_employee_contract_status_emp.Tag = "Employment Status";
            // 
            // lblEmploymentStatus
            // 
            this.lblEmploymentStatus.AutoSize = true;
            this.lblEmploymentStatus.Location = new System.Drawing.Point(466, 52);
            this.lblEmploymentStatus.Name = "lblEmploymentStatus";
            this.lblEmploymentStatus.Size = new System.Drawing.Size(97, 13);
            this.lblEmploymentStatus.TabIndex = 39;
            this.lblEmploymentStatus.Text = "Employment Status";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(466, 13);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(52, 13);
            this.lblDateEnd.TabIndex = 43;
            this.lblDateEnd.Text = "Date End";
            // 
            // lblPayrollGroup
            // 
            this.lblPayrollGroup.AutoSize = true;
            this.lblPayrollGroup.Location = new System.Drawing.Point(319, 53);
            this.lblPayrollGroup.Name = "lblPayrollGroup";
            this.lblPayrollGroup.Size = new System.Drawing.Size(70, 13);
            this.lblPayrollGroup.TabIndex = 42;
            this.lblPayrollGroup.Text = "Payroll Group";
            // 
            // lblDateHired
            // 
            this.lblDateHired.AutoSize = true;
            this.lblDateHired.Location = new System.Drawing.Point(319, 13);
            this.lblDateHired.Name = "lblDateHired";
            this.lblDateHired.Size = new System.Drawing.Size(58, 13);
            this.lblDateHired.TabIndex = 41;
            this.lblDateHired.Text = "Date Hired";
            // 
            // btnCompanyDetails
            // 
            this.btnCompanyDetails.Location = new System.Drawing.Point(469, 95);
            this.btnCompanyDetails.Name = "btnCompanyDetails";
            this.btnCompanyDetails.Size = new System.Drawing.Size(131, 23);
            this.btnCompanyDetails.TabIndex = 40;
            this.btnCompanyDetails.Text = "Company Details";
            this.btnCompanyDetails.UseVisualStyleBackColor = true;
            this.btnCompanyDetails.Visible = false;
            // 
            // btnNewCompanyDetails
            // 
            this.btnNewCompanyDetails.Location = new System.Drawing.Point(322, 95);
            this.btnNewCompanyDetails.Name = "btnNewCompanyDetails";
            this.btnNewCompanyDetails.Size = new System.Drawing.Size(141, 23);
            this.btnNewCompanyDetails.TabIndex = 39;
            this.btnNewCompanyDetails.Text = "New Company Details";
            this.btnNewCompanyDetails.UseVisualStyleBackColor = true;
            this.btnNewCompanyDetails.Visible = false;
            // 
            // payroll_group_id_emp
            // 
            this.payroll_group_id_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_group_id_emp.FormattingEnabled = true;
            this.payroll_group_id_emp.Location = new System.Drawing.Point(321, 68);
            this.payroll_group_id_emp.Name = "payroll_group_id_emp";
            this.payroll_group_id_emp.Size = new System.Drawing.Size(142, 21);
            this.payroll_group_id_emp.TabIndex = 37;
            this.payroll_group_id_emp.Tag = "Payroll Group";
            // 
            // payroll_employee_contract_date_end_emp
            // 
            this.payroll_employee_contract_date_end_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_employee_contract_date_end_emp.Location = new System.Drawing.Point(469, 29);
            this.payroll_employee_contract_date_end_emp.Name = "payroll_employee_contract_date_end_emp";
            this.payroll_employee_contract_date_end_emp.Size = new System.Drawing.Size(131, 20);
            this.payroll_employee_contract_date_end_emp.TabIndex = 36;
            // 
            // payroll_employee_contract_date_hired_emp
            // 
            this.payroll_employee_contract_date_hired_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_employee_contract_date_hired_emp.Location = new System.Drawing.Point(322, 29);
            this.payroll_employee_contract_date_hired_emp.Name = "payroll_employee_contract_date_hired_emp";
            this.payroll_employee_contract_date_hired_emp.Size = new System.Drawing.Size(141, 20);
            this.payroll_employee_contract_date_hired_emp.TabIndex = 34;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(3, 53);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 13);
            this.lblJobTitle.TabIndex = 35;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(3, 13);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 34;
            this.lblDepartment.Text = "Department";
            // 
            // payroll_jobtitle_id_emp
            // 
            this.payroll_jobtitle_id_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_jobtitle_id_emp.FormattingEnabled = true;
            this.payroll_jobtitle_id_emp.Location = new System.Drawing.Point(6, 68);
            this.payroll_jobtitle_id_emp.Name = "payroll_jobtitle_id_emp";
            this.payroll_jobtitle_id_emp.Size = new System.Drawing.Size(293, 21);
            this.payroll_jobtitle_id_emp.TabIndex = 1;
            this.payroll_jobtitle_id_emp.Tag = "Job Title";
            // 
            // payroll_department_id_emp
            // 
            this.payroll_department_id_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_department_id_emp.FormattingEnabled = true;
            this.payroll_department_id_emp.Location = new System.Drawing.Point(6, 29);
            this.payroll_department_id_emp.Name = "payroll_department_id_emp";
            this.payroll_department_id_emp.Size = new System.Drawing.Size(293, 21);
            this.payroll_department_id_emp.TabIndex = 0;
            this.payroll_department_id_emp.Tag = "Department";
            this.payroll_department_id_emp.SelectedIndexChanged += new System.EventHandler(this.payroll_department_id_emp_SelectedIndexChanged);
            // 
            // governmentTab
            // 
            this.governmentTab.Controls.Add(this.lblPagibigNumber);
            this.governmentTab.Controls.Add(this.payroll_employee_pagibig_emp);
            this.governmentTab.Controls.Add(this.payroll_employee_tax_status_emp);
            this.governmentTab.Controls.Add(this.lblTaxIdentificationNumber);
            this.governmentTab.Controls.Add(this.lblTaxStatus);
            this.governmentTab.Controls.Add(this.payroll_employee_tin_emp);
            this.governmentTab.Controls.Add(this.lblPhilhealthNumber);
            this.governmentTab.Controls.Add(this.lblSSSNumber);
            this.governmentTab.Controls.Add(this.payroll_employee_philhealth_emp);
            this.governmentTab.Controls.Add(this.payroll_employee_sss_emp);
            this.governmentTab.Location = new System.Drawing.Point(4, 22);
            this.governmentTab.Name = "governmentTab";
            this.governmentTab.Size = new System.Drawing.Size(620, 125);
            this.governmentTab.TabIndex = 2;
            this.governmentTab.Text = "Government";
            this.governmentTab.UseVisualStyleBackColor = true;
            // 
            // lblPagibigNumber
            // 
            this.lblPagibigNumber.AutoSize = true;
            this.lblPagibigNumber.Location = new System.Drawing.Point(400, 10);
            this.lblPagibigNumber.Name = "lblPagibigNumber";
            this.lblPagibigNumber.Size = new System.Drawing.Size(118, 13);
            this.lblPagibigNumber.TabIndex = 47;
            this.lblPagibigNumber.Text = "Pagibig/HDMF Number";
            // 
            // payroll_employee_pagibig_emp
            // 
            this.payroll_employee_pagibig_emp.Location = new System.Drawing.Point(403, 26);
            this.payroll_employee_pagibig_emp.Name = "payroll_employee_pagibig_emp";
            this.payroll_employee_pagibig_emp.Size = new System.Drawing.Size(172, 20);
            this.payroll_employee_pagibig_emp.TabIndex = 46;
            // 
            // payroll_employee_tax_status_emp
            // 
            this.payroll_employee_tax_status_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_tax_status_emp.FormattingEnabled = true;
            this.payroll_employee_tax_status_emp.Location = new System.Drawing.Point(12, 26);
            this.payroll_employee_tax_status_emp.Name = "payroll_employee_tax_status_emp";
            this.payroll_employee_tax_status_emp.Size = new System.Drawing.Size(172, 21);
            this.payroll_employee_tax_status_emp.TabIndex = 34;
            // 
            // lblTaxIdentificationNumber
            // 
            this.lblTaxIdentificationNumber.AutoSize = true;
            this.lblTaxIdentificationNumber.Location = new System.Drawing.Point(9, 49);
            this.lblTaxIdentificationNumber.Name = "lblTaxIdentificationNumber";
            this.lblTaxIdentificationNumber.Size = new System.Drawing.Size(128, 13);
            this.lblTaxIdentificationNumber.TabIndex = 45;
            this.lblTaxIdentificationNumber.Text = "Tax Identification Number";
            // 
            // lblTaxStatus
            // 
            this.lblTaxStatus.AutoSize = true;
            this.lblTaxStatus.Location = new System.Drawing.Point(9, 10);
            this.lblTaxStatus.Name = "lblTaxStatus";
            this.lblTaxStatus.Size = new System.Drawing.Size(58, 13);
            this.lblTaxStatus.TabIndex = 43;
            this.lblTaxStatus.Text = "Tax Status";
            // 
            // payroll_employee_tin_emp
            // 
            this.payroll_employee_tin_emp.Location = new System.Drawing.Point(12, 65);
            this.payroll_employee_tin_emp.Name = "payroll_employee_tin_emp";
            this.payroll_employee_tin_emp.Size = new System.Drawing.Size(172, 20);
            this.payroll_employee_tin_emp.TabIndex = 44;
            // 
            // lblPhilhealthNumber
            // 
            this.lblPhilhealthNumber.AutoSize = true;
            this.lblPhilhealthNumber.Location = new System.Drawing.Point(208, 49);
            this.lblPhilhealthNumber.Name = "lblPhilhealthNumber";
            this.lblPhilhealthNumber.Size = new System.Drawing.Size(93, 13);
            this.lblPhilhealthNumber.TabIndex = 41;
            this.lblPhilhealthNumber.Text = "Philhealth Number";
            // 
            // lblSSSNumber
            // 
            this.lblSSSNumber.AutoSize = true;
            this.lblSSSNumber.Location = new System.Drawing.Point(208, 10);
            this.lblSSSNumber.Name = "lblSSSNumber";
            this.lblSSSNumber.Size = new System.Drawing.Size(68, 13);
            this.lblSSSNumber.TabIndex = 39;
            this.lblSSSNumber.Text = "SSS Number";
            // 
            // payroll_employee_philhealth_emp
            // 
            this.payroll_employee_philhealth_emp.Location = new System.Drawing.Point(208, 65);
            this.payroll_employee_philhealth_emp.Name = "payroll_employee_philhealth_emp";
            this.payroll_employee_philhealth_emp.Size = new System.Drawing.Size(172, 20);
            this.payroll_employee_philhealth_emp.TabIndex = 40;
            // 
            // payroll_employee_sss_emp
            // 
            this.payroll_employee_sss_emp.Location = new System.Drawing.Point(208, 26);
            this.payroll_employee_sss_emp.Name = "payroll_employee_sss_emp";
            this.payroll_employee_sss_emp.Size = new System.Drawing.Size(172, 20);
            this.payroll_employee_sss_emp.TabIndex = 38;
            // 
            // salaryTab
            // 
            this.salaryTab.Controls.Add(this.payroll_employee_declare_emp);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_minimum_wage_emp);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_cola_emp);
            this.salaryTab.Controls.Add(this.lblColaDaily);
            this.salaryTab.Controls.Add(this.lblPhilhealthSalary);
            this.salaryTab.Controls.Add(this.monthly_cola_emp);
            this.salaryTab.Controls.Add(this.lblColaMonthly);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_philhealth_emp);
            this.salaryTab.Controls.Add(this.lblSSSSalary);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_hourly_emp);
            this.salaryTab.Controls.Add(this.lblHourlyRate);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_sss_emp);
            this.salaryTab.Controls.Add(this.lblMonthlyRate);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_monthly_emp);
            this.salaryTab.Controls.Add(this.lblTaxableSalary);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_daily_emp);
            this.salaryTab.Controls.Add(this.lblPagibigContri);
            this.salaryTab.Controls.Add(this.lblDailyRate);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_taxable_emp);
            this.salaryTab.Controls.Add(this.payroll_employee_salary_pagibig_emp);
            this.salaryTab.Location = new System.Drawing.Point(4, 22);
            this.salaryTab.Name = "salaryTab";
            this.salaryTab.Size = new System.Drawing.Size(620, 125);
            this.salaryTab.TabIndex = 3;
            this.salaryTab.Text = "Salary Details";
            this.salaryTab.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_declare_emp
            // 
            this.payroll_employee_declare_emp.AutoSize = true;
            this.payroll_employee_declare_emp.Location = new System.Drawing.Point(177, 10);
            this.payroll_employee_declare_emp.Name = "payroll_employee_declare_emp";
            this.payroll_employee_declare_emp.Size = new System.Drawing.Size(234, 17);
            this.payroll_employee_declare_emp.TabIndex = 53;
            this.payroll_employee_declare_emp.Text = "Declare Salary for SSS, Philhealth and Tax?";
            this.payroll_employee_declare_emp.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_salary_minimum_wage_emp
            // 
            this.payroll_employee_salary_minimum_wage_emp.AutoSize = true;
            this.payroll_employee_salary_minimum_wage_emp.Location = new System.Drawing.Point(12, 10);
            this.payroll_employee_salary_minimum_wage_emp.Name = "payroll_employee_salary_minimum_wage_emp";
            this.payroll_employee_salary_minimum_wage_emp.Size = new System.Drawing.Size(133, 17);
            this.payroll_employee_salary_minimum_wage_emp.TabIndex = 52;
            this.payroll_employee_salary_minimum_wage_emp.Text = "Minimum Wage Earner";
            this.payroll_employee_salary_minimum_wage_emp.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_salary_cola_emp
            // 
            this.payroll_employee_salary_cola_emp.Location = new System.Drawing.Point(477, 55);
            this.payroll_employee_salary_cola_emp.Name = "payroll_employee_salary_cola_emp";
            this.payroll_employee_salary_cola_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_cola_emp.TabIndex = 50;
            // 
            // lblColaDaily
            // 
            this.lblColaDaily.AutoSize = true;
            this.lblColaDaily.Location = new System.Drawing.Point(474, 39);
            this.lblColaDaily.Name = "lblColaDaily";
            this.lblColaDaily.Size = new System.Drawing.Size(67, 13);
            this.lblColaDaily.TabIndex = 51;
            this.lblColaDaily.Text = "COLA (Daily)";
            // 
            // lblPhilhealthSalary
            // 
            this.lblPhilhealthSalary.AutoSize = true;
            this.lblPhilhealthSalary.Location = new System.Drawing.Point(354, 78);
            this.lblPhilhealthSalary.Name = "lblPhilhealthSalary";
            this.lblPhilhealthSalary.Size = new System.Drawing.Size(85, 13);
            this.lblPhilhealthSalary.TabIndex = 49;
            this.lblPhilhealthSalary.Text = "Philhealth Salary";
            // 
            // monthly_cola_emp
            // 
            this.monthly_cola_emp.Location = new System.Drawing.Point(357, 55);
            this.monthly_cola_emp.Name = "monthly_cola_emp";
            this.monthly_cola_emp.Size = new System.Drawing.Size(104, 20);
            this.monthly_cola_emp.TabIndex = 46;
            // 
            // lblColaMonthly
            // 
            this.lblColaMonthly.AutoSize = true;
            this.lblColaMonthly.Location = new System.Drawing.Point(354, 39);
            this.lblColaMonthly.Name = "lblColaMonthly";
            this.lblColaMonthly.Size = new System.Drawing.Size(81, 13);
            this.lblColaMonthly.TabIndex = 47;
            this.lblColaMonthly.Text = "COLA (Monthly)";
            // 
            // payroll_employee_salary_philhealth_emp
            // 
            this.payroll_employee_salary_philhealth_emp.Location = new System.Drawing.Point(357, 94);
            this.payroll_employee_salary_philhealth_emp.Name = "payroll_employee_salary_philhealth_emp";
            this.payroll_employee_salary_philhealth_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_philhealth_emp.TabIndex = 48;
            // 
            // lblSSSSalary
            // 
            this.lblSSSSalary.AutoSize = true;
            this.lblSSSSalary.Location = new System.Drawing.Point(236, 78);
            this.lblSSSSalary.Name = "lblSSSSalary";
            this.lblSSSSalary.Size = new System.Drawing.Size(60, 13);
            this.lblSSSSalary.TabIndex = 45;
            this.lblSSSSalary.Text = "SSS Salary";
            // 
            // payroll_employee_salary_hourly_emp
            // 
            this.payroll_employee_salary_hourly_emp.Location = new System.Drawing.Point(239, 55);
            this.payroll_employee_salary_hourly_emp.Name = "payroll_employee_salary_hourly_emp";
            this.payroll_employee_salary_hourly_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_hourly_emp.TabIndex = 42;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(236, 39);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblHourlyRate.TabIndex = 43;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // payroll_employee_salary_sss_emp
            // 
            this.payroll_employee_salary_sss_emp.Location = new System.Drawing.Point(239, 94);
            this.payroll_employee_salary_sss_emp.Name = "payroll_employee_salary_sss_emp";
            this.payroll_employee_salary_sss_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_sss_emp.TabIndex = 44;
            // 
            // lblMonthlyRate
            // 
            this.lblMonthlyRate.AutoSize = true;
            this.lblMonthlyRate.Location = new System.Drawing.Point(9, 39);
            this.lblMonthlyRate.Name = "lblMonthlyRate";
            this.lblMonthlyRate.Size = new System.Drawing.Size(70, 13);
            this.lblMonthlyRate.TabIndex = 36;
            this.lblMonthlyRate.Text = "Monthly Rate";
            // 
            // payroll_employee_salary_monthly_emp
            // 
            this.payroll_employee_salary_monthly_emp.Location = new System.Drawing.Point(9, 55);
            this.payroll_employee_salary_monthly_emp.Name = "payroll_employee_salary_monthly_emp";
            this.payroll_employee_salary_monthly_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_monthly_emp.TabIndex = 34;
            // 
            // lblTaxableSalary
            // 
            this.lblTaxableSalary.AutoSize = true;
            this.lblTaxableSalary.Location = new System.Drawing.Point(120, 78);
            this.lblTaxableSalary.Name = "lblTaxableSalary";
            this.lblTaxableSalary.Size = new System.Drawing.Size(77, 13);
            this.lblTaxableSalary.TabIndex = 41;
            this.lblTaxableSalary.Text = "Taxable Salary";
            // 
            // payroll_employee_salary_daily_emp
            // 
            this.payroll_employee_salary_daily_emp.Location = new System.Drawing.Point(123, 55);
            this.payroll_employee_salary_daily_emp.Name = "payroll_employee_salary_daily_emp";
            this.payroll_employee_salary_daily_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_daily_emp.TabIndex = 35;
            // 
            // lblPagibigContri
            // 
            this.lblPagibigContri.AutoSize = true;
            this.lblPagibigContri.Location = new System.Drawing.Point(9, 78);
            this.lblPagibigContri.Name = "lblPagibigContri";
            this.lblPagibigContri.Size = new System.Drawing.Size(101, 13);
            this.lblPagibigContri.TabIndex = 40;
            this.lblPagibigContri.Text = "Pagibig Contribution";
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(120, 39);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(56, 13);
            this.lblDailyRate.TabIndex = 37;
            this.lblDailyRate.Text = "Daily Rate";
            // 
            // payroll_employee_salary_taxable_emp
            // 
            this.payroll_employee_salary_taxable_emp.Location = new System.Drawing.Point(123, 94);
            this.payroll_employee_salary_taxable_emp.Name = "payroll_employee_salary_taxable_emp";
            this.payroll_employee_salary_taxable_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_taxable_emp.TabIndex = 39;
            // 
            // payroll_employee_salary_pagibig_emp
            // 
            this.payroll_employee_salary_pagibig_emp.Location = new System.Drawing.Point(9, 94);
            this.payroll_employee_salary_pagibig_emp.Name = "payroll_employee_salary_pagibig_emp";
            this.payroll_employee_salary_pagibig_emp.Size = new System.Drawing.Size(104, 20);
            this.payroll_employee_salary_pagibig_emp.TabIndex = 38;
            // 
            // requirementTab
            // 
            this.requirementTab.Controls.Add(this.has_valid_id);
            this.requirementTab.Controls.Add(this.has_health_certificate);
            this.requirementTab.Controls.Add(this.has_school_credentials);
            this.requirementTab.Controls.Add(this.has_nbi);
            this.requirementTab.Controls.Add(this.has_police_clearance);
            this.requirementTab.Controls.Add(this.has_resume);
            this.requirementTab.Location = new System.Drawing.Point(4, 22);
            this.requirementTab.Name = "requirementTab";
            this.requirementTab.Size = new System.Drawing.Size(620, 125);
            this.requirementTab.TabIndex = 4;
            this.requirementTab.Text = "Requirements";
            this.requirementTab.UseVisualStyleBackColor = true;
            // 
            // has_valid_id
            // 
            this.has_valid_id.AutoSize = true;
            this.has_valid_id.Location = new System.Drawing.Point(177, 35);
            this.has_valid_id.Name = "has_valid_id";
            this.has_valid_id.Size = new System.Drawing.Size(63, 17);
            this.has_valid_id.TabIndex = 5;
            this.has_valid_id.Text = "Valid ID";
            this.has_valid_id.UseVisualStyleBackColor = true;
            // 
            // has_health_certificate
            // 
            this.has_health_certificate.AutoSize = true;
            this.has_health_certificate.Location = new System.Drawing.Point(18, 81);
            this.has_health_certificate.Name = "has_health_certificate";
            this.has_health_certificate.Size = new System.Drawing.Size(107, 17);
            this.has_health_certificate.TabIndex = 4;
            this.has_health_certificate.Text = "Health Certificate";
            this.has_health_certificate.UseVisualStyleBackColor = true;
            // 
            // has_school_credentials
            // 
            this.has_school_credentials.AutoSize = true;
            this.has_school_credentials.Location = new System.Drawing.Point(177, 10);
            this.has_school_credentials.Name = "has_school_credentials";
            this.has_school_credentials.Size = new System.Drawing.Size(114, 17);
            this.has_school_credentials.TabIndex = 3;
            this.has_school_credentials.Text = "School Credentials";
            this.has_school_credentials.UseVisualStyleBackColor = true;
            // 
            // has_nbi
            // 
            this.has_nbi.AutoSize = true;
            this.has_nbi.Location = new System.Drawing.Point(18, 58);
            this.has_nbi.Name = "has_nbi";
            this.has_nbi.Size = new System.Drawing.Size(44, 17);
            this.has_nbi.TabIndex = 2;
            this.has_nbi.Text = "NBI";
            this.has_nbi.UseVisualStyleBackColor = true;
            // 
            // has_police_clearance
            // 
            this.has_police_clearance.AutoSize = true;
            this.has_police_clearance.Location = new System.Drawing.Point(18, 35);
            this.has_police_clearance.Name = "has_police_clearance";
            this.has_police_clearance.Size = new System.Drawing.Size(106, 17);
            this.has_police_clearance.TabIndex = 1;
            this.has_police_clearance.Text = "Police Clearance";
            this.has_police_clearance.UseVisualStyleBackColor = true;
            // 
            // has_resume
            // 
            this.has_resume.AutoSize = true;
            this.has_resume.Location = new System.Drawing.Point(18, 10);
            this.has_resume.Name = "has_resume";
            this.has_resume.Size = new System.Drawing.Size(130, 17);
            this.has_resume.TabIndex = 0;
            this.has_resume.Text = "Resume/CV/Bio-Data";
            this.has_resume.UseVisualStyleBackColor = true;
            // 
            // dependentTab
            // 
            this.dependentTab.Controls.Add(this.payroll_dependent_relationship1_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_birthdate1_emp);
            this.dependentTab.Controls.Add(this.lblRelationship1);
            this.dependentTab.Controls.Add(this.lblDependentFullName1);
            this.dependentTab.Controls.Add(this.lblBirthDateDependent1);
            this.dependentTab.Controls.Add(this.payroll_dependent_name1_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_relationship2_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_birthdate2_emp);
            this.dependentTab.Controls.Add(this.lblRelationship2);
            this.dependentTab.Controls.Add(this.lblDependentFullName2);
            this.dependentTab.Controls.Add(this.lblBirthDateDependent2);
            this.dependentTab.Controls.Add(this.payroll_dependent_name2_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_relationship3_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_birthdate3_emp);
            this.dependentTab.Controls.Add(this.lblRelationship3);
            this.dependentTab.Controls.Add(this.lblDependentFullName3);
            this.dependentTab.Controls.Add(this.lblBirthDateDependent3);
            this.dependentTab.Controls.Add(this.payroll_dependent_name3_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_relationship4_emp);
            this.dependentTab.Controls.Add(this.payroll_dependent_birthdate4_emp);
            this.dependentTab.Controls.Add(this.lblRelationship4);
            this.dependentTab.Controls.Add(this.lblDependentFullName4);
            this.dependentTab.Controls.Add(this.lblBirthDateDependent4);
            this.dependentTab.Controls.Add(this.payroll_dependent_name4_emp);
            this.dependentTab.Location = new System.Drawing.Point(4, 22);
            this.dependentTab.Name = "dependentTab";
            this.dependentTab.Size = new System.Drawing.Size(620, 125);
            this.dependentTab.TabIndex = 5;
            this.dependentTab.Text = "Dependents";
            this.dependentTab.UseVisualStyleBackColor = true;
            // 
            // payroll_dependent_relationship1_emp
            // 
            this.payroll_dependent_relationship1_emp.FormattingEnabled = true;
            this.payroll_dependent_relationship1_emp.Location = new System.Drawing.Point(19, 95);
            this.payroll_dependent_relationship1_emp.Name = "payroll_dependent_relationship1_emp";
            this.payroll_dependent_relationship1_emp.Size = new System.Drawing.Size(138, 21);
            this.payroll_dependent_relationship1_emp.TabIndex = 69;
            // 
            // payroll_dependent_birthdate1_emp
            // 
            this.payroll_dependent_birthdate1_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_dependent_birthdate1_emp.Location = new System.Drawing.Point(18, 58);
            this.payroll_dependent_birthdate1_emp.Name = "payroll_dependent_birthdate1_emp";
            this.payroll_dependent_birthdate1_emp.Size = new System.Drawing.Size(139, 20);
            this.payroll_dependent_birthdate1_emp.TabIndex = 70;
            // 
            // lblRelationship1
            // 
            this.lblRelationship1.AutoSize = true;
            this.lblRelationship1.Location = new System.Drawing.Point(16, 79);
            this.lblRelationship1.Name = "lblRelationship1";
            this.lblRelationship1.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship1.TabIndex = 66;
            this.lblRelationship1.Text = "Relationship";
            // 
            // lblDependentFullName1
            // 
            this.lblDependentFullName1.AutoSize = true;
            this.lblDependentFullName1.Location = new System.Drawing.Point(17, 5);
            this.lblDependentFullName1.Name = "lblDependentFullName1";
            this.lblDependentFullName1.Size = new System.Drawing.Size(110, 13);
            this.lblDependentFullName1.TabIndex = 71;
            this.lblDependentFullName1.Text = "Dependent Full Name";
            // 
            // lblBirthDateDependent1
            // 
            this.lblBirthDateDependent1.AutoSize = true;
            this.lblBirthDateDependent1.Location = new System.Drawing.Point(15, 42);
            this.lblBirthDateDependent1.Name = "lblBirthDateDependent1";
            this.lblBirthDateDependent1.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDateDependent1.TabIndex = 67;
            this.lblBirthDateDependent1.Text = "Birth Date";
            // 
            // payroll_dependent_name1_emp
            // 
            this.payroll_dependent_name1_emp.Location = new System.Drawing.Point(17, 21);
            this.payroll_dependent_name1_emp.Name = "payroll_dependent_name1_emp";
            this.payroll_dependent_name1_emp.Size = new System.Drawing.Size(140, 20);
            this.payroll_dependent_name1_emp.TabIndex = 68;
            // 
            // payroll_dependent_relationship2_emp
            // 
            this.payroll_dependent_relationship2_emp.FormattingEnabled = true;
            this.payroll_dependent_relationship2_emp.Location = new System.Drawing.Point(167, 95);
            this.payroll_dependent_relationship2_emp.Name = "payroll_dependent_relationship2_emp";
            this.payroll_dependent_relationship2_emp.Size = new System.Drawing.Size(138, 21);
            this.payroll_dependent_relationship2_emp.TabIndex = 63;
            // 
            // payroll_dependent_birthdate2_emp
            // 
            this.payroll_dependent_birthdate2_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_dependent_birthdate2_emp.Location = new System.Drawing.Point(166, 58);
            this.payroll_dependent_birthdate2_emp.Name = "payroll_dependent_birthdate2_emp";
            this.payroll_dependent_birthdate2_emp.Size = new System.Drawing.Size(139, 20);
            this.payroll_dependent_birthdate2_emp.TabIndex = 64;
            // 
            // lblRelationship2
            // 
            this.lblRelationship2.AutoSize = true;
            this.lblRelationship2.Location = new System.Drawing.Point(164, 79);
            this.lblRelationship2.Name = "lblRelationship2";
            this.lblRelationship2.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship2.TabIndex = 60;
            this.lblRelationship2.Text = "Relationship";
            // 
            // lblDependentFullName2
            // 
            this.lblDependentFullName2.AutoSize = true;
            this.lblDependentFullName2.Location = new System.Drawing.Point(165, 5);
            this.lblDependentFullName2.Name = "lblDependentFullName2";
            this.lblDependentFullName2.Size = new System.Drawing.Size(110, 13);
            this.lblDependentFullName2.TabIndex = 65;
            this.lblDependentFullName2.Text = "Dependent Full Name";
            // 
            // lblBirthDateDependent2
            // 
            this.lblBirthDateDependent2.AutoSize = true;
            this.lblBirthDateDependent2.Location = new System.Drawing.Point(163, 42);
            this.lblBirthDateDependent2.Name = "lblBirthDateDependent2";
            this.lblBirthDateDependent2.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDateDependent2.TabIndex = 61;
            this.lblBirthDateDependent2.Text = "Birth Date";
            // 
            // payroll_dependent_name2_emp
            // 
            this.payroll_dependent_name2_emp.Location = new System.Drawing.Point(165, 21);
            this.payroll_dependent_name2_emp.Name = "payroll_dependent_name2_emp";
            this.payroll_dependent_name2_emp.Size = new System.Drawing.Size(140, 20);
            this.payroll_dependent_name2_emp.TabIndex = 62;
            // 
            // payroll_dependent_relationship3_emp
            // 
            this.payroll_dependent_relationship3_emp.FormattingEnabled = true;
            this.payroll_dependent_relationship3_emp.Location = new System.Drawing.Point(314, 95);
            this.payroll_dependent_relationship3_emp.Name = "payroll_dependent_relationship3_emp";
            this.payroll_dependent_relationship3_emp.Size = new System.Drawing.Size(138, 21);
            this.payroll_dependent_relationship3_emp.TabIndex = 57;
            // 
            // payroll_dependent_birthdate3_emp
            // 
            this.payroll_dependent_birthdate3_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_dependent_birthdate3_emp.Location = new System.Drawing.Point(313, 58);
            this.payroll_dependent_birthdate3_emp.Name = "payroll_dependent_birthdate3_emp";
            this.payroll_dependent_birthdate3_emp.Size = new System.Drawing.Size(139, 20);
            this.payroll_dependent_birthdate3_emp.TabIndex = 58;
            // 
            // lblRelationship3
            // 
            this.lblRelationship3.AutoSize = true;
            this.lblRelationship3.Location = new System.Drawing.Point(311, 79);
            this.lblRelationship3.Name = "lblRelationship3";
            this.lblRelationship3.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship3.TabIndex = 54;
            this.lblRelationship3.Text = "Relationship";
            // 
            // lblDependentFullName3
            // 
            this.lblDependentFullName3.AutoSize = true;
            this.lblDependentFullName3.Location = new System.Drawing.Point(312, 5);
            this.lblDependentFullName3.Name = "lblDependentFullName3";
            this.lblDependentFullName3.Size = new System.Drawing.Size(110, 13);
            this.lblDependentFullName3.TabIndex = 59;
            this.lblDependentFullName3.Text = "Dependent Full Name";
            // 
            // lblBirthDateDependent3
            // 
            this.lblBirthDateDependent3.AutoSize = true;
            this.lblBirthDateDependent3.Location = new System.Drawing.Point(310, 42);
            this.lblBirthDateDependent3.Name = "lblBirthDateDependent3";
            this.lblBirthDateDependent3.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDateDependent3.TabIndex = 55;
            this.lblBirthDateDependent3.Text = "Birth Date";
            // 
            // payroll_dependent_name3_emp
            // 
            this.payroll_dependent_name3_emp.Location = new System.Drawing.Point(312, 21);
            this.payroll_dependent_name3_emp.Name = "payroll_dependent_name3_emp";
            this.payroll_dependent_name3_emp.Size = new System.Drawing.Size(140, 20);
            this.payroll_dependent_name3_emp.TabIndex = 56;
            // 
            // payroll_dependent_relationship4_emp
            // 
            this.payroll_dependent_relationship4_emp.FormattingEnabled = true;
            this.payroll_dependent_relationship4_emp.Location = new System.Drawing.Point(461, 95);
            this.payroll_dependent_relationship4_emp.Name = "payroll_dependent_relationship4_emp";
            this.payroll_dependent_relationship4_emp.Size = new System.Drawing.Size(138, 21);
            this.payroll_dependent_relationship4_emp.TabIndex = 51;
            // 
            // payroll_dependent_birthdate4_emp
            // 
            this.payroll_dependent_birthdate4_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_dependent_birthdate4_emp.Location = new System.Drawing.Point(460, 58);
            this.payroll_dependent_birthdate4_emp.Name = "payroll_dependent_birthdate4_emp";
            this.payroll_dependent_birthdate4_emp.Size = new System.Drawing.Size(139, 20);
            this.payroll_dependent_birthdate4_emp.TabIndex = 52;
            // 
            // lblRelationship4
            // 
            this.lblRelationship4.AutoSize = true;
            this.lblRelationship4.Location = new System.Drawing.Point(458, 79);
            this.lblRelationship4.Name = "lblRelationship4";
            this.lblRelationship4.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship4.TabIndex = 48;
            this.lblRelationship4.Text = "Relationship";
            // 
            // lblDependentFullName4
            // 
            this.lblDependentFullName4.AutoSize = true;
            this.lblDependentFullName4.Location = new System.Drawing.Point(459, 5);
            this.lblDependentFullName4.Name = "lblDependentFullName4";
            this.lblDependentFullName4.Size = new System.Drawing.Size(110, 13);
            this.lblDependentFullName4.TabIndex = 53;
            this.lblDependentFullName4.Text = "Dependent Full Name";
            // 
            // lblBirthDateDependent4
            // 
            this.lblBirthDateDependent4.AutoSize = true;
            this.lblBirthDateDependent4.Location = new System.Drawing.Point(457, 42);
            this.lblBirthDateDependent4.Name = "lblBirthDateDependent4";
            this.lblBirthDateDependent4.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDateDependent4.TabIndex = 49;
            this.lblBirthDateDependent4.Text = "Birth Date";
            // 
            // payroll_dependent_name4_emp
            // 
            this.payroll_dependent_name4_emp.Location = new System.Drawing.Point(459, 21);
            this.payroll_dependent_name4_emp.Name = "payroll_dependent_name4_emp";
            this.payroll_dependent_name4_emp.Size = new System.Drawing.Size(140, 20);
            this.payroll_dependent_name4_emp.TabIndex = 50;
            // 
            // shiftTab
            // 
            this.shiftTab.AutoScroll = true;
            this.shiftTab.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.shiftTab.Controls.Add(this.payroll_datagrid_shift_emp);
            this.shiftTab.Controls.Add(this.shift_code_id_emp);
            this.shiftTab.Controls.Add(this.lblChooseShift);
            this.shiftTab.Location = new System.Drawing.Point(4, 22);
            this.shiftTab.Name = "shiftTab";
            this.shiftTab.Size = new System.Drawing.Size(620, 125);
            this.shiftTab.TabIndex = 6;
            this.shiftTab.Text = "Shift";
            this.shiftTab.UseVisualStyleBackColor = true;
            // 
            // payroll_datagrid_shift_emp
            // 
            this.payroll_datagrid_shift_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_datagrid_shift_emp.Location = new System.Drawing.Point(12, 53);
            this.payroll_datagrid_shift_emp.Name = "payroll_datagrid_shift_emp";
            this.payroll_datagrid_shift_emp.Size = new System.Drawing.Size(579, 180);
            this.payroll_datagrid_shift_emp.TabIndex = 36;
            // 
            // shift_code_id_emp
            // 
            this.shift_code_id_emp.FormattingEnabled = true;
            this.shift_code_id_emp.Location = new System.Drawing.Point(12, 26);
            this.shift_code_id_emp.Name = "shift_code_id_emp";
            this.shift_code_id_emp.Size = new System.Drawing.Size(213, 21);
            this.shift_code_id_emp.TabIndex = 35;
            // 
            // lblChooseShift
            // 
            this.lblChooseShift.AutoSize = true;
            this.lblChooseShift.Location = new System.Drawing.Point(12, 10);
            this.lblChooseShift.Name = "lblChooseShift";
            this.lblChooseShift.Size = new System.Drawing.Size(114, 13);
            this.lblChooseShift.TabIndex = 34;
            this.lblChooseShift.Text = "Choose Shift Template";
            // 
            // otherTab
            // 
            this.otherTab.Controls.Add(this.tabControl1);
            this.otherTab.Location = new System.Drawing.Point(4, 22);
            this.otherTab.Name = "otherTab";
            this.otherTab.Size = new System.Drawing.Size(620, 125);
            this.otherTab.TabIndex = 7;
            this.otherTab.Text = "Other";
            this.otherTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allowanceTab);
            this.tabControl1.Controls.Add(this.leaveTab);
            this.tabControl1.Controls.Add(this.deductionTab);
            this.tabControl1.Controls.Add(this.journalTab);
            this.tabControl1.Controls.Add(this.remarkTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // allowanceTab
            // 
            this.allowanceTab.Location = new System.Drawing.Point(4, 22);
            this.allowanceTab.Name = "allowanceTab";
            this.allowanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.allowanceTab.Size = new System.Drawing.Size(606, 74);
            this.allowanceTab.TabIndex = 0;
            this.allowanceTab.Text = "Allowance";
            this.allowanceTab.UseVisualStyleBackColor = true;
            // 
            // leaveTab
            // 
            this.leaveTab.Location = new System.Drawing.Point(4, 22);
            this.leaveTab.Name = "leaveTab";
            this.leaveTab.Padding = new System.Windows.Forms.Padding(3);
            this.leaveTab.Size = new System.Drawing.Size(606, 74);
            this.leaveTab.TabIndex = 1;
            this.leaveTab.Text = "Leave";
            this.leaveTab.UseVisualStyleBackColor = true;
            // 
            // deductionTab
            // 
            this.deductionTab.Location = new System.Drawing.Point(4, 22);
            this.deductionTab.Name = "deductionTab";
            this.deductionTab.Size = new System.Drawing.Size(606, 74);
            this.deductionTab.TabIndex = 2;
            this.deductionTab.Text = "Deduction";
            this.deductionTab.UseVisualStyleBackColor = true;
            // 
            // journalTab
            // 
            this.journalTab.Location = new System.Drawing.Point(4, 22);
            this.journalTab.Name = "journalTab";
            this.journalTab.Size = new System.Drawing.Size(606, 74);
            this.journalTab.TabIndex = 3;
            this.journalTab.Text = "Journal";
            this.journalTab.UseVisualStyleBackColor = true;
            // 
            // remarkTab
            // 
            this.remarkTab.Location = new System.Drawing.Point(4, 22);
            this.remarkTab.Name = "remarkTab";
            this.remarkTab.Size = new System.Drawing.Size(606, 74);
            this.remarkTab.TabIndex = 4;
            this.remarkTab.Text = "Remarks";
            this.remarkTab.UseVisualStyleBackColor = true;
            // 
            // payroll_employee_gender_emp
            // 
            this.payroll_employee_gender_emp.DisplayMember = "male";
            this.payroll_employee_gender_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_employee_gender_emp.FormattingEnabled = true;
            this.payroll_employee_gender_emp.Items.AddRange(new object[] {
            "male",
            "female"});
            this.payroll_employee_gender_emp.Location = new System.Drawing.Point(10, 149);
            this.payroll_employee_gender_emp.Name = "payroll_employee_gender_emp";
            this.payroll_employee_gender_emp.Size = new System.Drawing.Size(213, 21);
            this.payroll_employee_gender_emp.TabIndex = 27;
            this.payroll_employee_gender_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblPrintName
            // 
            this.lblPrintName.AutoSize = true;
            this.lblPrintName.Location = new System.Drawing.Point(445, 133);
            this.lblPrintName.Name = "lblPrintName";
            this.lblPrintName.Size = new System.Drawing.Size(104, 13);
            this.lblPrintName.TabIndex = 26;
            this.lblPrintName.Text = "Print on as check as";
            this.lblPrintName.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(226, 133);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 25;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 133);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender";
            this.lblGender.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_display_name_emp
            // 
            this.payroll_employee_display_name_emp.Location = new System.Drawing.Point(448, 149);
            this.payroll_employee_display_name_emp.Name = "payroll_employee_display_name_emp";
            this.payroll_employee_display_name_emp.Size = new System.Drawing.Size(264, 20);
            this.payroll_employee_display_name_emp.TabIndex = 23;
            this.payroll_employee_display_name_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(445, 94);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 20;
            this.lblEmailAddress.Text = "Email Address";
            this.lblEmailAddress.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(226, 94);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 19;
            this.lblCompany.Text = "Company ";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(10, 94);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 18;
            this.lblContactNumber.Text = "Contact Number";
            this.lblContactNumber.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_email_emp
            // 
            this.payroll_employee_email_emp.Location = new System.Drawing.Point(448, 110);
            this.payroll_employee_email_emp.Name = "payroll_employee_email_emp";
            this.payroll_employee_email_emp.Size = new System.Drawing.Size(264, 20);
            this.payroll_employee_email_emp.TabIndex = 17;
            this.payroll_employee_email_emp.Tag = "Email Address";
            this.payroll_employee_email_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_contact_emp
            // 
            this.payroll_employee_contact_emp.Location = new System.Drawing.Point(10, 110);
            this.payroll_employee_contact_emp.Name = "payroll_employee_contact_emp";
            this.payroll_employee_contact_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_contact_emp.TabIndex = 15;
            this.payroll_employee_contact_emp.Tag = "Contact Number";
            this.payroll_employee_contact_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblAtmNumber
            // 
            this.lblAtmNumber.AutoSize = true;
            this.lblAtmNumber.Location = new System.Drawing.Point(445, 55);
            this.lblAtmNumber.Name = "lblAtmNumber";
            this.lblAtmNumber.Size = new System.Drawing.Size(70, 13);
            this.lblAtmNumber.TabIndex = 14;
            this.lblAtmNumber.Text = "ATM Number";
            this.lblAtmNumber.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblBiometricNumber
            // 
            this.lblBiometricNumber.AutoSize = true;
            this.lblBiometricNumber.Location = new System.Drawing.Point(226, 55);
            this.lblBiometricNumber.Name = "lblBiometricNumber";
            this.lblBiometricNumber.Size = new System.Drawing.Size(90, 13);
            this.lblBiometricNumber.TabIndex = 13;
            this.lblBiometricNumber.Text = "Biometric Number";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(10, 55);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.lblEmployeeNumber.TabIndex = 12;
            this.lblEmployeeNumber.Text = "Employee Number";
            this.lblEmployeeNumber.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_atm_number_emp
            // 
            this.payroll_employee_atm_number_emp.Location = new System.Drawing.Point(448, 71);
            this.payroll_employee_atm_number_emp.Name = "payroll_employee_atm_number_emp";
            this.payroll_employee_atm_number_emp.Size = new System.Drawing.Size(264, 20);
            this.payroll_employee_atm_number_emp.TabIndex = 10;
            this.payroll_employee_atm_number_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_biometric_number_emp
            // 
            this.payroll_employee_biometric_number_emp.Location = new System.Drawing.Point(229, 71);
            this.payroll_employee_biometric_number_emp.Name = "payroll_employee_biometric_number_emp";
            this.payroll_employee_biometric_number_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_biometric_number_emp.TabIndex = 9;
            this.payroll_employee_biometric_number_emp.Tag = "Biometric Number";
            this.payroll_employee_biometric_number_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_number_emp
            // 
            this.payroll_employee_number_emp.Location = new System.Drawing.Point(10, 71);
            this.payroll_employee_number_emp.Name = "payroll_employee_number_emp";
            this.payroll_employee_number_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_number_emp.TabIndex = 8;
            this.payroll_employee_number_emp.Tag = "Employee Number";
            this.payroll_employee_number_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(664, 16);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblSuffix.TabIndex = 7;
            this.lblSuffix.Text = "Suffix";
            this.lblSuffix.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(445, 16);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(226, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_suffix_name_emp
            // 
            this.payroll_employee_suffix_name_emp.Location = new System.Drawing.Point(667, 32);
            this.payroll_employee_suffix_name_emp.Name = "payroll_employee_suffix_name_emp";
            this.payroll_employee_suffix_name_emp.Size = new System.Drawing.Size(45, 20);
            this.payroll_employee_suffix_name_emp.TabIndex = 3;
            this.payroll_employee_suffix_name_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_middle_name_emp
            // 
            this.payroll_employee_middle_name_emp.Location = new System.Drawing.Point(448, 32);
            this.payroll_employee_middle_name_emp.Name = "payroll_employee_middle_name_emp";
            this.payroll_employee_middle_name_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_middle_name_emp.TabIndex = 2;
            this.payroll_employee_middle_name_emp.Tag = "Middle Name";
            this.payroll_employee_middle_name_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_first_name_emp
            // 
            this.payroll_employee_first_name_emp.Location = new System.Drawing.Point(229, 32);
            this.payroll_employee_first_name_emp.Name = "payroll_employee_first_name_emp";
            this.payroll_employee_first_name_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_first_name_emp.TabIndex = 1;
            this.payroll_employee_first_name_emp.Tag = "First Name";
            this.payroll_employee_first_name_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // payroll_employee_last_name_emp
            // 
            this.payroll_employee_last_name_emp.Location = new System.Drawing.Point(10, 32);
            this.payroll_employee_last_name_emp.Name = "payroll_employee_last_name_emp";
            this.payroll_employee_last_name_emp.Size = new System.Drawing.Size(213, 20);
            this.payroll_employee_last_name_emp.TabIndex = 0;
            this.payroll_employee_last_name_emp.Tag = "Last Name";
            this.payroll_employee_last_name_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // grpExportEmployee
            // 
            this.grpExportEmployee.Controls.Add(this.btnExportEmployeePDF);
            this.grpExportEmployee.Location = new System.Drawing.Point(789, 531);
            this.grpExportEmployee.Name = "grpExportEmployee";
            this.grpExportEmployee.Size = new System.Drawing.Size(236, 51);
            this.grpExportEmployee.TabIndex = 21;
            this.grpExportEmployee.TabStop = false;
            this.grpExportEmployee.Text = "Export Employee";
            this.grpExportEmployee.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnExportEmployeePDF
            // 
            this.btnExportEmployeePDF.Location = new System.Drawing.Point(9, 19);
            this.btnExportEmployeePDF.Name = "btnExportEmployeePDF";
            this.btnExportEmployeePDF.Size = new System.Drawing.Size(212, 23);
            this.btnExportEmployeePDF.TabIndex = 39;
            this.btnExportEmployeePDF.Text = "Export to PDF";
            this.btnExportEmployeePDF.UseVisualStyleBackColor = true;
            this.btnExportEmployeePDF.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // grpImportEmployee
            // 
            this.grpImportEmployee.Controls.Add(this.btnUpdateEmployeeExcelFile);
            this.grpImportEmployee.Controls.Add(this.btnImportEmployeeExcelFile);
            this.grpImportEmployee.Controls.Add(this.btnChooseEmployeeExcelFile);
            this.grpImportEmployee.Controls.Add(this.btnDownloadEmployeeTemplate);
            this.grpImportEmployee.Controls.Add(this.lblNumberofEmployee);
            this.grpImportEmployee.Controls.Add(this.number_of_emp);
            this.grpImportEmployee.Location = new System.Drawing.Point(789, 324);
            this.grpImportEmployee.Name = "grpImportEmployee";
            this.grpImportEmployee.Size = new System.Drawing.Size(236, 201);
            this.grpImportEmployee.TabIndex = 20;
            this.grpImportEmployee.TabStop = false;
            this.grpImportEmployee.Text = "Import Employee";
            this.grpImportEmployee.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnUpdateEmployeeExcelFile
            // 
            this.btnUpdateEmployeeExcelFile.Location = new System.Drawing.Point(9, 158);
            this.btnUpdateEmployeeExcelFile.Name = "btnUpdateEmployeeExcelFile";
            this.btnUpdateEmployeeExcelFile.Size = new System.Drawing.Size(212, 23);
            this.btnUpdateEmployeeExcelFile.TabIndex = 38;
            this.btnUpdateEmployeeExcelFile.Text = "Update 201 File";
            this.btnUpdateEmployeeExcelFile.UseVisualStyleBackColor = true;
            this.btnUpdateEmployeeExcelFile.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnImportEmployeeExcelFile
            // 
            this.btnImportEmployeeExcelFile.Location = new System.Drawing.Point(9, 129);
            this.btnImportEmployeeExcelFile.Name = "btnImportEmployeeExcelFile";
            this.btnImportEmployeeExcelFile.Size = new System.Drawing.Size(212, 23);
            this.btnImportEmployeeExcelFile.TabIndex = 37;
            this.btnImportEmployeeExcelFile.Text = "Import Excel File";
            this.btnImportEmployeeExcelFile.UseVisualStyleBackColor = true;
            this.btnImportEmployeeExcelFile.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnChooseEmployeeExcelFile
            // 
            this.btnChooseEmployeeExcelFile.Location = new System.Drawing.Point(9, 100);
            this.btnChooseEmployeeExcelFile.Name = "btnChooseEmployeeExcelFile";
            this.btnChooseEmployeeExcelFile.Size = new System.Drawing.Size(212, 23);
            this.btnChooseEmployeeExcelFile.TabIndex = 36;
            this.btnChooseEmployeeExcelFile.Text = "Choose Excel File";
            this.btnChooseEmployeeExcelFile.UseVisualStyleBackColor = true;
            this.btnChooseEmployeeExcelFile.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // btnDownloadEmployeeTemplate
            // 
            this.btnDownloadEmployeeTemplate.Location = new System.Drawing.Point(9, 71);
            this.btnDownloadEmployeeTemplate.Name = "btnDownloadEmployeeTemplate";
            this.btnDownloadEmployeeTemplate.Size = new System.Drawing.Size(212, 23);
            this.btnDownloadEmployeeTemplate.TabIndex = 34;
            this.btnDownloadEmployeeTemplate.Text = "Download Template";
            this.btnDownloadEmployeeTemplate.UseVisualStyleBackColor = true;
            this.btnDownloadEmployeeTemplate.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // lblNumberofEmployee
            // 
            this.lblNumberofEmployee.AutoSize = true;
            this.lblNumberofEmployee.Location = new System.Drawing.Point(6, 19);
            this.lblNumberofEmployee.Name = "lblNumberofEmployee";
            this.lblNumberofEmployee.Size = new System.Drawing.Size(110, 13);
            this.lblNumberofEmployee.TabIndex = 35;
            this.lblNumberofEmployee.Text = "Number of Employees";
            this.lblNumberofEmployee.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // number_of_emp
            // 
            this.number_of_emp.Location = new System.Drawing.Point(9, 35);
            this.number_of_emp.Name = "number_of_emp";
            this.number_of_emp.Size = new System.Drawing.Size(212, 20);
            this.number_of_emp.TabIndex = 34;
            this.number_of_emp.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 71);
            this.panel3.TabIndex = 19;
            this.panel3.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1090, 677);
            this.Controls.Add(this.payroll_config_dropdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AuditlogsPanel);
            this.Controls.Add(this.EmployeePanel);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.b.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo_default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_company_datagrid)).EndInit();
            this.payroll_config_dropdown.ResumeLayout(false);
            this.AuditlogsPanel.ResumeLayout(false);
            this.AuditlogsPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_auditlogs_datagrid)).EndInit();
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeeTabControl.ResumeLayout(false);
            this.activeemployee.ResumeLayout(false);
            this.activeemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_employee_datagrid_active)).EndInit();
            this.separatedemployee.ResumeLayout(false);
            this.separatedemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_employee_datagrid_archive)).EndInit();
            this.grpCreateEmployee.ResumeLayout(false);
            this.grpCreateEmployee.PerformLayout();
            this.CreateEmployeeTabControl.ResumeLayout(false);
            this.addressTab.ResumeLayout(false);
            this.addressTab.PerformLayout();
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.governmentTab.ResumeLayout(false);
            this.governmentTab.PerformLayout();
            this.salaryTab.ResumeLayout(false);
            this.salaryTab.PerformLayout();
            this.requirementTab.ResumeLayout(false);
            this.requirementTab.PerformLayout();
            this.dependentTab.ResumeLayout(false);
            this.dependentTab.PerformLayout();
            this.shiftTab.ResumeLayout(false);
            this.shiftTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_shift_emp)).EndInit();
            this.otherTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.grpExportEmployee.ResumeLayout(false);
            this.grpImportEmployee.ResumeLayout(false);
            this.grpImportEmployee.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button btn_audit_trail;

        private System.Windows.Forms.Panel AuditlogsPanel;
        private System.Windows.Forms.Label labelAuditLogTo;
        private System.Windows.Forms.Label labelAuditLogFrom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelAuditLog;
        private System.Windows.Forms.DataGridView payroll_auditlogs_datagrid;
        private System.Windows.Forms.ComboBox cmb_AuditlogsUsers;

        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.TabControl EmployeeTabControl;
        private System.Windows.Forms.TabPage activeemployee;
        private System.Windows.Forms.Label lblSearchEmp;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.Label lblFilterDept;
        private System.Windows.Forms.TextBox payroll_employee_search;
        private System.Windows.Forms.ComboBox payroll_employee_filter_status;
        private System.Windows.Forms.ComboBox payroll_employee_filter_dept;
        private System.Windows.Forms.DataGridView payroll_employee_datagrid_active;
        private System.Windows.Forms.TabPage separatedemployee;
        private System.Windows.Forms.DataGridView payroll_employee_datagrid_archive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payroll_employee_search_sep;
        private System.Windows.Forms.ComboBox payroll_employee_filter_status_sep;
        private System.Windows.Forms.ComboBox payroll_employee_filter_dept_sep;
        private System.Windows.Forms.GroupBox grpCreateEmployee;
        private System.Windows.Forms.CheckBox check_as_print_name;
        private System.Windows.Forms.DateTimePicker payroll_employee_birthdate_emp;
        private System.Windows.Forms.ComboBox payroll_employee_company_id_emp;
        private System.Windows.Forms.Button btnCompanyClear;
        private System.Windows.Forms.Button btnEmployeeSave;
        private System.Windows.Forms.TabControl CreateEmployeeTabControl;
        private System.Windows.Forms.TabPage addressTab;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.ComboBox payroll_employee_country_emp;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCityTown;
        private System.Windows.Forms.TextBox payroll_employee_zipcode_emp;
        private System.Windows.Forms.TextBox payroll_employee_state_emp;
        private System.Windows.Forms.TextBox payroll_employee_city_emp;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox payroll_employee_street_emp;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.ComboBox payroll_employee_contract_status_emp;
        private System.Windows.Forms.Label lblEmploymentStatus;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblPayrollGroup;
        private System.Windows.Forms.Label lblDateHired;
        private System.Windows.Forms.Button btnCompanyDetails;
        private System.Windows.Forms.Button btnNewCompanyDetails;
        private System.Windows.Forms.ComboBox payroll_group_id_emp;
        private System.Windows.Forms.DateTimePicker payroll_employee_contract_date_end_emp;
        private System.Windows.Forms.DateTimePicker payroll_employee_contract_date_hired_emp;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox payroll_jobtitle_id_emp;
        private System.Windows.Forms.ComboBox payroll_department_id_emp;
        private System.Windows.Forms.TabPage governmentTab;
        private System.Windows.Forms.Label lblPagibigNumber;
        private System.Windows.Forms.TextBox payroll_employee_pagibig_emp;
        private System.Windows.Forms.ComboBox payroll_employee_tax_status_emp;
        private System.Windows.Forms.Label lblTaxIdentificationNumber;
        private System.Windows.Forms.Label lblTaxStatus;
        private System.Windows.Forms.TextBox payroll_employee_tin_emp;
        private System.Windows.Forms.Label lblPhilhealthNumber;
        private System.Windows.Forms.Label lblSSSNumber;
        private System.Windows.Forms.TextBox payroll_employee_philhealth_emp;
        private System.Windows.Forms.TextBox payroll_employee_sss_emp;
        private System.Windows.Forms.TabPage salaryTab;
        private System.Windows.Forms.CheckBox payroll_employee_declare_emp;
        private System.Windows.Forms.CheckBox payroll_employee_salary_minimum_wage_emp;
        private System.Windows.Forms.TextBox payroll_employee_salary_cola_emp;
        private System.Windows.Forms.Label lblColaDaily;
        private System.Windows.Forms.Label lblPhilhealthSalary;
        private System.Windows.Forms.TextBox monthly_cola_emp;
        private System.Windows.Forms.Label lblColaMonthly;
        private System.Windows.Forms.TextBox payroll_employee_salary_philhealth_emp;
        private System.Windows.Forms.Label lblSSSSalary;
        private System.Windows.Forms.TextBox payroll_employee_salary_hourly_emp;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox payroll_employee_salary_sss_emp;
        private System.Windows.Forms.Label lblMonthlyRate;
        private System.Windows.Forms.TextBox payroll_employee_salary_monthly_emp;
        private System.Windows.Forms.Label lblTaxableSalary;
        private System.Windows.Forms.TextBox payroll_employee_salary_daily_emp;
        private System.Windows.Forms.Label lblPagibigContri;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.TextBox payroll_employee_salary_taxable_emp;
        private System.Windows.Forms.TextBox payroll_employee_salary_pagibig_emp;
        private System.Windows.Forms.TabPage requirementTab;
        private System.Windows.Forms.CheckBox has_valid_id;
        private System.Windows.Forms.CheckBox has_health_certificate;
        private System.Windows.Forms.CheckBox has_school_credentials;
        private System.Windows.Forms.CheckBox has_nbi;
        private System.Windows.Forms.CheckBox has_police_clearance;
        private System.Windows.Forms.CheckBox has_resume;
        private System.Windows.Forms.TabPage dependentTab;
        private System.Windows.Forms.ComboBox payroll_dependent_relationship1_emp;
        private System.Windows.Forms.DateTimePicker payroll_dependent_birthdate1_emp;
        private System.Windows.Forms.Label lblRelationship1;
        private System.Windows.Forms.Label lblDependentFullName1;
        private System.Windows.Forms.Label lblBirthDateDependent1;
        private System.Windows.Forms.TextBox payroll_dependent_name1_emp;
        private System.Windows.Forms.ComboBox payroll_dependent_relationship2_emp;
        private System.Windows.Forms.DateTimePicker payroll_dependent_birthdate2_emp;
        private System.Windows.Forms.Label lblRelationship2;
        private System.Windows.Forms.Label lblDependentFullName2;
        private System.Windows.Forms.Label lblBirthDateDependent2;
        private System.Windows.Forms.TextBox payroll_dependent_name2_emp;
        private System.Windows.Forms.ComboBox payroll_dependent_relationship3_emp;
        private System.Windows.Forms.DateTimePicker payroll_dependent_birthdate3_emp;
        private System.Windows.Forms.Label lblRelationship3;
        private System.Windows.Forms.Label lblDependentFullName3;
        private System.Windows.Forms.Label lblBirthDateDependent3;
        private System.Windows.Forms.TextBox payroll_dependent_name3_emp;
        private System.Windows.Forms.ComboBox payroll_dependent_relationship4_emp;
        private System.Windows.Forms.DateTimePicker payroll_dependent_birthdate4_emp;
        private System.Windows.Forms.Label lblRelationship4;
        private System.Windows.Forms.Label lblDependentFullName4;
        private System.Windows.Forms.Label lblBirthDateDependent4;
        private System.Windows.Forms.TextBox payroll_dependent_name4_emp;
        private System.Windows.Forms.TabPage shiftTab;
        private System.Windows.Forms.DataGridView payroll_datagrid_shift_emp;
        private System.Windows.Forms.ComboBox shift_code_id_emp;
        private System.Windows.Forms.Label lblChooseShift;
        private System.Windows.Forms.TabPage otherTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allowanceTab;
        private System.Windows.Forms.TabPage leaveTab;
        private System.Windows.Forms.TabPage deductionTab;
        private System.Windows.Forms.TabPage journalTab;
        private System.Windows.Forms.TabPage remarkTab;
        private System.Windows.Forms.ComboBox payroll_employee_gender_emp;
        private System.Windows.Forms.Label lblPrintName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox payroll_employee_display_name_emp;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox payroll_employee_email_emp;
        private System.Windows.Forms.TextBox payroll_employee_contact_emp;
        private System.Windows.Forms.Label lblAtmNumber;
        private System.Windows.Forms.Label lblBiometricNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.TextBox payroll_employee_atm_number_emp;
        private System.Windows.Forms.TextBox payroll_employee_biometric_number_emp;
        private System.Windows.Forms.TextBox payroll_employee_number_emp;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox payroll_employee_suffix_name_emp;
        private System.Windows.Forms.TextBox payroll_employee_middle_name_emp;
        private System.Windows.Forms.TextBox payroll_employee_first_name_emp;
        private System.Windows.Forms.TextBox payroll_employee_last_name_emp;
        private System.Windows.Forms.GroupBox grpExportEmployee;
        private System.Windows.Forms.Button btnExportEmployeePDF;
        private System.Windows.Forms.GroupBox grpImportEmployee;
        private System.Windows.Forms.Button btnUpdateEmployeeExcelFile;
        private System.Windows.Forms.Button btnImportEmployeeExcelFile;
        private System.Windows.Forms.Button btnChooseEmployeeExcelFile;
        private System.Windows.Forms.Button btnDownloadEmployeeTemplate;
        private System.Windows.Forms.Label lblNumberofEmployee;
        private System.Windows.Forms.TextBox number_of_emp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel payroll_config_dropdown;
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
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuditLogFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuditLogTo;
    }
}

