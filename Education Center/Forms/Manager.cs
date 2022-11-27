using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education_Center.Classes;
using System.Xml.Linq;
using System.Data.SqlTypes;

namespace Education_Center.Forms
{
    public partial class Manager : Form
    {
        #region Construct

        private ContextMenu cmGroups;


        #endregion
        #region Атрибуты

        Dictionary<string, string> rbs = new Dictionary<string, string>
        {
            { "Клиенты", "clients" },
            { "Группы", "groups" },
            { "Курсы", "course" },
            { "Направления", "directions" },
            { "Группы-Клиенты", "group_clients" },
            { "Статусы группы", "GroupStatus" },
            { "Приходы", "income" },
            { "Расходы", "expenses" },
            { "Реализация", "RealizedTable" },
            { "Виды оплат", "payment_type" },
            { "Данные", "data" },
        };
        private bool isEdited = false;
        public bool IsEdited
        {
            get { return isEdited; }
            set { isEdited = value; }
        }
        
        #endregion

        #region Глобальные поля
        static private int dataID = 0;
        static internal int DataID
        {
            get { return dataID; }
            set { dataID = value; }
        }
        private int currentDataID;
        private DataTable dtWorkTable; // для записи в файл XML

        private bool Connected = false; // Показывает, есть ли соединение с сервером
        private object server;
        private Type type;

        private TreeNode selectedNode;
        private string selectedNodeName = "";
        //private TreeNodeType treeNodeType;
        private TreeNode MainTreeNode = null;
        //private DirectionTreeNode[] dtns = null;

        private Color itemColor;
        private Label labelSelectedListViewItem = new Label(); // Перемещаемый item в виде Label
        private Point NodePoint;
        private Point ClientPoint; // относительные координаты labelSelectedListViewItem
        private bool ItemCanMove = false;
        //private CustomListItem selectedItem; // Выбранный item на ListView проводника

        private CurrencyManager currManagerIncome;
        private CurrencyManager currManagerOut;
        private CurrencyManager currManagerPaymentType;
        private CurrencyManager currManagerTotal;

        internal static bool flashAttached = false;
        //internal frmAuthorization.UserGroup userGroup;
        private bool SelectingClient = false; // Можно ли выбирать клиента

        #endregion

        public Manager()
        {
            InitializeComponent();
            DesigneDataGrids();
            MySQL.OpenConnection();
            FillOnLoad();
            FillPaymentsPage();
            MySQL.ExecuteQueryWithoutResponse("set autocommit=0;start transaction;");
            Closing += new CancelEventHandler(Manager_Closing);
        }

        void Manager_Closing(object sender, CancelEventArgs e)
        {
            string query = "rollback;set autocommit=0;start transaction;";
            if (isEdited)
                if (MessageBox.Show("Вы хотите сохранить изменения в Базе Данных?", "Образовательный центр", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    query = "commit;set autocommit=0;start transaction;";
            MySQL.ExecuteQueryWithoutResponse(query);

            if (MessageBox.Show("Вы точно хотите выйти?", "Образовательный центр", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MySQL.ExecuteQueryWithoutResponse("rollback;");
                MySQL.CloseConnection();
                Application.Exit();
            }
        }

        private void tbMain_Click(object sender, EventArgs e)
        {

            
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            this.AddNewGroupWaitingRoom();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDeleteGroup.Tag == null)
                {
                    MessageBox.Show("Нельзя удалить группу!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int groupID = (int)btnDeleteGroup.Tag;
                MySQL.ExecuteQueryWithoutResponse($"DELETE FROM `groups` WHERE `groupID`='{groupID}'");
                
                dgCourses_Click(dgCourses, new EventArgs());

                btnDeleteGroup.Enabled = false;
                isEdited= true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            this.AddNewClientWaitingRoom();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDeleteClient.Tag == null)
                {
                    MessageBox.Show("Нельзя удалить клиента!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clientID = (int)btnDeleteClient.Tag;
                MySQL.ExecuteQueryWithoutResponse($"DELETE FROM `clients` WHERE `clientID`='{clientID}'");

                btnDeleteClient.Enabled = false;

                dgGroups_Click(dgGroups, new EventArgs());
                isEdited= true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        // VALIDATE
        private void cmbDirections_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDirections.SelectedIndex >= 0 && cmbGroupStatus.SelectedIndex >= 0)
                btnShowGroups.Enabled = true;
            else
                btnShowGroups.Enabled = false;
        }
        // VALIDATE
        private void cmbGroupStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDirections.SelectedIndex >= 0 && cmbGroupStatus.SelectedIndex >= 0)
                btnShowGroups.Enabled = true;
            else
                btnShowGroups.Enabled = false;
        }

        private void btnShowGroups_Click(object sender, EventArgs e)
        {
            dgGroups.DataSource = null;
            dgClients.DataSource = null;

            if (cmbDirections.SelectedIndex >= 0)
            {
                this.LoadCoursesDataGrid(cmbDirections.SelectedIndex + 1);
            }

            btnCreateGroup.Enabled = false;
            btnCreateClient.Enabled = false;
            btnShowGroups.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnDeleteGroup.Enabled = false;
        }

        private void rbClients_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            var headerName = (string) rb.Text;

            this.InsertToDataGrid(rbs[headerName], headerName);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*DataRowView drvData = (DataRowView)currManagerTotal.Current;
            CalculateTotalPage(drvData.Row);*/
        }

        private void btnNextDate_Click(object sender, EventArgs e)
        {
            int dataID = 0;
            selectedDataNum += 1;
            FillPaymentsPage();
                    
        }

        private void btnPrevDate_Click(object sender, EventArgs e)
        {
            int dataID = 0;
            selectedDataNum -= 1;
            FillPaymentsPage();
                   
        }

        private void btnShowPaymentTypeForm_Click(object sender, EventArgs e)
        {
            PaymentType fpt = new PaymentType();
            string query;
            if(fpt.ShowDialog() == DialogResult.OK)
            {
                foreach (string[] type in fpt.paymentTypes)
                {
                    if (type == null)
                        continue;
                    
                    int count = Convert.ToInt32(MySQL.ExecuteQuery($"SELECT COUNT(*) FROM `payment_type` WHERE `payment_typeID`='{type[0]}'"));
                    query = $"INSERT INTO `payment_type`(`payment_typeID`, `payment_typeName`, `note`) VALUES (NULL,'{type[1]}','{type[2]}')";
                    if (count > 0)
                    {
                        query = $"UPDATE `payment_type` SET `payment_typeName`='{type[1]}',`note`='{type[2]}' WHERE `payment_typeID`='{type[0]}'";
                    }
                    MySQL.ExecuteQueryWithoutResponse(query);
                }
                isEdited= true;
            }
        }

        private void tvManager_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lvManager_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lvManager_Click(object sender, EventArgs e)
        {

        }

        private void lvManager_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmbFilteringDirection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnCalculateOwe.Enabled = true;
        }

        private void btnCalculateOwe_Click(object sender, EventArgs e)
        {
            //this.GetOweStatistic();
        }

        // Устанавливаем дизайн DataGrid-ов
        private void DesigneDataGrids()
        {
            try
            {
                #region Дизайн dgCourses
                DataGridTableStyle coursesTableStyle = new DataGridTableStyle();
                coursesTableStyle.MappingName = "course";

                DataGridTextBoxColumn courseNameStyle = new DataGridTextBoxColumn();
                courseNameStyle.MappingName = "courseName";
                courseNameStyle.Width = 225;
                courseNameStyle.HeaderText = "Название курса";

                DataGridTextBoxColumn coursePriceStyle = new DataGridTextBoxColumn();
                coursePriceStyle.MappingName = "priceNumber";
                coursePriceStyle.Width = 100;
                coursePriceStyle.Format = "#.0";
                coursePriceStyle.HeaderText = "Цена курса";

                coursesTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                            courseNameStyle,
                                                                                            coursePriceStyle});

