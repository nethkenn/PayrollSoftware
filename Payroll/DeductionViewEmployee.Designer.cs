﻿namespace Payroll
{
    partial class DeductionViewEmployee
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
            this.tabDeductViewEmployee = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_payroll_deduction_view_employee_active = new System.Windows.Forms.DataGridView();
            this.dgv_payroll_deduction_view_employee_archived = new System.Windows.Forms.DataGridView();
            this.tabDeductViewEmployee.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_deduction_view_employee_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_deduction_view_employee_archived)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDeductViewEmployee
            // 
            this.tabDeductViewEmployee.Controls.Add(this.tabPage1);
            this.tabDeductViewEmployee.Controls.Add(this.tabPage2);
            this.tabDeductViewEmployee.Location = new System.Drawing.Point(12, 12);
            this.tabDeductViewEmployee.Name = "tabDeductViewEmployee";
            this.tabDeductViewEmployee.SelectedIndex = 0;
            this.tabDeductViewEmployee.Size = new System.Drawing.Size(679, 237);
            this.tabDeductViewEmployee.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_payroll_deduction_view_employee_active);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_payroll_deduction_view_employee_archived);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archived";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_payroll_deduction_view_employee_active
            // 
            this.dgv_payroll_deduction_view_employee_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_deduction_view_employee_active.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_deduction_view_employee_active.Name = "dgv_payroll_deduction_view_employee_active";
            this.dgv_payroll_deduction_view_employee_active.Size = new System.Drawing.Size(671, 211);
            this.dgv_payroll_deduction_view_employee_active.TabIndex = 0;
            // 
            // dgv_payroll_deduction_view_employee_archived
            // 
            this.dgv_payroll_deduction_view_employee_archived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_deduction_view_employee_archived.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_deduction_view_employee_archived.Name = "dgv_payroll_deduction_view_employee_archived";
            this.dgv_payroll_deduction_view_employee_archived.Size = new System.Drawing.Size(671, 211);
            this.dgv_payroll_deduction_view_employee_archived.TabIndex = 0;
            // 
            // DeductionViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 261);
            this.Controls.Add(this.tabDeductViewEmployee);
            this.Name = "DeductionViewEmployee";
            this.Text = "DeductionViewEmployee";
            this.tabDeductViewEmployee.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_deduction_view_employee_active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_deduction_view_employee_archived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeductViewEmployee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_payroll_deduction_view_employee_active;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_payroll_deduction_view_employee_archived;
    }
}