namespace Education_Center.Forms
{
    partial class Manager
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
            this.tbMain = new System.Windows.Forms.ToolBar();
            this.tbnRefreshMainDB = new System.Windows.Forms.ToolBarButton();
            this.tbnEmployees = new System.Windows.Forms.ToolBarButton();
            this.tbnFind = new System.Windows.Forms.ToolBarButton();
            this.tcManager = new System.Windows.Forms.TabControl();
            this.tpWaitingRoom = new System.Windows.Forms.TabPage();
            this.tpBaseTables = new System.Windows.Forms.TabPage();
            this.tpPayment = new System.Windows.Forms.TabPage();
            this.tpExplorer = new System.Windows.Forms.TabPage();
            this.tpStatistic = new System.Windows.Forms.TabPage();
            this.tpWaitingRoomBottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDirections = new System.Windows.Forms.ComboBox();
            this.cmbGroupStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowGroups = new System.Windows.Forms.Button();
            this.tcManager.SuspendLayout();
            this.tpWaitingRoom.SuspendLayout();
            this.tpWaitingRoomBottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbnRefreshMainDB,
            this.tbnEmployees,
            this.tbnFind});
            this.tbMain.DropDownArrows = true;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.ShowToolTips = true;
            this.tbMain.Size = new System.Drawing.Size(800, 28);
            this.tbMain.TabIndex = 0;
            this.tbMain.Click += new System.EventHandler(this.tbMain_Click);
            // 
            // tbnRefreshMainDB
            // 
            this.tbnRefreshMainDB.Name = "tbnRefreshMainDB";
            // 
            // tbnEmployees
            // 
            this.tbnEmployees.Name = "tbnEmployees";
            // 
            // tbnFind
            // 
            this.tbnFind.Name = "tbnFind";
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpWaitingRoom);
            this.tcManager.Controls.Add(this.tpBaseTables);
            this.tcManager.Controls.Add(this.tpPayment);
            this.tcManager.Controls.Add(this.tpExplorer);
            this.tcManager.Controls.Add(this.tpStatistic);
            this.tcManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManager.Location = new System.Drawing.Point(0, 28);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(800, 422);
            this.tcManager.TabIndex = 1;
            // 
            // tpWaitingRoom
            // 
            this.tpWaitingRoom.Controls.Add(this.panel1);
            this.tpWaitingRoom.Controls.Add(this.tpWaitingRoomBottomPanel);
            this.tpWaitingRoom.Location = new System.Drawing.Point(4, 22);
            this.tpWaitingRoom.Name = "tpWaitingRoom";
            this.tpWaitingRoom.Size = new System.Drawing.Size(792, 396);
            this.tpWaitingRoom.TabIndex = 0;
            this.tpWaitingRoom.Text = "Приемная";
            this.tpWaitingRoom.UseVisualStyleBackColor = true;
            // 
            // tpBaseTables
            // 
            this.tpBaseTables.Location = new System.Drawing.Point(4, 22);
            this.tpBaseTables.Name = "tpBaseTables";
            this.tpBaseTables.Size = new System.Drawing.Size(792, 396);
            this.tpBaseTables.TabIndex = 1;
            this.tpBaseTables.Text = "Основные таблицы";
            this.tpBaseTables.UseVisualStyleBackColor = true;
            // 
            // tpPayment
            // 
            this.tpPayment.Location = new System.Drawing.Point(4, 22);
            this.tpPayment.Name = "tpPayment";
            this.tpPayment.Size = new System.Drawing.Size(792, 396);
            this.tpPayment.TabIndex = 2;
            this.tpPayment.Text = "Оплаты";
            this.tpPayment.UseVisualStyleBackColor = true;
            // 
            // tpExplorer
            // 
            this.tpExplorer.Location = new System.Drawing.Point(4, 22);
            this.tpExplorer.Name = "tpExplorer";
            this.tpExplorer.Size = new System.Drawing.Size(792, 396);
            this.tpExplorer.TabIndex = 3;
            this.tpExplorer.Text = "Проводник";
            this.tpExplorer.UseVisualStyleBackColor = true;
            // 
            // tpStatistic
            // 
            this.tpStatistic.Location = new System.Drawing.Point(4, 22);
            this.tpStatistic.Name = "tpStatistic";
            this.tpStatistic.Size = new System.Drawing.Size(792, 396);
            this.tpStatistic.TabIndex = 4;
            this.tpStatistic.Text = "Статистика";
            this.tpStatistic.UseVisualStyleBackColor = true;
            // 
            // tpWaitingRoomBottomPanel
            // 
            this.tpWaitingRoomBottomPanel.Controls.Add(this.btnCreateGroup);
            this.tpWaitingRoomBottomPanel.Controls.Add(this.btnDeleteGroup);
            this.tpWaitingRoomBottomPanel.Controls.Add(this.btnCreateClient);
            this.tpWaitingRoomBottomPanel.Controls.Add(this.btnDeleteClient);
            this.tpWaitingRoomBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpWaitingRoomBottomPanel.Location = new System.Drawing.Point(0, 359);
            this.tpWaitingRoomBottomPanel.Name = "tpWaitingRoomBottomPanel";
            this.tpWaitingRoomBottomPanel.Size = new System.Drawing.Size(792, 37);
            this.tpWaitingRoomBottomPanel.TabIndex = 2;
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCreateGroup.Location = new System.Drawing.Point(3, 3);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(118, 26);
            this.btnCreateGroup.TabIndex = 0;
            this.btnCreateGroup.Text = "Создать группу";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDeleteGroup.Location = new System.Drawing.Point(127, 3);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(104, 26);
            this.btnDeleteGroup.TabIndex = 1;
            this.btnDeleteGroup.Text = "Удалить группу";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCreateClient.Location = new System.Drawing.Point(237, 3);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(112, 26);
            this.btnCreateClient.TabIndex = 2;
            this.btnCreateClient.Text = "Создать клиента";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDeleteClient.Location = new System.Drawing.Point(355, 3);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(109, 26);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowGroups);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbGroupStatus);
            this.panel1.Controls.Add(this.cmbDirections);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 58);
            this.panel1.TabIndex = 3;
            // 
            // cmbDirections
            // 
            this.cmbDirections.FormattingEnabled = true;
            this.cmbDirections.Location = new System.Drawing.Point(24, 34);
            this.cmbDirections.Name = "cmbDirections";
            this.cmbDirections.Size = new System.Drawing.Size(286, 21);
            this.cmbDirections.TabIndex = 0;
            this.cmbDirections.SelectionChangeCommitted += new System.EventHandler(this.cmbDirections_SelectionChangeCommitted);
            // 
            // cmbGroupStatus
            // 
            this.cmbGroupStatus.FormattingEnabled = true;
            this.cmbGroupStatus.Location = new System.Drawing.Point(332, 34);
            this.cmbGroupStatus.Name = "cmbGroupStatus";
            this.cmbGroupStatus.Size = new System.Drawing.Size(286, 21);
            this.cmbGroupStatus.TabIndex = 1;
            this.cmbGroupStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbGroupStatus_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(328, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отображаемые группы";
            // 
            // btnShowGroups
            // 
            this.btnShowGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnShowGroups.Location = new System.Drawing.Point(653, 24);
            this.btnShowGroups.Name = "btnShowGroups";
            this.btnShowGroups.Size = new System.Drawing.Size(131, 31);
            this.btnShowGroups.TabIndex = 4;
            this.btnShowGroups.Text = "Показать";
            this.btnShowGroups.UseVisualStyleBackColor = true;
            this.btnShowGroups.Click += new System.EventHandler(this.btnShowGroups_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcManager);
            this.Controls.Add(this.tbMain);
            this.Name = "Manager";
            this.Text = "Education Center";
            this.tcManager.ResumeLayout(false);
            this.tpWaitingRoom.ResumeLayout(false);
            this.tpWaitingRoomBottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar tbMain;
        private System.Windows.Forms.ToolBarButton tbnRefreshMainDB;
        private System.Windows.Forms.ToolBarButton tbnEmployees;
        private System.Windows.Forms.ToolBarButton tbnFind;
        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpWaitingRoom;
        private System.Windows.Forms.FlowLayoutPanel tpWaitingRoomBottomPanel;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.TabPage tpBaseTables;
        private System.Windows.Forms.TabPage tpPayment;
        private System.Windows.Forms.TabPage tpExplorer;
        private System.Windows.Forms.TabPage tpStatistic;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroupStatus;
        private System.Windows.Forms.ComboBox cmbDirections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowGroups;
    }
}