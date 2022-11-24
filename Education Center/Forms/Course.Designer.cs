namespace Education_Center.Forms
{
    partial class Course
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtCoursePrice = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(342, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cansel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(342, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblClientID
            // 
            this.lblClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClientID.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblClientID.Location = new System.Drawing.Point(162, 9);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(82, 20);
            this.lblClientID.TabIndex = 30;
            this.lblClientID.Text = "Курс № 1";
            // 
            // txtCoursePrice
            // 
            this.txtCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCoursePrice.Location = new System.Drawing.Point(12, 120);
            this.txtCoursePrice.Name = "txtCoursePrice";
            this.txtCoursePrice.Size = new System.Drawing.Size(280, 23);
            this.txtCoursePrice.TabIndex = 34;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCourseName.Location = new System.Drawing.Point(12, 60);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(280, 23);
            this.txtCourseName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Наименование курса";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 182);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txtCoursePrice);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Course";
            this.Text = "Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtCoursePrice;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}