namespace Payroll
{
    partial class TagEmployee
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
            this.grpEmployeeTag = new System.Windows.Forms.GroupBox();
            this.payroll_filter_dept_tag = new System.Windows.Forms.ComboBox();
            this.payroll_filter_job_tag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnTag = new System.Windows.Forms.Button();
            this.grpEmployeeTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeTag
            // 
            this.grpEmployeeTag.Controls.Add(this.checkBox1);
            this.grpEmployeeTag.Controls.Add(this.panelEmployee);
            this.grpEmployeeTag.Location = new System.Drawing.Point(12, 57);
            this.grpEmployeeTag.Name = "grpEmployeeTag";
            this.grpEmployeeTag.Size = new System.Drawing.Size(328, 448);
            this.grpEmployeeTag.TabIndex = 0;
            this.grpEmployeeTag.TabStop = false;
            this.grpEmployeeTag.Text = "Employee";
            // 
            // payroll_filter_dept_tag
            // 
            this.payroll_filter_dept_tag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_filter_dept_tag.FormattingEnabled = true;
            this.payroll_filter_dept_tag.Location = new System.Drawing.Point(12, 30);
            this.payroll_filter_dept_tag.Name = "payroll_filter_dept_tag";
            this.payroll_filter_dept_tag.Size = new System.Drawing.Size(147, 21);
            this.payroll_filter_dept_tag.TabIndex = 1;
            this.payroll_filter_dept_tag.SelectedIndexChanged += new System.EventHandler(this.payroll_filter_dept_tag_SelectedIndexChanged);
            // 
            // payroll_filter_job_tag
            // 
            this.payroll_filter_job_tag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_filter_job_tag.FormattingEnabled = true;
            this.payroll_filter_job_tag.Location = new System.Drawing.Point(191, 30);
            this.payroll_filter_job_tag.Name = "payroll_filter_job_tag";
            this.payroll_filter_job_tag.Size = new System.Drawing.Size(149, 21);
            this.payroll_filter_job_tag.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Job Title";
            // 
            // panelEmployee
            // 
            this.panelEmployee.AutoScroll = true;
            this.panelEmployee.Location = new System.Drawing.Point(6, 46);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(316, 396);
            this.panelEmployee.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Check All";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(259, 511);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(75, 23);
            this.btnTag.TabIndex = 0;
            this.btnTag.Text = "Tag";
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // TagEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 542);
            this.Controls.Add(this.btnTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payroll_filter_job_tag);
            this.Controls.Add(this.payroll_filter_dept_tag);
            this.Controls.Add(this.grpEmployeeTag);
            this.Name = "TagEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Employee";
            this.Load += new System.EventHandler(this.TagEmployee_Load);
            this.grpEmployeeTag.ResumeLayout(false);
            this.grpEmployeeTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeTag;
        private System.Windows.Forms.ComboBox payroll_filter_dept_tag;
        private System.Windows.Forms.ComboBox payroll_filter_job_tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button btnTag;
    }
}