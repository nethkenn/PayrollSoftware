namespace Payroll
{
    partial class ShiftTemplate
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShifttemplate = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_payroll_shift_template_active = new System.Windows.Forms.DataGridView();
            this.dgv_payroll_shifttemplate_archived = new System.Windows.Forms.DataGridView();
            this.btnCreateTemplateShift = new System.Windows.Forms.Button();
            this.btn_importTimeSheet_shift = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabShifttemplate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_shift_template_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_shifttemplate_archived)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShifttemplate);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabShifttemplate
            // 
            this.tabShifttemplate.Controls.Add(this.dgv_payroll_shift_template_active);
            this.tabShifttemplate.Location = new System.Drawing.Point(4, 22);
            this.tabShifttemplate.Name = "tabShifttemplate";
            this.tabShifttemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabShifttemplate.Size = new System.Drawing.Size(761, 287);
            this.tabShifttemplate.TabIndex = 0;
            this.tabShifttemplate.Text = "Active Template";
            this.tabShifttemplate.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_payroll_shifttemplate_archived);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archived";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_payroll_shift_template_active
            // 
            this.dgv_payroll_shift_template_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_shift_template_active.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_shift_template_active.Name = "dgv_payroll_shift_template_active";
            this.dgv_payroll_shift_template_active.Size = new System.Drawing.Size(761, 287);
            this.dgv_payroll_shift_template_active.TabIndex = 0;
            // 
            // dgv_payroll_shifttemplate_archived
            // 
            this.dgv_payroll_shifttemplate_archived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payroll_shifttemplate_archived.Location = new System.Drawing.Point(0, 0);
            this.dgv_payroll_shifttemplate_archived.Name = "dgv_payroll_shifttemplate_archived";
            this.dgv_payroll_shifttemplate_archived.Size = new System.Drawing.Size(761, 287);
            this.dgv_payroll_shifttemplate_archived.TabIndex = 0;
            // 
            // btnCreateTemplateShift
            // 
            this.btnCreateTemplateShift.Location = new System.Drawing.Point(581, 21);
            this.btnCreateTemplateShift.Name = "btnCreateTemplateShift";
            this.btnCreateTemplateShift.Size = new System.Drawing.Size(93, 23);
            this.btnCreateTemplateShift.TabIndex = 1;
            this.btnCreateTemplateShift.Text = "Create Template";
            this.btnCreateTemplateShift.UseVisualStyleBackColor = true;
            // 
            // btn_importTimeSheet_shift
            // 
            this.btn_importTimeSheet_shift.Location = new System.Drawing.Point(680, 21);
            this.btn_importTimeSheet_shift.Name = "btn_importTimeSheet_shift";
            this.btn_importTimeSheet_shift.Size = new System.Drawing.Size(111, 23);
            this.btn_importTimeSheet_shift.TabIndex = 2;
            this.btn_importTimeSheet_shift.Text = "Import Time Sheet";
            this.btn_importTimeSheet_shift.UseVisualStyleBackColor = true;
            // 
            // ShiftTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 362);
            this.Controls.Add(this.btn_importTimeSheet_shift);
            this.Controls.Add(this.btnCreateTemplateShift);
            this.Controls.Add(this.tabControl1);
            this.Name = "ShiftTemplate";
            this.Text = "ShiftTemplate";
            this.tabControl1.ResumeLayout(false);
            this.tabShifttemplate.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_shift_template_active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payroll_shifttemplate_archived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShifttemplate;
        private System.Windows.Forms.DataGridView dgv_payroll_shift_template_active;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_payroll_shifttemplate_archived;
        private System.Windows.Forms.Button btnCreateTemplateShift;
        private System.Windows.Forms.Button btn_importTimeSheet_shift;
    }
}