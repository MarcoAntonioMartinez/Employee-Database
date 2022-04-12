namespace Employee_Database_GUI
{
    partial class Form1
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
            this.OptionsListBox = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.EmployeeLbl = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.OptionsLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeptListBox = new System.Windows.Forms.ListBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OptionsListBox
            // 
            this.OptionsListBox.FormattingEnabled = true;
            this.OptionsListBox.Location = new System.Drawing.Point(22, 85);
            this.OptionsListBox.Name = "OptionsListBox";
            this.OptionsListBox.Size = new System.Drawing.Size(215, 82);
            this.OptionsListBox.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(310, 198);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(127, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // EmployeeLbl
            // 
            this.EmployeeLbl.AutoSize = true;
            this.EmployeeLbl.Location = new System.Drawing.Point(260, 69);
            this.EmployeeLbl.Name = "EmployeeLbl";
            this.EmployeeLbl.Size = new System.Drawing.Size(77, 13);
            this.EmployeeLbl.TabIndex = 2;
            this.EmployeeLbl.Text = "Employees List";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(263, 85);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(215, 82);
            this.EmployeeListBox.TabIndex = 0;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // OptionsLbl
            // 
            this.OptionsLbl.AutoSize = true;
            this.OptionsLbl.Location = new System.Drawing.Point(19, 69);
            this.OptionsLbl.Name = "OptionsLbl";
            this.OptionsLbl.Size = new System.Drawing.Size(159, 13);
            this.OptionsLbl.TabIndex = 2;
            this.OptionsLbl.Text = "What would you like to look up?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department List";
            // 
            // DeptListBox
            // 
            this.DeptListBox.FormattingEnabled = true;
            this.DeptListBox.Location = new System.Drawing.Point(512, 85);
            this.DeptListBox.Name = "DeptListBox";
            this.DeptListBox.Size = new System.Drawing.Size(215, 82);
            this.DeptListBox.TabIndex = 0;
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(234, 250);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(287, 160);
            this.ResultListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.OptionsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeLbl);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.DeptListBox);
            this.Controls.Add(this.OptionsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OptionsListBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label EmployeeLbl;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label OptionsLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DeptListBox;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Label label1;
    }
}

