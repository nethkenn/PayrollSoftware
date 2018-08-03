namespace Payroll
{
    partial class PayrollGroup
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
            this.tabPayrollGroup = new System.Windows.Forms.TabControl();
            this.activePayrollGroup = new System.Windows.Forms.TabPage();
            this.payroll_datagrid_payrollgroup_active = new System.Windows.Forms.DataGridView();
            this.archivePayrollGroup = new System.Windows.Forms.TabPage();
            this.payroll_datagrid_payrollgroup_archive = new System.Windows.Forms.DataGridView();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnArchived = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPayrollGroup.SuspendLayout();
            this.activePayrollGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_payrollgroup_active)).BeginInit();
            this.archivePayrollGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_payrollgroup_archive)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPayrollGroup
            // 
            this.tabPayrollGroup.Controls.Add(this.activePayrollGroup);
            this.tabPayrollGroup.Controls.Add(this.archivePayrollGroup);
            this.tabPayrollGroup.Location = new System.Drawing.Point(12, 12);
            this.tabPayrollGroup.Name = "tabPayrollGroup";
            this.tabPayrollGroup.SelectedIndex = 0;
            this.tabPayrollGroup.Size = new System.Drawing.Size(528, 289);
            this.tabPayrollGroup.TabIndex = 10;
            // 
            // activePayrollGroup
            // 
            this.activePayrollGroup.Controls.Add(this.payroll_datagrid_payrollgroup_active);
            this.activePayrollGroup.Location = new System.Drawing.Point(4, 22);
            this.activePayrollGroup.Name = "activePayrollGroup";
            this.activePayrollGroup.Padding = new System.Windows.Forms.Padding(3);
            this.activePayrollGroup.Size = new System.Drawing.Size(520, 263);
            this.activePayrollGroup.TabIndex = 0;
            this.activePayrollGroup.Text = "Active Payroll Group";
            this.activePayrollGroup.UseVisualStyleBackColor = true;
            // 
            // payroll_datagrid_payrollgroup_active
            // 
            this.payroll_datagrid_payrollgroup_active.AllowUserToAddRows = false;
            this.payroll_datagrid_payrollgroup_active.AllowUserToDeleteRows = false;
            this.payroll_datagrid_payrollgroup_active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_datagrid_payrollgroup_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_datagrid_payrollgroup_active.Location = new System.Drawing.Point(6, 6);
            this.payroll_datagrid_payrollgroup_active.Name = "payroll_datagrid_payrollgroup_active";
            this.payroll_datagrid_payrollgroup_active.ReadOnly = true;
            this.payroll_datagrid_payrollgroup_active.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_datagrid_payrollgroup_active.Size = new System.Drawing.Size(508, 254);
            this.payroll_datagrid_payrollgroup_active.TabIndex = 0;
            // 
            // archivePayrollGroup
            // 
            this.archivePayrollGroup.Controls.Add(this.payroll_datagrid_payrollgroup_archive);
            this.archivePayrollGroup.Location = new System.Drawing.Point(4, 22);
            this.archivePayrollGroup.Name = "archivePayrollGroup";
            this.archivePayrollGroup.Padding = new System.Windows.Forms.Padding(3);
            this.archivePayrollGroup.Size = new System.Drawing.Size(520, 263);
            this.archivePayrollGroup.TabIndex = 1;
            this.archivePayrollGroup.Text = "Archive Payroll Group";
            this.archivePayrollGroup.UseVisualStyleBackColor = true;
            // 
            // payroll_datagrid_payrollgroup_archive
            // 
            this.payroll_datagrid_payrollgroup_archive.AllowUserToAddRows = false;
            this.payroll_datagrid_payrollgroup_archive.AllowUserToDeleteRows = false;
            this.payroll_datagrid_payrollgroup_archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_datagrid_payrollgroup_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_datagrid_payrollgroup_archive.Location = new System.Drawing.Point(6, 6);
            this.payroll_datagrid_payrollgroup_archive.Name = "payroll_datagrid_payrollgroup_archive";
            this.payroll_datagrid_payrollgroup_archive.ReadOnly = true;
            this.payroll_datagrid_payrollgroup_archive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_datagrid_payrollgroup_archive.Size = new System.Drawing.Size(508, 251);
            this.payroll_datagrid_payrollgroup_archive.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(400, 322);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(122, 23);
            this.btnRestore.TabIndex = 36;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnArchived
            // 
            this.btnArchived.Enabled = false;
            this.btnArchived.Location = new System.Drawing.Point(272, 322);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(122, 23);
            this.btnArchived.TabIndex = 35;
            this.btnArchived.Text = "Archive";
            this.btnArchived.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(144, 322);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 23);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PayrollGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 362);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnArchived);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabPayrollGroup);
            this.Name = "PayrollGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayrollGroup";
            this.tabPayrollGroup.ResumeLayout(false);
            this.activePayrollGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_payrollgroup_active)).EndInit();
            this.archivePayrollGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_payrollgroup_archive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPayrollGroup;
        private System.Windows.Forms.TabPage activePayrollGroup;
        private System.Windows.Forms.DataGridView payroll_datagrid_payrollgroup_active;
        private System.Windows.Forms.TabPage archivePayrollGroup;
        private System.Windows.Forms.DataGridView payroll_datagrid_payrollgroup_archive;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnArchived;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}