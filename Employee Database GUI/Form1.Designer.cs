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
            this.submitBtn = new System.Windows.Forms.Button();
            this.EmployeeLbl = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.OptionsLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeptListBox = new System.Windows.Forms.ListBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.editEmpBtn = new System.Windows.Forms.Button();
            this.removeEmpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptionsListBox
            // 
            this.OptionsListBox.FormattingEnabled = true;
            this.OptionsListBox.Location = new System.Drawing.Point(22, 85);
            this.OptionsListBox.Name = "OptionsListBox";
            this.OptionsListBox.Size = new System.Drawing.Size(215, 82);
            this.OptionsListBox.TabIndex = 0;
            this.OptionsListBox.SelectedIndexChanged += new System.EventHandler(this.OptionsListBox_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(512, 199);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
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
            this.OptionsLbl.Location = new System.Drawing.Point(19, 56);
            this.OptionsLbl.Name = "OptionsLbl";
            this.OptionsLbl.Size = new System.Drawing.Size(162, 26);
            this.OptionsLbl.TabIndex = 2;
            this.OptionsLbl.Text = "What would you like to look up? \r\nChoose more than one.";
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
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(22, 199);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(127, 23);
            this.addEmpBtn.TabIndex = 1;
            this.addEmpBtn.Text = "Add an Employee";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            // 
            // editEmpBtn
            // 
            this.editEmpBtn.Location = new System.Drawing.Point(188, 199);
            this.editEmpBtn.Name = "editEmpBtn";
            this.editEmpBtn.Size = new System.Drawing.Size(127, 23);
            this.editEmpBtn.TabIndex = 1;
            this.editEmpBtn.Text = "Edit an Employee";
            this.editEmpBtn.UseVisualStyleBackColor = true;
            // 
            // removeEmpBtn
            // 
            this.removeEmpBtn.Location = new System.Drawing.Point(363, 199);
            this.removeEmpBtn.Name = "removeEmpBtn";
            this.removeEmpBtn.Size = new System.Drawing.Size(127, 23);
            this.removeEmpBtn.TabIndex = 1;
            this.removeEmpBtn.Text = "Remove an Employee";
            this.removeEmpBtn.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.removeEmpBtn);
            this.Controls.Add(this.editEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.DeptListBox);
            this.Controls.Add(this.OptionsListBox);
            this.Name = "Form1";
            this.Text = "Employee Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OptionsListBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label EmployeeLbl;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label OptionsLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DeptListBox;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button editEmpBtn;
        private System.Windows.Forms.Button removeEmpBtn;
    }
}

