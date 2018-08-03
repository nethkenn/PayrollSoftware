namespace Payroll
{
    partial class PayrollGrouptabs
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
            this.PayrollGroupTabControl = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.PG_13MonthBasisPanel = new System.Windows.Forms.Panel();
            this.Compute13month_additions_absent = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_undertime = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_late = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_cola = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_regularholiday = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_specialholiday = new System.Windows.Forms.CheckBox();
            this.Compute13month_additions_deminimis = new System.Windows.Forms.CheckBox();
            this.Compute13MonthAdditionsLabel = new System.Windows.Forms.Label();
            this.Compute13month_additions_allowances = new System.Windows.Forms.CheckBox();
            this.Compute13MonthLabel = new System.Windows.Forms.Label();
            this.Compute13month_NetBasicPay = new System.Windows.Forms.RadioButton();
            this.Compute13month_GrossBasicPay = new System.Windows.Forms.RadioButton();
            this.PG_13MonthBasisLabel = new System.Windows.Forms.Label();
            this.PG_ColaBasisPanel = new System.Windows.Forms.Panel();
            this.ComputeColaBasisLabel = new System.Windows.Forms.Label();
            this.ColaBasis_DailyComputation = new System.Windows.Forms.RadioButton();
            this.ColaBasis_DailyFixed = new System.Windows.Forms.RadioButton();
            this.ColaBasis_ProRatedMonthly = new System.Windows.Forms.RadioButton();
            this.ColaBasis_MonthlyFixed = new System.Windows.Forms.RadioButton();
            this.PG_ColaBasisLabel = new System.Windows.Forms.Label();
            this.PG_DisplayRatePanel = new System.Windows.Forms.Panel();
            this.checkBoxDisplayDailyRate = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayMonthlyRate = new System.Windows.Forms.CheckBox();
            this.PG_DisplayRateLabel = new System.Windows.Forms.Label();
            this.PG_PayrollPeriodPanel = new System.Windows.Forms.Panel();
            this.PayrollPeriod_Monthly = new System.Windows.Forms.RadioButton();
            this.PayrollPeriod_SemiMonthly = new System.Windows.Forms.RadioButton();
            this.PG_PayrollPeriodLabel = new System.Windows.Forms.Label();
            this.PG_SalaryComputationPanel = new System.Windows.Forms.Panel();
            this.SalaryComputation_HourlyRate = new System.Windows.Forms.RadioButton();
            this.SalaryComputation_MonthlyRate = new System.Windows.Forms.RadioButton();
            this.SalaryComputation_DailyRate = new System.Windows.Forms.RadioButton();
            this.SalaryComputation_FlatRate = new System.Windows.Forms.RadioButton();
            this.PG_SalaryComputationLabel = new System.Windows.Forms.Label();
            this.PayrollcodePanel = new System.Windows.Forms.Panel();
            this.PG_PayrollCodelabel = new System.Windows.Forms.Label();
            this.payroll_group_code = new System.Windows.Forms.TextBox();
            this.tabDeduction = new System.Windows.Forms.TabPage();
            this.PG_BreakDeductionPanel = new System.Windows.Forms.Panel();
            this.BreakDeduction_NotDeducted = new System.Windows.Forms.RadioButton();
            this.BreakDeduction_Baseonsalary = new System.Windows.Forms.RadioButton();
            this.PG_BreakDeductionLabel = new System.Windows.Forms.Label();
            this.PG_UndertimeDeductionPanel = new System.Windows.Forms.Panel();
            this.PG_UndertimePercentageLabel = new System.Windows.Forms.Label();
            this.PG_UndertimeParameterLabel = new System.Windows.Forms.Label();
            this.payroll_under_time_deduction = new System.Windows.Forms.NumericUpDown();
            this.payroll_under_time_interval = new System.Windows.Forms.NumericUpDown();
            this.payroll_under_time_parameter = new System.Windows.Forms.ComboBox();
            this.UndertimeDeduction_NotDeducted = new System.Windows.Forms.RadioButton();
            this.UndertimeDeduction_Custom = new System.Windows.Forms.RadioButton();
            this.UndertimeDeduction_BaseOnSalary = new System.Windows.Forms.RadioButton();
            this.PG_UndertimeDeductionLabel = new System.Windows.Forms.Label();
            this.PG_LateDeductionPanel = new System.Windows.Forms.Panel();
            this.PG_DeductionLatePercentageLabel = new System.Windows.Forms.Label();
            this.PG_LateParameterLabel = new System.Windows.Forms.Label();
            this.payroll_late_deduction = new System.Windows.Forms.NumericUpDown();
            this.payroll_late_interval = new System.Windows.Forms.NumericUpDown();
            this.payroll_late_parameter = new System.Windows.Forms.ComboBox();
            this.LateDeduction_NotDeducted = new System.Windows.Forms.RadioButton();
            this.LateDeduction_Custom = new System.Windows.Forms.RadioButton();
            this.LateDeduction_BaseonSalary = new System.Windows.Forms.RadioButton();
            this.PG_LateDeductionLabel = new System.Windows.Forms.Label();
            this.PG_ContributionReferencePanel = new System.Windows.Forms.Panel();
            this.philhealth_reference = new System.Windows.Forms.ComboBox();
            this.sss_reference = new System.Windows.Forms.ComboBox();
            this.PG_PhilhealthContributionLabel = new System.Windows.Forms.Label();
            this.PG_SSSContributionLabel = new System.Windows.Forms.Label();
            this.PG_TaxContributionLabel = new System.Windows.Forms.Label();
            this.tax_reference = new System.Windows.Forms.ComboBox();
            this.PG_ContributionReferenceLabel = new System.Windows.Forms.Label();
            this.PG_AgencyFeePanel = new System.Windows.Forms.Panel();
            this.payroll_group_agency_fee = new System.Windows.Forms.NumericUpDown();
            this.PG_AgencyFeeLabel = new System.Windows.Forms.Label();
            this.PG_PagibigPanel = new System.Windows.Forms.Panel();
            this.Pagibig_NotDeducted = new System.Windows.Forms.RadioButton();
            this.Pagibig_EveryPeriod = new System.Windows.Forms.RadioButton();
            this.Pagibig_LastPeriod = new System.Windows.Forms.RadioButton();
            this.Pagibig_1stPeriod = new System.Windows.Forms.RadioButton();
            this.PG_PagibigLabel = new System.Windows.Forms.Label();
            this.PG_PhilhealthPanel = new System.Windows.Forms.Panel();
            this.Philhealth_NotDeducted = new System.Windows.Forms.RadioButton();
            this.Philhealth_EveryPeriod = new System.Windows.Forms.RadioButton();
            this.Philhealth_LastPeriod = new System.Windows.Forms.RadioButton();
            this.Philhealth_1stPeriod = new System.Windows.Forms.RadioButton();
            this.PG_PhilhealthLabel = new System.Windows.Forms.Label();
            this.PG_SSSPanel = new System.Windows.Forms.Panel();
            this.SSS_NotDeducted = new System.Windows.Forms.RadioButton();
            this.SSS_EveryPeriod = new System.Windows.Forms.RadioButton();
            this.SSS_LastPeriod = new System.Windows.Forms.RadioButton();
            this.SSS_1stPeriod = new System.Windows.Forms.RadioButton();
            this.PG_SSSLabel = new System.Windows.Forms.Label();
            this.PG_AgencyFeeDeductionPanel = new System.Windows.Forms.Panel();
            this.AgencyFeeDeduction_NotDeducted = new System.Windows.Forms.RadioButton();
            this.AgencyFeeDeduction_EveryPeriod = new System.Windows.Forms.RadioButton();
            this.AgencyFeeDeduction_LastPeriod = new System.Windows.Forms.RadioButton();
            this.AgencyFeeDeduction_2ndPeriod = new System.Windows.Forms.RadioButton();
            this.AgencyFeeDeduction_1stPeriod = new System.Windows.Forms.RadioButton();
            this.PG_AgencyFeeDeductionLabel = new System.Windows.Forms.Label();
            this.PG_WithHoldingTaxPanel = new System.Windows.Forms.Panel();
            this.WithholdingTax_NotDeducted = new System.Windows.Forms.RadioButton();
            this.WithholdingTax_LastPeriod = new System.Windows.Forms.RadioButton();
            this.WithholdingTax_EveryPeriod = new System.Windows.Forms.RadioButton();
            this.PG_WithHoldingTaxLabel = new System.Windows.Forms.Label();
            this.PG_DeductTaxAfterAll = new System.Windows.Forms.Panel();
            this.payroll_group_before_tax = new System.Windows.Forms.CheckBox();
            this.tabOvertime = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PG_OTRegularLabel = new System.Windows.Forms.Label();
            this.PG_OTLegalHolidayLabel = new System.Windows.Forms.Label();
            this.PG_OTSpecialHolidayLabel = new System.Windows.Forms.Label();
            this.payroll_overtime_regular = new System.Windows.Forms.NumericUpDown();
            this.OverTimeRatesTableSubHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PG_OvertimeRateFactorsRegularLabel = new System.Windows.Forms.Label();
            this.PG_OvertimeRateFactorsRegularNightDiffLabel = new System.Windows.Forms.Label();
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel = new System.Windows.Forms.Label();
            this.PG_OvertimeRateFactorsRestdayOTLabel = new System.Windows.Forms.Label();
            this.OverTimeRatesTableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PG_OvertimeRateFactorsLabel = new System.Windows.Forms.Label();
            this.PG_OvertimeRateFactorsRestDayLabel = new System.Windows.Forms.Label();
            this.tabShifting = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.PG_WorkingDayPerMonthLabel = new System.Windows.Forms.Label();
            this.payroll_group_working_day_month = new System.Windows.Forms.NumericUpDown();
            this.PG_GraceTime_Late = new System.Windows.Forms.Panel();
            this.PG_GraceTime_Overtime = new System.Windows.Forms.Panel();
            this.PG_GraceTime_LateLabel = new System.Windows.Forms.Label();
            this.PG_GraceTime_OvertimeLabel = new System.Windows.Forms.Label();
            this.PG_GraceTime_LateSubLabel = new System.Windows.Forms.Label();
            this.late_grace_time = new System.Windows.Forms.DateTimePicker();
            this.PG_GraceTimeRule_LateSubLabel = new System.Windows.Forms.Label();
            this.grace_time_rule_late = new System.Windows.Forms.ComboBox();
            this.grace_time_rule_overtime = new System.Windows.Forms.ComboBox();
            this.PG_GraceTimeRule_OvertimeSubLabel = new System.Windows.Forms.Label();
            this.overtime_grace_time = new System.Windows.Forms.DateTimePicker();
            this.PG_GraceTime_OvetimeSubLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tag_payroll_group_employee = new System.Windows.Forms.Button();
            this.PayrollGroupTabControl.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.PG_13MonthBasisPanel.SuspendLayout();
            this.PG_ColaBasisPanel.SuspendLayout();
            this.PG_DisplayRatePanel.SuspendLayout();
            this.PG_PayrollPeriodPanel.SuspendLayout();
            this.PG_SalaryComputationPanel.SuspendLayout();
            this.PayrollcodePanel.SuspendLayout();
            this.tabDeduction.SuspendLayout();
            this.PG_BreakDeductionPanel.SuspendLayout();
            this.PG_UndertimeDeductionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_under_time_deduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_under_time_interval)).BeginInit();
            this.PG_LateDeductionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_late_deduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_late_interval)).BeginInit();
            this.PG_ContributionReferencePanel.SuspendLayout();
            this.PG_AgencyFeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_group_agency_fee)).BeginInit();
            this.PG_PagibigPanel.SuspendLayout();
            this.PG_PhilhealthPanel.SuspendLayout();
            this.PG_SSSPanel.SuspendLayout();
            this.PG_AgencyFeeDeductionPanel.SuspendLayout();
            this.PG_WithHoldingTaxPanel.SuspendLayout();
            this.PG_DeductTaxAfterAll.SuspendLayout();
            this.tabOvertime.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_overtime_regular)).BeginInit();
            this.OverTimeRatesTableSubHeader.SuspendLayout();
            this.OverTimeRatesTableHeader.SuspendLayout();
            this.tabShifting.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_group_working_day_month)).BeginInit();
            this.PG_GraceTime_Late.SuspendLayout();
            this.PG_GraceTime_Overtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayrollGroupTabControl
            // 
            this.PayrollGroupTabControl.Controls.Add(this.tabBasic);
            this.PayrollGroupTabControl.Controls.Add(this.tabDeduction);
            this.PayrollGroupTabControl.Controls.Add(this.tabOvertime);
            this.PayrollGroupTabControl.Controls.Add(this.tabShifting);
            this.PayrollGroupTabControl.Controls.Add(this.tabEmployee);
            this.PayrollGroupTabControl.Location = new System.Drawing.Point(12, 12);
            this.PayrollGroupTabControl.Name = "PayrollGroupTabControl";
            this.PayrollGroupTabControl.SelectedIndex = 0;
            this.PayrollGroupTabControl.Size = new System.Drawing.Size(866, 547);
            this.PayrollGroupTabControl.TabIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.PG_13MonthBasisPanel);
            this.tabBasic.Controls.Add(this.PG_ColaBasisPanel);
            this.tabBasic.Controls.Add(this.PG_DisplayRatePanel);
            this.tabBasic.Controls.Add(this.PG_PayrollPeriodPanel);
            this.tabBasic.Controls.Add(this.PG_SalaryComputationPanel);
            this.tabBasic.Controls.Add(this.PayrollcodePanel);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(858, 521);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // PG_13MonthBasisPanel
            // 
            this.PG_13MonthBasisPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_absent);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_undertime);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_late);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_cola);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_regularholiday);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_specialholiday);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_deminimis);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13MonthAdditionsLabel);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_additions_allowances);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13MonthLabel);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_NetBasicPay);
            this.PG_13MonthBasisPanel.Controls.Add(this.Compute13month_GrossBasicPay);
            this.PG_13MonthBasisPanel.Controls.Add(this.PG_13MonthBasisLabel);
            this.PG_13MonthBasisPanel.Location = new System.Drawing.Point(317, 255);
            this.PG_13MonthBasisPanel.Name = "PG_13MonthBasisPanel";
            this.PG_13MonthBasisPanel.Size = new System.Drawing.Size(228, 260);
            this.PG_13MonthBasisPanel.TabIndex = 13;
            // 
            // Compute13month_additions_absent
            // 
            this.Compute13month_additions_absent.AutoSize = true;
            this.Compute13month_additions_absent.Location = new System.Drawing.Point(33, 233);
            this.Compute13month_additions_absent.Name = "Compute13month_additions_absent";
            this.Compute13month_additions_absent.Size = new System.Drawing.Size(59, 17);
            this.Compute13month_additions_absent.TabIndex = 22;
            this.Compute13month_additions_absent.Text = "Absent";
            this.Compute13month_additions_absent.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_undertime
            // 
            this.Compute13month_additions_undertime.AutoSize = true;
            this.Compute13month_additions_undertime.Location = new System.Drawing.Point(33, 216);
            this.Compute13month_additions_undertime.Name = "Compute13month_additions_undertime";
            this.Compute13month_additions_undertime.Size = new System.Drawing.Size(74, 17);
            this.Compute13month_additions_undertime.TabIndex = 21;
            this.Compute13month_additions_undertime.Text = "Undertime";
            this.Compute13month_additions_undertime.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_late
            // 
            this.Compute13month_additions_late.AutoSize = true;
            this.Compute13month_additions_late.Location = new System.Drawing.Point(33, 199);
            this.Compute13month_additions_late.Name = "Compute13month_additions_late";
            this.Compute13month_additions_late.Size = new System.Drawing.Size(47, 17);
            this.Compute13month_additions_late.TabIndex = 20;
            this.Compute13month_additions_late.Text = "Late";
            this.Compute13month_additions_late.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_cola
            // 
            this.Compute13month_additions_cola.AutoSize = true;
            this.Compute13month_additions_cola.Location = new System.Drawing.Point(33, 182);
            this.Compute13month_additions_cola.Name = "Compute13month_additions_cola";
            this.Compute13month_additions_cola.Size = new System.Drawing.Size(54, 17);
            this.Compute13month_additions_cola.TabIndex = 19;
            this.Compute13month_additions_cola.Text = "COLA";
            this.Compute13month_additions_cola.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_regularholiday
            // 
            this.Compute13month_additions_regularholiday.AutoSize = true;
            this.Compute13month_additions_regularholiday.Location = new System.Drawing.Point(33, 166);
            this.Compute13month_additions_regularholiday.Name = "Compute13month_additions_regularholiday";
            this.Compute13month_additions_regularholiday.Size = new System.Drawing.Size(101, 17);
            this.Compute13month_additions_regularholiday.TabIndex = 18;
            this.Compute13month_additions_regularholiday.Text = "Regular Holiday";
            this.Compute13month_additions_regularholiday.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_specialholiday
            // 
            this.Compute13month_additions_specialholiday.AutoSize = true;
            this.Compute13month_additions_specialholiday.Location = new System.Drawing.Point(33, 149);
            this.Compute13month_additions_specialholiday.Name = "Compute13month_additions_specialholiday";
            this.Compute13month_additions_specialholiday.Size = new System.Drawing.Size(99, 17);
            this.Compute13month_additions_specialholiday.TabIndex = 17;
            this.Compute13month_additions_specialholiday.Text = "Special Holiday";
            this.Compute13month_additions_specialholiday.UseVisualStyleBackColor = true;
            // 
            // Compute13month_additions_deminimis
            // 
            this.Compute13month_additions_deminimis.AutoSize = true;
            this.Compute13month_additions_deminimis.Location = new System.Drawing.Point(33, 132);
            this.Compute13month_additions_deminimis.Name = "Compute13month_additions_deminimis";
            this.Compute13month_additions_deminimis.Size = new System.Drawing.Size(113, 17);
            this.Compute13month_additions_deminimis.TabIndex = 14;
            this.Compute13month_additions_deminimis.Text = "De Minimis Benefit";
            this.Compute13month_additions_deminimis.UseVisualStyleBackColor = true;
            // 
            // Compute13MonthAdditionsLabel
            // 
            this.Compute13MonthAdditionsLabel.Location = new System.Drawing.Point(20, 93);
            this.Compute13MonthAdditionsLabel.Name = "Compute13MonthAdditionsLabel";
            this.Compute13MonthAdditionsLabel.Size = new System.Drawing.Size(158, 19);
            this.Compute13MonthAdditionsLabel.TabIndex = 16;
            this.Compute13MonthAdditionsLabel.Text = "Additions (+)";
            // 
            // Compute13month_additions_allowances
            // 
            this.Compute13month_additions_allowances.AutoSize = true;
            this.Compute13month_additions_allowances.Location = new System.Drawing.Point(33, 115);
            this.Compute13month_additions_allowances.Name = "Compute13month_additions_allowances";
            this.Compute13month_additions_allowances.Size = new System.Drawing.Size(75, 17);
            this.Compute13month_additions_allowances.TabIndex = 12;
            this.Compute13month_additions_allowances.Text = "Allowance";
            this.Compute13month_additions_allowances.UseVisualStyleBackColor = true;
            // 
            // Compute13MonthLabel
            // 
            this.Compute13MonthLabel.Location = new System.Drawing.Point(19, 28);
            this.Compute13MonthLabel.Name = "Compute13MonthLabel";
            this.Compute13MonthLabel.Size = new System.Drawing.Size(111, 23);
            this.Compute13MonthLabel.TabIndex = 11;
            this.Compute13MonthLabel.Text = "Compute 13 Month";
            // 
            // Compute13month_NetBasicPay
            // 
            this.Compute13month_NetBasicPay.AutoSize = true;
            this.Compute13month_NetBasicPay.Checked = true;
            this.Compute13month_NetBasicPay.Location = new System.Drawing.Point(33, 73);
            this.Compute13month_NetBasicPay.Name = "Compute13month_NetBasicPay";
            this.Compute13month_NetBasicPay.Size = new System.Drawing.Size(92, 17);
            this.Compute13month_NetBasicPay.TabIndex = 15;
            this.Compute13month_NetBasicPay.TabStop = true;
            this.Compute13month_NetBasicPay.Text = "Net Basic Pay";
            this.Compute13month_NetBasicPay.UseVisualStyleBackColor = true;
            // 
            // Compute13month_GrossBasicPay
            // 
            this.Compute13month_GrossBasicPay.AutoSize = true;
            this.Compute13month_GrossBasicPay.Location = new System.Drawing.Point(33, 50);
            this.Compute13month_GrossBasicPay.Name = "Compute13month_GrossBasicPay";
            this.Compute13month_GrossBasicPay.Size = new System.Drawing.Size(102, 17);
            this.Compute13month_GrossBasicPay.TabIndex = 13;
            this.Compute13month_GrossBasicPay.Text = "Gross Basic Pay";
            this.Compute13month_GrossBasicPay.UseVisualStyleBackColor = true;
            // 
            // PG_13MonthBasisLabel
            // 
            this.PG_13MonthBasisLabel.AutoSize = true;
            this.PG_13MonthBasisLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_13MonthBasisLabel.Name = "PG_13MonthBasisLabel";
            this.PG_13MonthBasisLabel.Size = new System.Drawing.Size(80, 13);
            this.PG_13MonthBasisLabel.TabIndex = 2;
            this.PG_13MonthBasisLabel.Text = "13 Month Basis";
            // 
            // PG_ColaBasisPanel
            // 
            this.PG_ColaBasisPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_ColaBasisPanel.Controls.Add(this.ComputeColaBasisLabel);
            this.PG_ColaBasisPanel.Controls.Add(this.ColaBasis_DailyComputation);
            this.PG_ColaBasisPanel.Controls.Add(this.ColaBasis_DailyFixed);
            this.PG_ColaBasisPanel.Controls.Add(this.ColaBasis_ProRatedMonthly);
            this.PG_ColaBasisPanel.Controls.Add(this.ColaBasis_MonthlyFixed);
            this.PG_ColaBasisPanel.Controls.Add(this.PG_ColaBasisLabel);
            this.PG_ColaBasisPanel.Location = new System.Drawing.Point(15, 255);
            this.PG_ColaBasisPanel.Name = "PG_ColaBasisPanel";
            this.PG_ColaBasisPanel.Size = new System.Drawing.Size(228, 156);
            this.PG_ColaBasisPanel.TabIndex = 12;
            // 
            // ComputeColaBasisLabel
            // 
            this.ComputeColaBasisLabel.Location = new System.Drawing.Point(18, 34);
            this.ComputeColaBasisLabel.Name = "ComputeColaBasisLabel";
            this.ComputeColaBasisLabel.Size = new System.Drawing.Size(111, 23);
            this.ComputeColaBasisLabel.TabIndex = 5;
            this.ComputeColaBasisLabel.Text = "Compute Cola Basis";
            // 
            // ColaBasis_DailyComputation
            // 
            this.ColaBasis_DailyComputation.AutoSize = true;
            this.ColaBasis_DailyComputation.Location = new System.Drawing.Point(32, 125);
            this.ColaBasis_DailyComputation.Name = "ColaBasis_DailyComputation";
            this.ColaBasis_DailyComputation.Size = new System.Drawing.Size(110, 17);
            this.ColaBasis_DailyComputation.TabIndex = 9;
            this.ColaBasis_DailyComputation.Text = "Daily Computation";
            this.ColaBasis_DailyComputation.UseVisualStyleBackColor = true;
            // 
            // ColaBasis_DailyFixed
            // 
            this.ColaBasis_DailyFixed.AutoSize = true;
            this.ColaBasis_DailyFixed.Location = new System.Drawing.Point(32, 102);
            this.ColaBasis_DailyFixed.Name = "ColaBasis_DailyFixed";
            this.ColaBasis_DailyFixed.Size = new System.Drawing.Size(76, 17);
            this.ColaBasis_DailyFixed.TabIndex = 6;
            this.ColaBasis_DailyFixed.Text = "Daily Fixed";
            this.ColaBasis_DailyFixed.UseVisualStyleBackColor = true;
            // 
            // ColaBasis_ProRatedMonthly
            // 
            this.ColaBasis_ProRatedMonthly.AutoSize = true;
            this.ColaBasis_ProRatedMonthly.Checked = true;
            this.ColaBasis_ProRatedMonthly.Location = new System.Drawing.Point(32, 79);
            this.ColaBasis_ProRatedMonthly.Name = "ColaBasis_ProRatedMonthly";
            this.ColaBasis_ProRatedMonthly.Size = new System.Drawing.Size(113, 17);
            this.ColaBasis_ProRatedMonthly.TabIndex = 8;
            this.ColaBasis_ProRatedMonthly.TabStop = true;
            this.ColaBasis_ProRatedMonthly.Text = "Pro Rated Monthly";
            this.ColaBasis_ProRatedMonthly.UseVisualStyleBackColor = true;
            // 
            // ColaBasis_MonthlyFixed
            // 
            this.ColaBasis_MonthlyFixed.AutoSize = true;
            this.ColaBasis_MonthlyFixed.Location = new System.Drawing.Point(32, 56);
            this.ColaBasis_MonthlyFixed.Name = "ColaBasis_MonthlyFixed";
            this.ColaBasis_MonthlyFixed.Size = new System.Drawing.Size(90, 17);
            this.ColaBasis_MonthlyFixed.TabIndex = 7;
            this.ColaBasis_MonthlyFixed.Text = "Monthly Fixed";
            this.ColaBasis_MonthlyFixed.UseVisualStyleBackColor = true;
            // 
            // PG_ColaBasisLabel
            // 
            this.PG_ColaBasisLabel.AutoSize = true;
            this.PG_ColaBasisLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_ColaBasisLabel.Name = "PG_ColaBasisLabel";
            this.PG_ColaBasisLabel.Size = new System.Drawing.Size(71, 13);
            this.PG_ColaBasisLabel.TabIndex = 2;
            this.PG_ColaBasisLabel.Text = "Payroll Period";
            // 
            // PG_DisplayRatePanel
            // 
            this.PG_DisplayRatePanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_DisplayRatePanel.Controls.Add(this.checkBoxDisplayDailyRate);
            this.PG_DisplayRatePanel.Controls.Add(this.checkBoxDisplayMonthlyRate);
            this.PG_DisplayRatePanel.Controls.Add(this.PG_DisplayRateLabel);
            this.PG_DisplayRatePanel.Location = new System.Drawing.Point(614, 93);
            this.PG_DisplayRatePanel.Name = "PG_DisplayRatePanel";
            this.PG_DisplayRatePanel.Size = new System.Drawing.Size(228, 142);
            this.PG_DisplayRatePanel.TabIndex = 11;
            // 
            // checkBoxDisplayDailyRate
            // 
            this.checkBoxDisplayDailyRate.AutoSize = true;
            this.checkBoxDisplayDailyRate.Checked = true;
            this.checkBoxDisplayDailyRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayDailyRate.Location = new System.Drawing.Point(24, 51);
            this.checkBoxDisplayDailyRate.Name = "checkBoxDisplayDailyRate";
            this.checkBoxDisplayDailyRate.Size = new System.Drawing.Size(112, 17);
            this.checkBoxDisplayDailyRate.TabIndex = 4;
            this.checkBoxDisplayDailyRate.Text = "Display Daily Rate";
            this.checkBoxDisplayDailyRate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayMonthlyRate
            // 
            this.checkBoxDisplayMonthlyRate.AutoSize = true;
            this.checkBoxDisplayMonthlyRate.Checked = true;
            this.checkBoxDisplayMonthlyRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayMonthlyRate.Location = new System.Drawing.Point(24, 28);
            this.checkBoxDisplayMonthlyRate.Name = "checkBoxDisplayMonthlyRate";
            this.checkBoxDisplayMonthlyRate.Size = new System.Drawing.Size(126, 17);
            this.checkBoxDisplayMonthlyRate.TabIndex = 3;
            this.checkBoxDisplayMonthlyRate.Text = "Display Monthly Rate";
            this.checkBoxDisplayMonthlyRate.UseVisualStyleBackColor = true;
            // 
            // PG_DisplayRateLabel
            // 
            this.PG_DisplayRateLabel.AutoSize = true;
            this.PG_DisplayRateLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_DisplayRateLabel.Name = "PG_DisplayRateLabel";
            this.PG_DisplayRateLabel.Size = new System.Drawing.Size(71, 13);
            this.PG_DisplayRateLabel.TabIndex = 2;
            this.PG_DisplayRateLabel.Text = "Payroll Period";
            // 
            // PG_PayrollPeriodPanel
            // 
            this.PG_PayrollPeriodPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_PayrollPeriodPanel.Controls.Add(this.PayrollPeriod_Monthly);
            this.PG_PayrollPeriodPanel.Controls.Add(this.PayrollPeriod_SemiMonthly);
            this.PG_PayrollPeriodPanel.Controls.Add(this.PG_PayrollPeriodLabel);
            this.PG_PayrollPeriodPanel.Location = new System.Drawing.Point(317, 93);
            this.PG_PayrollPeriodPanel.Name = "PG_PayrollPeriodPanel";
            this.PG_PayrollPeriodPanel.Size = new System.Drawing.Size(228, 142);
            this.PG_PayrollPeriodPanel.TabIndex = 10;
            // 
            // PayrollPeriod_Monthly
            // 
            this.PayrollPeriod_Monthly.AutoSize = true;
            this.PayrollPeriod_Monthly.Location = new System.Drawing.Point(22, 51);
            this.PayrollPeriod_Monthly.Name = "PayrollPeriod_Monthly";
            this.PayrollPeriod_Monthly.Size = new System.Drawing.Size(62, 17);
            this.PayrollPeriod_Monthly.TabIndex = 5;
            this.PayrollPeriod_Monthly.TabStop = true;
            this.PayrollPeriod_Monthly.Text = "Monthly";
            this.PayrollPeriod_Monthly.UseVisualStyleBackColor = true;
            // 
            // PayrollPeriod_SemiMonthly
            // 
            this.PayrollPeriod_SemiMonthly.AutoSize = true;
            this.PayrollPeriod_SemiMonthly.Location = new System.Drawing.Point(22, 28);
            this.PayrollPeriod_SemiMonthly.Name = "PayrollPeriod_SemiMonthly";
            this.PayrollPeriod_SemiMonthly.Size = new System.Drawing.Size(88, 17);
            this.PayrollPeriod_SemiMonthly.TabIndex = 4;
            this.PayrollPeriod_SemiMonthly.TabStop = true;
            this.PayrollPeriod_SemiMonthly.Text = "Semi-Monthly";
            this.PayrollPeriod_SemiMonthly.UseVisualStyleBackColor = true;
            // 
            // PG_PayrollPeriodLabel
            // 
            this.PG_PayrollPeriodLabel.AutoSize = true;
            this.PG_PayrollPeriodLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_PayrollPeriodLabel.Name = "PG_PayrollPeriodLabel";
            this.PG_PayrollPeriodLabel.Size = new System.Drawing.Size(71, 13);
            this.PG_PayrollPeriodLabel.TabIndex = 2;
            this.PG_PayrollPeriodLabel.Text = "Payroll Period";
            // 
            // PG_SalaryComputationPanel
            // 
            this.PG_SalaryComputationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_SalaryComputationPanel.Controls.Add(this.SalaryComputation_HourlyRate);
            this.PG_SalaryComputationPanel.Controls.Add(this.SalaryComputation_MonthlyRate);
            this.PG_SalaryComputationPanel.Controls.Add(this.SalaryComputation_DailyRate);
            this.PG_SalaryComputationPanel.Controls.Add(this.SalaryComputation_FlatRate);
            this.PG_SalaryComputationPanel.Controls.Add(this.PG_SalaryComputationLabel);
            this.PG_SalaryComputationPanel.Location = new System.Drawing.Point(15, 93);
            this.PG_SalaryComputationPanel.Name = "PG_SalaryComputationPanel";
            this.PG_SalaryComputationPanel.Size = new System.Drawing.Size(228, 142);
            this.PG_SalaryComputationPanel.TabIndex = 9;
            // 
            // SalaryComputation_HourlyRate
            // 
            this.SalaryComputation_HourlyRate.AutoSize = true;
            this.SalaryComputation_HourlyRate.Location = new System.Drawing.Point(21, 101);
            this.SalaryComputation_HourlyRate.Name = "SalaryComputation_HourlyRate";
            this.SalaryComputation_HourlyRate.Size = new System.Drawing.Size(81, 17);
            this.SalaryComputation_HourlyRate.TabIndex = 8;
            this.SalaryComputation_HourlyRate.Text = "Hourly Rate";
            this.SalaryComputation_HourlyRate.UseVisualStyleBackColor = true;
            // 
            // SalaryComputation_MonthlyRate
            // 
            this.SalaryComputation_MonthlyRate.AutoSize = true;
            this.SalaryComputation_MonthlyRate.Location = new System.Drawing.Point(21, 78);
            this.SalaryComputation_MonthlyRate.Name = "SalaryComputation_MonthlyRate";
            this.SalaryComputation_MonthlyRate.Size = new System.Drawing.Size(88, 17);
            this.SalaryComputation_MonthlyRate.TabIndex = 5;
            this.SalaryComputation_MonthlyRate.Text = "Monthly Rate";
            this.SalaryComputation_MonthlyRate.UseVisualStyleBackColor = true;
            // 
            // SalaryComputation_DailyRate
            // 
            this.SalaryComputation_DailyRate.AutoSize = true;
            this.SalaryComputation_DailyRate.Checked = true;
            this.SalaryComputation_DailyRate.Location = new System.Drawing.Point(21, 55);
            this.SalaryComputation_DailyRate.Name = "SalaryComputation_DailyRate";
            this.SalaryComputation_DailyRate.Size = new System.Drawing.Size(74, 17);
            this.SalaryComputation_DailyRate.TabIndex = 7;
            this.SalaryComputation_DailyRate.TabStop = true;
            this.SalaryComputation_DailyRate.Text = "Daily Rate";
            this.SalaryComputation_DailyRate.UseVisualStyleBackColor = true;
            // 
            // SalaryComputation_FlatRate
            // 
            this.SalaryComputation_FlatRate.AutoSize = true;
            this.SalaryComputation_FlatRate.Location = new System.Drawing.Point(21, 32);
            this.SalaryComputation_FlatRate.Name = "SalaryComputation_FlatRate";
            this.SalaryComputation_FlatRate.Size = new System.Drawing.Size(68, 17);
            this.SalaryComputation_FlatRate.TabIndex = 6;
            this.SalaryComputation_FlatRate.Text = "Flat Rate";
            this.SalaryComputation_FlatRate.UseVisualStyleBackColor = true;
            // 
            // PG_SalaryComputationLabel
            // 
            this.PG_SalaryComputationLabel.AutoSize = true;
            this.PG_SalaryComputationLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_SalaryComputationLabel.Name = "PG_SalaryComputationLabel";
            this.PG_SalaryComputationLabel.Size = new System.Drawing.Size(98, 13);
            this.PG_SalaryComputationLabel.TabIndex = 2;
            this.PG_SalaryComputationLabel.Text = "Salary Computation";
            // 
            // PayrollcodePanel
            // 
            this.PayrollcodePanel.BackColor = System.Drawing.SystemColors.Control;
            this.PayrollcodePanel.Controls.Add(this.PG_PayrollCodelabel);
            this.PayrollcodePanel.Controls.Add(this.payroll_group_code);
            this.PayrollcodePanel.Location = new System.Drawing.Point(15, 27);
            this.PayrollcodePanel.Name = "PayrollcodePanel";
            this.PayrollcodePanel.Size = new System.Drawing.Size(228, 58);
            this.PayrollcodePanel.TabIndex = 8;
            // 
            // PG_PayrollCodelabel
            // 
            this.PG_PayrollCodelabel.AutoSize = true;
            this.PG_PayrollCodelabel.Location = new System.Drawing.Point(9, 11);
            this.PG_PayrollCodelabel.Name = "PG_PayrollCodelabel";
            this.PG_PayrollCodelabel.Size = new System.Drawing.Size(66, 13);
            this.PG_PayrollCodelabel.TabIndex = 2;
            this.PG_PayrollCodelabel.Text = "Payroll Code";
            // 
            // payroll_group_code
            // 
            this.payroll_group_code.Location = new System.Drawing.Point(10, 29);
            this.payroll_group_code.Name = "payroll_group_code";
            this.payroll_group_code.Size = new System.Drawing.Size(210, 20);
            this.payroll_group_code.TabIndex = 1;
            // 
            // tabDeduction
            // 
            this.tabDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabDeduction.Controls.Add(this.PG_BreakDeductionPanel);
            this.tabDeduction.Controls.Add(this.PG_UndertimeDeductionPanel);
            this.tabDeduction.Controls.Add(this.PG_LateDeductionPanel);
            this.tabDeduction.Controls.Add(this.PG_ContributionReferencePanel);
            this.tabDeduction.Controls.Add(this.PG_AgencyFeePanel);
            this.tabDeduction.Controls.Add(this.PG_PagibigPanel);
            this.tabDeduction.Controls.Add(this.PG_PhilhealthPanel);
            this.tabDeduction.Controls.Add(this.PG_SSSPanel);
            this.tabDeduction.Controls.Add(this.PG_AgencyFeeDeductionPanel);
            this.tabDeduction.Controls.Add(this.PG_WithHoldingTaxPanel);
            this.tabDeduction.Controls.Add(this.PG_DeductTaxAfterAll);
            this.tabDeduction.Location = new System.Drawing.Point(4, 22);
            this.tabDeduction.Name = "tabDeduction";
            this.tabDeduction.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeduction.Size = new System.Drawing.Size(858, 521);
            this.tabDeduction.TabIndex = 1;
            this.tabDeduction.Text = "Deduction Basis";
            this.tabDeduction.UseVisualStyleBackColor = true;
            // 
            // PG_BreakDeductionPanel
            // 
            this.PG_BreakDeductionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_BreakDeductionPanel.Controls.Add(this.BreakDeduction_NotDeducted);
            this.PG_BreakDeductionPanel.Controls.Add(this.BreakDeduction_Baseonsalary);
            this.PG_BreakDeductionPanel.Controls.Add(this.PG_BreakDeductionLabel);
            this.PG_BreakDeductionPanel.Location = new System.Drawing.Point(16, 323);
            this.PG_BreakDeductionPanel.Name = "PG_BreakDeductionPanel";
            this.PG_BreakDeductionPanel.Size = new System.Drawing.Size(568, 51);
            this.PG_BreakDeductionPanel.TabIndex = 25;
            // 
            // BreakDeduction_NotDeducted
            // 
            this.BreakDeduction_NotDeducted.AutoSize = true;
            this.BreakDeduction_NotDeducted.Checked = true;
            this.BreakDeduction_NotDeducted.Location = new System.Drawing.Point(257, 21);
            this.BreakDeduction_NotDeducted.Name = "BreakDeduction_NotDeducted";
            this.BreakDeduction_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.BreakDeduction_NotDeducted.TabIndex = 7;
            this.BreakDeduction_NotDeducted.TabStop = true;
            this.BreakDeduction_NotDeducted.Text = "Not Deducted";
            this.BreakDeduction_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // BreakDeduction_Baseonsalary
            // 
            this.BreakDeduction_Baseonsalary.AutoSize = true;
            this.BreakDeduction_Baseonsalary.Location = new System.Drawing.Point(25, 21);
            this.BreakDeduction_Baseonsalary.Name = "BreakDeduction_Baseonsalary";
            this.BreakDeduction_Baseonsalary.Size = new System.Drawing.Size(96, 17);
            this.BreakDeduction_Baseonsalary.TabIndex = 6;
            this.BreakDeduction_Baseonsalary.Text = "Base on Salary";
            this.BreakDeduction_Baseonsalary.UseVisualStyleBackColor = true;
            // 
            // PG_BreakDeductionLabel
            // 
            this.PG_BreakDeductionLabel.AutoSize = true;
            this.PG_BreakDeductionLabel.Location = new System.Drawing.Point(9, 5);
            this.PG_BreakDeductionLabel.Name = "PG_BreakDeductionLabel";
            this.PG_BreakDeductionLabel.Size = new System.Drawing.Size(87, 13);
            this.PG_BreakDeductionLabel.TabIndex = 2;
            this.PG_BreakDeductionLabel.Text = "Break Deduction";
            // 
            // PG_UndertimeDeductionPanel
            // 
            this.PG_UndertimeDeductionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_UndertimeDeductionPanel.Controls.Add(this.PG_UndertimePercentageLabel);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.PG_UndertimeParameterLabel);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.payroll_under_time_deduction);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.payroll_under_time_interval);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.payroll_under_time_parameter);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.UndertimeDeduction_NotDeducted);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.UndertimeDeduction_Custom);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.UndertimeDeduction_BaseOnSalary);
            this.PG_UndertimeDeductionPanel.Controls.Add(this.PG_UndertimeDeductionLabel);
            this.PG_UndertimeDeductionPanel.Location = new System.Drawing.Point(16, 235);
            this.PG_UndertimeDeductionPanel.Name = "PG_UndertimeDeductionPanel";
            this.PG_UndertimeDeductionPanel.Size = new System.Drawing.Size(568, 48);
            this.PG_UndertimeDeductionPanel.TabIndex = 17;
            // 
            // PG_UndertimePercentageLabel
            // 
            this.PG_UndertimePercentageLabel.AutoSize = true;
            this.PG_UndertimePercentageLabel.Location = new System.Drawing.Point(285, 53);
            this.PG_UndertimePercentageLabel.Name = "PG_UndertimePercentageLabel";
            this.PG_UndertimePercentageLabel.Size = new System.Drawing.Size(138, 13);
            this.PG_UndertimePercentageLabel.TabIndex = 24;
            this.PG_UndertimePercentageLabel.Text = "Deduction Late Percentage";
            // 
            // PG_UndertimeParameterLabel
            // 
            this.PG_UndertimeParameterLabel.AutoSize = true;
            this.PG_UndertimeParameterLabel.Location = new System.Drawing.Point(48, 53);
            this.PG_UndertimeParameterLabel.Name = "PG_UndertimeParameterLabel";
            this.PG_UndertimeParameterLabel.Size = new System.Drawing.Size(105, 13);
            this.PG_UndertimeParameterLabel.TabIndex = 23;
            this.PG_UndertimeParameterLabel.Text = "Undertime parameter";
            // 
            // payroll_under_time_deduction
            // 
            this.payroll_under_time_deduction.Location = new System.Drawing.Point(285, 66);
            this.payroll_under_time_deduction.Name = "payroll_under_time_deduction";
            this.payroll_under_time_deduction.Size = new System.Drawing.Size(202, 20);
            this.payroll_under_time_deduction.TabIndex = 22;
            // 
            // payroll_under_time_interval
            // 
            this.payroll_under_time_interval.Location = new System.Drawing.Point(49, 67);
            this.payroll_under_time_interval.Name = "payroll_under_time_interval";
            this.payroll_under_time_interval.Size = new System.Drawing.Size(69, 20);
            this.payroll_under_time_interval.TabIndex = 21;
            // 
            // payroll_under_time_parameter
            // 
            this.payroll_under_time_parameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_under_time_parameter.FormattingEnabled = true;
            this.payroll_under_time_parameter.Items.AddRange(new object[] {
            "Minute",
            "Hour"});
            this.payroll_under_time_parameter.Location = new System.Drawing.Point(118, 66);
            this.payroll_under_time_parameter.Name = "payroll_under_time_parameter";
            this.payroll_under_time_parameter.Size = new System.Drawing.Size(149, 21);
            this.payroll_under_time_parameter.TabIndex = 20;
            // 
            // UndertimeDeduction_NotDeducted
            // 
            this.UndertimeDeduction_NotDeducted.AutoSize = true;
            this.UndertimeDeduction_NotDeducted.Checked = true;
            this.UndertimeDeduction_NotDeducted.Location = new System.Drawing.Point(441, 21);
            this.UndertimeDeduction_NotDeducted.Name = "UndertimeDeduction_NotDeducted";
            this.UndertimeDeduction_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.UndertimeDeduction_NotDeducted.TabIndex = 5;
            this.UndertimeDeduction_NotDeducted.TabStop = true;
            this.UndertimeDeduction_NotDeducted.Text = "Not Deducted";
            this.UndertimeDeduction_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // UndertimeDeduction_Custom
            // 
            this.UndertimeDeduction_Custom.AutoSize = true;
            this.UndertimeDeduction_Custom.Location = new System.Drawing.Point(257, 21);
            this.UndertimeDeduction_Custom.Name = "UndertimeDeduction_Custom";
            this.UndertimeDeduction_Custom.Size = new System.Drawing.Size(60, 17);
            this.UndertimeDeduction_Custom.TabIndex = 7;
            this.UndertimeDeduction_Custom.Text = "Custom";
            this.UndertimeDeduction_Custom.UseVisualStyleBackColor = true;
            this.UndertimeDeduction_Custom.CheckedChanged += new System.EventHandler(this.CustomChecked);
            // 
            // UndertimeDeduction_BaseOnSalary
            // 
            this.UndertimeDeduction_BaseOnSalary.AutoSize = true;
            this.UndertimeDeduction_BaseOnSalary.Location = new System.Drawing.Point(25, 21);
            this.UndertimeDeduction_BaseOnSalary.Name = "UndertimeDeduction_BaseOnSalary";
            this.UndertimeDeduction_BaseOnSalary.Size = new System.Drawing.Size(96, 17);
            this.UndertimeDeduction_BaseOnSalary.TabIndex = 6;
            this.UndertimeDeduction_BaseOnSalary.Text = "Base on Salary";
            this.UndertimeDeduction_BaseOnSalary.UseVisualStyleBackColor = true;
            // 
            // PG_UndertimeDeductionLabel
            // 
            this.PG_UndertimeDeductionLabel.AutoSize = true;
            this.PG_UndertimeDeductionLabel.Location = new System.Drawing.Point(9, 5);
            this.PG_UndertimeDeductionLabel.Name = "PG_UndertimeDeductionLabel";
            this.PG_UndertimeDeductionLabel.Size = new System.Drawing.Size(107, 13);
            this.PG_UndertimeDeductionLabel.TabIndex = 2;
            this.PG_UndertimeDeductionLabel.Text = "Undertime Deduction";
            // 
            // PG_LateDeductionPanel
            // 
            this.PG_LateDeductionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_LateDeductionPanel.Controls.Add(this.PG_DeductionLatePercentageLabel);
            this.PG_LateDeductionPanel.Controls.Add(this.PG_LateParameterLabel);
            this.PG_LateDeductionPanel.Controls.Add(this.payroll_late_deduction);
            this.PG_LateDeductionPanel.Controls.Add(this.payroll_late_interval);
            this.PG_LateDeductionPanel.Controls.Add(this.payroll_late_parameter);
            this.PG_LateDeductionPanel.Controls.Add(this.LateDeduction_NotDeducted);
            this.PG_LateDeductionPanel.Controls.Add(this.LateDeduction_Custom);
            this.PG_LateDeductionPanel.Controls.Add(this.LateDeduction_BaseonSalary);
            this.PG_LateDeductionPanel.Controls.Add(this.PG_LateDeductionLabel);
            this.PG_LateDeductionPanel.Location = new System.Drawing.Point(16, 148);
            this.PG_LateDeductionPanel.Name = "PG_LateDeductionPanel";
            this.PG_LateDeductionPanel.Size = new System.Drawing.Size(568, 48);
            this.PG_LateDeductionPanel.TabIndex = 16;
            // 
            // PG_DeductionLatePercentageLabel
            // 
            this.PG_DeductionLatePercentageLabel.AutoSize = true;
            this.PG_DeductionLatePercentageLabel.Location = new System.Drawing.Point(283, 49);
            this.PG_DeductionLatePercentageLabel.Name = "PG_DeductionLatePercentageLabel";
            this.PG_DeductionLatePercentageLabel.Size = new System.Drawing.Size(138, 13);
            this.PG_DeductionLatePercentageLabel.TabIndex = 19;
            this.PG_DeductionLatePercentageLabel.Text = "Deduction Late Percentage";
            // 
            // PG_LateParameterLabel
            // 
            this.PG_LateParameterLabel.AutoSize = true;
            this.PG_LateParameterLabel.Location = new System.Drawing.Point(46, 49);
            this.PG_LateParameterLabel.Name = "PG_LateParameterLabel";
            this.PG_LateParameterLabel.Size = new System.Drawing.Size(78, 13);
            this.PG_LateParameterLabel.TabIndex = 18;
            this.PG_LateParameterLabel.Text = "Late parameter";
            // 
            // payroll_late_deduction
            // 
            this.payroll_late_deduction.Location = new System.Drawing.Point(283, 62);
            this.payroll_late_deduction.Name = "payroll_late_deduction";
            this.payroll_late_deduction.Size = new System.Drawing.Size(202, 20);
            this.payroll_late_deduction.TabIndex = 17;
            // 
            // payroll_late_interval
            // 
            this.payroll_late_interval.Location = new System.Drawing.Point(47, 63);
            this.payroll_late_interval.Name = "payroll_late_interval";
            this.payroll_late_interval.Size = new System.Drawing.Size(69, 20);
            this.payroll_late_interval.TabIndex = 16;
            // 
            // payroll_late_parameter
            // 
            this.payroll_late_parameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_late_parameter.FormattingEnabled = true;
            this.payroll_late_parameter.Items.AddRange(new object[] {
            "Minute",
            "Hour"});
            this.payroll_late_parameter.Location = new System.Drawing.Point(116, 62);
            this.payroll_late_parameter.Name = "payroll_late_parameter";
            this.payroll_late_parameter.Size = new System.Drawing.Size(149, 21);
            this.payroll_late_parameter.TabIndex = 15;
            // 
            // LateDeduction_NotDeducted
            // 
            this.LateDeduction_NotDeducted.AutoSize = true;
            this.LateDeduction_NotDeducted.Checked = true;
            this.LateDeduction_NotDeducted.Location = new System.Drawing.Point(441, 24);
            this.LateDeduction_NotDeducted.Name = "LateDeduction_NotDeducted";
            this.LateDeduction_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.LateDeduction_NotDeducted.TabIndex = 5;
            this.LateDeduction_NotDeducted.TabStop = true;
            this.LateDeduction_NotDeducted.Text = "Not Deducted";
            this.LateDeduction_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // LateDeduction_Custom
            // 
            this.LateDeduction_Custom.AutoSize = true;
            this.LateDeduction_Custom.Location = new System.Drawing.Point(257, 24);
            this.LateDeduction_Custom.Name = "LateDeduction_Custom";
            this.LateDeduction_Custom.Size = new System.Drawing.Size(60, 17);
            this.LateDeduction_Custom.TabIndex = 7;
            this.LateDeduction_Custom.Text = "Custom";
            this.LateDeduction_Custom.UseVisualStyleBackColor = true;
            this.LateDeduction_Custom.CheckedChanged += new System.EventHandler(this.CustomChecked);
            // 
            // LateDeduction_BaseonSalary
            // 
            this.LateDeduction_BaseonSalary.AutoSize = true;
            this.LateDeduction_BaseonSalary.Location = new System.Drawing.Point(25, 24);
            this.LateDeduction_BaseonSalary.Name = "LateDeduction_BaseonSalary";
            this.LateDeduction_BaseonSalary.Size = new System.Drawing.Size(96, 17);
            this.LateDeduction_BaseonSalary.TabIndex = 6;
            this.LateDeduction_BaseonSalary.Text = "Base on Salary";
            this.LateDeduction_BaseonSalary.UseVisualStyleBackColor = true;
            // 
            // PG_LateDeductionLabel
            // 
            this.PG_LateDeductionLabel.AutoSize = true;
            this.PG_LateDeductionLabel.Location = new System.Drawing.Point(9, 5);
            this.PG_LateDeductionLabel.Name = "PG_LateDeductionLabel";
            this.PG_LateDeductionLabel.Size = new System.Drawing.Size(80, 13);
            this.PG_LateDeductionLabel.TabIndex = 2;
            this.PG_LateDeductionLabel.Text = "Late Deduction";
            // 
            // PG_ContributionReferencePanel
            // 
            this.PG_ContributionReferencePanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_ContributionReferencePanel.Controls.Add(this.philhealth_reference);
            this.PG_ContributionReferencePanel.Controls.Add(this.sss_reference);
            this.PG_ContributionReferencePanel.Controls.Add(this.PG_PhilhealthContributionLabel);
            this.PG_ContributionReferencePanel.Controls.Add(this.PG_SSSContributionLabel);
            this.PG_ContributionReferencePanel.Controls.Add(this.PG_TaxContributionLabel);
            this.PG_ContributionReferencePanel.Controls.Add(this.tax_reference);
            this.PG_ContributionReferencePanel.Controls.Add(this.PG_ContributionReferenceLabel);
            this.PG_ContributionReferencePanel.Location = new System.Drawing.Point(16, 380);
            this.PG_ContributionReferencePanel.Name = "PG_ContributionReferencePanel";
            this.PG_ContributionReferencePanel.Size = new System.Drawing.Size(382, 135);
            this.PG_ContributionReferencePanel.TabIndex = 16;
            // 
            // philhealth_reference
            // 
            this.philhealth_reference.DisplayMember = "1,2,3";
            this.philhealth_reference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.philhealth_reference.FormattingEnabled = true;
            this.philhealth_reference.Items.AddRange(new object[] {
            "Declared Tax Salary",
            "Computed Taxable Salary",
            "Net Basic"});
            this.philhealth_reference.Location = new System.Drawing.Point(191, 92);
            this.philhealth_reference.Name = "philhealth_reference";
            this.philhealth_reference.Size = new System.Drawing.Size(158, 21);
            this.philhealth_reference.TabIndex = 26;
            // 
            // sss_reference
            // 
            this.sss_reference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sss_reference.FormattingEnabled = true;
            this.sss_reference.Items.AddRange(new object[] {
            "Declared Tax Salary",
            "Computed Taxable Salary",
            "Net Basic"});
            this.sss_reference.Location = new System.Drawing.Point(191, 61);
            this.sss_reference.Name = "sss_reference";
            this.sss_reference.Size = new System.Drawing.Size(158, 21);
            this.sss_reference.TabIndex = 25;
            // 
            // PG_PhilhealthContributionLabel
            // 
            this.PG_PhilhealthContributionLabel.AutoSize = true;
            this.PG_PhilhealthContributionLabel.Location = new System.Drawing.Point(26, 95);
            this.PG_PhilhealthContributionLabel.Name = "PG_PhilhealthContributionLabel";
            this.PG_PhilhealthContributionLabel.Size = new System.Drawing.Size(114, 13);
            this.PG_PhilhealthContributionLabel.TabIndex = 23;
            this.PG_PhilhealthContributionLabel.Text = "PhilHealth Contribution";
            // 
            // PG_SSSContributionLabel
            // 
            this.PG_SSSContributionLabel.AutoSize = true;
            this.PG_SSSContributionLabel.Location = new System.Drawing.Point(26, 64);
            this.PG_SSSContributionLabel.Name = "PG_SSSContributionLabel";
            this.PG_SSSContributionLabel.Size = new System.Drawing.Size(87, 13);
            this.PG_SSSContributionLabel.TabIndex = 21;
            this.PG_SSSContributionLabel.Text = "SSS Contribution";
            // 
            // PG_TaxContributionLabel
            // 
            this.PG_TaxContributionLabel.AutoSize = true;
            this.PG_TaxContributionLabel.Location = new System.Drawing.Point(27, 35);
            this.PG_TaxContributionLabel.Name = "PG_TaxContributionLabel";
            this.PG_TaxContributionLabel.Size = new System.Drawing.Size(84, 13);
            this.PG_TaxContributionLabel.TabIndex = 22;
            this.PG_TaxContributionLabel.Text = "Tax Contribution";
            // 
            // tax_reference
            // 
            this.tax_reference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tax_reference.FormattingEnabled = true;
            this.tax_reference.Location = new System.Drawing.Point(191, 32);
            this.tax_reference.Name = "tax_reference";
            this.tax_reference.Size = new System.Drawing.Size(158, 21);
            this.tax_reference.TabIndex = 24;
            // 
            // PG_ContributionReferenceLabel
            // 
            this.PG_ContributionReferenceLabel.AutoSize = true;
            this.PG_ContributionReferenceLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_ContributionReferenceLabel.Name = "PG_ContributionReferenceLabel";
            this.PG_ContributionReferenceLabel.Size = new System.Drawing.Size(116, 13);
            this.PG_ContributionReferenceLabel.TabIndex = 2;
            this.PG_ContributionReferenceLabel.Text = "Contribution Reference";
            // 
            // PG_AgencyFeePanel
            // 
            this.PG_AgencyFeePanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_AgencyFeePanel.Controls.Add(this.payroll_group_agency_fee);
            this.PG_AgencyFeePanel.Controls.Add(this.PG_AgencyFeeLabel);
            this.PG_AgencyFeePanel.Location = new System.Drawing.Point(615, 178);
            this.PG_AgencyFeePanel.Name = "PG_AgencyFeePanel";
            this.PG_AgencyFeePanel.Size = new System.Drawing.Size(228, 61);
            this.PG_AgencyFeePanel.TabIndex = 21;
            // 
            // payroll_group_agency_fee
            // 
            this.payroll_group_agency_fee.DecimalPlaces = 4;
            this.payroll_group_agency_fee.Location = new System.Drawing.Point(12, 28);
            this.payroll_group_agency_fee.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.payroll_group_agency_fee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            720896});
            this.payroll_group_agency_fee.Name = "payroll_group_agency_fee";
            this.payroll_group_agency_fee.Size = new System.Drawing.Size(202, 20);
            this.payroll_group_agency_fee.TabIndex = 3;
            this.payroll_group_agency_fee.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // PG_AgencyFeeLabel
            // 
            this.PG_AgencyFeeLabel.AutoSize = true;
            this.PG_AgencyFeeLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_AgencyFeeLabel.Name = "PG_AgencyFeeLabel";
            this.PG_AgencyFeeLabel.Size = new System.Drawing.Size(61, 13);
            this.PG_AgencyFeeLabel.TabIndex = 2;
            this.PG_AgencyFeeLabel.Text = "AgencyFee";
            // 
            // PG_PagibigPanel
            // 
            this.PG_PagibigPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_PagibigPanel.Controls.Add(this.Pagibig_NotDeducted);
            this.PG_PagibigPanel.Controls.Add(this.Pagibig_EveryPeriod);
            this.PG_PagibigPanel.Controls.Add(this.Pagibig_LastPeriod);
            this.PG_PagibigPanel.Controls.Add(this.Pagibig_1stPeriod);
            this.PG_PagibigPanel.Controls.Add(this.PG_PagibigLabel);
            this.PG_PagibigPanel.Location = new System.Drawing.Point(419, 380);
            this.PG_PagibigPanel.Name = "PG_PagibigPanel";
            this.PG_PagibigPanel.Size = new System.Drawing.Size(131, 135);
            this.PG_PagibigPanel.TabIndex = 20;
            // 
            // Pagibig_NotDeducted
            // 
            this.Pagibig_NotDeducted.AutoSize = true;
            this.Pagibig_NotDeducted.Location = new System.Drawing.Point(23, 101);
            this.Pagibig_NotDeducted.Name = "Pagibig_NotDeducted";
            this.Pagibig_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.Pagibig_NotDeducted.TabIndex = 19;
            this.Pagibig_NotDeducted.Text = "Not Deducted";
            this.Pagibig_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // Pagibig_EveryPeriod
            // 
            this.Pagibig_EveryPeriod.AutoSize = true;
            this.Pagibig_EveryPeriod.Checked = true;
            this.Pagibig_EveryPeriod.Location = new System.Drawing.Point(23, 78);
            this.Pagibig_EveryPeriod.Name = "Pagibig_EveryPeriod";
            this.Pagibig_EveryPeriod.Size = new System.Drawing.Size(85, 17);
            this.Pagibig_EveryPeriod.TabIndex = 18;
            this.Pagibig_EveryPeriod.TabStop = true;
            this.Pagibig_EveryPeriod.Text = "Every Period";
            this.Pagibig_EveryPeriod.UseVisualStyleBackColor = true;
            // 
            // Pagibig_LastPeriod
            // 
            this.Pagibig_LastPeriod.AutoSize = true;
            this.Pagibig_LastPeriod.Location = new System.Drawing.Point(23, 55);
            this.Pagibig_LastPeriod.Name = "Pagibig_LastPeriod";
            this.Pagibig_LastPeriod.Size = new System.Drawing.Size(78, 17);
            this.Pagibig_LastPeriod.TabIndex = 15;
            this.Pagibig_LastPeriod.Text = "Last Period";
            this.Pagibig_LastPeriod.UseVisualStyleBackColor = true;
            // 
            // Pagibig_1stPeriod
            // 
            this.Pagibig_1stPeriod.AutoSize = true;
            this.Pagibig_1stPeriod.Location = new System.Drawing.Point(23, 32);
            this.Pagibig_1stPeriod.Name = "Pagibig_1stPeriod";
            this.Pagibig_1stPeriod.Size = new System.Drawing.Size(72, 17);
            this.Pagibig_1stPeriod.TabIndex = 16;
            this.Pagibig_1stPeriod.Text = "1st Period";
            this.Pagibig_1stPeriod.UseVisualStyleBackColor = true;
            // 
            // PG_PagibigLabel
            // 
            this.PG_PagibigLabel.AutoSize = true;
            this.PG_PagibigLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_PagibigLabel.Name = "PG_PagibigLabel";
            this.PG_PagibigLabel.Size = new System.Drawing.Size(28, 13);
            this.PG_PagibigLabel.TabIndex = 2;
            this.PG_PagibigLabel.Text = "SSS";
            // 
            // PG_PhilhealthPanel
            // 
            this.PG_PhilhealthPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_PhilhealthPanel.Controls.Add(this.Philhealth_NotDeducted);
            this.PG_PhilhealthPanel.Controls.Add(this.Philhealth_EveryPeriod);
            this.PG_PhilhealthPanel.Controls.Add(this.Philhealth_LastPeriod);
            this.PG_PhilhealthPanel.Controls.Add(this.Philhealth_1stPeriod);
            this.PG_PhilhealthPanel.Controls.Add(this.PG_PhilhealthLabel);
            this.PG_PhilhealthPanel.Location = new System.Drawing.Point(715, 380);
            this.PG_PhilhealthPanel.Name = "PG_PhilhealthPanel";
            this.PG_PhilhealthPanel.Size = new System.Drawing.Size(131, 135);
            this.PG_PhilhealthPanel.TabIndex = 20;
            // 
            // Philhealth_NotDeducted
            // 
            this.Philhealth_NotDeducted.AutoSize = true;
            this.Philhealth_NotDeducted.Location = new System.Drawing.Point(23, 101);
            this.Philhealth_NotDeducted.Name = "Philhealth_NotDeducted";
            this.Philhealth_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.Philhealth_NotDeducted.TabIndex = 19;
            this.Philhealth_NotDeducted.Text = "Not Deducted";
            this.Philhealth_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // Philhealth_EveryPeriod
            // 
            this.Philhealth_EveryPeriod.AutoSize = true;
            this.Philhealth_EveryPeriod.Checked = true;
            this.Philhealth_EveryPeriod.Location = new System.Drawing.Point(23, 78);
            this.Philhealth_EveryPeriod.Name = "Philhealth_EveryPeriod";
            this.Philhealth_EveryPeriod.Size = new System.Drawing.Size(85, 17);
            this.Philhealth_EveryPeriod.TabIndex = 18;
            this.Philhealth_EveryPeriod.TabStop = true;
            this.Philhealth_EveryPeriod.Text = "Every Period";
            this.Philhealth_EveryPeriod.UseVisualStyleBackColor = true;
            // 
            // Philhealth_LastPeriod
            // 
            this.Philhealth_LastPeriod.AutoSize = true;
            this.Philhealth_LastPeriod.Location = new System.Drawing.Point(23, 55);
            this.Philhealth_LastPeriod.Name = "Philhealth_LastPeriod";
            this.Philhealth_LastPeriod.Size = new System.Drawing.Size(78, 17);
            this.Philhealth_LastPeriod.TabIndex = 15;
            this.Philhealth_LastPeriod.Text = "Last Period";
            this.Philhealth_LastPeriod.UseVisualStyleBackColor = true;
            // 
            // Philhealth_1stPeriod
            // 
            this.Philhealth_1stPeriod.AutoSize = true;
            this.Philhealth_1stPeriod.Location = new System.Drawing.Point(23, 32);
            this.Philhealth_1stPeriod.Name = "Philhealth_1stPeriod";
            this.Philhealth_1stPeriod.Size = new System.Drawing.Size(72, 17);
            this.Philhealth_1stPeriod.TabIndex = 16;
            this.Philhealth_1stPeriod.Text = "1st Period";
            this.Philhealth_1stPeriod.UseVisualStyleBackColor = true;
            // 
            // PG_PhilhealthLabel
            // 
            this.PG_PhilhealthLabel.AutoSize = true;
            this.PG_PhilhealthLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_PhilhealthLabel.Name = "PG_PhilhealthLabel";
            this.PG_PhilhealthLabel.Size = new System.Drawing.Size(53, 13);
            this.PG_PhilhealthLabel.TabIndex = 2;
            this.PG_PhilhealthLabel.Text = "Philhealth";
            // 
            // PG_SSSPanel
            // 
            this.PG_SSSPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_SSSPanel.Controls.Add(this.SSS_NotDeducted);
            this.PG_SSSPanel.Controls.Add(this.SSS_EveryPeriod);
            this.PG_SSSPanel.Controls.Add(this.SSS_LastPeriod);
            this.PG_SSSPanel.Controls.Add(this.SSS_1stPeriod);
            this.PG_SSSPanel.Controls.Add(this.PG_SSSLabel);
            this.PG_SSSPanel.Location = new System.Drawing.Point(566, 380);
            this.PG_SSSPanel.Name = "PG_SSSPanel";
            this.PG_SSSPanel.Size = new System.Drawing.Size(131, 135);
            this.PG_SSSPanel.TabIndex = 18;
            // 
            // SSS_NotDeducted
            // 
            this.SSS_NotDeducted.AutoSize = true;
            this.SSS_NotDeducted.Location = new System.Drawing.Point(23, 101);
            this.SSS_NotDeducted.Name = "SSS_NotDeducted";
            this.SSS_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.SSS_NotDeducted.TabIndex = 19;
            this.SSS_NotDeducted.Text = "Not Deducted";
            this.SSS_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // SSS_EveryPeriod
            // 
            this.SSS_EveryPeriod.AutoSize = true;
            this.SSS_EveryPeriod.Checked = true;
            this.SSS_EveryPeriod.Location = new System.Drawing.Point(23, 78);
            this.SSS_EveryPeriod.Name = "SSS_EveryPeriod";
            this.SSS_EveryPeriod.Size = new System.Drawing.Size(85, 17);
            this.SSS_EveryPeriod.TabIndex = 18;
            this.SSS_EveryPeriod.TabStop = true;
            this.SSS_EveryPeriod.Text = "Every Period";
            this.SSS_EveryPeriod.UseVisualStyleBackColor = true;
            // 
            // SSS_LastPeriod
            // 
            this.SSS_LastPeriod.AutoSize = true;
            this.SSS_LastPeriod.Location = new System.Drawing.Point(23, 55);
            this.SSS_LastPeriod.Name = "SSS_LastPeriod";
            this.SSS_LastPeriod.Size = new System.Drawing.Size(78, 17);
            this.SSS_LastPeriod.TabIndex = 15;
            this.SSS_LastPeriod.Text = "Last Period";
            this.SSS_LastPeriod.UseVisualStyleBackColor = true;
            // 
            // SSS_1stPeriod
            // 
            this.SSS_1stPeriod.AutoSize = true;
            this.SSS_1stPeriod.Location = new System.Drawing.Point(23, 32);
            this.SSS_1stPeriod.Name = "SSS_1stPeriod";
            this.SSS_1stPeriod.Size = new System.Drawing.Size(72, 17);
            this.SSS_1stPeriod.TabIndex = 16;
            this.SSS_1stPeriod.Text = "1st Period";
            this.SSS_1stPeriod.UseVisualStyleBackColor = true;
            // 
            // PG_SSSLabel
            // 
            this.PG_SSSLabel.AutoSize = true;
            this.PG_SSSLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_SSSLabel.Name = "PG_SSSLabel";
            this.PG_SSSLabel.Size = new System.Drawing.Size(28, 13);
            this.PG_SSSLabel.TabIndex = 2;
            this.PG_SSSLabel.Text = "SSS";
            // 
            // PG_AgencyFeeDeductionPanel
            // 
            this.PG_AgencyFeeDeductionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.AgencyFeeDeduction_NotDeducted);
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.AgencyFeeDeduction_EveryPeriod);
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.AgencyFeeDeduction_LastPeriod);
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.AgencyFeeDeduction_2ndPeriod);
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.AgencyFeeDeduction_1stPeriod);
            this.PG_AgencyFeeDeductionPanel.Controls.Add(this.PG_AgencyFeeDeductionLabel);
            this.PG_AgencyFeeDeductionPanel.Location = new System.Drawing.Point(615, 21);
            this.PG_AgencyFeeDeductionPanel.Name = "PG_AgencyFeeDeductionPanel";
            this.PG_AgencyFeeDeductionPanel.Size = new System.Drawing.Size(228, 145);
            this.PG_AgencyFeeDeductionPanel.TabIndex = 17;
            // 
            // AgencyFeeDeduction_NotDeducted
            // 
            this.AgencyFeeDeduction_NotDeducted.AutoSize = true;
            this.AgencyFeeDeduction_NotDeducted.Location = new System.Drawing.Point(22, 117);
            this.AgencyFeeDeduction_NotDeducted.Name = "AgencyFeeDeduction_NotDeducted";
            this.AgencyFeeDeduction_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.AgencyFeeDeduction_NotDeducted.TabIndex = 14;
            this.AgencyFeeDeduction_NotDeducted.TabStop = true;
            this.AgencyFeeDeduction_NotDeducted.Text = "Not Deducted";
            this.AgencyFeeDeduction_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // AgencyFeeDeduction_EveryPeriod
            // 
            this.AgencyFeeDeduction_EveryPeriod.AutoSize = true;
            this.AgencyFeeDeduction_EveryPeriod.Location = new System.Drawing.Point(22, 94);
            this.AgencyFeeDeduction_EveryPeriod.Name = "AgencyFeeDeduction_EveryPeriod";
            this.AgencyFeeDeduction_EveryPeriod.Size = new System.Drawing.Size(85, 17);
            this.AgencyFeeDeduction_EveryPeriod.TabIndex = 13;
            this.AgencyFeeDeduction_EveryPeriod.TabStop = true;
            this.AgencyFeeDeduction_EveryPeriod.Text = "Every Period";
            this.AgencyFeeDeduction_EveryPeriod.UseVisualStyleBackColor = true;
            // 
            // AgencyFeeDeduction_LastPeriod
            // 
            this.AgencyFeeDeduction_LastPeriod.AutoSize = true;
            this.AgencyFeeDeduction_LastPeriod.Location = new System.Drawing.Point(22, 71);
            this.AgencyFeeDeduction_LastPeriod.Name = "AgencyFeeDeduction_LastPeriod";
            this.AgencyFeeDeduction_LastPeriod.Size = new System.Drawing.Size(78, 17);
            this.AgencyFeeDeduction_LastPeriod.TabIndex = 10;
            this.AgencyFeeDeduction_LastPeriod.TabStop = true;
            this.AgencyFeeDeduction_LastPeriod.Text = "Last Period";
            this.AgencyFeeDeduction_LastPeriod.UseVisualStyleBackColor = true;
            // 
            // AgencyFeeDeduction_2ndPeriod
            // 
            this.AgencyFeeDeduction_2ndPeriod.AutoSize = true;
            this.AgencyFeeDeduction_2ndPeriod.Location = new System.Drawing.Point(22, 48);
            this.AgencyFeeDeduction_2ndPeriod.Name = "AgencyFeeDeduction_2ndPeriod";
            this.AgencyFeeDeduction_2ndPeriod.Size = new System.Drawing.Size(76, 17);
            this.AgencyFeeDeduction_2ndPeriod.TabIndex = 12;
            this.AgencyFeeDeduction_2ndPeriod.TabStop = true;
            this.AgencyFeeDeduction_2ndPeriod.Text = "2nd Period";
            this.AgencyFeeDeduction_2ndPeriod.UseVisualStyleBackColor = true;
            // 
            // AgencyFeeDeduction_1stPeriod
            // 
            this.AgencyFeeDeduction_1stPeriod.AutoSize = true;
            this.AgencyFeeDeduction_1stPeriod.Location = new System.Drawing.Point(22, 25);
            this.AgencyFeeDeduction_1stPeriod.Name = "AgencyFeeDeduction_1stPeriod";
            this.AgencyFeeDeduction_1stPeriod.Size = new System.Drawing.Size(72, 17);
            this.AgencyFeeDeduction_1stPeriod.TabIndex = 11;
            this.AgencyFeeDeduction_1stPeriod.TabStop = true;
            this.AgencyFeeDeduction_1stPeriod.Text = "1st Period";
            this.AgencyFeeDeduction_1stPeriod.UseVisualStyleBackColor = true;
            // 
            // PG_AgencyFeeDeductionLabel
            // 
            this.PG_AgencyFeeDeductionLabel.AutoSize = true;
            this.PG_AgencyFeeDeductionLabel.Location = new System.Drawing.Point(9, 11);
            this.PG_AgencyFeeDeductionLabel.Name = "PG_AgencyFeeDeductionLabel";
            this.PG_AgencyFeeDeductionLabel.Size = new System.Drawing.Size(116, 13);
            this.PG_AgencyFeeDeductionLabel.TabIndex = 2;
            this.PG_AgencyFeeDeductionLabel.Text = "Agency Fee Deduction";
            // 
            // PG_WithHoldingTaxPanel
            // 
            this.PG_WithHoldingTaxPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PG_WithHoldingTaxPanel.Controls.Add(this.WithholdingTax_NotDeducted);
            this.PG_WithHoldingTaxPanel.Controls.Add(this.WithholdingTax_LastPeriod);
            this.PG_WithHoldingTaxPanel.Controls.Add(this.WithholdingTax_EveryPeriod);
            this.PG_WithHoldingTaxPanel.Controls.Add(this.PG_WithHoldingTaxLabel);
            this.PG_WithHoldingTaxPanel.Location = new System.Drawing.Point(16, 82);
            this.PG_WithHoldingTaxPanel.Name = "PG_WithHoldingTaxPanel";
            this.PG_WithHoldingTaxPanel.Size = new System.Drawing.Size(568, 48);
            this.PG_WithHoldingTaxPanel.TabIndex = 15;
            // 
            // WithholdingTax_NotDeducted
            // 
            this.WithholdingTax_NotDeducted.AutoSize = true;
            this.WithholdingTax_NotDeducted.Location = new System.Drawing.Point(441, 21);
            this.WithholdingTax_NotDeducted.Name = "WithholdingTax_NotDeducted";
            this.WithholdingTax_NotDeducted.Size = new System.Drawing.Size(92, 17);
            this.WithholdingTax_NotDeducted.TabIndex = 5;
            this.WithholdingTax_NotDeducted.Text = "Not Deducted";
            this.WithholdingTax_NotDeducted.UseVisualStyleBackColor = true;
            // 
            // WithholdingTax_LastPeriod
            // 
            this.WithholdingTax_LastPeriod.AutoSize = true;
            this.WithholdingTax_LastPeriod.Location = new System.Drawing.Point(257, 21);
            this.WithholdingTax_LastPeriod.Name = "WithholdingTax_LastPeriod";
            this.WithholdingTax_LastPeriod.Size = new System.Drawing.Size(78, 17);
            this.WithholdingTax_LastPeriod.TabIndex = 7;
            this.WithholdingTax_LastPeriod.Text = "Last Period";
            this.WithholdingTax_LastPeriod.UseVisualStyleBackColor = true;
            // 
            // WithholdingTax_EveryPeriod
            // 
            this.WithholdingTax_EveryPeriod.AutoSize = true;
            this.WithholdingTax_EveryPeriod.Checked = true;
            this.WithholdingTax_EveryPeriod.Location = new System.Drawing.Point(24, 21);
            this.WithholdingTax_EveryPeriod.Name = "WithholdingTax_EveryPeriod";
            this.WithholdingTax_EveryPeriod.Size = new System.Drawing.Size(85, 17);
            this.WithholdingTax_EveryPeriod.TabIndex = 6;
            this.WithholdingTax_EveryPeriod.TabStop = true;
            this.WithholdingTax_EveryPeriod.Text = "Every Period";
            this.WithholdingTax_EveryPeriod.UseVisualStyleBackColor = true;
            // 
            // PG_WithHoldingTaxLabel
            // 
            this.PG_WithHoldingTaxLabel.AutoSize = true;
            this.PG_WithHoldingTaxLabel.Location = new System.Drawing.Point(9, 5);
            this.PG_WithHoldingTaxLabel.Name = "PG_WithHoldingTaxLabel";
            this.PG_WithHoldingTaxLabel.Size = new System.Drawing.Size(84, 13);
            this.PG_WithHoldingTaxLabel.TabIndex = 2;
            this.PG_WithHoldingTaxLabel.Text = "Withholding Tax";
            // 
            // PG_DeductTaxAfterAll
            // 
            this.PG_DeductTaxAfterAll.BackColor = System.Drawing.SystemColors.Control;
            this.PG_DeductTaxAfterAll.Controls.Add(this.payroll_group_before_tax);
            this.PG_DeductTaxAfterAll.Location = new System.Drawing.Point(16, 21);
            this.PG_DeductTaxAfterAll.Name = "PG_DeductTaxAfterAll";
            this.PG_DeductTaxAfterAll.Size = new System.Drawing.Size(568, 52);
            this.PG_DeductTaxAfterAll.TabIndex = 14;
            // 
            // payroll_group_before_tax
            // 
            this.payroll_group_before_tax.AutoSize = true;
            this.payroll_group_before_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll_group_before_tax.Location = new System.Drawing.Point(8, 18);
            this.payroll_group_before_tax.Name = "payroll_group_before_tax";
            this.payroll_group_before_tax.Size = new System.Drawing.Size(302, 20);
            this.payroll_group_before_tax.TabIndex = 4;
            this.payroll_group_before_tax.Text = "Deduct Tax after SSS, PhilHealth, And Pagibig";
            this.payroll_group_before_tax.UseVisualStyleBackColor = true;
            // 
            // tabOvertime
            // 
            this.tabOvertime.Controls.Add(this.tableLayoutPanel1);
            this.tabOvertime.Controls.Add(this.OverTimeRatesTableSubHeader);
            this.tabOvertime.Controls.Add(this.OverTimeRatesTableHeader);
            this.tabOvertime.Location = new System.Drawing.Point(4, 22);
            this.tabOvertime.Name = "tabOvertime";
            this.tabOvertime.Size = new System.Drawing.Size(858, 521);
            this.tabOvertime.TabIndex = 2;
            this.tabOvertime.Text = "Over Time Rates";
            this.tabOvertime.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown18, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown17, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown16, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown12, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown11, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PG_OTRegularLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PG_OTLegalHolidayLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PG_OTSpecialHolidayLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.payroll_overtime_regular, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 105);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown18.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown18.DecimalPlaces = 3;
            this.numericUpDown18.Location = new System.Drawing.Point(700, 80);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown18.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(116, 20);
            this.numericUpDown18.TabIndex = 18;
            this.numericUpDown18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown18.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown17.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown17.DecimalPlaces = 3;
            this.numericUpDown17.Location = new System.Drawing.Point(576, 80);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown17.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown17.TabIndex = 17;
            this.numericUpDown17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown17.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown16.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown16.DecimalPlaces = 3;
            this.numericUpDown16.Location = new System.Drawing.Point(455, 80);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown16.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown16.TabIndex = 16;
            this.numericUpDown16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown16.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown15.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown15.DecimalPlaces = 3;
            this.numericUpDown15.Location = new System.Drawing.Point(336, 80);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown15.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown15.TabIndex = 15;
            this.numericUpDown15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown15.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown14.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown14.DecimalPlaces = 3;
            this.numericUpDown14.Location = new System.Drawing.Point(200, 80);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown14.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(129, 20);
            this.numericUpDown14.TabIndex = 14;
            this.numericUpDown14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown14.Value = new decimal(new int[] {
            69,
            0,
            0,
            131072});
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown13.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown13.DecimalPlaces = 3;
            this.numericUpDown13.Location = new System.Drawing.Point(99, 80);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown13.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown13.TabIndex = 13;
            this.numericUpDown13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown13.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown12.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown12.DecimalPlaces = 3;
            this.numericUpDown12.Location = new System.Drawing.Point(700, 44);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(116, 20);
            this.numericUpDown12.TabIndex = 12;
            this.numericUpDown12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown12.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown11.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown11.DecimalPlaces = 3;
            this.numericUpDown11.Location = new System.Drawing.Point(576, 44);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown11.TabIndex = 11;
            this.numericUpDown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown11.Value = new decimal(new int[] {
            238,
            0,
            0,
            131072});
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown10.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown10.DecimalPlaces = 3;
            this.numericUpDown10.Location = new System.Drawing.Point(455, 44);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown10.TabIndex = 10;
            this.numericUpDown10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown10.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown9.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown9.DecimalPlaces = 3;
            this.numericUpDown9.Location = new System.Drawing.Point(336, 44);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown9.TabIndex = 9;
            this.numericUpDown9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown8.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown8.DecimalPlaces = 3;
            this.numericUpDown8.Location = new System.Drawing.Point(200, 44);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(129, 20);
            this.numericUpDown8.TabIndex = 8;
            this.numericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown8.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown7.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown7.DecimalPlaces = 3;
            this.numericUpDown7.Location = new System.Drawing.Point(99, 44);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown7.TabIndex = 7;
            this.numericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown6.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown6.DecimalPlaces = 3;
            this.numericUpDown6.Location = new System.Drawing.Point(700, 8);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(116, 20);
            this.numericUpDown6.TabIndex = 6;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown5.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Location = new System.Drawing.Point(576, 8);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown5.TabIndex = 5;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown5.Value = new decimal(new int[] {
            69,
            0,
            0,
            131072});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Location = new System.Drawing.Point(455, 8);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown4.TabIndex = 4;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown4.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Location = new System.Drawing.Point(336, 8);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(200, 8);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(129, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // PG_OTRegularLabel
            // 
            this.PG_OTRegularLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OTRegularLabel.AutoSize = true;
            this.PG_OTRegularLabel.Location = new System.Drawing.Point(4, 12);
            this.PG_OTRegularLabel.Name = "PG_OTRegularLabel";
            this.PG_OTRegularLabel.Size = new System.Drawing.Size(88, 13);
            this.PG_OTRegularLabel.TabIndex = 0;
            this.PG_OTRegularLabel.Text = "Regular";
            this.PG_OTRegularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PG_OTLegalHolidayLabel
            // 
            this.PG_OTLegalHolidayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OTLegalHolidayLabel.AutoSize = true;
            this.PG_OTLegalHolidayLabel.Location = new System.Drawing.Point(4, 48);
            this.PG_OTLegalHolidayLabel.Name = "PG_OTLegalHolidayLabel";
            this.PG_OTLegalHolidayLabel.Size = new System.Drawing.Size(88, 13);
            this.PG_OTLegalHolidayLabel.TabIndex = 0;
            this.PG_OTLegalHolidayLabel.Text = "Legal Holiday";
            this.PG_OTLegalHolidayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PG_OTSpecialHolidayLabel
            // 
            this.PG_OTSpecialHolidayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OTSpecialHolidayLabel.AutoSize = true;
            this.PG_OTSpecialHolidayLabel.Location = new System.Drawing.Point(4, 84);
            this.PG_OTSpecialHolidayLabel.Name = "PG_OTSpecialHolidayLabel";
            this.PG_OTSpecialHolidayLabel.Size = new System.Drawing.Size(88, 13);
            this.PG_OTSpecialHolidayLabel.TabIndex = 0;
            this.PG_OTSpecialHolidayLabel.Text = "Special Holiday";
            this.PG_OTSpecialHolidayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payroll_overtime_regular
            // 
            this.payroll_overtime_regular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payroll_overtime_regular.Cursor = System.Windows.Forms.Cursors.Default;
            this.payroll_overtime_regular.DecimalPlaces = 3;
            this.payroll_overtime_regular.Location = new System.Drawing.Point(99, 8);
            this.payroll_overtime_regular.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.payroll_overtime_regular.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.payroll_overtime_regular.Name = "payroll_overtime_regular";
            this.payroll_overtime_regular.Size = new System.Drawing.Size(94, 20);
            this.payroll_overtime_regular.TabIndex = 1;
            this.payroll_overtime_regular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.payroll_overtime_regular.Value = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            // 
            // OverTimeRatesTableSubHeader
            // 
            this.OverTimeRatesTableSubHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.OverTimeRatesTableSubHeader.ColumnCount = 6;
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.OverTimeRatesTableSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.OverTimeRatesTableSubHeader.Controls.Add(this.PG_OvertimeRateFactorsRegularLabel, 1, 0);
            this.OverTimeRatesTableSubHeader.Controls.Add(this.PG_OvertimeRateFactorsRegularNightDiffLabel, 2, 0);
            this.OverTimeRatesTableSubHeader.Controls.Add(this.PG_OvertimeRateFactorsRestdayNigthDiffLabel, 5, 0);
            this.OverTimeRatesTableSubHeader.Controls.Add(this.PG_OvertimeRateFactorsRestdayOTLabel, 4, 0);
            this.OverTimeRatesTableSubHeader.Location = new System.Drawing.Point(16, 63);
            this.OverTimeRatesTableSubHeader.Name = "OverTimeRatesTableSubHeader";
            this.OverTimeRatesTableSubHeader.RowCount = 1;
            this.OverTimeRatesTableSubHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.OverTimeRatesTableSubHeader.Size = new System.Drawing.Size(817, 35);
            this.OverTimeRatesTableSubHeader.TabIndex = 1;
            // 
            // PG_OvertimeRateFactorsRegularLabel
            // 
            this.PG_OvertimeRateFactorsRegularLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsRegularLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsRegularLabel.Location = new System.Drawing.Point(200, 13);
            this.PG_OvertimeRateFactorsRegularLabel.Name = "PG_OvertimeRateFactorsRegularLabel";
            this.PG_OvertimeRateFactorsRegularLabel.Size = new System.Drawing.Size(128, 13);
            this.PG_OvertimeRateFactorsRegularLabel.TabIndex = 0;
            this.PG_OvertimeRateFactorsRegularLabel.Text = "Over Time";
            this.PG_OvertimeRateFactorsRegularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PG_OvertimeRateFactorsRegularNightDiffLabel
            // 
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.Location = new System.Drawing.Point(335, 13);
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.Name = "PG_OvertimeRateFactorsRegularNightDiffLabel";
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.Size = new System.Drawing.Size(113, 13);
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.TabIndex = 1;
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.Text = "Night Differential";
            this.PG_OvertimeRateFactorsRegularNightDiffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PG_OvertimeRateFactorsRestdayNigthDiffLabel
            // 
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.Location = new System.Drawing.Point(700, 13);
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.Name = "PG_OvertimeRateFactorsRestdayNigthDiffLabel";
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.Size = new System.Drawing.Size(116, 13);
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.TabIndex = 1;
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.Text = "Night Differential";
            this.PG_OvertimeRateFactorsRestdayNigthDiffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PG_OvertimeRateFactorsRestdayOTLabel
            // 
            this.PG_OvertimeRateFactorsRestdayOTLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsRestdayOTLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsRestdayOTLabel.Location = new System.Drawing.Point(575, 13);
            this.PG_OvertimeRateFactorsRestdayOTLabel.Name = "PG_OvertimeRateFactorsRestdayOTLabel";
            this.PG_OvertimeRateFactorsRestdayOTLabel.Size = new System.Drawing.Size(118, 13);
            this.PG_OvertimeRateFactorsRestdayOTLabel.TabIndex = 0;
            this.PG_OvertimeRateFactorsRestdayOTLabel.Text = "Over Time";
            this.PG_OvertimeRateFactorsRestdayOTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverTimeRatesTableHeader
            // 
            this.OverTimeRatesTableHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.OverTimeRatesTableHeader.ColumnCount = 3;
            this.OverTimeRatesTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.OverTimeRatesTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.OverTimeRatesTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.OverTimeRatesTableHeader.Controls.Add(this.PG_OvertimeRateFactorsLabel, 0, 0);
            this.OverTimeRatesTableHeader.Controls.Add(this.PG_OvertimeRateFactorsRestDayLabel, 2, 0);
            this.OverTimeRatesTableHeader.Location = new System.Drawing.Point(16, 28);
            this.OverTimeRatesTableHeader.Name = "OverTimeRatesTableHeader";
            this.OverTimeRatesTableHeader.RowCount = 1;
            this.OverTimeRatesTableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OverTimeRatesTableHeader.Size = new System.Drawing.Size(817, 35);
            this.OverTimeRatesTableHeader.TabIndex = 0;
            // 
            // PG_OvertimeRateFactorsLabel
            // 
            this.PG_OvertimeRateFactorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsLabel.Location = new System.Drawing.Point(4, 11);
            this.PG_OvertimeRateFactorsLabel.Name = "PG_OvertimeRateFactorsLabel";
            this.PG_OvertimeRateFactorsLabel.Size = new System.Drawing.Size(189, 13);
            this.PG_OvertimeRateFactorsLabel.TabIndex = 0;
            this.PG_OvertimeRateFactorsLabel.Text = "Overtime Rate Factors";
            // 
            // PG_OvertimeRateFactorsRestDayLabel
            // 
            this.PG_OvertimeRateFactorsRestDayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PG_OvertimeRateFactorsRestDayLabel.AutoSize = true;
            this.PG_OvertimeRateFactorsRestDayLabel.Location = new System.Drawing.Point(455, 11);
            this.PG_OvertimeRateFactorsRestDayLabel.Name = "PG_OvertimeRateFactorsRestDayLabel";
            this.PG_OvertimeRateFactorsRestDayLabel.Size = new System.Drawing.Size(361, 13);
            this.PG_OvertimeRateFactorsRestDayLabel.TabIndex = 1;
            this.PG_OvertimeRateFactorsRestDayLabel.Text = "Rest Day";
            this.PG_OvertimeRateFactorsRestDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabShifting
            // 
            this.tabShifting.Controls.Add(this.PG_GraceTime_OvertimeLabel);
            this.tabShifting.Controls.Add(this.PG_GraceTime_LateLabel);
            this.tabShifting.Controls.Add(this.PG_GraceTime_Overtime);
            this.tabShifting.Controls.Add(this.PG_GraceTime_Late);
            this.tabShifting.Controls.Add(this.payroll_group_working_day_month);
            this.tabShifting.Controls.Add(this.PG_WorkingDayPerMonthLabel);
            this.tabShifting.Location = new System.Drawing.Point(4, 22);
            this.tabShifting.Name = "tabShifting";
            this.tabShifting.Size = new System.Drawing.Size(858, 521);
            this.tabShifting.TabIndex = 3;
            this.tabShifting.Text = "Shifting";
            this.tabShifting.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.tag_payroll_group_employee);
            this.tabEmployee.Controls.Add(this.dataGridView1);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(858, 521);
            this.tabEmployee.TabIndex = 4;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // PG_WorkingDayPerMonthLabel
            // 
            this.PG_WorkingDayPerMonthLabel.AutoSize = true;
            this.PG_WorkingDayPerMonthLabel.Location = new System.Drawing.Point(22, 28);
            this.PG_WorkingDayPerMonthLabel.Name = "PG_WorkingDayPerMonthLabel";
            this.PG_WorkingDayPerMonthLabel.Size = new System.Drawing.Size(130, 13);
            this.PG_WorkingDayPerMonthLabel.TabIndex = 0;
            this.PG_WorkingDayPerMonthLabel.Text = "Working Days (per month)";
            // 
            // payroll_group_working_day_month
            // 
            this.payroll_group_working_day_month.DecimalPlaces = 2;
            this.payroll_group_working_day_month.Location = new System.Drawing.Point(25, 44);
            this.payroll_group_working_day_month.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.payroll_group_working_day_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.payroll_group_working_day_month.Name = "payroll_group_working_day_month";
            this.payroll_group_working_day_month.Size = new System.Drawing.Size(260, 20);
            this.payroll_group_working_day_month.TabIndex = 1;
            this.payroll_group_working_day_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.payroll_group_working_day_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PG_GraceTime_Late
            // 
            this.PG_GraceTime_Late.BackColor = System.Drawing.SystemColors.Control;
            this.PG_GraceTime_Late.Controls.Add(this.grace_time_rule_late);
            this.PG_GraceTime_Late.Controls.Add(this.PG_GraceTimeRule_LateSubLabel);
            this.PG_GraceTime_Late.Controls.Add(this.late_grace_time);
            this.PG_GraceTime_Late.Controls.Add(this.PG_GraceTime_LateSubLabel);
            this.PG_GraceTime_Late.Location = new System.Drawing.Point(20, 110);
            this.PG_GraceTime_Late.Name = "PG_GraceTime_Late";
            this.PG_GraceTime_Late.Size = new System.Drawing.Size(384, 87);
            this.PG_GraceTime_Late.TabIndex = 27;
            // 
            // PG_GraceTime_Overtime
            // 
            this.PG_GraceTime_Overtime.BackColor = System.Drawing.SystemColors.Control;
            this.PG_GraceTime_Overtime.Controls.Add(this.PG_GraceTimeRule_OvertimeSubLabel);
            this.PG_GraceTime_Overtime.Controls.Add(this.overtime_grace_time);
            this.PG_GraceTime_Overtime.Controls.Add(this.PG_GraceTime_OvetimeSubLabel);
            this.PG_GraceTime_Overtime.Controls.Add(this.grace_time_rule_overtime);
            this.PG_GraceTime_Overtime.Location = new System.Drawing.Point(452, 110);
            this.PG_GraceTime_Overtime.Name = "PG_GraceTime_Overtime";
            this.PG_GraceTime_Overtime.Size = new System.Drawing.Size(384, 87);
            this.PG_GraceTime_Overtime.TabIndex = 28;
            // 
            // PG_GraceTime_LateLabel
            // 
            this.PG_GraceTime_LateLabel.AutoSize = true;
            this.PG_GraceTime_LateLabel.Location = new System.Drawing.Point(22, 94);
            this.PG_GraceTime_LateLabel.Name = "PG_GraceTime_LateLabel";
            this.PG_GraceTime_LateLabel.Size = new System.Drawing.Size(98, 13);
            this.PG_GraceTime_LateLabel.TabIndex = 29;
            this.PG_GraceTime_LateLabel.Text = "Grace Time (LATE)";
            // 
            // PG_GraceTime_OvertimeLabel
            // 
            this.PG_GraceTime_OvertimeLabel.AutoSize = true;
            this.PG_GraceTime_OvertimeLabel.Location = new System.Drawing.Point(455, 94);
            this.PG_GraceTime_OvertimeLabel.Name = "PG_GraceTime_OvertimeLabel";
            this.PG_GraceTime_OvertimeLabel.Size = new System.Drawing.Size(127, 13);
            this.PG_GraceTime_OvertimeLabel.TabIndex = 30;
            this.PG_GraceTime_OvertimeLabel.Text = "Grace Time (OVERTIME)";
            // 
            // PG_GraceTime_LateSubLabel
            // 
            this.PG_GraceTime_LateSubLabel.AutoSize = true;
            this.PG_GraceTime_LateSubLabel.Location = new System.Drawing.Point(31, 34);
            this.PG_GraceTime_LateSubLabel.Name = "PG_GraceTime_LateSubLabel";
            this.PG_GraceTime_LateSubLabel.Size = new System.Drawing.Size(62, 13);
            this.PG_GraceTime_LateSubLabel.TabIndex = 31;
            this.PG_GraceTime_LateSubLabel.Text = "Grace Time";
            // 
            // late_grace_time
            // 
            this.late_grace_time.CustomFormat = "HH:mm";
            this.late_grace_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.late_grace_time.Location = new System.Drawing.Point(28, 50);
            this.late_grace_time.MaxDate = new System.DateTime(9998, 8, 3, 23, 59, 0, 0);
            this.late_grace_time.MinDate = new System.DateTime(2018, 8, 3, 0, 1, 0, 0);
            this.late_grace_time.Name = "late_grace_time";
            this.late_grace_time.ShowUpDown = true;
            this.late_grace_time.Size = new System.Drawing.Size(104, 20);
            this.late_grace_time.TabIndex = 33;
            this.late_grace_time.Value = new System.DateTime(2018, 8, 3, 0, 1, 0, 0);
            // 
            // PG_GraceTimeRule_LateSubLabel
            // 
            this.PG_GraceTimeRule_LateSubLabel.AutoSize = true;
            this.PG_GraceTimeRule_LateSubLabel.Location = new System.Drawing.Point(209, 34);
            this.PG_GraceTimeRule_LateSubLabel.Name = "PG_GraceTimeRule_LateSubLabel";
            this.PG_GraceTimeRule_LateSubLabel.Size = new System.Drawing.Size(87, 13);
            this.PG_GraceTimeRule_LateSubLabel.TabIndex = 34;
            this.PG_GraceTimeRule_LateSubLabel.Text = "Grace Time Rule";
            // 
            // grace_time_rule_late
            // 
            this.grace_time_rule_late.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grace_time_rule_late.FormattingEnabled = true;
            this.grace_time_rule_late.Location = new System.Drawing.Point(206, 49);
            this.grace_time_rule_late.Name = "grace_time_rule_late";
            this.grace_time_rule_late.Size = new System.Drawing.Size(158, 21);
            this.grace_time_rule_late.TabIndex = 35;
            // 
            // grace_time_rule_overtime
            // 
            this.grace_time_rule_overtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grace_time_rule_overtime.FormattingEnabled = true;
            this.grace_time_rule_overtime.Location = new System.Drawing.Point(208, 49);
            this.grace_time_rule_overtime.Name = "grace_time_rule_overtime";
            this.grace_time_rule_overtime.Size = new System.Drawing.Size(158, 21);
            this.grace_time_rule_overtime.TabIndex = 36;
            // 
            // PG_GraceTimeRule_OvertimeSubLabel
            // 
            this.PG_GraceTimeRule_OvertimeSubLabel.AutoSize = true;
            this.PG_GraceTimeRule_OvertimeSubLabel.Location = new System.Drawing.Point(211, 34);
            this.PG_GraceTimeRule_OvertimeSubLabel.Name = "PG_GraceTimeRule_OvertimeSubLabel";
            this.PG_GraceTimeRule_OvertimeSubLabel.Size = new System.Drawing.Size(87, 13);
            this.PG_GraceTimeRule_OvertimeSubLabel.TabIndex = 39;
            this.PG_GraceTimeRule_OvertimeSubLabel.Text = "Grace Time Rule";
            // 
            // overtime_grace_time
            // 
            this.overtime_grace_time.CustomFormat = "HH:mm";
            this.overtime_grace_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.overtime_grace_time.Location = new System.Drawing.Point(36, 50);
            this.overtime_grace_time.MaxDate = new System.DateTime(9998, 8, 3, 23, 59, 0, 0);
            this.overtime_grace_time.MinDate = new System.DateTime(2018, 8, 3, 0, 1, 0, 0);
            this.overtime_grace_time.Name = "overtime_grace_time";
            this.overtime_grace_time.ShowUpDown = true;
            this.overtime_grace_time.Size = new System.Drawing.Size(104, 20);
            this.overtime_grace_time.TabIndex = 38;
            this.overtime_grace_time.Value = new System.DateTime(2018, 8, 3, 0, 1, 0, 0);
            // 
            // PG_GraceTime_OvetimeSubLabel
            // 
            this.PG_GraceTime_OvetimeSubLabel.AutoSize = true;
            this.PG_GraceTime_OvetimeSubLabel.Location = new System.Drawing.Point(38, 34);
            this.PG_GraceTime_OvetimeSubLabel.Name = "PG_GraceTime_OvetimeSubLabel";
            this.PG_GraceTime_OvetimeSubLabel.Size = new System.Drawing.Size(62, 13);
            this.PG_GraceTime_OvetimeSubLabel.TabIndex = 37;
            this.PG_GraceTime_OvetimeSubLabel.Text = "Grace Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // tag_payroll_group_employee
            // 
            this.tag_payroll_group_employee.Location = new System.Drawing.Point(723, 20);
            this.tag_payroll_group_employee.Name = "tag_payroll_group_employee";
            this.tag_payroll_group_employee.Size = new System.Drawing.Size(114, 23);
            this.tag_payroll_group_employee.TabIndex = 1;
            this.tag_payroll_group_employee.Text = "Tag Employee";
            this.tag_payroll_group_employee.UseVisualStyleBackColor = true;
            this.tag_payroll_group_employee.Click += new System.EventHandler(this.tag_payroll_group_employee_Click);
            // 
            // PayrollGrouptabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 571);
            this.Controls.Add(this.PayrollGroupTabControl);
            this.Name = "PayrollGrouptabs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayrollGrouptabs";
            this.Load += new System.EventHandler(this.PayrollGrouptabs_Load);
            this.PayrollGroupTabControl.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.PG_13MonthBasisPanel.ResumeLayout(false);
            this.PG_13MonthBasisPanel.PerformLayout();
            this.PG_ColaBasisPanel.ResumeLayout(false);
            this.PG_ColaBasisPanel.PerformLayout();
            this.PG_DisplayRatePanel.ResumeLayout(false);
            this.PG_DisplayRatePanel.PerformLayout();
            this.PG_PayrollPeriodPanel.ResumeLayout(false);
            this.PG_PayrollPeriodPanel.PerformLayout();
            this.PG_SalaryComputationPanel.ResumeLayout(false);
            this.PG_SalaryComputationPanel.PerformLayout();
            this.PayrollcodePanel.ResumeLayout(false);
            this.PayrollcodePanel.PerformLayout();
            this.tabDeduction.ResumeLayout(false);
            this.PG_BreakDeductionPanel.ResumeLayout(false);
            this.PG_BreakDeductionPanel.PerformLayout();
            this.PG_UndertimeDeductionPanel.ResumeLayout(false);
            this.PG_UndertimeDeductionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_under_time_deduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_under_time_interval)).EndInit();
            this.PG_LateDeductionPanel.ResumeLayout(false);
            this.PG_LateDeductionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_late_deduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_late_interval)).EndInit();
            this.PG_ContributionReferencePanel.ResumeLayout(false);
            this.PG_ContributionReferencePanel.PerformLayout();
            this.PG_AgencyFeePanel.ResumeLayout(false);
            this.PG_AgencyFeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_group_agency_fee)).EndInit();
            this.PG_PagibigPanel.ResumeLayout(false);
            this.PG_PagibigPanel.PerformLayout();
            this.PG_PhilhealthPanel.ResumeLayout(false);
            this.PG_PhilhealthPanel.PerformLayout();
            this.PG_SSSPanel.ResumeLayout(false);
            this.PG_SSSPanel.PerformLayout();
            this.PG_AgencyFeeDeductionPanel.ResumeLayout(false);
            this.PG_AgencyFeeDeductionPanel.PerformLayout();
            this.PG_WithHoldingTaxPanel.ResumeLayout(false);
            this.PG_WithHoldingTaxPanel.PerformLayout();
            this.PG_DeductTaxAfterAll.ResumeLayout(false);
            this.PG_DeductTaxAfterAll.PerformLayout();
            this.tabOvertime.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_overtime_regular)).EndInit();
            this.OverTimeRatesTableSubHeader.ResumeLayout(false);
            this.OverTimeRatesTableSubHeader.PerformLayout();
            this.OverTimeRatesTableHeader.ResumeLayout(false);
            this.OverTimeRatesTableHeader.PerformLayout();
            this.tabShifting.ResumeLayout(false);
            this.tabShifting.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_group_working_day_month)).EndInit();
            this.PG_GraceTime_Late.ResumeLayout(false);
            this.PG_GraceTime_Late.PerformLayout();
            this.PG_GraceTime_Overtime.ResumeLayout(false);
            this.PG_GraceTime_Overtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PayrollGroupTabControl;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabDeduction;
        private System.Windows.Forms.TabPage tabOvertime;
        private System.Windows.Forms.TabPage tabShifting;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Panel PG_SalaryComputationPanel;
        private System.Windows.Forms.RadioButton SalaryComputation_HourlyRate;
        private System.Windows.Forms.RadioButton SalaryComputation_MonthlyRate;
        private System.Windows.Forms.RadioButton SalaryComputation_DailyRate;
        private System.Windows.Forms.RadioButton SalaryComputation_FlatRate;
        private System.Windows.Forms.Label PG_SalaryComputationLabel;
        private System.Windows.Forms.Panel PayrollcodePanel;
        private System.Windows.Forms.Label PG_PayrollCodelabel;
        private System.Windows.Forms.TextBox payroll_group_code;
        private System.Windows.Forms.Panel PG_PayrollPeriodPanel;
        private System.Windows.Forms.Label PG_PayrollPeriodLabel;
        private System.Windows.Forms.Panel PG_DisplayRatePanel;
        private System.Windows.Forms.Label PG_DisplayRateLabel;
        private System.Windows.Forms.RadioButton PayrollPeriod_Monthly;
        private System.Windows.Forms.RadioButton PayrollPeriod_SemiMonthly;
        private System.Windows.Forms.Panel PG_ColaBasisPanel;
        private System.Windows.Forms.Label PG_ColaBasisLabel;
        private System.Windows.Forms.CheckBox checkBoxDisplayDailyRate;
        private System.Windows.Forms.CheckBox checkBoxDisplayMonthlyRate;
        private System.Windows.Forms.Panel PG_13MonthBasisPanel;
        private System.Windows.Forms.Label PG_13MonthBasisLabel;
        private System.Windows.Forms.Label ComputeColaBasisLabel;
        private System.Windows.Forms.RadioButton ColaBasis_DailyComputation;
        private System.Windows.Forms.RadioButton ColaBasis_DailyFixed;
        private System.Windows.Forms.RadioButton ColaBasis_ProRatedMonthly;
        private System.Windows.Forms.RadioButton ColaBasis_MonthlyFixed;
        private System.Windows.Forms.CheckBox Compute13month_additions_absent;
        private System.Windows.Forms.CheckBox Compute13month_additions_undertime;
        private System.Windows.Forms.CheckBox Compute13month_additions_late;
        private System.Windows.Forms.CheckBox Compute13month_additions_cola;
        private System.Windows.Forms.CheckBox Compute13month_additions_regularholiday;
        private System.Windows.Forms.CheckBox Compute13month_additions_specialholiday;
        private System.Windows.Forms.CheckBox Compute13month_additions_deminimis;
        private System.Windows.Forms.Label Compute13MonthAdditionsLabel;
        private System.Windows.Forms.CheckBox Compute13month_additions_allowances;
        private System.Windows.Forms.Label Compute13MonthLabel;
        private System.Windows.Forms.RadioButton Compute13month_NetBasicPay;
        private System.Windows.Forms.RadioButton Compute13month_GrossBasicPay;
        private System.Windows.Forms.Panel PG_SSSPanel;
        private System.Windows.Forms.Label PG_SSSLabel;
        private System.Windows.Forms.Panel PG_AgencyFeeDeductionPanel;
        private System.Windows.Forms.RadioButton AgencyFeeDeduction_NotDeducted;
        private System.Windows.Forms.RadioButton AgencyFeeDeduction_EveryPeriod;
        private System.Windows.Forms.RadioButton AgencyFeeDeduction_LastPeriod;
        private System.Windows.Forms.RadioButton AgencyFeeDeduction_2ndPeriod;
        private System.Windows.Forms.RadioButton AgencyFeeDeduction_1stPeriod;
        private System.Windows.Forms.Label PG_AgencyFeeDeductionLabel;
        private System.Windows.Forms.Panel PG_WithHoldingTaxPanel;
        private System.Windows.Forms.RadioButton WithholdingTax_NotDeducted;
        private System.Windows.Forms.RadioButton WithholdingTax_LastPeriod;
        private System.Windows.Forms.RadioButton WithholdingTax_EveryPeriod;
        private System.Windows.Forms.Label PG_WithHoldingTaxLabel;
        private System.Windows.Forms.Panel PG_DeductTaxAfterAll;
        private System.Windows.Forms.CheckBox payroll_group_before_tax;
        private System.Windows.Forms.Panel PG_AgencyFeePanel;
        private System.Windows.Forms.NumericUpDown payroll_group_agency_fee;
        private System.Windows.Forms.Label PG_AgencyFeeLabel;
        private System.Windows.Forms.Panel PG_PagibigPanel;
        private System.Windows.Forms.RadioButton Pagibig_NotDeducted;
        private System.Windows.Forms.RadioButton Pagibig_EveryPeriod;
        private System.Windows.Forms.RadioButton Pagibig_LastPeriod;
        private System.Windows.Forms.RadioButton Pagibig_1stPeriod;
        private System.Windows.Forms.Label PG_PagibigLabel;
        private System.Windows.Forms.Panel PG_PhilhealthPanel;
        private System.Windows.Forms.RadioButton Philhealth_NotDeducted;
        private System.Windows.Forms.RadioButton Philhealth_EveryPeriod;
        private System.Windows.Forms.RadioButton Philhealth_LastPeriod;
        private System.Windows.Forms.RadioButton Philhealth_1stPeriod;
        private System.Windows.Forms.Label PG_PhilhealthLabel;
        private System.Windows.Forms.RadioButton SSS_NotDeducted;
        private System.Windows.Forms.RadioButton SSS_EveryPeriod;
        private System.Windows.Forms.RadioButton SSS_LastPeriod;
        private System.Windows.Forms.RadioButton SSS_1stPeriod;
        private System.Windows.Forms.Panel PG_ContributionReferencePanel;
        private System.Windows.Forms.Label PG_ContributionReferenceLabel;
        private System.Windows.Forms.Panel PG_LateDeductionPanel;
        private System.Windows.Forms.RadioButton LateDeduction_NotDeducted;
        private System.Windows.Forms.RadioButton LateDeduction_Custom;
        private System.Windows.Forms.RadioButton LateDeduction_BaseonSalary;
        private System.Windows.Forms.Label PG_LateDeductionLabel;
        private System.Windows.Forms.Panel PG_UndertimeDeductionPanel;
        private System.Windows.Forms.RadioButton UndertimeDeduction_NotDeducted;
        private System.Windows.Forms.RadioButton UndertimeDeduction_Custom;
        private System.Windows.Forms.RadioButton UndertimeDeduction_BaseOnSalary;
        private System.Windows.Forms.Label PG_UndertimeDeductionLabel;
        private System.Windows.Forms.NumericUpDown payroll_late_deduction;
        private System.Windows.Forms.NumericUpDown payroll_late_interval;
        private System.Windows.Forms.ComboBox payroll_late_parameter;
        private System.Windows.Forms.Label PG_LateParameterLabel;
        private System.Windows.Forms.Label PG_DeductionLatePercentageLabel;
        private System.Windows.Forms.Label PG_UndertimePercentageLabel;
        private System.Windows.Forms.Label PG_UndertimeParameterLabel;
        private System.Windows.Forms.NumericUpDown payroll_under_time_deduction;
        private System.Windows.Forms.NumericUpDown payroll_under_time_interval;
        private System.Windows.Forms.ComboBox payroll_under_time_parameter;
        private System.Windows.Forms.Panel PG_BreakDeductionPanel;
        private System.Windows.Forms.RadioButton BreakDeduction_NotDeducted;
        private System.Windows.Forms.RadioButton BreakDeduction_Baseonsalary;
        private System.Windows.Forms.Label PG_BreakDeductionLabel;
        private System.Windows.Forms.ComboBox philhealth_reference;
        private System.Windows.Forms.ComboBox sss_reference;
        private System.Windows.Forms.Label PG_PhilhealthContributionLabel;
        private System.Windows.Forms.Label PG_SSSContributionLabel;
        private System.Windows.Forms.Label PG_TaxContributionLabel;
        private System.Windows.Forms.ComboBox tax_reference;
        private System.Windows.Forms.TableLayoutPanel OverTimeRatesTableHeader;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsLabel;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsRestDayLabel;
        private System.Windows.Forms.TableLayoutPanel OverTimeRatesTableSubHeader;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsRegularLabel;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsRegularNightDiffLabel;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsRestdayNigthDiffLabel;
        private System.Windows.Forms.Label PG_OvertimeRateFactorsRestdayOTLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PG_OTRegularLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label PG_OTLegalHolidayLabel;
        private System.Windows.Forms.Label PG_OTSpecialHolidayLabel;
        private System.Windows.Forms.NumericUpDown payroll_overtime_regular;
        private System.Windows.Forms.Label PG_WorkingDayPerMonthLabel;
        private System.Windows.Forms.Label PG_GraceTime_LateLabel;
        private System.Windows.Forms.Panel PG_GraceTime_Overtime;
        private System.Windows.Forms.Panel PG_GraceTime_Late;
        private System.Windows.Forms.NumericUpDown payroll_group_working_day_month;
        private System.Windows.Forms.Label PG_GraceTime_OvertimeLabel;
        private System.Windows.Forms.Label PG_GraceTime_LateSubLabel;
        private System.Windows.Forms.DateTimePicker late_grace_time;
        private System.Windows.Forms.ComboBox grace_time_rule_late;
        private System.Windows.Forms.Label PG_GraceTimeRule_LateSubLabel;
        private System.Windows.Forms.ComboBox grace_time_rule_overtime;
        private System.Windows.Forms.Label PG_GraceTimeRule_OvertimeSubLabel;
        private System.Windows.Forms.DateTimePicker overtime_grace_time;
        private System.Windows.Forms.Label PG_GraceTime_OvetimeSubLabel;
        private System.Windows.Forms.Button tag_payroll_group_employee;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}