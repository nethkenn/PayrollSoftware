namespace Payroll
{
    partial class Leave
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
            this.tabLeave = new System.Windows.Forms.TabControl();
            this.activeleave = new System.Windows.Forms.TabPage();
            this.payroll_leave_datagrid_active = new System.Windows.Forms.DataGridView();
            this.archiveleave = new System.Windows.Forms.TabPage();
            this.payroll_leave_datagrid_archive = new System.Windows.Forms.DataGridView();
            this.dgvTaggedEmployee = new System.Windows.Forms.DataGridView();
            this.payroll_leave_temp_name = new System.Windows.Forms.ComboBox();
            this.btnTagEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAffected = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnNo = new System.Windows.Forms.RadioButton();
            this.rdnYes = new System.Windows.Forms.RadioButton();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLeave.SuspendLayout();
            this.activeleave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_leave_datagrid_active)).BeginInit();
            this.archiveleave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_leave_datagrid_archive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaggedEmployee)).BeginInit();
            this.grpAffected.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLeave
            // 
            this.tabLeave.Controls.Add(this.activeleave);
            this.tabLeave.Controls.Add(this.archiveleave);
            this.tabLeave.Location = new System.Drawing.Point(12, 12);
            this.tabLeave.Name = "tabLeave";
            this.tabLeave.SelectedIndex = 0;
            this.tabLeave.Size = new System.Drawing.Size(461, 202);
            this.tabLeave.TabIndex = 25;
            // 
            // activeleave
            // 
            this.activeleave.Controls.Add(this.payroll_leave_datagrid_active);
            this.activeleave.Location = new System.Drawing.Point(4, 22);
            this.activeleave.Name = "activeleave";
            this.activeleave.Padding = new System.Windows.Forms.Padding(3);
            this.activeleave.Size = new System.Drawing.Size(453, 176);
            this.activeleave.TabIndex = 0;
            this.activeleave.Text = "Active Leave ";
            this.activeleave.UseVisualStyleBackColor = true;
            // 
            // payroll_leave_datagrid_active
            // 
            this.payroll_leave_datagrid_active.AllowUserToAddRows = false;
            this.payroll_leave_datagrid_active.AllowUserToResizeColumns = false;
            this.payroll_leave_datagrid_active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_leave_datagrid_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_leave_datagrid_active.Location = new System.Drawing.Point(0, 0);
            this.payroll_leave_datagrid_active.Name = "payroll_leave_datagrid_active";
            this.payroll_leave_datagrid_active.ReadOnly = true;
            this.payroll_leave_datagrid_active.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_leave_datagrid_active.Size = new System.Drawing.Size(453, 176);
            this.payroll_leave_datagrid_active.TabIndex = 0;
            // 
            // archiveleave
            // 
            this.archiveleave.Controls.Add(this.payroll_leave_datagrid_archive);
            this.archiveleave.Location = new System.Drawing.Point(4, 22);
            this.archiveleave.Name = "archiveleave";
            this.archiveleave.Padding = new System.Windows.Forms.Padding(3);
            this.archiveleave.Size = new System.Drawing.Size(453, 176);
            this.archiveleave.TabIndex = 1;
            this.archiveleave.Text = "Archived Leave";
            this.archiveleave.UseVisualStyleBackColor = true;
            // 
            // payroll_leave_datagrid_archive
            // 
            this.payroll_leave_datagrid_archive.AllowUserToAddRows = false;
            this.payroll_leave_datagrid_archive.AllowUserToResizeColumns = false;
            this.payroll_leave_datagrid_archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_leave_datagrid_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_leave_datagrid_archive.Location = new System.Drawing.Point(0, 0);
            this.payroll_leave_datagrid_archive.Name = "payroll_leave_datagrid_archive";
            this.payroll_leave_datagrid_archive.ReadOnly = true;
            this.payroll_leave_datagrid_archive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_leave_datagrid_archive.Size = new System.Drawing.Size(453, 176);
            this.payroll_leave_datagrid_archive.TabIndex = 0;
            // 
            // dgvTaggedEmployee
            // 
            this.dgvTaggedEmployee.AllowUserToAddRows = false;
            this.dgvTaggedEmployee.AllowUserToResizeColumns = false;
            this.dgvTaggedEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaggedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaggedEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empName,
            this.EmpID,
            this.leaveHours});
            this.dgvTaggedEmployee.Location = new System.Drawing.Point(6, 19);
            this.dgvTaggedEmployee.Name = "dgvTaggedEmployee";
            this.dgvTaggedEmployee.ReadOnly = true;
            this.dgvTaggedEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaggedEmployee.Size = new System.Drawing.Size(445, 154);
            this.dgvTaggedEmployee.TabIndex = 1;
            // 
            // payroll_leave_temp_name
            // 
            this.payroll_leave_temp_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_leave_temp_name.FormattingEnabled = true;
            this.payroll_leave_temp_name.Items.AddRange(new object[] {
            "Bereavement Leave",
            "Emergency Leave",
            "Leave For Victims of VAWC",
            "Maternity Leave",
            "Parental Leave",
            "Paternity Leave",
            "Sick Leave",
            "Special Leave For Women",
            "Vacation Leave"});
            this.payroll_leave_temp_name.Location = new System.Drawing.Point(16, 237);
            this.payroll_leave_temp_name.Name = "payroll_leave_temp_name";
            this.payroll_leave_temp_name.Size = new System.Drawing.Size(168, 21);
            this.payroll_leave_temp_name.TabIndex = 26;
            // 
            // btnTagEmployee
            // 
            this.btnTagEmployee.Location = new System.Drawing.Point(373, 256);
            this.btnTagEmployee.Name = "btnTagEmployee";
            this.btnTagEmployee.Size = new System.Drawing.Size(96, 23);
            this.btnTagEmployee.TabIndex = 27;
            this.btnTagEmployee.Text = "Tag Employee";
            this.btnTagEmployee.UseVisualStyleBackColor = true;
            this.btnTagEmployee.Click += new System.EventHandler(this.btnTagEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type of Leave";
            // 
            // grpAffected
            // 
            this.grpAffected.Controls.Add(this.dgvTaggedEmployee);
            this.grpAffected.Location = new System.Drawing.Point(16, 285);
            this.grpAffected.Name = "grpAffected";
            this.grpAffected.Size = new System.Drawing.Size(457, 179);
            this.grpAffected.TabIndex = 29;
            this.grpAffected.TabStop = false;
            this.grpAffected.Text = "Affected Employee";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(271, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnNo);
            this.groupBox1.Controls.Add(this.rdnYes);
            this.groupBox1.Location = new System.Drawing.Point(205, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 37);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cumulative?";
            // 
            // rdnNo
            // 
            this.rdnNo.AutoSize = true;
            this.rdnNo.Location = new System.Drawing.Point(75, 14);
            this.rdnNo.Name = "rdnNo";
            this.rdnNo.Size = new System.Drawing.Size(39, 17);
            this.rdnNo.TabIndex = 34;
            this.rdnNo.TabStop = true;
            this.rdnNo.Text = "No";
            this.rdnNo.UseVisualStyleBackColor = true;
            // 
            // rdnYes
            // 
            this.rdnYes.AutoSize = true;
            this.rdnYes.Location = new System.Drawing.Point(26, 14);
            this.rdnYes.Name = "rdnYes";
            this.rdnYes.Size = new System.Drawing.Size(43, 17);
            this.rdnYes.TabIndex = 33;
            this.rdnYes.TabStop = true;
            this.rdnYes.Text = "Yes";
            this.rdnYes.UseVisualStyleBackColor = true;
            // 
            // empName
            // 
            this.empName.HeaderText = "Employee Name";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Visible = false;
            // 
            // leaveHours
            // 
            this.leaveHours.HeaderText = "Leave Hours";
            this.leaveHours.Name = "leaveHours";
            this.leaveHours.ReadOnly = true;
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAffected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTagEmployee);
            this.Controls.Add(this.payroll_leave_temp_name);
            this.Controls.Add(this.tabLeave);
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            this.tabLeave.ResumeLayout(false);
            this.activeleave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_leave_datagrid_active)).EndInit();
            this.archiveleave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_leave_datagrid_archive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaggedEmployee)).EndInit();
            this.grpAffected.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLeave;
        private System.Windows.Forms.TabPage activeleave;
        private System.Windows.Forms.DataGridView payroll_leave_datagrid_active;
        private System.Windows.Forms.TabPage archiveleave;
        private System.Windows.Forms.DataGridView payroll_leave_datagrid_archive;
        private System.Windows.Forms.DataGridView dgvTaggedEmployee;
        private System.Windows.Forms.ComboBox payroll_leave_temp_name;
        private System.Windows.Forms.Button btnTagEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAffected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnNo;
        private System.Windows.Forms.RadioButton rdnYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveHours;
    }
}