                dgCourses.TableStyles.Add(coursesTableStyle);

                #endregion

                #region Дизайн dgGroups

                DataGridTableStyle groupsTableStyle = new DataGridTableStyle();
                groupsTableStyle.MappingName = "groups";

                DataGridTextBoxColumn groupIDStyle = new DataGridTextBoxColumn();
                groupIDStyle.MappingName = "groupID";
                groupIDStyle.Width = 50;
                groupIDStyle.HeaderText = "Номер";

                DataGridTextBoxColumn beginDateStyle = new DataGridTextBoxColumn();
                beginDateStyle.MappingName = "beginDate";
                beginDateStyle.Width = 110;
                beginDateStyle.Format = "dd MMMM yyyy";
                beginDateStyle.HeaderText = "Дата начала";

                DataGridTextBoxColumn endDateStyle = new DataGridTextBoxColumn();
                endDateStyle.MappingName = "endDate";
                endDateStyle.Width = 110;
                endDateStyle.Format = "dd MMMM yyyy";
                endDateStyle.HeaderText = "Дата конца";

                DataGridTextBoxColumn beginTimeStyle = new DataGridTextBoxColumn();
                beginTimeStyle.MappingName = "beginTime";
                beginTimeStyle.Width = 110;
                beginTimeStyle.Format = "HH:mm";
                beginTimeStyle.HeaderText = "Время начала";

                DataGridTextBoxColumn endTimeStyle = new DataGridTextBoxColumn();
                endTimeStyle.MappingName = "endTime";
                endTimeStyle.Width = 110;
                endTimeStyle.Format = "HH:mm";
                endTimeStyle.HeaderText = "Время конца";

                DataGridTextBoxColumn classNumberStyle = new DataGridTextBoxColumn();
                classNumberStyle.MappingName = "classNumber";
                classNumberStyle.Width = 110;
                classNumberStyle.HeaderText = "Номер класса";

                groupsTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                           beginTimeStyle,
                                                                                           endTimeStyle,
                                                                                           classNumberStyle,
                                                                                           beginDateStyle,
                                                                                           endDateStyle,
                                                                                           groupIDStyle});
                dgGroups.TableStyles.Add(groupsTableStyle);

                #endregion

                #region Дизайн dgClients

                DataGridTableStyle clientsTableStyle = new DataGridTableStyle();
                clientsTableStyle.MappingName = "clients";

                DataGridTextBoxColumn clientIDStyle = new DataGridTextBoxColumn();
                clientIDStyle.MappingName = "clientID";
                clientIDStyle.ReadOnly = true;
                clientIDStyle.Width = 50;
                clientIDStyle.HeaderText = "Номер";

                DataGridTextBoxColumn firstNameStyle = new DataGridTextBoxColumn();
                firstNameStyle.MappingName = "fname";
                firstNameStyle.Width = 130;
                firstNameStyle.HeaderText = "Имя";

                DataGridTextBoxColumn lastNameStyle = new DataGridTextBoxColumn();
                lastNameStyle.MappingName = "lname";
                lastNameStyle.Width = 130;
                lastNameStyle.HeaderText = "Фамилия";

                DataGridTextBoxColumn fatherNameStyle = new DataGridTextBoxColumn();
                fatherNameStyle.MappingName = "fathName";
                fatherNameStyle.Width = 130;
                fatherNameStyle.HeaderText = "Отчество";

                DataGridTextBoxColumn clientPhoneStyle = new DataGridTextBoxColumn();
                clientPhoneStyle.MappingName = "linkData";
                clientPhoneStyle.Width = 200;
                clientPhoneStyle.HeaderText = "Контакты";

                DataGridBoolColumn clientIsRingedStyle = new DataGridBoolColumn();
                clientIsRingedStyle.MappingName = "isRinged";
                clientIsRingedStyle.Width = 100;
                clientIsRingedStyle.AllowNull = false;
                clientIsRingedStyle.HeaderText = "Дозвонились";

                clientsTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                            clientIDStyle,
                                                                                            lastNameStyle,
                                                                                            firstNameStyle,
                                                                                            fatherNameStyle,
                                                                                            clientPhoneStyle,
                                                                                            clientIsRingedStyle});

                dgClients.TableStyles.Add(clientsTableStyle);

                #endregion

                #region Дизайн dgIncome

                DataGridTableStyle incomeTableStyle = new DataGridTableStyle();
                incomeTableStyle.MappingName = "income";

                DataGridTextBoxColumn incomeClientIDStyle = new DataGridTextBoxColumn();
                incomeClientIDStyle.MappingName = "clientID";
                incomeClientIDStyle.Width = 45;
                incomeClientIDStyle.HeaderText = "ID клиента";
                incomeClientIDStyle.Alignment = HorizontalAlignment.Center;

                DataGridTextBoxColumn incomeSummaStyle = new DataGridTextBoxColumn();
                incomeSummaStyle.MappingName = "summa";
                incomeSummaStyle.Width = 100;
                incomeSummaStyle.Format = "#.0";
                incomeSummaStyle.HeaderText = "Сумма";

                DataGridTextBoxColumn incomePaymentTypeIDStyle = new DataGridTextBoxColumn();
                incomePaymentTypeIDStyle.MappingName = "payment_typeID";
                incomePaymentTypeIDStyle.Width = 45;
                incomePaymentTypeIDStyle.HeaderText = "Код вида оплаты";

                DataGridTextBoxColumn incomeNoteStyle = new DataGridTextBoxColumn();
                incomeNoteStyle.MappingName = "note";
                incomeNoteStyle.Width = 300;
                incomeNoteStyle.HeaderText = "Заметки";

                DataGridBoolColumn realizedStyle = new DataGridBoolColumn();
                realizedStyle.MappingName = "IsRealized";
                realizedStyle.Width = 100;
                realizedStyle.HeaderText = "Реализовано";

                DataGridTextBoxColumn incomeDataIDStyle = new DataGridTextBoxColumn();
                incomeDataIDStyle.MappingName = "dataID";
                incomeDataIDStyle.Width = 45;
                incomeDataIDStyle.HeaderText = "ID data";
                incomeDataIDStyle.Alignment = HorizontalAlignment.Center;

                incomeTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                         incomeSummaStyle,
                                                                                         incomePaymentTypeIDStyle,
                                                                                         incomeNoteStyle,
                                                                                         incomeClientIDStyle,
                                                                                         incomeDataIDStyle});

                incomeTableStyle.HeaderBackColor = dgIncome.HeaderBackColor;
                incomeTableStyle.BackColor = dgIncome.BackColor;
                incomeTableStyle.ForeColor = dgIncome.ForeColor;
                incomeTableStyle.GridLineColor = dgIncome.GridLineColor;
                incomeTableStyle.HeaderForeColor = dgIncome.HeaderForeColor;
                incomeTableStyle.SelectionBackColor = dgIncome.SelectionBackColor;
                incomeTableStyle.SelectionForeColor = dgIncome.SelectionForeColor;
                dgIncome.TableStyles.Add(incomeTableStyle);

                #endregion

                #region Дизайн dgOut
                DataGridTableStyle expensesTableStyle = new DataGridTableStyle();
                expensesTableStyle.MappingName = "expenses";

                DataGridTextBoxColumn expensesClientIDStyle = new DataGridTextBoxColumn();
                expensesClientIDStyle.MappingName = "clientID";
                expensesClientIDStyle.Width = 45;
                expensesClientIDStyle.HeaderText = "ID клиента";

                DataGridTextBoxColumn expensesEmployeeIDStyle = new DataGridTextBoxColumn();
                expensesEmployeeIDStyle.MappingName = "employeeID";
                expensesEmployeeIDStyle.Width = 45;
                expensesEmployeeIDStyle.HeaderText = "ID сотрудника";

                DataGridTextBoxColumn expensesSummaStyle = new DataGridTextBoxColumn();
                expensesSummaStyle.MappingName = "summa";
                expensesSummaStyle.Width = 100;
                expensesSummaStyle.Format = "#.0";
                expensesSummaStyle.HeaderText = "Сумма";

                DataGridTextBoxColumn expensesPaymentTypeIDStyle = new DataGridTextBoxColumn();
                expensesPaymentTypeIDStyle.MappingName = "payment_typeID";
                expensesPaymentTypeIDStyle.Width = 45;
                expensesPaymentTypeIDStyle.HeaderText = "Код вида оплаты";

                DataGridTextBoxColumn expensesNoteStyle = new DataGridTextBoxColumn();
                expensesNoteStyle.MappingName = "note";
                expensesNoteStyle.Width = 300;
                expensesNoteStyle.HeaderText = "Заметки";

                expensesTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                           expensesSummaStyle,
                                                                                           expensesPaymentTypeIDStyle,
                                                                                           expensesNoteStyle,
                                                                                           expensesClientIDStyle,
                                                                                           expensesEmployeeIDStyle});

                expensesTableStyle.HeaderBackColor = dgOut.HeaderBackColor;
                expensesTableStyle.BackColor = dgOut.BackColor;
                expensesTableStyle.ForeColor = dgOut.ForeColor;
                expensesTableStyle.GridLineColor = dgOut.GridLineColor;
                expensesTableStyle.HeaderForeColor = dgOut.HeaderForeColor;
                expensesTableStyle.SelectionBackColor = dgOut.SelectionBackColor;
                expensesTableStyle.SelectionForeColor = dgOut.SelectionForeColor;
                dgOut.TableStyles.Add(expensesTableStyle);

                #endregion

                #region  Дизайн dgMainTable

                #region  Стиль таблицы directions на странице "Основные таблицы"
                DataGridTableStyle directionsTableStyle = new DataGridTableStyle();
                directionsTableStyle.MappingName = "directions";

                DataGridTextBoxColumn directionIDStyle = new DataGridTextBoxColumn();
                directionIDStyle.MappingName = "directionID";
                directionIDStyle.Width = 100;
                directionIDStyle.HeaderText = "Номер направления";

                DataGridTextBoxColumn directionNameStyle = new DataGridTextBoxColumn();
                directionNameStyle.MappingName = "directName";
                directionNameStyle.Width = 100;
                directionNameStyle.HeaderText = "Наименование";

                DataGridTextBoxColumn directionNotesStyle = new DataGridTextBoxColumn();
                directionNotesStyle.MappingName = "note";
                directionNotesStyle.Width = 100;
                directionNotesStyle.HeaderText = "Заметки";

                directionsTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                               directionIDStyle,
                                                                                               directionNameStyle,
                                                                                               directionNotesStyle});

                dgMainTable.TableStyles.Add(directionsTableStyle);

                #endregion

                #region Стиль таблицы course на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableСoursesTableStyle = new DataGridTableStyle();
                dgWorkTableСoursesTableStyle.MappingName = "course";

                DataGridTextBoxColumn dgWorkTableСourseNameStyle = new DataGridTextBoxColumn();
                dgWorkTableСourseNameStyle.MappingName = "courseName";
                dgWorkTableСourseNameStyle.Width = 150;
                dgWorkTableСourseNameStyle.HeaderText = "Название курса";

                DataGridTextBoxColumn dgWorkTableСoursePriceStyle = new DataGridTextBoxColumn();
                dgWorkTableСoursePriceStyle.MappingName = "priceNumber";
                dgWorkTableСoursePriceStyle.Width = 100;
                dgWorkTableСoursePriceStyle.Format = "#.0";
                dgWorkTableСoursePriceStyle.HeaderText = "Цена курса";

                DataGridTextBoxColumn dgWorkTableDirectionIDStyle = new DataGridTextBoxColumn();
                dgWorkTableDirectionIDStyle.MappingName = "directionID";
                dgWorkTableDirectionIDStyle.Width = 50;
                dgWorkTableDirectionIDStyle.HeaderText = "Номер направления";

                DataGridTextBoxColumn dgWorkTableNoteStyle = new DataGridTextBoxColumn();
                dgWorkTableNoteStyle.MappingName = "note";
                dgWorkTableNoteStyle.Width = 150;
                dgWorkTableNoteStyle.HeaderText = "Заметки";

                dgWorkTableСoursesTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                       dgWorkTableСourseNameStyle,
                                                                                                       dgWorkTableСoursePriceStyle,
                                                                                                       dgWorkTableDirectionIDStyle,
                                                                                                       dgWorkTableNoteStyle});

                dgMainTable.TableStyles.Add(dgWorkTableСoursesTableStyle);

                #endregion

                #region  Стиль таблицы data на странице "Основные таблицы"
                DataGridTableStyle totalTableStyle = new DataGridTableStyle();
                totalTableStyle.MappingName = "data";

                DataGridTextBoxColumn totalIDStyle = new DataGridTextBoxColumn();
                totalIDStyle.MappingName = "directionID";
                totalIDStyle.Width = 100;
                totalIDStyle.HeaderText = "Номер";

                DataGridTextBoxColumn currentDateStyle = new DataGridTextBoxColumn();
                currentDateStyle.MappingName = "currentDate";
                currentDateStyle.Width = 100;
                currentDateStyle.Format = "dd MMMM yyyy";
                currentDateStyle.HeaderText = "Текущая дата";

                DataGridTextBoxColumn amountYesterdayStyle = new DataGridTextBoxColumn();
                amountYesterdayStyle.MappingName = "amountYesterday";
                amountYesterdayStyle.Width = 100;
                amountYesterdayStyle.HeaderText = "Всего вчера";

                DataGridTextBoxColumn amountTodayStyle = new DataGridTextBoxColumn();
                amountTodayStyle.MappingName = "amountToday";
                amountTodayStyle.Width = 100;
                amountTodayStyle.HeaderText = "Всего cегодня";

                DataGridTextBoxColumn incomeTodayStyle = new DataGridTextBoxColumn();
                incomeTodayStyle.MappingName = "incomeToday";
                incomeTodayStyle.Width = 100;
                incomeTodayStyle.HeaderText = "Приход сегодня";

                DataGridTextBoxColumn expanseTodayStyle = new DataGridTextBoxColumn();
                expanseTodayStyle.MappingName = "expanseToday";
                expanseTodayStyle.Width = 100;
                expanseTodayStyle.HeaderText = "Расход сегодня";

                DataGridTextBoxColumn totalNoteStyle = new DataGridTextBoxColumn();
                totalNoteStyle.MappingName = "note";
                totalNoteStyle.Width = 100;
                totalNoteStyle.HeaderText = "Заметки";

                totalTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                          totalIDStyle,
                                                                                          currentDateStyle,
                                                                                          amountYesterdayStyle,
                                                                                          amountTodayStyle,
                                                                                          incomeTodayStyle,
                                                                                          expanseTodayStyle,
                                                                                          totalNoteStyle});

                dgMainTable.TableStyles.Add(totalTableStyle);

                #endregion

                #region Стиль таблицы groups на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableGroupsTableStyle = new DataGridTableStyle();
                dgWorkTableGroupsTableStyle.MappingName = "groups";

                DataGridTextBoxColumn dgWorkTableGroupIDStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupIDStyle.MappingName = "groupID";
                dgWorkTableGroupIDStyle.Width = 100;
                dgWorkTableGroupIDStyle.HeaderText = "Номер группы";

                DataGridTextBoxColumn dgWorkTableBeginDateStyle = new DataGridTextBoxColumn();
                dgWorkTableBeginDateStyle.MappingName = "beginDate";
                dgWorkTableBeginDateStyle.Width = 100;
                dgWorkTableBeginDateStyle.Format = "dd MMMM yyyy";
                dgWorkTableBeginDateStyle.HeaderText = "Дата начала";

                DataGridTextBoxColumn dgWorkTableEndDateStyle = new DataGridTextBoxColumn();
                dgWorkTableEndDateStyle.MappingName = "endDate";
                dgWorkTableEndDateStyle.Width = 100;
                dgWorkTableEndDateStyle.Format = "dd MMMM yyyy";
                dgWorkTableEndDateStyle.HeaderText = "Дата конца";

                DataGridTextBoxColumn dgWorkTableBeginTimeStyle = new DataGridTextBoxColumn();
                dgWorkTableBeginTimeStyle.MappingName = "beginTime";
                dgWorkTableBeginTimeStyle.Width = 100;
                dgWorkTableBeginTimeStyle.Format = "HH:mm";
                dgWorkTableBeginTimeStyle.HeaderText = "Время начала";

                DataGridTextBoxColumn dgWorkTableEndTimeStyle = new DataGridTextBoxColumn();
                dgWorkTableEndTimeStyle.MappingName = "endTime";
                dgWorkTableEndTimeStyle.Width = 100;
                dgWorkTableEndTimeStyle.Format = "HH:mm";
                dgWorkTableEndTimeStyle.HeaderText = "Время конца";

                DataGridTextBoxColumn dgWorkTableClassNumberStyle = new DataGridTextBoxColumn();
                dgWorkTableClassNumberStyle.MappingName = "classNumber";
                dgWorkTableClassNumberStyle.Width = 100;
                dgWorkTableClassNumberStyle.HeaderText = "Номер класса";

                DataGridTextBoxColumn dgWorkTableCourseIDStyle = new DataGridTextBoxColumn();
                dgWorkTableCourseIDStyle.MappingName = "courseID";
                dgWorkTableCourseIDStyle.Width = 100;
                dgWorkTableCourseIDStyle.HeaderText = "Номер курса";

                DataGridTextBoxColumn dgWorkTableEmployeeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeeIDStyle.MappingName = "employeeID";
                dgWorkTableEmployeeIDStyle.Width = 100;
                dgWorkTableEmployeeIDStyle.HeaderText = "Номер сотрудника";

                DataGridTextBoxColumn dgWorkTableGroupNoteStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupNoteStyle.MappingName = "note";
                dgWorkTableGroupNoteStyle.Width = 100;
                dgWorkTableGroupNoteStyle.HeaderText = "Заметки";

                DataGridTextBoxColumn dgWorkTableStatusIDStyle = new DataGridTextBoxColumn();
                dgWorkTableStatusIDStyle.MappingName = "StatusID";
                dgWorkTableStatusIDStyle.Width = 100;
                dgWorkTableStatusIDStyle.HeaderText = "Номер статуса группы";

                dgWorkTableGroupsTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                      dgWorkTableGroupIDStyle,
                                                                                                      dgWorkTableClassNumberStyle,
                                                                                                      dgWorkTableBeginDateStyle,
                                                                                                      dgWorkTableEndDateStyle,
                                                                                                      dgWorkTableBeginTimeStyle,
                                                                                                      dgWorkTableEndTimeStyle,
                                                                                                      dgWorkTableCourseIDStyle,
                                                                                                      dgWorkTableEmployeeIDStyle,
                                                                                                      dgWorkTableGroupNoteStyle,
                                                                                                      dgWorkTableStatusIDStyle
                                                                                                  });

                dgMainTable.TableStyles.Add(dgWorkTableGroupsTableStyle);

                #endregion

                #region Стиль таблицы clients на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableСlientsTableStyle = new DataGridTableStyle();
                dgWorkTableСlientsTableStyle.MappingName = "clients";

                DataGridTextBoxColumn dgWorkTableClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableClientIDStyle.MappingName = "clientID";
                dgWorkTableClientIDStyle.Width = 100;
                dgWorkTableClientIDStyle.HeaderText = "Номер клиента";

                DataGridTextBoxColumn dgWorkTableFirstNameStyle = new DataGridTextBoxColumn();
                dgWorkTableFirstNameStyle.MappingName = "fname";
                dgWorkTableFirstNameStyle.Width = 100;
                dgWorkTableFirstNameStyle.HeaderText = "Имя";

                DataGridTextBoxColumn dgWorkTableLastNameStyle = new DataGridTextBoxColumn();
                dgWorkTableLastNameStyle.MappingName = "lname";
                dgWorkTableLastNameStyle.Width = 100;
                dgWorkTableLastNameStyle.HeaderText = "Фамилия";

                DataGridTextBoxColumn dgWorkTableFatherNameStyle = new DataGridTextBoxColumn();
                dgWorkTableFatherNameStyle.MappingName = "fathName";
                dgWorkTableFatherNameStyle.Width = 100;
                dgWorkTableFatherNameStyle.HeaderText = "Отчество";

                DataGridTextBoxColumn dgWorkTableLinkDataStyle = new DataGridTextBoxColumn();
                dgWorkTableLinkDataStyle.MappingName = "linkData";
                dgWorkTableLinkDataStyle.Width = 100;
                dgWorkTableLinkDataStyle.HeaderText = "Контакты";

                DataGridTextBoxColumn dgWorkTableRecordDateStyle = new DataGridTextBoxColumn();
                dgWorkTableRecordDateStyle.MappingName = "recorddate";
                dgWorkTableRecordDateStyle.Width = 100;
                dgWorkTableRecordDateStyle.Format = "dd-MMMM-yyyy";
                dgWorkTableRecordDateStyle.HeaderText = "Дата записи";

                DataGridTextBoxColumn dgWorkTableClientNoteStyle = new DataGridTextBoxColumn();
                dgWorkTableClientNoteStyle.MappingName = "note";
                dgWorkTableClientNoteStyle.Width = 100;
                dgWorkTableClientNoteStyle.HeaderText = "Заметки";

                DataGridTextBoxColumn dgWorkTablePaymentTypeStyle = new DataGridTextBoxColumn();
                dgWorkTablePaymentTypeStyle.MappingName = "paymentType";
                dgWorkTablePaymentTypeStyle.Width = 100;
                dgWorkTablePaymentTypeStyle.HeaderText = "Тип оплаты";

                dgWorkTableСlientsTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                       dgWorkTableClientIDStyle,
                                                                                                       dgWorkTableLastNameStyle,
                                                                                                       dgWorkTableFirstNameStyle,
                                                                                                       dgWorkTableFatherNameStyle,
                                                                                                       dgWorkTableLinkDataStyle,
                                                                                                       dgWorkTableRecordDateStyle,
                                                                                                       dgWorkTableClientNoteStyle,
                                                                                                       dgWorkTablePaymentTypeStyle});

                dgMainTable.TableStyles.Add(dgWorkTableСlientsTableStyle);

                #endregion

                #region Стиль таблицы income на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableIncomeTableStyle = new DataGridTableStyle();
                dgWorkTableIncomeTableStyle.MappingName = "income";

                DataGridTextBoxColumn dgWorkTableIncomeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableIncomeIDStyle.MappingName = "incomeID";
                dgWorkTableIncomeIDStyle.Width = 100;
                dgWorkTableIncomeIDStyle.HeaderText = "ID прихода";

                DataGridTextBoxColumn dgWorkTableIncomeClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableIncomeClientIDStyle.MappingName = "clientID";
                dgWorkTableIncomeClientIDStyle.Width = 100;
                dgWorkTableIncomeClientIDStyle.HeaderText = "ID клиента";

                DataGridTextBoxColumn dgWorkTableIncomeSummaStyle = new DataGridTextBoxColumn();
                dgWorkTableIncomeSummaStyle.MappingName = "summa";
                dgWorkTableIncomeSummaStyle.Width = 100;
                dgWorkTableIncomeSummaStyle.Format = "#.0";
                dgWorkTableIncomeSummaStyle.HeaderText = "Сумма";

                DataGridTextBoxColumn dgWorkTableIncomePaymentTypeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableIncomePaymentTypeIDStyle.MappingName = "payment_typeID";
                dgWorkTableIncomePaymentTypeIDStyle.Width = 100;
                dgWorkTableIncomePaymentTypeIDStyle.HeaderText = "Код вида оплаты";

                DataGridTextBoxColumn dgWorkTableIncomeNoteStyle = new DataGridTextBoxColumn();
                dgWorkTableIncomeNoteStyle.MappingName = "note";
                dgWorkTableIncomeNoteStyle.Width = 100;
                dgWorkTableIncomeNoteStyle.HeaderText = "Заметки";

                DataGridBoolColumn dgWorkTableRealizedStyle = new DataGridBoolColumn();
                dgWorkTableRealizedStyle.MappingName = "IsRealized";
                dgWorkTableRealizedStyle.Width = 100;
                dgWorkTableRealizedStyle.HeaderText = "Реализовано";

                DataGridTextBoxColumn dgWorkTableDataIDStyle = new DataGridTextBoxColumn();
                dgWorkTableDataIDStyle.MappingName = "dataID";
                dgWorkTableDataIDStyle.Width = 100;
                dgWorkTableDataIDStyle.HeaderText = "ID data";

                dgWorkTableIncomeTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                                    dgWorkTableIncomeIDStyle,
                                                                                                    dgWorkTableIncomeClientIDStyle,
                                                                                                    dgWorkTableIncomeSummaStyle,
                                                                                                    dgWorkTableIncomePaymentTypeIDStyle,
                                                                                                    dgWorkTableIncomeNoteStyle,
                                                                                                    dgWorkTableRealizedStyle,
                                                                                                    dgWorkTableDataIDStyle});

                dgWorkTableIncomeTableStyle.HeaderBackColor = dgMainTable.HeaderBackColor;
                dgWorkTableIncomeTableStyle.BackColor = dgMainTable.BackColor;
                dgWorkTableIncomeTableStyle.ForeColor = dgMainTable.ForeColor;
                dgWorkTableIncomeTableStyle.GridLineColor = dgMainTable.GridLineColor;
                dgWorkTableIncomeTableStyle.HeaderForeColor = dgMainTable.HeaderForeColor;
                dgWorkTableIncomeTableStyle.SelectionBackColor = dgMainTable.SelectionBackColor;
                dgWorkTableIncomeTableStyle.SelectionForeColor = dgMainTable.SelectionForeColor;
                dgMainTable.TableStyles.Add(dgWorkTableIncomeTableStyle);

                #endregion

                #region Стиль таблицы expenses на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableExpensesTableStyle = new DataGridTableStyle();
                dgWorkTableExpensesTableStyle.MappingName = "expenses";

                DataGridTextBoxColumn dgWorkTableExpensesExpenseIDStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesExpenseIDStyle.MappingName = "expenseID";
                dgWorkTableExpensesExpenseIDStyle.Width = 100;
                dgWorkTableExpensesExpenseIDStyle.HeaderText = "ID расхода";

                DataGridTextBoxColumn dgWorkTableExpensesDataIDStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesDataIDStyle.MappingName = "dataID";
                dgWorkTableExpensesDataIDStyle.Width = 100;
                dgWorkTableExpensesDataIDStyle.HeaderText = "ID data";

                DataGridTextBoxColumn dgWorkTableExpensesClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesClientIDStyle.MappingName = "clientID";
                dgWorkTableExpensesClientIDStyle.Width = 100;
                dgWorkTableExpensesClientIDStyle.HeaderText = "ID клиента";

                DataGridTextBoxColumn dgWorkTableExpensesEmployeeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesEmployeeIDStyle.MappingName = "employeeID";
                dgWorkTableExpensesEmployeeIDStyle.Width = 100;
                dgWorkTableExpensesEmployeeIDStyle.HeaderText = "ID сотрудника";

                DataGridTextBoxColumn dgWorkTableExpensesSummaStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesSummaStyle.MappingName = "summa";
                dgWorkTableExpensesSummaStyle.Width = 100;
                dgWorkTableExpensesSummaStyle.Format = "#.0";
                dgWorkTableExpensesSummaStyle.HeaderText = "Сумма";

                DataGridTextBoxColumn dgWorkTableExpensesPaymentTypeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesPaymentTypeIDStyle.MappingName = "payment_typeID";
                dgWorkTableExpensesPaymentTypeIDStyle.Width = 100;
                dgWorkTableExpensesPaymentTypeIDStyle.HeaderText = "Код вида оплаты";

                DataGridTextBoxColumn dgWorkTableExpensesNoteStyle = new DataGridTextBoxColumn();
                dgWorkTableExpensesNoteStyle.MappingName = "note";
                dgWorkTableExpensesNoteStyle.Width = 100;
                dgWorkTableExpensesNoteStyle.HeaderText = "Заметки";

                dgWorkTableExpensesTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                                      dgWorkTableExpensesExpenseIDStyle,
                                                                                                      dgWorkTableExpensesDataIDStyle,
                                                                                                      dgWorkTableExpensesClientIDStyle,
                                                                                                      dgWorkTableExpensesEmployeeIDStyle,
                                                                                                      dgWorkTableExpensesSummaStyle,
                                                                                                      dgWorkTableExpensesPaymentTypeIDStyle,
                                                                                                      dgWorkTableExpensesNoteStyle});

                dgWorkTableExpensesTableStyle.HeaderBackColor = dgMainTable.HeaderBackColor;
                dgWorkTableExpensesTableStyle.BackColor = dgMainTable.BackColor;
                dgWorkTableExpensesTableStyle.ForeColor = dgMainTable.ForeColor;
                dgWorkTableExpensesTableStyle.GridLineColor = dgMainTable.GridLineColor;
                dgWorkTableExpensesTableStyle.HeaderForeColor = dgMainTable.HeaderForeColor;
                dgWorkTableExpensesTableStyle.SelectionBackColor = dgMainTable.SelectionBackColor;
                dgWorkTableExpensesTableStyle.SelectionForeColor = dgMainTable.SelectionForeColor;
                dgMainTable.TableStyles.Add(dgWorkTableExpensesTableStyle);

                #endregion

                #region Стиль таблицы employees на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableEmployeesTableStyle = new DataGridTableStyle();
                dgWorkTableEmployeesTableStyle.MappingName = "employees";

                DataGridTextBoxColumn dgWorkTableEmployeesEmployeeIDStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesEmployeeIDStyle.MappingName = "employeeID";
                dgWorkTableEmployeesEmployeeIDStyle.Width = 100;
                dgWorkTableEmployeesEmployeeIDStyle.HeaderText = "Номер сотрудника";

                DataGridTextBoxColumn dgWorkTableEmployeesFirstNameStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesFirstNameStyle.MappingName = "FirstName";
                dgWorkTableEmployeesFirstNameStyle.Width = 100;
                dgWorkTableEmployeesFirstNameStyle.HeaderText = "Имя";

                DataGridTextBoxColumn dgWorkTableEmployeesLastNameStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesLastNameStyle.MappingName = "LastName";
                dgWorkTableEmployeesLastNameStyle.Width = 100;
                dgWorkTableEmployeesLastNameStyle.HeaderText = "Фамилия";

                DataGridTextBoxColumn dgWorkTableEmployeesFatherNameStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesFatherNameStyle.MappingName = "FatherName";
                dgWorkTableEmployeesFatherNameStyle.Width = 100;
                dgWorkTableEmployeesFatherNameStyle.HeaderText = "Отчество";

                DataGridTextBoxColumn dgWorkTableEmployeesLinkDataStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesLinkDataStyle.MappingName = "linkData";
                dgWorkTableEmployeesLinkDataStyle.Width = 100;
                dgWorkTableEmployeesLinkDataStyle.HeaderText = "Контакты";

                DataGridTextBoxColumn dgWorkTableEmployeesBirthdayStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesBirthdayStyle.MappingName = "birthday";
                dgWorkTableEmployeesBirthdayStyle.Width = 100;
                dgWorkTableEmployeesBirthdayStyle.Format = "dd-MMMM-yyyy";
                dgWorkTableEmployeesBirthdayStyle.HeaderText = "День рождения";

                DataGridTextBoxColumn dgWorkTableEmployeesDirectionIDStyle = new DataGridTextBoxColumn();
                dgWorkTableEmployeesDirectionIDStyle.MappingName = "directionID";
                dgWorkTableEmployeesDirectionIDStyle.Width = 100;
                dgWorkTableEmployeesDirectionIDStyle.HeaderText = "Номер направления";

                dgWorkTableEmployeesTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                         dgWorkTableEmployeesEmployeeIDStyle,
                                                                                                         dgWorkTableEmployeesLastNameStyle,
                                                                                                         dgWorkTableEmployeesFirstNameStyle,
                                                                                                         dgWorkTableEmployeesFatherNameStyle,
                                                                                                         dgWorkTableEmployeesLinkDataStyle,
                                                                                                         dgWorkTableEmployeesBirthdayStyle,
                                                                                                         dgWorkTableEmployeesDirectionIDStyle});

                dgMainTable.TableStyles.Add(dgWorkTableEmployeesTableStyle);

                #endregion

                #region Стиль таблицы GroupStatus на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableGroupStatusTableStyle = new DataGridTableStyle();
                dgWorkTableGroupStatusTableStyle.MappingName = "GroupStatus";

                DataGridTextBoxColumn dgWorkTableGroupStatusStatusIDStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupStatusStatusIDStyle.MappingName = "StatusID";
                dgWorkTableGroupStatusStatusIDStyle.Width = 100;
                dgWorkTableGroupStatusStatusIDStyle.HeaderText = "Номер статуса";

                DataGridTextBoxColumn dgWorkTableStatusNameStyle = new DataGridTextBoxColumn();
                dgWorkTableStatusNameStyle.MappingName = "StatusName";
                dgWorkTableStatusNameStyle.Width = 100;
                dgWorkTableStatusNameStyle.HeaderText = "Имя";

                dgWorkTableGroupStatusTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                           dgWorkTableGroupStatusStatusIDStyle,
                                                                                                           dgWorkTableStatusNameStyle});

                dgMainTable.TableStyles.Add(dgWorkTableGroupStatusTableStyle);

                #endregion

                #region Стиль таблицы payment_type на странице "Основные таблицы"
                DataGridTableStyle dgWorkTablePaymentTypeTableStyle = new DataGridTableStyle();
                dgWorkTablePaymentTypeTableStyle.MappingName = "payment_type";

                DataGridTextBoxColumn dgWorkTablePaymentTypeIDStyle = new DataGridTextBoxColumn();
                dgWorkTablePaymentTypeIDStyle.MappingName = "payment_typeID";
                dgWorkTablePaymentTypeIDStyle.Width = 100;
                dgWorkTablePaymentTypeIDStyle.HeaderText = "Номер вида оплаты";

                DataGridTextBoxColumn dgWorkTablePaymentTypeNameStyle = new DataGridTextBoxColumn();
                dgWorkTablePaymentTypeNameStyle.MappingName = "payment_typeName";
                dgWorkTablePaymentTypeNameStyle.Width = 100;
                dgWorkTablePaymentTypeNameStyle.HeaderText = "Наименование оплаты";

                DataGridTextBoxColumn dgWorkTablePaymentNotesStyle = new DataGridTextBoxColumn();
                dgWorkTablePaymentNotesStyle.MappingName = "note";
                dgWorkTablePaymentNotesStyle.Width = 100;
                dgWorkTablePaymentNotesStyle.HeaderText = "Заметки";

                dgWorkTablePaymentTypeTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                           dgWorkTablePaymentTypeIDStyle,
                                                                                                           dgWorkTablePaymentTypeNameStyle,
                                                                                                           dgWorkTablePaymentNotesStyle});

                dgMainTable.TableStyles.Add(dgWorkTablePaymentTypeTableStyle);

                #endregion

                #region Стиль таблицы RealizedTable на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableRealizedTableStyle = new DataGridTableStyle();
                dgWorkTableRealizedTableStyle.MappingName = "RealizedTable";

                DataGridTextBoxColumn dgWorkTableRealizedTableIDStyle = new DataGridTextBoxColumn();
                dgWorkTableRealizedTableIDStyle.MappingName = "ID";
                dgWorkTableRealizedTableIDStyle.Width = 100;
                dgWorkTableRealizedTableIDStyle.HeaderText = "Номер реализации";

                DataGridTextBoxColumn dgWorkTableRealizedSummStyle = new DataGridTextBoxColumn();
                dgWorkTableRealizedSummStyle.MappingName = "realizedSumm";
                dgWorkTableRealizedSummStyle.Width = 100;
                dgWorkTableRealizedSummStyle.HeaderText = "Реализованная сумма";

                DataGridTextBoxColumn dgWorkTableRealizingDateStyle = new DataGridTextBoxColumn();
                dgWorkTableRealizingDateStyle.MappingName = "realizingDate";
                dgWorkTableRealizingDateStyle.Width = 100;
                dgWorkTableRealizingDateStyle.Format = "dd-MMMM-yyyy";
                dgWorkTableRealizingDateStyle.HeaderText = "Дата реализации";

                DataGridTextBoxColumn dgWorkTableRealizedTableNotesStyle = new DataGridTextBoxColumn();
                dgWorkTableRealizedTableNotesStyle.MappingName = "note";
                dgWorkTableRealizedTableNotesStyle.Width = 100;
                dgWorkTableRealizedTableNotesStyle.HeaderText = "Заметки";

                DataGridTextBoxColumn dgWorkTableRealizedTableClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableRealizedTableClientIDStyle.MappingName = "clientID";
                dgWorkTableRealizedTableClientIDStyle.Width = 100;
                dgWorkTableRealizedTableClientIDStyle.HeaderText = "Номер клиента";

                dgWorkTableRealizedTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                        dgWorkTableRealizedTableIDStyle,
                                                                                                        dgWorkTableRealizedSummStyle,
                                                                                                        dgWorkTableRealizingDateStyle,
                                                                                                        dgWorkTableRealizedTableNotesStyle,
                                                                                                        dgWorkTableRealizedTableClientIDStyle});

                dgMainTable.TableStyles.Add(dgWorkTableRealizedTableStyle);

                #endregion

                #region Стиль таблицы group_clients на странице "Основные таблицы"
                DataGridTableStyle dgWorkTableGroupClientsStyle = new DataGridTableStyle();
                dgWorkTableGroupClientsStyle.MappingName = "group_clients";

                DataGridTextBoxColumn dgWorkTableGroupClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupClientIDStyle.MappingName = "GroupClientID";
                dgWorkTableGroupClientIDStyle.Width = 100;
                dgWorkTableGroupClientIDStyle.HeaderText = "ID";

                DataGridTextBoxColumn dgWorkTableGroupClientsGroupIDStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupClientsGroupIDStyle.MappingName = "groupID";
                dgWorkTableGroupClientsGroupIDStyle.Width = 100;
                dgWorkTableGroupClientsGroupIDStyle.HeaderText = "Номер группы";

                DataGridTextBoxColumn dgWorkTableGroupClientsClientIDStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupClientsClientIDStyle.MappingName = "clientID";
                dgWorkTableGroupClientsClientIDStyle.Width = 100;
                dgWorkTableGroupClientsClientIDStyle.HeaderText = "Номер клиента";

                DataGridBoolColumn dgWorkTableGroupClientsIsPaidStyle = new DataGridBoolColumn();
                dgWorkTableGroupClientsIsPaidStyle.MappingName = "IsPaid";
                dgWorkTableGroupClientsIsPaidStyle.Width = 50;
                dgWorkTableGroupClientsIsPaidStyle.HeaderText = "Оплачено";

                DataGridTextBoxColumn dgWorkTableGroupClientsNotesStyle = new DataGridTextBoxColumn();
                dgWorkTableGroupClientsNotesStyle.MappingName = "Notes";
                dgWorkTableGroupClientsNotesStyle.Width = 100;
                dgWorkTableGroupClientsNotesStyle.HeaderText = "Заметки";

                dgWorkTableGroupClientsStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                                      dgWorkTableGroupClientIDStyle,
                                                                                                      dgWorkTableGroupClientsGroupIDStyle,
                                                                                                      dgWorkTableGroupClientsClientIDStyle,
                                                                                                      dgWorkTableGroupClientsIsPaidStyle,
                                                                                                      dgWorkTableGroupClientsNotesStyle});

                dgMainTable.TableStyles.Add(dgWorkTableGroupClientsStyle);

                #endregion

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void FillOnLoad()
        {
            var groups = MySQL.ExecuteQuery("SELECT * FROM `groupstatus`", 2);
            var directions = MySQL.ExecuteQuery("SELECT * FROM `directions`", 2);

            cmbDirections.Items.Clear();
            cmbGroupStatus.Items.Clear();

            foreach(var g in groups)
                cmbGroupStatus.Items.Add(g[1]);
            foreach(var d in directions)
                cmbDirections.Items.Add(d[1]);

            cmbDirections.SelectedIndex = 0;
            cmbGroupStatus.SelectedIndex = 0;

            btnCreateGroup.Enabled = false;
            btnCreateClient.Enabled = false;
            btnShowGroups.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnDeleteGroup.Enabled = false;

        }

        private void InsertToDataGrid(string tableName, string headerName)
        {
            dgMainTable.CaptionText = headerName;
            var table = MySQL.GetDataBase(tableName);
            dgMainTable.DataSource = table;
        }

        private void LoadCoursesDataGrid(int directionID)
        {
            try
            {
                DataTable table = MySQL.GetDataBase("course");
                DataView dv = new DataView(table);
                dv.RowFilter = "directionID = " + directionID.ToString();

                dgCourses.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgCourses_Click(object sender, EventArgs e)
        {
            DataGrid dg = (DataGrid)sender;

            int rowID = dg.CurrentRowIndex;
            if (rowID >= 0)
            {
                DataView dvCourses = (DataView)dg.DataSource;

                DataRow course = dvCourses[rowID].Row;

                int courseID = (int)course["courseID"];
                int statusID = cmbGroupStatus.SelectedIndex + 1;

                DataView dvGroups = new DataView(MySQL.GetDataBase("groups"));
                dvGroups.RowFilter = "courseID = " + courseID.ToString() + " AND StatusID = " + statusID.ToString();

                cmGroupsTable = (CurrencyManager)this.BindingContext[dvGroups, null];
                dgGroups.DataSource = dvGroups;
                btnCreateGroup.Enabled = true;
                btnCreateClient.Enabled = false;
                //btnFindPasteClient.Enabled = false;
                btnDeleteClient.Enabled = false;
                btnDeleteGroup.Enabled = false;
                dgClients.DataSource = null;
            }
        }

        CurrencyManager cmGroupsTable;
        Point pointGroup;
        bool IsRightButtonGroups = false; // Нажата ли правая кнопка мыши над табл. групп
                                          //-----------------------------------------------------------------------
        internal void dgGroups_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dgGroups.DataSource != null)
                {
                    if (IsRightButtonGroups)
                    {
                        DataGrid.HitTestInfo hti = dgGroups.HitTest(pointGroup);
                        cmGroupsTable.Position = hti.Row;

                        IsRightButtonGroups = false;

                        dgGroups.ContextMenu = cmGroups;
                        cmGroups.Show(dgGroups, pointGroup);
                    }
                    else
                    {
                        DataGrid dg = (DataGrid)sender;

                        int rowID = dg.CurrentRowIndex;
                        if (rowID >= 0)
                        {
                            DataView dvGroups = (DataView)dg.DataSource;
                            DataRow group = dvGroups[rowID].Row;
                            int groupID = (int)group["groupID"];

                            btnDeleteGroup.Enabled = true;
                            btnDeleteGroup.Tag = groupID;

                            DataView dvGroupClients = new DataView(MySQL.GetDataBase("group_clients"));
                            dvGroupClients.RowFilter = "groupID = " + groupID.ToString();

                            DataRow[] clients = new DataRow[dvGroupClients.Count];
                            string query = "SELECT `c`.`clientID`, `c`.`fname`, `c`.`lname`, `c`.`fathName`, `c`.`linkData`, `c`.`recorddate`, `c`.`note`, " +
                                "`c`.`paymentType`, `c`.`isRinged` FROM `group_clients` `g` INNER JOIN `clients` `c` ON `c`.`clientID`=`g`.`clientID` WHERE " +
                                $"`g`.`groupID`='{groupID}';";

                            DataTable clnts = MySQL.GetDataBaseQuery(query);
                            // Помещаем полученные записи в таблицу dtClients				
                            if (clnts.Rows.Count > 0)
                            {
                                dgClients.DataSource = clnts;
                                clnts.RowChanged += new DataRowChangeEventHandler(dtClients_RowChanged);

                                //cmClientsTable = (CurrencyManager)this.BindingContext[dtClients, null];
                            }
                            else
                                dgClients.DataSource = null;

                            btnCreateClient.Enabled = true;
                            //btnFindPasteClient.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void dtClients_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            int k = (int)e.Row["clientID"];
            string query = $"UPDATE `clients` SET `fnane`='{e.Row["fname"]}'," +
                $"`lname`='{e.Row["lname"]}',`fathName`='{e.Row["fathName"]}'," +
                $"`linkData`='{e.Row["linkData"]}',`recorddate`='{e.Row["recorddate"]}'," +
                $"`note`='{e.Row["note"]}',`paymentType`='{e.Row["paymentType"]}'," +
                $"`isRinged`='{Convert.ToInt32(e.Row["isRinged"])}' WHERE `clientID`='0'";
            MySQL.ExecuteQueryWithoutResponse(query);
            isEdited= true;
        }
        // Добавляем новую группу со страницы 'Приемная' 
        private void AddNewGroupWaitingRoom()
        {
            try
            {
                Group f = new Group();

                int courseRowID = dgCourses.CurrentRowIndex;
                DataView dvCourses = (DataView)dgCourses.DataSource;
                DataRow course = dvCourses[courseRowID].Row;
                f.Text += course["courseName"].ToString();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int courseID = (int)course[0];

                        var beginDate = f.dtpBeginDate.Value.ToString("yyyy-MM-dd");
                        var endDate = f.dtpEndDate.Value.ToString("yyyy-MM-dd");
                        var beginTime = f.dtpBeginTime.Value.ToString("HH:mm");
                        var endTime = f.dtpEndTime.Value.ToString("HH:mm");
                        var classNumber = int.Parse(f.cmbClassNumber.Text);
                        var clientsCount = 0;
                        var employeeID = f.cmbEmployee.SelectedIndex + 1;
                        var note = f.txtNotes.Text;
                        var StatusID = f.cmbStatus.SelectedIndex + 1;

                        string query = "INSERT INTO `groups`(`groupID`, `beginDate`, `endDate`, `beginTime`, `endTime`, `clientsCount`, `classNumber`, " +
                            $"`courseID`, `employeeID`, `note`, `StatusID`) VALUES " +
                            $"(NULL,'{beginDate}','{endDate}','{beginTime}','{endTime}','{clientsCount}','{classNumber}','{courseID}','{employeeID}','{note}','{StatusID}')";

                        MySQL.ExecuteQueryWithoutResponse(query);
                        isEdited= true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        // Добавление нового клиента со страницы 'Приемная'
        private void AddNewClientWaitingRoom()
        {
            Client f = new Client();

            int groupRowID = dgGroups.CurrentRowIndex;
            DataView dvGroups = (DataView)dgGroups.DataSource;
            DataRow group = dvGroups[groupRowID].Row;
            f.Text += group["groupID"].ToString();
            f.lblClientID.Text = "Новый клиент";
            string query = "INSERT INTO `clients`(`clientID`, `fname`, `lname`, `fathName`, `linkData`, `recorddate`, `note`, `paymentType`, `isRinged`) " +
                        $"VALUES (NULL,'NULL','NULL','NULL','NULL','{DateTime.Now.ToString("yyyy-MM-dd")}','NULL',NULL,'0')";
            MySQL.ExecuteQueryWithoutResponse(query);

            int clientID = Convert.ToInt32(MySQL.ExecuteQuery("SELECT MAX(`clientID`) FROM `clients`"));
            f.GroupID = (int)group["groupID"];
            f.MainForm = this;
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Добавляем данные в табл. clients
                    var fname = f.txtFirstName.Text;
                    var lname = f.txtLastName.Text;
                    var fathName = f.txtFatherName.Text;
                    var linkData = f.txtPhones.Text;
                    var recorddate = f.dtpRecordDate.Value.ToString("yyyy-MM-dd");
                    var note = f.txtNotes.Text;

                    query = $"UPDATE `clients`  SET  `fname`='{fname}', `lname`='{lname}', `fathName`='{fathName}', `linkData`='{linkData}', " +
                        $"`recorddate`='{recorddate}', `note`='{note}' WHERE `clientID`='{clientID}'";

                    MySQL.ExecuteQueryWithoutResponse(query);

                    // Добавляем данные в табл. Group_Clients
                    query = $"INSERT INTO `group_clients`(`GroupClientID`, `groupID`, `clientID`, `IsPaid`, `Notes`) VALUES (NULL,'{group["groupID"]}','{clientID}','0','')";
                    MySQL.ExecuteQueryWithoutResponse(query);
                    isEdited= true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }

                dgGroups_Click(this.dgGroups, new EventArgs());
            }
            else if (f.ShowDialog() == DialogResult.Cancel)
            {
                MySQL.ExecuteQueryWithoutResponse($"DELETE FROM `clients` WHERE `clientID`={clientID}; ALTER TABLE `clients` AUTO_INCREMENT = {clientID}");
            }
        }

        private void dgClients_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Point point = new Point(e.X, e.Y);
                DataGrid.HitTestInfo hti = dgClients.HitTest(point);

                dgClients.ContextMenu = null;
                if (hti.Row >= 0)
                {
                    /*if (e.Button == MouseButtons.Right)
                    {
                        cmiFindClientsClientID.Visible = false;

                        if (hti.Column == 0)
                            cmiFindClientsClientID.Visible = true;

                        dgClients.CurrentRowIndex = hti.Row;
                        cmClients.Show(dgClients, point);
                    }*/

                    btnDeleteClient.Enabled = true;
                    DataTable table = (DataTable)dgClients.DataSource;

                    if (hti.Row <= table.Rows.Count - 1)
                        btnDeleteClient.Tag = table.Rows[hti.Row]["clientID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        // Итоговые расчеты на текущую запись в таблице data
        private void CalculateTotalPage(DataRow currentTotalRow)
        {
            double resultIncome = 0;
            double resultOut = 0;
            double balance = 0;

            int dataID = (int)currentTotalRow[0];

            DataRow[] incomeRows = currentTotalRow.GetChildRows("dataincome");
            DataRow[] outRows = currentTotalRow.GetChildRows("dataexpenses");

            // Определение прихода
            foreach (DataRow dr in incomeRows)
            {
                if (dr[3] == null)
                    continue;

                resultIncome += (double)dr[3];
            }
            txtResultIncome.Text = resultIncome.ToString("c");

            // Определение расхода
            foreach (DataRow dr in outRows)
            {
                if (dr[3] == null)
                    continue;

                resultOut += (double)dr[3];
            }
            txtResultOut.Text = resultOut.ToString("c");

            // Баланс
            balance = resultIncome - resultOut;
            txtBalance.Text = balance.ToString("c");

            // Итоговые расчеты
            double yesterdaySumm = Convert.ToDouble(currentTotalRow[2]);
            txtYesterdaySumm.Text = yesterdaySumm.ToString("c");

            double total = yesterdaySumm + balance;
            txtResultCount.Text = total.ToString("c");

            currentTotalRow["incomeToday"] = (double)resultIncome;      // Приход на сегодня
            currentTotalRow["expanseToday"] = (double)resultOut;            // Расход на сегодня
            currentTotalRow["amountToday"] = yesterdaySumm + balance; // Итог на сегодня. Ко вчерашней сумме прибавляем баланс на сегодня
        }

        int selectedDataNum = 0;
        int selectedData = 0;
        internal void FillPaymentsPage()
        {
            try
            {
                var income = MySQL.GetDataBase("income");
                var expenses = MySQL.GetDataBase("expenses");
                var data = MySQL.GetDataBase("data");

                if(selectedData == 0)
                {
                    selectedData = (int)data.Rows[data.Rows.Count - 1]["dataID"];
                    selectedDataNum = data.Rows.Count;
                }

                int lastDataNum = data.Rows.Count;
                if (lastDataNum < selectedDataNum) 
                {
                    selectedDataNum = 1;
                    selectedData = (int)data.Rows[selectedDataNum - 1]["dataID"];
                }
                else if(selectedDataNum <= 0)
                {
                    selectedDataNum = lastDataNum;
                    selectedData = (int)data.Rows[selectedDataNum - 1]["dataID"];
                }
              
                if (income.Rows.Count != 0)
                {
                    DataView dvIncome = new DataView(income);
                    dvIncome.RowFilter = $"dataID={selectedData}";
                    dgIncome.DataSource = dvIncome;
                }
                
                if (expenses.Rows.Count != 0)
                {
                    DataView dvOut = new DataView(expenses);
                    dvOut.RowFilter = $"dataID={selectedData}";
                    dgOut.DataSource = dgOut;
                }

                lblDateTime.Text = MySQL.ExecuteQuery($"SELECT currentDate FROM data WHERE dataID={selectedData}").Split(' ')[0];
                txtYesterdaySumm.Text = MySQL.ExecuteQuery($"SELECT `amountYesterday` FROM `data` WHERE dataID={selectedData};");
                txtResultCount.Text = MySQL.ExecuteQuery($"SELECT `amountToday` FROM `data` WHERE dataID={selectedData};");
                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void tbMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Equals(tbnFind))
            {
                this.SearchClient();
            }
            if (e.Button.Equals(tbnEmployees))
            {
                this.OpenEmployees();
            }
            if (e.Button.Equals(tbnRefreshMainDB))
            {
                this.UpdateMainData();
            }
        }
        private void SearchClient()
        {
            SearchClient f = new SearchClient();

            f.ShowDialog();

            if (f.isEdited)
                isEdited = true;
        }
        // Форма сотрудников
        private void OpenEmployees()
        {
            Employee f = new Employee();

            f.ShowDialog();

            if (f.isEdited)
                isEdited = true;
        }
        private void UpdateMainData()
        {
            MySQL.ExecuteQueryWithoutResponse("commit;set autocommit=0;start transaction;");
            MessageBox.Show("Данные успешно загружены в базу данных!");
        }
    }
}
