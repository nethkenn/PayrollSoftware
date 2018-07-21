namespace Payroll
{
    partial class Holiday
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
            this.payroll_holiday_name = new System.Windows.Forms.TextBox();
            this.lblHolidayName = new System.Windows.Forms.Label();
            this.payroll_holiday_date = new System.Windows.Forms.DateTimePicker();
            this.payroll_holiday_category = new System.Windows.Forms.ComboBox();
            this.lblHolidayDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabHoliday = new System.Windows.Forms.TabControl();
            this.activeHoliday = new System.Windows.Forms.TabPage();
            this.payroll_datagrid_holiday_active = new System.Windows.Forms.DataGridView();
            this.archiveHoliday = new System.Windows.Forms.TabPage();
            this.payroll_holiday_holiday_archive = new System.Windows.Forms.DataGridView();
            this.grpAffected = new System.Windows.Forms.GroupBox();
            this.panelHoliday = new System.Windows.Forms.Panel();
            this.tabHoliday.SuspendLayout();
            this.activeHoliday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_holiday_active)).BeginInit();
            this.archiveHoliday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_holiday_holiday_archive)).BeginInit();
            this.grpAffected.SuspendLayout();
            this.SuspendLayout();
            // 
            // payroll_holiday_name
            // 
            this.payroll_holiday_name.Location = new System.Drawing.Point(12, 286);
            this.payroll_holiday_name.Name = "payroll_holiday_name";
            this.payroll_holiday_name.Size = new System.Drawing.Size(456, 20);
            this.payroll_holiday_name.TabIndex = 1;
            // 
            // lblHolidayName
            // 
            this.lblHolidayName.AutoSize = true;
            this.lblHolidayName.Location = new System.Drawing.Point(9, 270);
            this.lblHolidayName.Name = "lblHolidayName";
            this.lblHolidayName.Size = new System.Drawing.Size(73, 13);
            this.lblHolidayName.TabIndex = 2;
            this.lblHolidayName.Text = "Holiday Name";
            // 
            // payroll_holiday_date
            // 
            this.payroll_holiday_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payroll_holiday_date.Location = new System.Drawing.Point(12, 329);
            this.payroll_holiday_date.Name = "payroll_holiday_date";
            this.payroll_holiday_date.Size = new System.Drawing.Size(200, 20);
            this.payroll_holiday_date.TabIndex = 3;
            // 
            // payroll_holiday_category
            // 
            this.payroll_holiday_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_holiday_category.FormattingEnabled = true;
            this.payroll_holiday_category.Items.AddRange(new object[] {
            "Regular",
            "Special"});
            this.payroll_holiday_category.Location = new System.Drawing.Point(240, 328);
            this.payroll_holiday_category.Name = "payroll_holiday_category";
            this.payroll_holiday_category.Size = new System.Drawing.Size(228, 21);
            this.payroll_holiday_category.TabIndex = 4;
            // 
            // lblHolidayDate
            // 
            this.lblHolidayDate.AutoSize = true;
            this.lblHolidayDate.Location = new System.Drawing.Point(9, 313);
            this.lblHolidayDate.Name = "lblHolidayDate";
            this.lblHolidayDate.Size = new System.Drawing.Size(30, 13);
            this.lblHolidayDate.TabIndex = 5;
            this.lblHolidayDate.Text = "Date";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(237, 313);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tabHoliday
            // 
            this.tabHoliday.Controls.Add(this.activeHoliday);
            this.tabHoliday.Controls.Add(this.archiveHoliday);
            this.tabHoliday.Location = new System.Drawing.Point(12, 12);
            this.tabHoliday.Name = "tabHoliday";
            this.tabHoliday.SelectedIndex = 0;
            this.tabHoliday.Size = new System.Drawing.Size(456, 255);
            this.tabHoliday.TabIndex = 9;
            // 
            // activeHoliday
            // 
            this.activeHoliday.Controls.Add(this.payroll_datagrid_holiday_active);
            this.activeHoliday.Location = new System.Drawing.Point(4, 22);
            this.activeHoliday.Name = "activeHoliday";
            this.activeHoliday.Padding = new System.Windows.Forms.Padding(3);
            this.activeHoliday.Size = new System.Drawing.Size(448, 229);
            this.activeHoliday.TabIndex = 0;
            this.activeHoliday.Text = "Active Holiday";
            this.activeHoliday.UseVisualStyleBackColor = true;
            // 
            // payroll_datagrid_holiday_active
            // 
            this.payroll_datagrid_holiday_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_datagrid_holiday_active.Location = new System.Drawing.Point(6, 6);
            this.payroll_datagrid_holiday_active.Name = "payroll_datagrid_holiday_active";
            this.payroll_datagrid_holiday_active.Size = new System.Drawing.Size(436, 217);
            this.payroll_datagrid_holiday_active.TabIndex = 0;
            // 
            // archiveHoliday
            // 
            this.archiveHoliday.Controls.Add(this.payroll_holiday_holiday_archive);
            this.archiveHoliday.Location = new System.Drawing.Point(4, 22);
            this.archiveHoliday.Name = "archiveHoliday";
            this.archiveHoliday.Padding = new System.Windows.Forms.Padding(3);
            this.archiveHoliday.Size = new System.Drawing.Size(448, 229);
            this.archiveHoliday.TabIndex = 1;
            this.archiveHoliday.Text = "Archive Holiday";
            this.archiveHoliday.UseVisualStyleBackColor = true;
            // 
            // payroll_holiday_holiday_archive
            // 
            this.payroll_holiday_holiday_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payroll_holiday_holiday_archive.Location = new System.Drawing.Point(6, 6);
            this.payroll_holiday_holiday_archive.Name = "payroll_holiday_holiday_archive";
            this.payroll_holiday_holiday_archive.Size = new System.Drawing.Size(436, 217);
            this.payroll_holiday_holiday_archive.TabIndex = 1;
            // 
            // grpAffected
            // 
            this.grpAffected.Controls.Add(this.panelHoliday);
            this.grpAffected.Location = new System.Drawing.Point(12, 364);
            this.grpAffected.Name = "grpAffected";
            this.grpAffected.Size = new System.Drawing.Size(457, 176);
            this.grpAffected.TabIndex = 7;
            this.grpAffected.TabStop = false;
            this.grpAffected.Text = "Company";
            // 
            // panelHoliday
            // 
            this.panelHoliday.AutoScroll = true;
            this.panelHoliday.Location = new System.Drawing.Point(4, 13);
            this.panelHoliday.Name = "panelHoliday";
            this.panelHoliday.Size = new System.Drawing.Size(449, 157);
            this.panelHoliday.TabIndex = 0;
            // 
            // Holiday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 586);
            this.Controls.Add(this.tabHoliday);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAffected);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblHolidayDate);
            this.Controls.Add(this.payroll_holiday_category);
            this.Controls.Add(this.payroll_holiday_date);
            this.Controls.Add(this.lblHolidayName);
            this.Controls.Add(this.payroll_holiday_name);
            this.Name = "Holiday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday";
            this.Load += new System.EventHandler(this.Holiday_Load);
            this.tabHoliday.ResumeLayout(false);
            this.activeHoliday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_datagrid_holiday_active)).EndInit();
            this.archiveHoliday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payroll_holiday_holiday_archive)).EndInit();
            this.grpAffected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox payroll_holiday_name;
        private System.Windows.Forms.Label lblHolidayName;
        private System.Windows.Forms.DateTimePicker payroll_holiday_date;
        private System.Windows.Forms.ComboBox payroll_holiday_category;
        private System.Windows.Forms.Label lblHolidayDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabHoliday;
        private System.Windows.Forms.TabPage activeHoliday;
        private System.Windows.Forms.DataGridView payroll_datagrid_holiday_active;
        private System.Windows.Forms.TabPage archiveHoliday;
        private System.Windows.Forms.DataGridView payroll_holiday_holiday_archive;
        private System.Windows.Forms.GroupBox grpAffected;
        private System.Windows.Forms.Panel panelHoliday;
    }
}