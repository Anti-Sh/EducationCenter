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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCourses = new System.Windows.Forms.DataGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgGroups = new System.Windows.Forms.DataGrid();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClients = new System.Windows.Forms.RadioButton();
            this.rbGroups = new System.Windows.Forms.RadioButton();
            this.rbCourses = new System.Windows.Forms.RadioButton();
            this.rbDirections = new System.Windows.Forms.RadioButton();
            this.rbGroupClientsMain = new System.Windows.Forms.RadioButton();
            this.rbStatusMain = new System.Windows.Forms.RadioButton();
            this.rbIncomeMain = new System.Windows.Forms.RadioButton();
            this.rbOutMain = new System.Windows.Forms.RadioButton();
            this.rbRealizedTableMain = new System.Windows.Forms.RadioButton();
            this.rbPaymentTypeMain = new System.Windows.Forms.RadioButton();
            this.rbDataMain = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtResultIncome = new System.Windows.Forms.TextBox();
            this.txtResultOut = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtYesterdaySumm = new System.Windows.Forms.TextBox();
            this.txtResultCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPrevDate = new System.Windows.Forms.Button();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.btnShowPaymentTypeForm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgIncome = new System.Windows.Forms.DataGrid();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.dataGrid3 = new System.Windows.Forms.DataGrid();
            this.tcManager.SuspendLayout();
            this.tpWaitingRoom.SuspendLayout();
            this.tpBaseTables.SuspendLayout();
            this.tpPayment.SuspendLayout();
            this.tpWaitingRoomBottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbnRefreshMainDB,
            this.tbnEmployees,
            this.tbnFind});
            this.tbMain.DropDownArrows = true;
            this.tbMain.ImageList = this.imageList1;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.ShowToolTips = true;
            this.tbMain.Size = new System.Drawing.Size(800, 32);
            this.tbMain.TabIndex = 0;
            this.tbMain.Click += new System.EventHandler(this.tbMain_Click);
            // 
            // tbnRefreshMainDB
            // 
            this.tbnRefreshMainDB.ImageIndex = 1;
            this.tbnRefreshMainDB.Name = "tbnRefreshMainDB";
            // 
            // tbnEmployees
            // 
            this.tbnEmployees.ImageIndex = 0;
            this.tbnEmployees.Name = "tbnEmployees";
            // 
            // tbnFind
            // 
            this.tbnFind.ImageIndex = 2;
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
            this.tcManager.Location = new System.Drawing.Point(0, 32);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(800, 418);
            this.tcManager.TabIndex = 1;
            // 
            // tpWaitingRoom
            // 
            this.tpWaitingRoom.Controls.Add(this.panel2);
            this.tpWaitingRoom.Controls.Add(this.panel1);
            this.tpWaitingRoom.Controls.Add(this.tpWaitingRoomBottomPanel);
            this.tpWaitingRoom.Location = new System.Drawing.Point(4, 22);
            this.tpWaitingRoom.Name = "tpWaitingRoom";
            this.tpWaitingRoom.Size = new System.Drawing.Size(792, 392);
            this.tpWaitingRoom.TabIndex = 0;
            this.tpWaitingRoom.Text = "Приемная";
            this.tpWaitingRoom.UseVisualStyleBackColor = true;
            // 
            // tpBaseTables
            // 
            this.tpBaseTables.Controls.Add(this.dataGrid2);
            this.tpBaseTables.Controls.Add(this.panel4);
            this.tpBaseTables.Location = new System.Drawing.Point(4, 22);
            this.tpBaseTables.Name = "tpBaseTables";
            this.tpBaseTables.Size = new System.Drawing.Size(792, 396);
            this.tpBaseTables.TabIndex = 1;
            this.tpBaseTables.Text = "Основные таблицы";
            this.tpBaseTables.UseVisualStyleBackColor = true;
            // 
            // tpPayment
            // 
            this.tpPayment.Controls.Add(this.panel6);
            this.tpPayment.Controls.Add(this.panel5);
            this.tpPayment.Location = new System.Drawing.Point(4, 22);
            this.tpPayment.Name = "tpPayment";
            this.tpPayment.Size = new System.Drawing.Size(792, 392);
            this.tpPayment.TabIndex = 2;
            this.tpPayment.Text = "Оплаты";
            this.tpPayment.UseVisualStyleBackColor = true;
            // 
            // tpExplorer
            // 
            this.tpExplorer.Location = new System.Drawing.Point(4, 22);
            this.tpExplorer.Name = "tpExplorer";
            this.tpExplorer.Size = new System.Drawing.Size(792, 392);
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
            this.tpWaitingRoomBottomPanel.Location = new System.Drawing.Point(0, 355);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.dgCourses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 297);
            this.panel2.TabIndex = 4;
            // 
            // dgCourses
            // 
            this.dgCourses.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgCourses.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgCourses.CaptionText = "Курсы";
            this.dgCourses.DataMember = "";
            this.dgCourses.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgCourses.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.dgCourses.Location = new System.Drawing.Point(0, 0);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.Size = new System.Drawing.Size(130, 297);
            this.dgCourses.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(130, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 297);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid1);
            this.panel3.Controls.Add(this.splitter2);
            this.panel3.Controls.Add(this.dgGroups);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(133, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 297);
            this.panel3.TabIndex = 2;
            // 
            // dgGroups
            // 
            this.dgGroups.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgGroups.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgGroups.CaptionText = "Группы";
            this.dgGroups.DataMember = "";
            this.dgGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgGroups.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.dgGroups.Location = new System.Drawing.Point(0, 0);
            this.dgGroups.Name = "dgGroups";
            this.dgGroups.Size = new System.Drawing.Size(659, 134);
            this.dgGroups.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 134);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(659, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid1.CaptionText = "Клиенты";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 137);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(659, 160);
            this.dataGrid1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(537, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 396);
            this.panel4.TabIndex = 0;
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(0, 0);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(531, 396);
            this.dataGrid2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDataMain);
            this.groupBox1.Controls.Add(this.rbPaymentTypeMain);
            this.groupBox1.Controls.Add(this.rbRealizedTableMain);
            this.groupBox1.Controls.Add(this.rbOutMain);
            this.groupBox1.Controls.Add(this.rbIncomeMain);
            this.groupBox1.Controls.Add(this.rbStatusMain);
            this.groupBox1.Controls.Add(this.rbGroupClientsMain);
            this.groupBox1.Controls.Add(this.rbDirections);
            this.groupBox1.Controls.Add(this.rbCourses);
            this.groupBox1.Controls.Add(this.rbGroups);
            this.groupBox1.Controls.Add(this.rbClients);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная БД";
            // 
            // rbClients
            // 
            this.rbClients.AutoSize = true;
            this.rbClients.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbClients.Location = new System.Drawing.Point(7, 20);
            this.rbClients.Name = "rbClients";
            this.rbClients.Size = new System.Drawing.Size(69, 17);
            this.rbClients.TabIndex = 0;
            this.rbClients.TabStop = true;
            this.rbClients.Text = "Клиенты";
            this.rbClients.UseVisualStyleBackColor = true;
            this.rbClients.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbGroups.Location = new System.Drawing.Point(7, 43);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(62, 17);
            this.rbGroups.TabIndex = 1;
            this.rbGroups.TabStop = true;
            this.rbGroups.Text = "Группы";
            this.rbGroups.UseVisualStyleBackColor = true;
            this.rbGroups.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbCourses
            // 
            this.rbCourses.AutoSize = true;
            this.rbCourses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbCourses.Location = new System.Drawing.Point(7, 66);
            this.rbCourses.Name = "rbCourses";
            this.rbCourses.Size = new System.Drawing.Size(57, 17);
            this.rbCourses.TabIndex = 2;
            this.rbCourses.TabStop = true;
            this.rbCourses.Text = "Курсы";
            this.rbCourses.UseVisualStyleBackColor = true;
            this.rbCourses.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbDirections
            // 
            this.rbDirections.AutoSize = true;
            this.rbDirections.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbDirections.Location = new System.Drawing.Point(7, 89);
            this.rbDirections.Name = "rbDirections";
            this.rbDirections.Size = new System.Drawing.Size(93, 17);
            this.rbDirections.TabIndex = 3;
            this.rbDirections.TabStop = true;
            this.rbDirections.Text = "Направления";
            this.rbDirections.UseVisualStyleBackColor = true;
            this.rbDirections.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbGroupClientsMain
            // 
            this.rbGroupClientsMain.AutoSize = true;
            this.rbGroupClientsMain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbGroupClientsMain.Location = new System.Drawing.Point(7, 112);
            this.rbGroupClientsMain.Name = "rbGroupClientsMain";
            this.rbGroupClientsMain.Size = new System.Drawing.Size(109, 17);
            this.rbGroupClientsMain.TabIndex = 4;
            this.rbGroupClientsMain.TabStop = true;
            this.rbGroupClientsMain.Text = "Группы-Клиенты";
            this.rbGroupClientsMain.UseVisualStyleBackColor = true;
            this.rbGroupClientsMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbStatusMain
            // 
            this.rbStatusMain.AutoSize = true;
            this.rbStatusMain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbStatusMain.Location = new System.Drawing.Point(7, 135);
            this.rbStatusMain.Name = "rbStatusMain";
            this.rbStatusMain.Size = new System.Drawing.Size(106, 17);
            this.rbStatusMain.TabIndex = 5;
            this.rbStatusMain.TabStop = true;
            this.rbStatusMain.Text = "Статусы группы";
            this.rbStatusMain.UseVisualStyleBackColor = true;
            this.rbStatusMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbIncomeMain
            // 
            this.rbIncomeMain.AutoSize = true;
            this.rbIncomeMain.ForeColor = System.Drawing.Color.Green;
            this.rbIncomeMain.Location = new System.Drawing.Point(128, 20);
            this.rbIncomeMain.Name = "rbIncomeMain";
            this.rbIncomeMain.Size = new System.Drawing.Size(70, 17);
            this.rbIncomeMain.TabIndex = 6;
            this.rbIncomeMain.TabStop = true;
            this.rbIncomeMain.Text = "Приходы";
            this.rbIncomeMain.UseVisualStyleBackColor = true;
            this.rbIncomeMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbOutMain
            // 
            this.rbOutMain.AutoSize = true;
            this.rbOutMain.ForeColor = System.Drawing.Color.Green;
            this.rbOutMain.Location = new System.Drawing.Point(128, 43);
            this.rbOutMain.Name = "rbOutMain";
            this.rbOutMain.Size = new System.Drawing.Size(69, 17);
            this.rbOutMain.TabIndex = 7;
            this.rbOutMain.TabStop = true;
            this.rbOutMain.Text = "Расходы";
            this.rbOutMain.UseVisualStyleBackColor = true;
            this.rbOutMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbRealizedTableMain
            // 
            this.rbRealizedTableMain.AutoSize = true;
            this.rbRealizedTableMain.ForeColor = System.Drawing.Color.Green;
            this.rbRealizedTableMain.Location = new System.Drawing.Point(128, 66);
            this.rbRealizedTableMain.Name = "rbRealizedTableMain";
            this.rbRealizedTableMain.Size = new System.Drawing.Size(86, 17);
            this.rbRealizedTableMain.TabIndex = 8;
            this.rbRealizedTableMain.TabStop = true;
            this.rbRealizedTableMain.Text = "Реализация";
            this.rbRealizedTableMain.UseVisualStyleBackColor = true;
            this.rbRealizedTableMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbPaymentTypeMain
            // 
            this.rbPaymentTypeMain.AutoSize = true;
            this.rbPaymentTypeMain.ForeColor = System.Drawing.Color.Green;
            this.rbPaymentTypeMain.Location = new System.Drawing.Point(128, 89);
            this.rbPaymentTypeMain.Name = "rbPaymentTypeMain";
            this.rbPaymentTypeMain.Size = new System.Drawing.Size(84, 17);
            this.rbPaymentTypeMain.TabIndex = 9;
            this.rbPaymentTypeMain.TabStop = true;
            this.rbPaymentTypeMain.Text = "Виды оплат";
            this.rbPaymentTypeMain.UseVisualStyleBackColor = true;
            this.rbPaymentTypeMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // rbDataMain
            // 
            this.rbDataMain.AutoSize = true;
            this.rbDataMain.ForeColor = System.Drawing.Color.Green;
            this.rbDataMain.Location = new System.Drawing.Point(128, 112);
            this.rbDataMain.Name = "rbDataMain";
            this.rbDataMain.Size = new System.Drawing.Size(66, 17);
            this.rbDataMain.TabIndex = 10;
            this.rbDataMain.TabStop = true;
            this.rbDataMain.Text = "Данные";
            this.rbDataMain.UseVisualStyleBackColor = true;
            this.rbDataMain.CheckedChanged += new System.EventHandler(this.rbClients_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "employee.png");
            this.imageList1.Images.SetKeyName(1, "refresh.png");
            this.imageList1.Images.SetKeyName(2, "search.png");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnShowPaymentTypeForm);
            this.panel5.Controls.Add(this.btnNextDate);
            this.panel5.Controls.Add(this.btnPrevDate);
            this.panel5.Controls.Add(this.btnCalculate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtResultCount);
            this.panel5.Controls.Add(this.txtYesterdaySumm);
            this.panel5.Controls.Add(this.txtBalance);
            this.panel5.Controls.Add(this.txtResultOut);
            this.panel5.Controls.Add(this.txtResultIncome);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 307);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 85);
            this.panel5.TabIndex = 0;
            // 
            // txtResultIncome
            // 
            this.txtResultIncome.Location = new System.Drawing.Point(9, 49);
            this.txtResultIncome.Name = "txtResultIncome";
            this.txtResultIncome.Size = new System.Drawing.Size(100, 20);
            this.txtResultIncome.TabIndex = 0;
            // 
            // txtResultOut
            // 
            this.txtResultOut.Location = new System.Drawing.Point(115, 49);
            this.txtResultOut.Name = "txtResultOut";
            this.txtResultOut.Size = new System.Drawing.Size(100, 20);
            this.txtResultOut.TabIndex = 1;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(221, 49);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 2;
            // 
            // txtYesterdaySumm
            // 
            this.txtYesterdaySumm.Location = new System.Drawing.Point(327, 49);
            this.txtYesterdaySumm.Name = "txtYesterdaySumm";
            this.txtYesterdaySumm.Size = new System.Drawing.Size(100, 20);
            this.txtYesterdaySumm.TabIndex = 3;
            // 
            // txtResultCount
            // 
            this.txtResultCount.Location = new System.Drawing.Point(433, 49);
            this.txtResultCount.Name = "txtResultCount";
            this.txtResultCount.Size = new System.Drawing.Size(100, 20);
            this.txtResultCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Итого приход:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(112, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Итого расход:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(218, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Баланс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(327, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вчера:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(430, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Всего:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Green;
            this.btnCalculate.Location = new System.Drawing.Point(549, 47);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Расчёт";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPrevDate
            // 
            this.btnPrevDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPrevDate.Location = new System.Drawing.Point(608, 8);
            this.btnPrevDate.Name = "btnPrevDate";
            this.btnPrevDate.Size = new System.Drawing.Size(33, 26);
            this.btnPrevDate.TabIndex = 11;
            this.btnPrevDate.Text = "🡸";
            this.btnPrevDate.UseVisualStyleBackColor = true;
            this.btnPrevDate.Click += new System.EventHandler(this.btnPrevDate_Click);
            // 
            // btnNextDate
            // 
            this.btnNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNextDate.Location = new System.Drawing.Point(647, 8);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(33, 26);
            this.btnNextDate.TabIndex = 12;
            this.btnNextDate.Text = "🡺";
            this.btnNextDate.UseVisualStyleBackColor = true;
            this.btnNextDate.Click += new System.EventHandler(this.btnNextDate_Click);
            // 
            // btnShowPaymentTypeForm
            // 
            this.btnShowPaymentTypeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnShowPaymentTypeForm.ForeColor = System.Drawing.Color.Navy;
            this.btnShowPaymentTypeForm.Location = new System.Drawing.Point(699, 8);
            this.btnShowPaymentTypeForm.Name = "btnShowPaymentTypeForm";
            this.btnShowPaymentTypeForm.Size = new System.Drawing.Size(75, 26);
            this.btnShowPaymentTypeForm.TabIndex = 13;
            this.btnShowPaymentTypeForm.Text = "Оплаты";
            this.btnShowPaymentTypeForm.UseVisualStyleBackColor = true;
            this.btnShowPaymentTypeForm.Click += new System.EventHandler(this.btnShowPaymentTypeForm_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGrid3);
            this.panel6.Controls.Add(this.splitter3);
            this.panel6.Controls.Add(this.dgIncome);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(792, 307);
            this.panel6.TabIndex = 1;
            // 
            // dgIncome
            // 
            this.dgIncome.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dgIncome.CaptionForeColor = System.Drawing.Color.Green;
            this.dgIncome.CaptionText = "Приход";
            this.dgIncome.DataMember = "";
            this.dgIncome.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgIncome.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgIncome.Location = new System.Drawing.Point(0, 0);
            this.dgIncome.Name = "dgIncome";
            this.dgIncome.Size = new System.Drawing.Size(344, 307);
            this.dgIncome.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(344, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 307);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // dataGrid3
            // 
            this.dataGrid3.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dataGrid3.CaptionForeColor = System.Drawing.Color.Green;
            this.dataGrid3.CaptionText = "Расход";
            this.dataGrid3.DataMember = "";
            this.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid3.Location = new System.Drawing.Point(347, 0);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.Size = new System.Drawing.Size(445, 307);
            this.dataGrid3.TabIndex = 2;
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
            this.tpBaseTables.ResumeLayout(false);
            this.tpPayment.ResumeLayout(false);
            this.tpWaitingRoomBottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGrid dgGroups;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGrid dgCourses;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDataMain;
        private System.Windows.Forms.RadioButton rbPaymentTypeMain;
        private System.Windows.Forms.RadioButton rbRealizedTableMain;
        private System.Windows.Forms.RadioButton rbOutMain;
        private System.Windows.Forms.RadioButton rbIncomeMain;
        private System.Windows.Forms.RadioButton rbStatusMain;
        private System.Windows.Forms.RadioButton rbGroupClientsMain;
        private System.Windows.Forms.RadioButton rbDirections;
        private System.Windows.Forms.RadioButton rbCourses;
        private System.Windows.Forms.RadioButton rbGroups;
        private System.Windows.Forms.RadioButton rbClients;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultCount;
        private System.Windows.Forms.TextBox txtYesterdaySumm;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtResultOut;
        private System.Windows.Forms.TextBox txtResultIncome;
        private System.Windows.Forms.Button btnShowPaymentTypeForm;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPrevDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGrid dgIncome;
        private System.Windows.Forms.DataGrid dataGrid3;
        private System.Windows.Forms.Splitter splitter3;
    }
}