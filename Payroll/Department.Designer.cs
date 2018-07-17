namespace Payroll
{
    partial class Department
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
            this.tabDept = new System.Windows.Forms.TabControl();
            this.activedepartment = new System.Windows.Forms.TabPage();
            this.payroll_department_datagrid_active = new System.Windows.Forms.DataGridView();
            this.archiveddepartment = new System.Windows.Forms.TabPage();
            this.payroll_department_datagrid_archive = new System.Windows.Forms.DataGridView();
            this.payroll_department_name = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.btnDeptSave = new System.Windows.Forms.Button();
            this.btnDeptArchived = new System.Windows.Forms.Button();
            this.payroll_department_id = new System.Windows.Forms.TextBox();
            this.btnDeptRestore = new System.Windows.Forms.Button();
            this.btnDeptEdit = new System.Windows.Forms.Button();
            this.tabDept.SuspendLayout();
            this.activedepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_department_datagrid_active)).BeginInit();
            this.archiveddepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_department_datagrid_archive)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDept
            // 
            this.tabDept.Controls.Add(this.activedepartment);
            this.tabDept.Controls.Add(this.archiveddepartment);
            this.tabDept.Location = new System.Drawing.Point(14, 12);
            this.tabDept.Name = "tabDept";
            this.tabDept.SelectedIndex = 0;
            this.tabDept.Size = new System.Drawing.Size(461, 202);
            this.tabDept.TabIndex = 1;
            this.tabDept.SelectedIndexChanged += new System.EventHandler(this.tabDept_SelectedIndexChanged);
            // 
            // activedepartment
            // 
            this.activedepartment.Controls.Add(this.payroll_department_datagrid_active);
            this.activedepartment.Location = new System.Drawing.Point(4, 22);
            this.activedepartment.Name = "activedepartment";
            this.activedepartment.Padding = new System.Windows.Forms.Padding(3);
            this.activedepartment.Size = new System.Drawing.Size(453, 176);
            this.activedepartment.TabIndex = 0;
            this.activedepartment.Text = "Active Department";
            this.activedepartment.UseVisualStyleBackColor = true;
            // 
            // payroll_department_datagrid_active
            // 
            this.payroll_department_datagrid_active.AllowUserToAddRows = false;
            this.payroll_department_datagrid_active.AllowUserToResizeColumns = false;
            this.payroll_department_datagrid_active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_department_datagrid_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_department_datagrid_active.Location = new System.Drawing.Point(0, 0);
            this.payroll_department_datagrid_active.Name = "payroll_department_datagrid_active";
            this.payroll_department_datagrid_active.ReadOnly = true;
            this.payroll_department_datagrid_active.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_department_datagrid_active.Size = new System.Drawing.Size(453, 176);
            this.payroll_department_datagrid_active.TabIndex = 0;
            this.payroll_department_datagrid_active.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payroll_department_datagrid_active_CellClick);
            // 
            // archiveddepartment
            // 
            this.archiveddepartment.Controls.Add(this.payroll_department_datagrid_archive);
            this.archiveddepartment.Location = new System.Drawing.Point(4, 22);
            this.archiveddepartment.Name = "archiveddepartment";
            this.archiveddepartment.Padding = new System.Windows.Forms.Padding(3);
            this.archiveddepartment.Size = new System.Drawing.Size(453, 176);
            this.archiveddepartment.TabIndex = 1;
            this.archiveddepartment.Text = "Archived Department";
            this.archiveddepartment.UseVisualStyleBackColor = true;
            // 
            // payroll_department_datagrid_archive
            // 
            this.payroll_department_datagrid_archive.AllowUserToAddRows = false;
            this.payroll_department_datagrid_archive.AllowUserToResizeColumns = false;
            this.payroll_department_datagrid_archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payroll_department_datagrid_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_department_datagrid_archive.Location = new System.Drawing.Point(0, 0);
            this.payroll_department_datagrid_archive.Name = "payroll_department_datagrid_archive";
            this.payroll_department_datagrid_archive.ReadOnly = true;
            this.payroll_department_datagrid_archive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payroll_department_datagrid_archive.Size = new System.Drawing.Size(454, 176);
            this.payroll_department_datagrid_archive.TabIndex = 0;
            this.payroll_department_datagrid_archive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payroll_department_datagrid_archive_CellClick);
            // 
            // payroll_department_name
            // 
            this.payroll_department_name.Location = new System.Drawing.Point(18, 238);
            this.payroll_department_name.Name = "payroll_department_name";
            this.payroll_department_name.Size = new System.Drawing.Size(241, 20);
            this.payroll_department_name.TabIndex = 2;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(15, 222);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(93, 13);
            this.lblDeptName.TabIndex = 3;
            this.lblDeptName.Text = "Department Name";
            // 
            // btnDeptSave
            // 
            this.btnDeptSave.Location = new System.Drawing.Point(343, 222);
            this.btnDeptSave.Name = "btnDeptSave";
            this.btnDeptSave.Size = new System.Drawing.Size(128, 23);
            this.btnDeptSave.TabIndex = 18;
            this.btnDeptSave.Text = "Save";
            this.btnDeptSave.UseVisualStyleBackColor = true;
            this.btnDeptSave.Click += new System.EventHandler(this.btnDeptSave_Click);
            // 
            // btnDeptArchived
            // 
            this.btnDeptArchived.Enabled = false;
            this.btnDeptArchived.Location = new System.Drawing.Point(344, 278);
            this.btnDeptArchived.Name = "btnDeptArchived";
            this.btnDeptArchived.Size = new System.Drawing.Size(128, 23);
            this.btnDeptArchived.TabIndex = 20;
            this.btnDeptArchived.Text = "Archive";
            this.btnDeptArchived.UseVisualStyleBackColor = true;
            this.btnDeptArchived.Click += new System.EventHandler(this.btnDeptArchived_Click);
            // 
            // payroll_department_id
            // 
            this.payroll_department_id.Location = new System.Drawing.Point(181, 280);
            this.payroll_department_id.Name = "payroll_department_id";
            this.payroll_department_id.Size = new System.Drawing.Size(91, 20);
            this.payroll_department_id.TabIndex = 21;
            this.payroll_department_id.Visible = false;
            // 
            // btnDeptRestore
            // 
            this.btnDeptRestore.Enabled = false;
            this.btnDeptRestore.Location = new System.Drawing.Point(344, 307);
            this.btnDeptRestore.Name = "btnDeptRestore";
            this.btnDeptRestore.Size = new System.Drawing.Size(128, 23);
            this.btnDeptRestore.TabIndex = 22;
            this.btnDeptRestore.Text = "Restore";
            this.btnDeptRestore.UseVisualStyleBackColor = true;
            this.btnDeptRestore.Click += new System.EventHandler(this.btnDeptRestore_Click);
            // 
            // btnDeptEdit
            // 
            this.btnDeptEdit.Enabled = false;
            this.btnDeptEdit.Location = new System.Drawing.Point(344, 250);
            this.btnDeptEdit.Name = "btnDeptEdit";
            this.btnDeptEdit.Size = new System.Drawing.Size(128, 23);
            this.btnDeptEdit.TabIndex = 23;
            this.btnDeptEdit.Text = "Edit";
            this.btnDeptEdit.UseVisualStyleBackColor = true;
            this.btnDeptEdit.Click += new System.EventHandler(this.btnDeptEdit_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 339);
            this.Controls.Add(this.btnDeptEdit);
            this.Controls.Add(this.btnDeptRestore);
            this.Controls.Add(this.payroll_department_id);
            this.Controls.Add(this.btnDeptArchived);
            this.Controls.Add(this.btnDeptSave);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.payroll_department_name);
            this.Controls.Add(this.tabDept);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.tabDept.ResumeLayout(false);
            this.activedepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_department_datagrid_active)).EndInit();
            this.archiveddepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_department_datagrid_archive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDept;
        private System.Windows.Forms.TabPage activedepartment;
        private System.Windows.Forms.DataGridView payroll_department_datagrid_active;
        private System.Windows.Forms.TabPage archiveddepartment;
        private System.Windows.Forms.DataGridView payroll_department_datagrid_archive;
        private System.Windows.Forms.TextBox payroll_department_name;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Button btnDeptSave;
        private System.Windows.Forms.Button btnDeptArchived;
        private System.Windows.Forms.TextBox payroll_department_id;
        private System.Windows.Forms.Button btnDeptRestore;
        private System.Windows.Forms.Button btnDeptEdit;
    }
}