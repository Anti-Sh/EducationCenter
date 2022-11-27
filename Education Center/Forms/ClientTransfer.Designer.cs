namespace Education_Center.Forms
{
    partial class ClientTransfer
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
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtAccountSumm = new System.Windows.Forms.TextBox();
            this.txtNewCoursePrice = new System.Windows.Forms.TextBox();
            this.txtDifferenceCount = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountSumma = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblCourseFrom = new System.Windows.Forms.Label();
            this.lblGroupFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblGroupTo = new System.Windows.Forms.Label();
            this.lblOldCourseName = new System.Windows.Forms.Label();
            this.lblNewCourseName = new System.Windows.Forms.Label();
            this.lblNewGroupNumber = new System.Windows.Forms.Label();
            this.lblOldGroupNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgClientPayments = new System.Windows.Forms.DataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtClientName.Location = new System.Drawing.Point(12, 35);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(324, 23);
            this.txtClientName.TabIndex = 1;
            // 
            // txtAccountSumm
            // 
            this.txtAccountSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAccountSumm.Location = new System.Drawing.Point(458, 85);
            this.txtAccountSumm.Name = "txtAccountSumm";
            this.txtAccountSumm.Size = new System.Drawing.Size(154, 23);
            this.txtAccountSumm.TabIndex = 2;
            // 
            // txtNewCoursePrice
            // 
            this.txtNewCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNewCoursePrice.Location = new System.Drawing.Point(458, 35);
            this.txtNewCoursePrice.Name = "txtNewCoursePrice";
            this.txtNewCoursePrice.Size = new System.Drawing.Size(154, 23);
            this.txtNewCoursePrice.TabIndex = 3;
            // 
            // txtDifferenceCount
            // 
            this.txtDifferenceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDifferenceCount.Location = new System.Drawing.Point(458, 132);
            this.txtDifferenceCount.Name = "txtDifferenceCount";
            this.txtDifferenceCount.Size = new System.Drawing.Size(154, 23);
            this.txtDifferenceCount.TabIndex = 4;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblClientName.ForeColor = System.Drawing.Color.Navy;
            this.lblClientName.Location = new System.Drawing.Point(12, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(62, 17);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(455, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость курса";
            // 
            // lblAccountSumma
            // 
            this.lblAccountSumma.AutoSize = true;
            this.lblAccountSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAccountSumma.ForeColor = System.Drawing.Color.Navy;
            this.lblAccountSumma.Location = new System.Drawing.Point(455, 65);
            this.lblAccountSumma.Name = "lblAccountSumma";
            this.lblAccountSumma.Size = new System.Drawing.Size(125, 17);
            this.lblAccountSumma.TabIndex = 7;
            this.lblAccountSumma.Text = "Сумма на счету";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDifference.Location = new System.Drawing.Point(455, 112);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(71, 17);
            this.lblDifference.TabIndex = 8;
            this.lblDifference.Text = "Разница";
            // 
            // lblCourseFrom
            // 
            this.lblCourseFrom.AutoSize = true;
            this.lblCourseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourseFrom.ForeColor = System.Drawing.Color.Green;
            this.lblCourseFrom.Location = new System.Drawing.Point(12, 76);
            this.lblCourseFrom.Name = "lblCourseFrom";
            this.lblCourseFrom.Size = new System.Drawing.Size(133, 15);
            this.lblCourseFrom.TabIndex = 9;
            this.lblCourseFrom.Text = "Перевод с курса №";
            // 
            // lblGroupFrom
            // 
            this.lblGroupFrom.AutoSize = true;
            this.lblGroupFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGroupFrom.ForeColor = System.Drawing.Color.Green;
            this.lblGroupFrom.Location = new System.Drawing.Point(190, 76);
            this.lblGroupFrom.Name = "lblGroupFrom";
            this.lblGroupFrom.Size = new System.Drawing.Size(126, 15);
            this.lblGroupFrom.TabIndex = 10;
            this.lblGroupFrom.Text = "Перевод с группы";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.Navy;
            this.lblTo.Location = new System.Drawing.Point(12, 123);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 15);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "Новый курс №";
            // 
            // lblGroupTo
            // 
            this.lblGroupTo.AutoSize = true;
            this.lblGroupTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGroupTo.ForeColor = System.Drawing.Color.Navy;
            this.lblGroupTo.Location = new System.Drawing.Point(190, 123);
            this.lblGroupTo.Name = "lblGroupTo";
            this.lblGroupTo.Size = new System.Drawing.Size(123, 15);
            this.lblGroupTo.TabIndex = 12;
            this.lblGroupTo.Text = "Перевод в группу";
            // 
            // lblOldCourseName
            // 
            this.lblOldCourseName.AutoSize = true;
            this.lblOldCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOldCourseName.ForeColor = System.Drawing.Color.Green;
            this.lblOldCourseName.Location = new System.Drawing.Point(13, 99);
            this.lblOldCourseName.Name = "lblOldCourseName";
            this.lblOldCourseName.Size = new System.Drawing.Size(22, 15);
            this.lblOldCourseName.TabIndex = 13;
            this.lblOldCourseName.Text = "С#";
            // 
            // lblNewCourseName
            // 
            this.lblNewCourseName.AutoSize = true;
            this.lblNewCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewCourseName.ForeColor = System.Drawing.Color.Navy;
            this.lblNewCourseName.Location = new System.Drawing.Point(13, 149);
            this.lblNewCourseName.Name = "lblNewCourseName";
            this.lblNewCourseName.Size = new System.Drawing.Size(22, 15);
            this.lblNewCourseName.TabIndex = 14;
            this.lblNewCourseName.Text = "С#";
            // 
            // lblNewGroupNumber
            // 
            this.lblNewGroupNumber.AutoSize = true;
            this.lblNewGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewGroupNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblNewGroupNumber.Location = new System.Drawing.Point(195, 149);
            this.lblNewGroupNumber.Name = "lblNewGroupNumber";
            this.lblNewGroupNumber.Size = new System.Drawing.Size(14, 15);
            this.lblNewGroupNumber.TabIndex = 15;
            this.lblNewGroupNumber.Text = "2";
            // 
            // lblOldGroupNumber
            // 
            this.lblOldGroupNumber.AutoSize = true;
            this.lblOldGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOldGroupNumber.ForeColor = System.Drawing.Color.Green;
            this.lblOldGroupNumber.Location = new System.Drawing.Point(195, 99);
            this.lblOldGroupNumber.Name = "lblOldGroupNumber";
            this.lblOldGroupNumber.Size = new System.Drawing.Size(14, 15);
            this.lblOldGroupNumber.TabIndex = 16;
            this.lblOldGroupNumber.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 34);
            this.panel1.TabIndex = 17;
            // 
            // btnCancel
            // 
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
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(453, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dgClientPayments
            // 
            this.dgClientPayments.CaptionBackColor = System.Drawing.Color.OliveDrab;
            this.dgClientPayments.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.dgClientPayments.CaptionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgClientPayments.CaptionText = "Оплаты клиента";
            this.dgClientPayments.DataMember = "";
            this.dgClientPayments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgClientPayments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgClientPayments.Location = new System.Drawing.Point(0, 179);
            this.dgClientPayments.Name = "dgClientPayments";
            this.dgClientPayments.Size = new System.Drawing.Size(624, 241);
            this.dgClientPayments.TabIndex = 18;
            // 
            // ClientTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.dgClientPayments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOldGroupNumber);
            this.Controls.Add(this.lblNewGroupNumber);
            this.Controls.Add(this.lblNewCourseName);
            this.Controls.Add(this.lblOldCourseName);
            this.Controls.Add(this.lblGroupTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblGroupFrom);
            this.Controls.Add(this.lblCourseFrom);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.lblAccountSumma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtDifferenceCount);
            this.Controls.Add(this.txtNewCoursePrice);
            this.Controls.Add(this.txtAccountSumm);
            this.Controls.Add(this.txtClientName);
            this.Name = "ClientTransfer";
            this.Text = "ClientTransfer";
            this.Load += new System.EventHandler(this.ClientTransfer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountSumma;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblCourseFrom;
        private System.Windows.Forms.Label lblGroupFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblGroupTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtClientName;
        public System.Windows.Forms.TextBox txtAccountSumm;
        public System.Windows.Forms.TextBox txtNewCoursePrice;
        public System.Windows.Forms.TextBox txtDifferenceCount;
        public System.Windows.Forms.Label lblOldCourseName;
        public System.Windows.Forms.Label lblNewCourseName;
        public System.Windows.Forms.Label lblNewGroupNumber;
        public System.Windows.Forms.Label lblOldGroupNumber;
        internal System.Windows.Forms.DataGrid dgClientPayments;
    }
}