namespace Payroll
{
    partial class Deduction
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
            this.tabDeduction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDeductions = new System.Windows.Forms.DataGridView();
            this.dgvArchivedDeductions = new System.Windows.Forms.DataGridView();
            this.btnCreateDeduction = new System.Windows.Forms.Button();
            this.tabDeduction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedDeductions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDeduction
            // 
            this.tabDeduction.Controls.Add(this.tabPage1);
            this.tabDeduction.Controls.Add(this.tabPage2);
            this.tabDeduction.Location = new System.Drawing.Point(12, 59);
            this.tabDeduction.Name = "tabDeduction";
            this.tabDeduction.SelectedIndex = 0;
            this.tabDeduction.Size = new System.Drawing.Size(414, 179);
            this.tabDeduction.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDeductions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Deductions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvArchivedDeductions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archived Deductions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDeductions
            // 
            this.dgvDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeductions.Location = new System.Drawing.Point(0, 0);
            this.dgvDeductions.Name = "dgvDeductions";
            this.dgvDeductions.Size = new System.Drawing.Size(406, 153);
            this.dgvDeductions.TabIndex = 0;
            // 
            // dgvArchivedDeductions
            // 
            this.dgvArchivedDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivedDeductions.Location = new System.Drawing.Point(0, 0);
            this.dgvArchivedDeductions.Name = "dgvArchivedDeductions";
            this.dgvArchivedDeductions.Size = new System.Drawing.Size(406, 153);
            this.dgvArchivedDeductions.TabIndex = 1;
            // 
            // btnCreateDeduction
            // 
            this.btnCreateDeduction.Location = new System.Drawing.Point(318, 30);
            this.btnCreateDeduction.Name = "btnCreateDeduction";
            this.btnCreateDeduction.Size = new System.Drawing.Size(104, 23);
            this.btnCreateDeduction.TabIndex = 2;
            this.btnCreateDeduction.Text = "Create Deduction";
            this.btnCreateDeduction.UseVisualStyleBackColor = true;
            this.btnCreateDeduction.Click += new System.EventHandler(this.btnCreateDeduction_Click);
            // 
            // Deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 288);
            this.Controls.Add(this.btnCreateDeduction);
            this.Controls.Add(this.tabDeduction);
            this.Name = "Deduction";
            this.Text = "Deduction";
            this.tabDeduction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedDeductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeduction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDeductions;
        private System.Windows.Forms.DataGridView dgvArchivedDeductions;
        private System.Windows.Forms.Button btnCreateDeduction;
    }
}