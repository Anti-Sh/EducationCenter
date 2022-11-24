namespace Education_Center.Forms
{
    partial class Direction
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
            this.txtDirectionName = new System.Windows.Forms.TextBox();
            this.lblDirectionName = new System.Windows.Forms.Label();
            this.lblDirectionNote = new System.Windows.Forms.Label();
            this.txtDirectionNote = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirectionName
            // 
            this.txtDirectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDirectionName.Location = new System.Drawing.Point(34, 41);
            this.txtDirectionName.Name = "txtDirectionName";
            this.txtDirectionName.Size = new System.Drawing.Size(359, 23);
            this.txtDirectionName.TabIndex = 0;
            this.txtDirectionName.Validated += new System.EventHandler(this.txtDirectionName_Validated);
            // 
            // lblDirectionName
            // 
            this.lblDirectionName.AutoSize = true;
            this.lblDirectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDirectionName.Location = new System.Drawing.Point(31, 21);
            this.lblDirectionName.Name = "lblDirectionName";
            this.lblDirectionName.Size = new System.Drawing.Size(101, 17);
            this.lblDirectionName.TabIndex = 1;
            this.lblDirectionName.Text = "Направление:";
            // 
            // lblDirectionNote
            // 
            this.lblDirectionNote.AutoSize = true;
            this.lblDirectionNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDirectionNote.Location = new System.Drawing.Point(31, 82);
            this.lblDirectionNote.Name = "lblDirectionNote";
            this.lblDirectionNote.Size = new System.Drawing.Size(78, 17);
            this.lblDirectionNote.TabIndex = 2;
            this.lblDirectionNote.Text = "Описание:";
            // 
            // txtDirectionNote
            // 
            this.txtDirectionNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDirectionNote.Location = new System.Drawing.Point(115, 82);
            this.txtDirectionNote.Multiline = true;
            this.txtDirectionNote.Name = "txtDirectionNote";
            this.txtDirectionNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDirectionNote.Size = new System.Drawing.Size(278, 110);
            this.txtDirectionNote.TabIndex = 3;
            this.txtDirectionNote.Validated += new System.EventHandler(this.txtDirectionNote_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(234, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(318, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cansel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Direction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 232);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDirectionNote);
            this.Controls.Add(this.lblDirectionNote);
            this.Controls.Add(this.lblDirectionName);
            this.Controls.Add(this.txtDirectionName);
            this.Name = "Direction";
            this.Text = "Direction";
            this.Load += new System.EventHandler(this.Direction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectionName;
        private System.Windows.Forms.Label lblDirectionName;
        private System.Windows.Forms.Label lblDirectionNote;
        private System.Windows.Forms.TextBox txtDirectionNote;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}