namespace Education_Center.Forms
{
    partial class SearchClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.dtpRecDate = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnGetChanges = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgSearchRez = new System.Windows.Forms.DataGridView();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recorddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRinged = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchRez)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 34);
            this.panel1.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(537, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cansel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(453, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(64, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtLName.Location = new System.Drawing.Point(146, 20);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(249, 23);
            this.txtLName.TabIndex = 24;
            this.txtLName.Validated += new System.EventHandler(this.txtLName_Validated);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFName.Location = new System.Drawing.Point(146, 65);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(249, 23);
            this.txtFName.TabIndex = 25;
            this.txtFName.Validated += new System.EventHandler(this.txtLName_Validated);
            // 
            // dtpRecDate
            // 
            this.dtpRecDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRecDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRecDate.Location = new System.Drawing.Point(146, 110);
            this.dtpRecDate.Name = "dtpRecDate";
            this.dtpRecDate.Size = new System.Drawing.Size(249, 23);
            this.dtpRecDate.TabIndex = 26;
            this.dtpRecDate.Validated += new System.EventHandler(this.txtLName_Validated);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(481, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(116, 26);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "НАЙТИ";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnGetChanges
            // 
            this.btnGetChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetChanges.Location = new System.Drawing.Point(481, 55);
            this.btnGetChanges.Name = "btnGetChanges";
            this.btnGetChanges.Size = new System.Drawing.Size(116, 48);
            this.btnGetChanges.TabIndex = 28;
            this.btnGetChanges.Text = "Внести изменения";
            this.btnGetChanges.UseVisualStyleBackColor = true;
            this.btnGetChanges.Click += new System.EventHandler(this.btnGetChanges_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(481, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 26);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgSearchRez
            // 
            this.dgSearchRez.AllowUserToAddRows = false;
            this.dgSearchRez.AllowUserToDeleteRows = false;
            this.dgSearchRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchRez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientID,
            this.fname,
            this.lname,
            this.fathName,
            this.linkData,
            this.recorddate,
            this.note,
            this.paymentType,
            this.isRinged});
            this.dgSearchRez.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSearchRez.Location = new System.Drawing.Point(0, 141);
            this.dgSearchRez.Name = "dgSearchRez";
            this.dgSearchRez.Size = new System.Drawing.Size(624, 279);
            this.dgSearchRez.TabIndex = 30;
            this.dgSearchRez.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearchRez_RowValidated);
            this.dgSearchRez.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgSearchRez_RowValidating);
            // 
            // clientID
            // 
            this.clientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clientID.HeaderText = "ID";
            this.clientID.Name = "clientID";
            this.clientID.ReadOnly = true;
            this.clientID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clientID.Width = 24;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fname.HeaderText = "Имя";
            this.fname.Name = "fname";
            this.fname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fname.Width = 35;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lname.HeaderText = "Фамилия";
            this.lname.Name = "lname";
            this.lname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lname.Width = 62;
            // 
            // fathName
            // 
            this.fathName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fathName.HeaderText = "Отчество";
            this.fathName.Name = "fathName";
            this.fathName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fathName.Width = 60;
            // 
            // linkData
            // 
            this.linkData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.linkData.HeaderText = "Контактные данные";
            this.linkData.Name = "linkData";
            this.linkData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.linkData.Width = 104;
            // 
            // recorddate
            // 
            this.recorddate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.NullValue = null;
            this.recorddate.DefaultCellStyle = dataGridViewCellStyle1;
            this.recorddate.HeaderText = "Дата записи";
            this.recorddate.Name = "recorddate";
            this.recorddate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recorddate.Width = 70;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.note.HeaderText = "Заметки";
            this.note.Name = "note";
            this.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.note.Width = 57;
            // 
            // paymentType
            // 
            this.paymentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.paymentType.HeaderText = "Вид оплаты";
            this.paymentType.Name = "paymentType";
            this.paymentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentType.Width = 65;
            // 
            // isRinged
            // 
            this.isRinged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isRinged.HeaderText = "Оповещен";
            this.isRinged.Name = "isRinged";
            this.isRinged.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRinged.Width = 66;
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.dgSearchRez);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetChanges);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dtpRecDate);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SearchClient";
            this.Text = "SearchClient";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchRez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.DateTimePicker dtpRecDate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnGetChanges;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgSearchRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkData;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRinged;
    }
}