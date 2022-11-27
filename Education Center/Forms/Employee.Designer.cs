namespace Education_Center.Forms
{
    partial class Employee
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
            this.txtEmployeeFatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDirections = new System.Windows.Forms.ComboBox();
            this.txtEmployeeNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeFatherName
            // 
            this.txtEmployeeFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmployeeFatherName.Location = new System.Drawing.Point(13, 122);
            this.txtEmployeeFatherName.Name = "txtEmployeeFatherName";
            this.txtEmployeeFatherName.Size = new System.Drawing.Size(187, 23);
            this.txtEmployeeFatherName.TabIndex = 39;
            this.txtEmployeeFatherName.Validated += new System.EventHandler(this.txtEmployeeFatherName_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Отчество";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(12, 76);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(188, 23);
            this.txtEmployeeFirstName.TabIndex = 37;
            this.txtEmployeeFirstName.Validated += new System.EventHandler(this.txtEmployeeFirstName_Validated);
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmployeeLastName.Location = new System.Drawing.Point(12, 30);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(188, 23);
            this.txtEmployeeLastName.TabIndex = 36;
            this.txtEmployeeLastName.Validated += new System.EventHandler(this.txtEmployeeLastName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Фамилия";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpBirthDay.Location = new System.Drawing.Point(12, 168);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(188, 23);
            this.dtpBirthDay.TabIndex = 41;
            this.dtpBirthDay.Validated += new System.EventHandler(this.dtpBirthDay_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "День рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(9, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Направление";
            // 
            // cmbDirections
            // 
            this.cmbDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbDirections.FormattingEnabled = true;
            this.cmbDirections.Location = new System.Drawing.Point(12, 215);
            this.cmbDirections.Name = "cmbDirections";
            this.cmbDirections.Size = new System.Drawing.Size(188, 25);
            this.cmbDirections.TabIndex = 43;
            this.cmbDirections.Validated += new System.EventHandler(this.cmbDirections_Validated);
            // 
            // txtEmployeeNotes
            // 
            this.txtEmployeeNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmployeeNotes.Location = new System.Drawing.Point(12, 263);
            this.txtEmployeeNotes.Multiline = true;
            this.txtEmployeeNotes.Name = "txtEmployeeNotes";
            this.txtEmployeeNotes.Size = new System.Drawing.Size(187, 61);
            this.txtEmployeeNotes.TabIndex = 45;
            this.txtEmployeeNotes.Validated += new System.EventHandler(this.txtEmployeeNotes_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(10, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Контакты";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNext.Location = new System.Drawing.Point(112, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 26);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = "Вперед";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrev.Location = new System.Drawing.Point(6, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(69, 26);
            this.btnPrev.TabIndex = 46;
            this.btnPrev.Text = "Назад";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 47);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(135, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cansel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(54, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.LastName,
            this.FirstName,
            this.FatherName,
            this.linkData,
            this.birthDay,
            this.Address,
            this.Notes});
            this.dgEmployees.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgEmployees.Location = new System.Drawing.Point(216, 0);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployees.Size = new System.Drawing.Size(584, 450);
            this.dgEmployees.TabIndex = 51;
            this.dgEmployees.SelectionChanged += new System.EventHandler(this.dgEmployees_SelectionChanged);
            // 
            // employeeID
            // 
            this.employeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.employeeID.HeaderText = "ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeID.Width = 24;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastName.Width = 62;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FirstName.Width = 35;
            // 
            // FatherName
            // 
            this.FatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FatherName.HeaderText = "Отчество";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FatherName.Width = 60;
            // 
            // linkData
            // 
            this.linkData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.linkData.HeaderText = "Контакты";
            this.linkData.Name = "linkData";
            this.linkData.ReadOnly = true;
            this.linkData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.linkData.Width = 62;
            // 
            // birthDay
            // 
            this.birthDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.birthDay.HeaderText = "День рождения";
            this.birthDay.Name = "birthDay";
            this.birthDay.ReadOnly = true;
            this.birthDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.birthDay.Width = 84;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 44;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Notes.HeaderText = "Заметки";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Notes.Width = 57;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmployeeNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDirections);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeFatherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeFirstName);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Сотрудник";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmployeeFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDirections;
        private System.Windows.Forms.TextBox txtEmployeeNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkData;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}