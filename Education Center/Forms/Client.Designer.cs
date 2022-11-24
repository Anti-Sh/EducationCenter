namespace Education_Center.Forms
{
    partial class Client
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
            this.tcClient = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgFindedClients = new System.Windows.Forms.DataGrid();
            this.lblClientID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhones = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIncomeNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIncomeClientSumm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRealizingNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpRealizedDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRealizedSumm = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.btnRealizedClients = new System.Windows.Forms.Button();
            this.btnCreateClientPayment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgPayments = new System.Windows.Forms.DataGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgClientsRealization = new System.Windows.Forms.DataGrid();
            this.txtIncomeSumm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRealizationSumm = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgClientsGroups = new System.Windows.Forms.DataGrid();
            this.tcClient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFindedClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsRealization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClient
            // 
            this.tcClient.Controls.Add(this.tabPage1);
            this.tcClient.Controls.Add(this.tabPage2);
            this.tcClient.Controls.Add(this.tabPage3);
            this.tcClient.Controls.Add(this.tabPage4);
            this.tcClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcClient.Location = new System.Drawing.Point(0, 0);
            this.tcClient.Name = "tcClient";
            this.tcClient.SelectedIndex = 0;
            this.tcClient.Size = new System.Drawing.Size(624, 459);
            this.tcClient.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectClient);
            this.tabPage1.Controls.Add(this.btnFindClient);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblClientID);
            this.tabPage1.Controls.Add(this.dgFindedClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные клиента";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата и реализация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculate);
            this.tabPage3.Controls.Add(this.txtRealizationSumm);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtIncomeSumm);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Архив";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgClientsGroups);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(616, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Группы клиента";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 34);
            this.panel1.TabIndex = 20;
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
            this.btnOK.Text = "Создать";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dgFindedClients
            // 
            this.dgFindedClients.CaptionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgFindedClients.DataMember = "";
            this.dgFindedClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgFindedClients.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgFindedClients.Location = new System.Drawing.Point(3, 255);
            this.dgFindedClients.Name = "dgFindedClients";
            this.dgFindedClients.Size = new System.Drawing.Size(610, 175);
            this.dgFindedClients.TabIndex = 0;
            // 
            // lblClientID
            // 
            this.lblClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClientID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClientID.Location = new System.Drawing.Point(248, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(128, 20);
            this.lblClientID.TabIndex = 1;
            this.lblClientID.Text = "Новый клиент";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.txtPhones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpRecordDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelectClient.Location = new System.Drawing.Point(533, 227);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(75, 22);
            this.btnSelectClient.TabIndex = 9;
            this.btnSelectClient.Text = "Выбрать";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFindClient.Location = new System.Drawing.Point(449, 227);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 22);
            this.btnFindClient.TabIndex = 8;
            this.btnFindClient.Text = "Найти";
            this.btnFindClient.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFirstName.Location = new System.Drawing.Point(9, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(280, 23);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtLastName.Location = new System.Drawing.Point(9, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(280, 23);
            this.txtLastName.TabIndex = 28;
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фамилия";
            // 
            // dtpRecordDate
            // 
            this.dtpRecordDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRecordDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRecordDate.Location = new System.Drawing.Point(116, 19);
            this.dtpRecordDate.Name = "dtpRecordDate";
            this.dtpRecordDate.Size = new System.Drawing.Size(173, 23);
            this.dtpRecordDate.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Дата записи";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFatherName.Location = new System.Drawing.Point(10, 161);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(279, 23);
            this.txtFatherName.TabIndex = 33;
            this.txtFatherName.Validated += new System.EventHandler(this.txtFatherName_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(325, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Заметки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(325, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Телефоны";
            // 
            // txtPhones
            // 
            this.txtPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPhones.Location = new System.Drawing.Point(328, 42);
            this.txtPhones.Multiline = true;
            this.txtPhones.Name = "txtPhones";
            this.txtPhones.Size = new System.Drawing.Size(249, 61);
            this.txtPhones.TabIndex = 36;
            this.txtPhones.Validated += new System.EventHandler(this.txtPhones_Validated);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNotes.Location = new System.Drawing.Point(328, 126);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(249, 58);
            this.txtNotes.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateClientPayment);
            this.groupBox2.Controls.Add(this.cmbPaymentType);
            this.groupBox2.Controls.Add(this.txtIncomeNotes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIncomeClientSumm);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оплата клиента";
            // 
            // txtIncomeNotes
            // 
            this.txtIncomeNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtIncomeNotes.Location = new System.Drawing.Point(328, 50);
            this.txtIncomeNotes.Multiline = true;
            this.txtIncomeNotes.Name = "txtIncomeNotes";
            this.txtIncomeNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIncomeNotes.Size = new System.Drawing.Size(276, 91);
            this.txtIncomeNotes.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(325, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Заметки";
            // 
            // txtIncomeClientSumm
            // 
            this.txtIncomeClientSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtIncomeClientSumm.Location = new System.Drawing.Point(10, 50);
            this.txtIncomeClientSumm.Name = "txtIncomeClientSumm";
            this.txtIncomeClientSumm.Size = new System.Drawing.Size(280, 23);
            this.txtIncomeClientSumm.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Тип оплаты";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(7, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Сумма";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRealizedClients);
            this.groupBox3.Controls.Add(this.txtRealizingNotes);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtpRealizedDate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtRealizedSumm);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(3, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 229);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Реализация клиента";
            // 
            // txtRealizingNotes
            // 
            this.txtRealizingNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtRealizingNotes.Location = new System.Drawing.Point(328, 53);
            this.txtRealizingNotes.Multiline = true;
            this.txtRealizingNotes.Name = "txtRealizingNotes";
            this.txtRealizingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRealizingNotes.Size = new System.Drawing.Size(276, 86);
            this.txtRealizingNotes.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(325, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Заметки";
            // 
            // dtpRealizedDate
            // 
            this.dtpRealizedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRealizedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpRealizedDate.Location = new System.Drawing.Point(10, 116);
            this.dtpRealizedDate.Name = "dtpRealizedDate";
            this.dtpRealizedDate.Size = new System.Drawing.Size(173, 23);
            this.dtpRealizedDate.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(7, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Дата реализации";
            // 
            // txtRealizedSumm
            // 
            this.txtRealizedSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtRealizedSumm.Location = new System.Drawing.Point(10, 53);
            this.txtRealizedSumm.Name = "txtRealizedSumm";
            this.txtRealizedSumm.Size = new System.Drawing.Size(280, 23);
            this.txtRealizedSumm.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(7, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Сумма";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(10, 115);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(279, 26);
            this.cmbPaymentType.TabIndex = 38;
            // 
            // btnRealizedClients
            // 
            this.btnRealizedClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRealizedClients.Location = new System.Drawing.Point(409, 162);
            this.btnRealizedClients.Name = "btnRealizedClients";
            this.btnRealizedClients.Size = new System.Drawing.Size(115, 24);
            this.btnRealizedClients.TabIndex = 38;
            this.btnRealizedClients.Text = "Реализовать";
            this.btnRealizedClients.UseVisualStyleBackColor = true;
            // 
            // btnCreateClientPayment
            // 
            this.btnCreateClientPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateClientPayment.Location = new System.Drawing.Point(391, 158);
            this.btnCreateClientPayment.Name = "btnCreateClientPayment";
            this.btnCreateClientPayment.Size = new System.Drawing.Size(150, 24);
            this.btnCreateClientPayment.TabIndex = 39;
            this.btnCreateClientPayment.Text = "Произвести оплату";
            this.btnCreateClientPayment.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgClientsRealization);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.dgPayments);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 362);
            this.panel2.TabIndex = 0;
            // 
            // dgPayments
            // 
            this.dgPayments.CaptionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPayments.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dgPayments.CaptionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgPayments.CaptionText = "Приход";
            this.dgPayments.DataMember = "";
            this.dgPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgPayments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPayments.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.dgPayments.Location = new System.Drawing.Point(0, 0);
            this.dgPayments.Name = "dgPayments";
            this.dgPayments.Size = new System.Drawing.Size(616, 188);
            this.dgPayments.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 188);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(616, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dgClientsRealization
            // 
            this.dgClientsRealization.CaptionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgClientsRealization.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dgClientsRealization.CaptionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgClientsRealization.CaptionText = "Реализация клиента";
            this.dgClientsRealization.DataMember = "";
            this.dgClientsRealization.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgClientsRealization.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgClientsRealization.Location = new System.Drawing.Point(0, 191);
            this.dgClientsRealization.Name = "dgClientsRealization";
            this.dgClientsRealization.Size = new System.Drawing.Size(616, 230);
            this.dgClientsRealization.TabIndex = 2;
            // 
            // txtIncomeSumm
            // 
            this.txtIncomeSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtIncomeSumm.Location = new System.Drawing.Point(178, 13);
            this.txtIncomeSumm.Name = "txtIncomeSumm";
            this.txtIncomeSumm.Size = new System.Drawing.Size(280, 23);
            this.txtIncomeSumm.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(76, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Итого приход";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(36, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Итого реализовано";
            // 
            // txtRealizationSumm
            // 
            this.txtRealizationSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtRealizationSumm.Location = new System.Drawing.Point(178, 42);
            this.txtRealizationSumm.Name = "txtRealizationSumm";
            this.txtRealizationSumm.Size = new System.Drawing.Size(280, 23);
            this.txtRealizationSumm.TabIndex = 32;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCalculate.Location = new System.Drawing.Point(506, 27);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 22);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Расчет";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // dgClientsGroups
            // 
            this.dgClientsGroups.CaptionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgClientsGroups.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dgClientsGroups.CaptionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgClientsGroups.CaptionText = "Группы клиента";
            this.dgClientsGroups.DataMember = "";
            this.dgClientsGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClientsGroups.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgClientsGroups.Location = new System.Drawing.Point(0, 0);
            this.dgClientsGroups.Name = "dgClientsGroups";
            this.dgClientsGroups.Size = new System.Drawing.Size(616, 433);
            this.dgClientsGroups.TabIndex = 1;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcClient);
            this.Name = "Client";
            this.Text = "Группа №1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.tcClient.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFindedClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsRealization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClient;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.DataGrid dgFindedClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPhones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRealizedClients;
        private System.Windows.Forms.TextBox txtRealizingNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpRealizedDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRealizedSumm;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateClientPayment;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.TextBox txtIncomeNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIncomeClientSumm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRealizationSumm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIncomeSumm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGrid dgClientsRealization;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGrid dgPayments;
        private System.Windows.Forms.DataGrid dgClientsGroups;
    }
}