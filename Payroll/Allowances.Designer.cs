namespace Payroll
{
    partial class Allowances
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
            this.tabAllowances = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_payroll_allowances_active_allowances = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_payroll_allowances_archived_allowances = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.payroll_allowance_name = new System.Windows.Forms.TextBox();
            this.payroll_allowance_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payroll_allowance_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payroll_allowance_add_period = new System.Windows.Forms.GroupBox();
            this.payroll_allowance_add_every_period = new System.Windows.Forms.RadioButton();
            this.payroll_allowance_add_second_period = new System.Windows.Forms.RadioButton();
            this.payroll_allowance_add_last_period = new System.Windows.Forms.RadioButton();
            this.payroll_allowance_add_first_period = new System.Windows.Forms.RadioButton();
            this.payroll_allowance_expense_account = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payroll_allowance_tag_employee = new System.Windows.Forms.Button();
            this.grp_payroll_allowance_affected = new System.Windows.Forms.GroupBox();
            this.dgv_Allowances_TaggedEmployee = new System.Windows.Forms.DataGridView();
            this.btnCloseAllowances = new System.Windows.Forms.Button();
            this.btnSaveAllowances = new System.Windows.Forms.Button();
            this.tabAllowances.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_allowances_active_allowances)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_allowances_archived_allowances)).BeginInit();
            this.payroll_allowance_add_period.SuspendLayout();
            this.grp_payroll_allowance_affected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Allowances_TaggedEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAllowances
            // 
            this.tabAllowances.Controls.Add(this.tabPage1);
            this.tabAllowances.Controls.Add(this.tabPage2);
            this.tabAllowances.Location = new System.Drawing.Point(29, 12);
            this.tabAllowances.Name = "tabAllowances";
            this.tabAllowances.SelectedIndex = 0;
            this.tabAllowances.Size = new System.Drawing.Size(622, 179);
            this.tabAllowances.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_payroll_allowances_active_allowances);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Allowances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_payroll_allowances_active_allowances
            // 
            this.dgv_payroll_allowances_active_allowances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_allowances_active_allowances.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_allowances_active_allowances.Name = "dgv_payroll_allowances_active_allowances";
            this.dgv_payroll_allowances_active_allowances.Size = new System.Drawing.Size(615, 153);
            this.dgv_payroll_allowances_active_allowances.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_payroll_allowances_archived_allowances);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archived Allowances";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_payroll_allowances_archived_allowances
            // 
            this.dgv_payroll_allowances_archived_allowances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_allowances_archived_allowances.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_allowances_archived_allowances.Name = "dgv_payroll_allowances_archived_allowances";
            this.dgv_payroll_allowances_archived_allowances.Size = new System.Drawing.Size(614, 157);
            this.dgv_payroll_allowances_archived_allowances.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Allowance Name";
            // 
            // payroll_allowance_name
            // 
            this.payroll_allowance_name.Location = new System.Drawing.Point(29, 220);
            this.payroll_allowance_name.Name = "payroll_allowance_name";
            this.payroll_allowance_name.Size = new System.Drawing.Size(366, 20);
            this.payroll_allowance_name.TabIndex = 2;
            // 
            // payroll_allowance_type
            // 
            this.payroll_allowance_type.FormattingEnabled = true;
            this.payroll_allowance_type.Location = new System.Drawing.Point(29, 261);
            this.payroll_allowance_type.Name = "payroll_allowance_type";
            this.payroll_allowance_type.Size = new System.Drawing.Size(167, 21);
            this.payroll_allowance_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // payroll_allowance_category
            // 
            this.payroll_allowance_category.FormattingEnabled = true;
            this.payroll_allowance_category.Location = new System.Drawing.Point(228, 261);
            this.payroll_allowance_category.Name = "payroll_allowance_category";
            this.payroll_allowance_category.Size = new System.Drawing.Size(167, 21);
            this.payroll_allowance_category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // payroll_allowance_add_period
            // 
            this.payroll_allowance_add_period.Controls.Add(this.payroll_allowance_add_every_period);
            this.payroll_allowance_add_period.Controls.Add(this.payroll_allowance_add_second_period);
            this.payroll_allowance_add_period.Controls.Add(this.payroll_allowance_add_last_period);
            this.payroll_allowance_add_period.Controls.Add(this.payroll_allowance_add_first_period);
            this.payroll_allowance_add_period.Location = new System.Drawing.Point(29, 300);
            this.payroll_allowance_add_period.Name = "payroll_allowance_add_period";
            this.payroll_allowance_add_period.Size = new System.Drawing.Size(285, 127);
            this.payroll_allowance_add_period.TabIndex = 7;
            this.payroll_allowance_add_period.TabStop = false;
            this.payroll_allowance_add_period.Text = "Add Every";
            // 
            // payroll_allowance_add_every_period
            // 
            this.payroll_allowance_add_every_period.AutoSize = true;
            this.payroll_allowance_add_every_period.Location = new System.Drawing.Point(147, 75);
            this.payroll_allowance_add_every_period.Name = "payroll_allowance_add_every_period";
            this.payroll_allowance_add_every_period.Size = new System.Drawing.Size(85, 17);
            this.payroll_allowance_add_every_period.TabIndex = 3;
            this.payroll_allowance_add_every_period.TabStop = true;
            this.payroll_allowance_add_every_period.Text = "Every Period";
            this.payroll_allowance_add_every_period.UseVisualStyleBackColor = true;
            // 
            // payroll_allowance_add_second_period
            // 
            this.payroll_allowance_add_second_period.AutoSize = true;
            this.payroll_allowance_add_second_period.Location = new System.Drawing.Point(147, 30);
            this.payroll_allowance_add_second_period.Name = "payroll_allowance_add_second_period";
            this.payroll_allowance_add_second_period.Size = new System.Drawing.Size(95, 17);
            this.payroll_allowance_add_second_period.TabIndex = 2;
            this.payroll_allowance_add_second_period.TabStop = true;
            this.payroll_allowance_add_second_period.Text = "Second Period";
            this.payroll_allowance_add_second_period.UseVisualStyleBackColor = true;
            // 
            // payroll_allowance_add_last_period
            // 
            this.payroll_allowance_add_last_period.AutoSize = true;
            this.payroll_allowance_add_last_period.Location = new System.Drawing.Point(23, 75);
            this.payroll_allowance_add_last_period.Name = "payroll_allowance_add_last_period";
            this.payroll_allowance_add_last_period.Size = new System.Drawing.Size(78, 17);
            this.payroll_allowance_add_last_period.TabIndex = 1;
            this.payroll_allowance_add_last_period.TabStop = true;
            this.payroll_allowance_add_last_period.Text = "Last Period";
            this.payroll_allowance_add_last_period.UseVisualStyleBackColor = true;
            // 
            // payroll_allowance_add_first_period
            // 
            this.payroll_allowance_add_first_period.AutoSize = true;
            this.payroll_allowance_add_first_period.Location = new System.Drawing.Point(23, 30);
            this.payroll_allowance_add_first_period.Name = "payroll_allowance_add_first_period";
            this.payroll_allowance_add_first_period.Size = new System.Drawing.Size(77, 17);
            this.payroll_allowance_add_first_period.TabIndex = 0;
            this.payroll_allowance_add_first_period.TabStop = true;
            this.payroll_allowance_add_first_period.Text = "First Period";
            this.payroll_allowance_add_first_period.UseVisualStyleBackColor = true;
            // 
            // payroll_allowance_expense_account
            // 
            this.payroll_allowance_expense_account.FormattingEnabled = true;
            this.payroll_allowance_expense_account.Location = new System.Drawing.Point(29, 448);
            this.payroll_allowance_expense_account.Name = "payroll_allowance_expense_account";
            this.payroll_allowance_expense_account.Size = new System.Drawing.Size(167, 21);
            this.payroll_allowance_expense_account.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expense Account";
            // 
            // payroll_allowance_tag_employee
            // 
            this.payroll_allowance_tag_employee.Location = new System.Drawing.Point(288, 446);
            this.payroll_allowance_tag_employee.Name = "payroll_allowance_tag_employee";
            this.payroll_allowance_tag_employee.Size = new System.Drawing.Size(107, 23);
            this.payroll_allowance_tag_employee.TabIndex = 10;
            this.payroll_allowance_tag_employee.Text = "Tag Employee";
            this.payroll_allowance_tag_employee.UseVisualStyleBackColor = true;
            // 
            // grp_payroll_allowance_affected
            // 
            this.grp_payroll_allowance_affected.Controls.Add(this.dgv_Allowances_TaggedEmployee);
            this.grp_payroll_allowance_affected.Location = new System.Drawing.Point(33, 491);
            this.grp_payroll_allowance_affected.Name = "grp_payroll_allowance_affected";
            this.grp_payroll_allowance_affected.Size = new System.Drawing.Size(614, 185);
            this.grp_payroll_allowance_affected.TabIndex = 11;
            this.grp_payroll_allowance_affected.TabStop = false;
            this.grp_payroll_allowance_affected.Text = "Affected Employee";
            // 
            // dgv_Allowances_TaggedEmployee
            // 
            this.dgv_Allowances_TaggedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Allowances_TaggedEmployee.Location = new System.Drawing.Point(6, 19);
            this.dgv_Allowances_TaggedEmployee.Name = "dgv_Allowances_TaggedEmployee";
            this.dgv_Allowances_TaggedEmployee.Size = new System.Drawing.Size(602, 160);
            this.dgv_Allowances_TaggedEmployee.TabIndex = 0;
            // 
            // btnCloseAllowances
            // 
            this.btnCloseAllowances.Location = new System.Drawing.Point(443, 697);
            this.btnCloseAllowances.Name = "btnCloseAllowances";
            this.btnCloseAllowances.Size = new System.Drawing.Size(96, 23);
            this.btnCloseAllowances.TabIndex = 12;
            this.btnCloseAllowances.Text = "Close";
            this.btnCloseAllowances.UseVisualStyleBackColor = true;
            // 
            // btnSaveAllowances
            // 
            this.btnSaveAllowances.Location = new System.Drawing.Point(545, 697);
            this.btnSaveAllowances.Name = "btnSaveAllowances";
            this.btnSaveAllowances.Size = new System.Drawing.Size(96, 23);
            this.btnSaveAllowances.TabIndex = 13;
            this.btnSaveAllowances.Text = "Save";
            this.btnSaveAllowances.UseVisualStyleBackColor = true;
            // 
            // Allowances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 732);
            this.Controls.Add(this.btnSaveAllowances);
            this.Controls.Add(this.btnCloseAllowances);
            this.Controls.Add(this.grp_payroll_allowance_affected);
            this.Controls.Add(this.payroll_allowance_tag_employee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payroll_allowance_expense_account);
            this.Controls.Add(this.payroll_allowance_add_period);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payroll_allowance_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payroll_allowance_type);
            this.Controls.Add(this.payroll_allowance_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAllowances);
            this.Name = "Allowances";
            this.Text = "Allowances";
            this.Load += new System.EventHandler(this.Allowances_Load);
            this.tabAllowances.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_allowances_active_allowances)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_allowances_archived_allowances)).EndInit();
            this.payroll_allowance_add_period.ResumeLayout(false);
            this.payroll_allowance_add_period.PerformLayout();
            this.grp_payroll_allowance_affected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Allowances_TaggedEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAllowances;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payroll_allowance_name;
        private System.Windows.Forms.ComboBox payroll_allowance_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox payroll_allowance_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox payroll_allowance_add_period;
        private System.Windows.Forms.RadioButton payroll_allowance_add_every_period;
        private System.Windows.Forms.RadioButton payroll_allowance_add_second_period;
        private System.Windows.Forms.RadioButton payroll_allowance_add_last_period;
        private System.Windows.Forms.RadioButton payroll_allowance_add_first_period;
        private System.Windows.Forms.ComboBox payroll_allowance_expense_account;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button payroll_allowance_tag_employee;
        private System.Windows.Forms.GroupBox grp_payroll_allowance_affected;
        private System.Windows.Forms.DataGridView dgv_Allowances_TaggedEmployee;
        private System.Windows.Forms.Button btnCloseAllowances;
        private System.Windows.Forms.Button btnSaveAllowances;
        private System.Windows.Forms.DataGridView dgv_payroll_allowances_active_allowances;
        private System.Windows.Forms.DataGridView dgv_payroll_allowances_archived_allowances;
    }
}