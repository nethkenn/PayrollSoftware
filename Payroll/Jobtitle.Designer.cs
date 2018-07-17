namespace Payroll
{
    partial class Jobtitle
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
            this.btnJobEdit = new System.Windows.Forms.Button();
            this.btnJobRestore = new System.Windows.Forms.Button();
            this.payroll_jobtitle_id = new System.Windows.Forms.TextBox();
            this.btnJobArchived = new System.Windows.Forms.Button();
            this.btnJobSave = new System.Windows.Forms.Button();
            this.lblJobTitleName = new System.Windows.Forms.Label();
            this.payroll_jobtitle_name = new System.Windows.Forms.TextBox();
            this.tabJob = new System.Windows.Forms.TabControl();
            this.activejobtitle = new System.Windows.Forms.TabPage();
            this.payroll_job_datagrid_active = new System.Windows.Forms.DataGridView();
            this.archivejobtitle = new System.Windows.Forms.TabPage();
            this.payroll_job_datagrid_archive = new System.Windows.Forms.DataGridView();
            this.payroll_jobtitle_department_id = new System.Windows.Forms.ComboBox();
            this.lblDepartmentJob = new System.Windows.Forms.Label();
            this.tabJob.SuspendLayout();
            this.activejobtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_job_datagrid_active)).BeginInit();
            this.archivejobtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_job_datagrid_archive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJobEdit
            // 
            this.btnJobEdit.Enabled = false;
            this.btnJobEdit.Location = new System.Drawing.Point(342, 248);
            this.btnJobEdit.Name = "btnJobEdit";
            this.btnJobEdit.Size = new System.Drawing.Size(128, 23);
            this.btnJobEdit.TabIndex = 31;
            this.btnJobEdit.Text = "Edit";
            this.btnJobEdit.UseVisualStyleBackColor = true;
            this.btnJobEdit.Click += new System.EventHandler(this.btnJobEdit_Click);
            // 
            // btnJobRestore
            // 
            this.btnJobRestore.Enabled = false;
            this.btnJobRestore.Location = new System.Drawing.Point(342, 305);
            this.btnJobRestore.Name = "btnJobRestore";
            this.btnJobRestore.Size = new System.Drawing.Size(128, 23);
            this.btnJobRestore.TabIndex = 30;
            this.btnJobRestore.Text = "Restore";
            this.btnJobRestore.UseVisualStyleBackColor = true;
            this.btnJobRestore.Click += new System.EventHandler(this.btnJobRestore_Click);
            // 
            // payroll_jobtitle_id
            // 
            this.payroll_jobtitle_id.Location = new System.Drawing.Point(245, 308);
            this.payroll_jobtitle_id.Name = "payroll_jobtitle_id";
            this.payroll_jobtitle_id.Size = new System.Drawing.Size(91, 20);
            this.payroll_jobtitle_id.TabIndex = 29;
            this.payroll_jobtitle_id.Visible = false;
            // 
            // btnJobArchived
            // 
            this.btnJobArchived.Enabled = false;
            this.btnJobArchived.Location = new System.Drawing.Point(342, 276);
            this.btnJobArchived.Name = "btnJobArchived";
            this.btnJobArchived.Size = new System.Drawing.Size(128, 23);
            this.btnJobArchived.TabIndex = 28;
            this.btnJobArchived.Text = "Archive";
            this.btnJobArchived.UseVisualStyleBackColor = true;
            this.btnJobArchived.Click += new System.EventHandler(this.btnJobArchived_Click);
            // 
            // btnJobSave
            // 
            this.btnJobSave.Location = new System.Drawing.Point(341, 220);
            this.btnJobSave.Name = "btnJobSave";
            this.btnJobSave.Size = new System.Drawing.Size(128, 23);
            this.btnJobSave.TabIndex = 27;
            this.btnJobSave.Text = "Save";
            this.btnJobSave.UseVisualStyleBackColor = true;
            this.btnJobSave.Click += new System.EventHandler(this.btnJobSave_Click);
            // 
            // lblJobTitleName
            // 
            this.lblJobTitleName.AutoSize = true;
            this.lblJobTitleName.Location = new System.Drawing.Point(9, 260);
            this.lblJobTitleName.Name = "lblJobTitleName";
            this.lblJobTitleName.Size = new System.Drawing.Size(78, 13);
            this.lblJobTitleName.TabIndex = 26;
            this.lblJobTitleName.Text = "Job Title Name";
            // 
            // payroll_jobtitle_name
            // 
            this.payroll_jobtitle_name.Location = new System.Drawing.Point(12, 276);
            this.payroll_jobtitle_name.Name = "payroll_jobtitle_name";
            this.payroll_jobtitle_name.Size = new System.Drawing.Size(241, 20);
            this.payroll_jobtitle_name.TabIndex = 25;
            // 
            // tabJob
            // 
            this.tabJob.Controls.Add(this.activejobtitle);
            this.tabJob.Controls.Add(this.archivejobtitle);
            this.tabJob.Location = new System.Drawing.Point(12, 10);
            this.tabJob.Name = "tabJob";
            this.tabJob.SelectedIndex = 0;
            this.tabJob.Size = new System.Drawing.Size(461, 202);
            this.tabJob.TabIndex = 24;
            this.tabJob.SelectedIndexChanged += new System.EventHandler(this.tabJob_SelectedIndexChanged);
            // 
            // activejobtitle
            // 
            this.activejobtitle.Controls.Add(this.payroll_job_datagrid_active);
            this.activejobtitle.Location = new System.Drawing.Point(4, 22);
            this.activejobtitle.Name = "activejobtitle";
            this.activejobtitle.Padding = new System.Windows.Forms.Padding(3);
            this.activejobtitle.Size = new System.Drawing.Size(453, 176);
            this.activejobtitle.TabIndex = 0;
            this.activejobtitle.Text = "Active Job Title";
            this.activejobtitle.UseVisualStyleBackColor = true;
            // 
            // payroll_job_datagrid_active
            // 
            this.payroll_job_datagrid_active.AllowUserToAddRows = false;
            this.payroll_job_datagrid_active.AllowUserToResizeColumns = false;
            this.payroll_job_datagrid_active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_job_datagrid_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_job_datagrid_active.Location = new System.Drawing.Point(0, 0);
            this.payroll_job_datagrid_active.Name = "payroll_job_datagrid_active";
            this.payroll_job_datagrid_active.ReadOnly = true;
            this.payroll_job_datagrid_active.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_job_datagrid_active.Size = new System.Drawing.Size(453, 176);
            this.payroll_job_datagrid_active.TabIndex = 0;
            this.payroll_job_datagrid_active.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payroll_job_datagrid_active_CellClick);
            // 
            // archivejobtitle
            // 
            this.archivejobtitle.Controls.Add(this.payroll_job_datagrid_archive);
            this.archivejobtitle.Location = new System.Drawing.Point(4, 22);
            this.archivejobtitle.Name = "archivejobtitle";
            this.archivejobtitle.Padding = new System.Windows.Forms.Padding(3);
            this.archivejobtitle.Size = new System.Drawing.Size(453, 176);
            this.archivejobtitle.TabIndex = 1;
            this.archivejobtitle.Text = "Archived Job Title";
            this.archivejobtitle.UseVisualStyleBackColor = true;
            // 
            // payroll_job_datagrid_archive
            // 
            this.payroll_job_datagrid_archive.AllowUserToAddRows = false;
            this.payroll_job_datagrid_archive.AllowUserToResizeColumns = false;
            this.payroll_job_datagrid_archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_job_datagrid_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_job_datagrid_archive.Location = new System.Drawing.Point(0, 0);
            this.payroll_job_datagrid_archive.Name = "payroll_job_datagrid_archive";
            this.payroll_job_datagrid_archive.ReadOnly = true;
            this.payroll_job_datagrid_archive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_job_datagrid_archive.Size = new System.Drawing.Size(453, 176);
            this.payroll_job_datagrid_archive.TabIndex = 0;
            this.payroll_job_datagrid_archive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payroll_job_datagrid_archive_CellClick);
            // 
            // payroll_jobtitle_department_id
            // 
            this.payroll_jobtitle_department_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_jobtitle_department_id.FormattingEnabled = true;
            this.payroll_jobtitle_department_id.Location = new System.Drawing.Point(12, 236);
            this.payroll_jobtitle_department_id.Name = "payroll_jobtitle_department_id";
            this.payroll_jobtitle_department_id.Size = new System.Drawing.Size(241, 21);
            this.payroll_jobtitle_department_id.TabIndex = 32;
            // 
            // lblDepartmentJob
            // 
            this.lblDepartmentJob.AutoSize = true;
            this.lblDepartmentJob.Location = new System.Drawing.Point(9, 220);
            this.lblDepartmentJob.Name = "lblDepartmentJob";
            this.lblDepartmentJob.Size = new System.Drawing.Size(62, 13);
            this.lblDepartmentJob.TabIndex = 33;
            this.lblDepartmentJob.Text = "Department";
            // 
            // Jobtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 333);
            this.Controls.Add(this.lblDepartmentJob);
            this.Controls.Add(this.payroll_jobtitle_department_id);
            this.Controls.Add(this.btnJobEdit);
            this.Controls.Add(this.btnJobRestore);
            this.Controls.Add(this.payroll_jobtitle_id);
            this.Controls.Add(this.btnJobArchived);
            this.Controls.Add(this.btnJobSave);
            this.Controls.Add(this.lblJobTitleName);
            this.Controls.Add(this.payroll_jobtitle_name);
            this.Controls.Add(this.tabJob);
            this.Name = "Jobtitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Title";
            this.Load += new System.EventHandler(this.Jobtitle_Load);
            this.tabJob.ResumeLayout(false);
            this.activejobtitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_job_datagrid_active)).EndInit();
            this.archivejobtitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_job_datagrid_archive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJobEdit;
        private System.Windows.Forms.Button btnJobRestore;
        private System.Windows.Forms.TextBox payroll_jobtitle_id;
        private System.Windows.Forms.Button btnJobArchived;
        private System.Windows.Forms.Button btnJobSave;
        private System.Windows.Forms.Label lblJobTitleName;
        private System.Windows.Forms.TextBox payroll_jobtitle_name;
        private System.Windows.Forms.TabControl tabJob;
        private System.Windows.Forms.TabPage activejobtitle;
        private System.Windows.Forms.DataGridView payroll_job_datagrid_active;
        private System.Windows.Forms.TabPage archivejobtitle;
        private System.Windows.Forms.DataGridView payroll_job_datagrid_archive;
        private System.Windows.Forms.ComboBox payroll_jobtitle_department_id;
        private System.Windows.Forms.Label lblDepartmentJob;
    }
}