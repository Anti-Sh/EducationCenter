namespace Education_Center.Forms
{
    partial class PaymentType
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
            this.dgPaymentType = new System.Windows.Forms.DataGridView();
            this.payment_typeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 34);
            this.panel1.TabIndex = 21;
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgPaymentType
            // 
            this.dgPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment_typeID,
            this.payment_typeName,
            this.note});
            this.dgPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPaymentType.Location = new System.Drawing.Point(0, 0);
            this.dgPaymentType.Name = "dgPaymentType";
            this.dgPaymentType.Size = new System.Drawing.Size(624, 252);
            this.dgPaymentType.TabIndex = 22;
            this.dgPaymentType.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgPaymentType_DefaultValuesNeeded);
            this.dgPaymentType.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPaymentType_RowValidating);
            this.dgPaymentType.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgPaymentType_UserAddedRow);
            // 
            // payment_typeID
            // 
            this.payment_typeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.payment_typeID.DefaultCellStyle = dataGridViewCellStyle1;
            this.payment_typeID.HeaderText = "ID";
            this.payment_typeID.Name = "payment_typeID";
            this.payment_typeID.ReadOnly = true;
            this.payment_typeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.payment_typeID.Width = 24;
            // 
            // payment_typeName
            // 
            this.payment_typeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment_typeName.HeaderText = "Name";
            this.payment_typeName.Name = "payment_typeName";
            this.payment_typeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.note.Width = 36;
            // 
            // PaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 286);
            this.Controls.Add(this.dgPaymentType);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentType";
            this.Text = "PaymentType";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_typeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}