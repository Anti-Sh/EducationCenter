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

namespace Education_Center.Forms
{
    public partial class Client : Form
    {
        private int groupID = 0;
        internal int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        private int clientID = 0;
        internal int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private Manager mainForm = null;

        internal Manager MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }

        internal CurrencyManager cmPaymentType;
        public Client()
        {
            InitializeComponent();

            dgPayments.Tag = "Payments";
            dgClientsRealization.Tag = "Realization";
            Size labelSize = new Size(this.Width, lblClientID.Size.Height);
            this.lblClientID.Size = labelSize;
/*
            mainDataSet.income.Columns["clientID"].DefaultValue = this.ClientID;
            mainDataSet.RealizedTable.Columns["clientID"].DefaultValue = this.ClientID;
*/

            DesigneDataGrids();
            btnCreateClientPayment.Click += new EventHandler(btnCreateClientPayment_Click);
            btnRealizedClients.Click += new EventHandler(btnRealizedClients_Click);
            
            cmbPaymentType.DataSource = MySQL.GetDataBase("payment_type");
            
            cmbPaymentType.DisplayMember = "payment_typeName";
            //cmbPaymentType = (CurrencyManager)this.BindingContext[mainDataSet, "payment_type"];
            //cmPaymentType.Position = 0;
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {

        }

        private void txtFatherName_Validated(object sender, EventArgs e)
        {

        }

        private void txtPhones_Validated(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }
        private void DesigneDataGrids()
        {
            // Стиль таблицы оплат клиента 
            DataGridTableStyle incomeTableStyle = new DataGridTableStyle();
            incomeTableStyle.MappingName = "income";

            DataGridTextBoxColumn summaStyle = new DataGridTextBoxColumn();
            summaStyle.MappingName = "summa";
            summaStyle.Width = 100;
            summaStyle.Format = "#.0";
            summaStyle.HeaderText = "Сумма";

            DataGridTextBoxColumn payment_typeIDStyle = new DataGridTextBoxColumn();
            payment_typeIDStyle.MappingName = "payment_typeID";
            payment_typeIDStyle.Width = 100;
            payment_typeIDStyle.HeaderText = "Код вида оплаты";

            DataGridTextBoxColumn noteStyle = new DataGridTextBoxColumn();
            noteStyle.MappingName = "note";
            noteStyle.Width = 100;
            noteStyle.HeaderText = "Заметки";

            DataGridBoolColumn realizedStyle = new DataGridBoolColumn();
            realizedStyle.MappingName = "IsRealized";
            realizedStyle.Width = 100;
            realizedStyle.HeaderText = "Реализовано";

            incomeTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                     summaStyle,
                                                                                     payment_typeIDStyle,
                                                                                     noteStyle});

            dgPayments.TableStyles.Add(incomeTableStyle);

            // Стиль таблицы реализации оплат клиента 
            DataGridTableStyle PlanRealizationTableStyle = new DataGridTableStyle();
            PlanRealizationTableStyle.MappingName = "PlanRealization";

            DataGridTextBoxColumn SummaRealizationStyle = new DataGridTextBoxColumn();
            SummaRealizationStyle.MappingName = "SummaRealization";
            SummaRealizationStyle.Width = 150;
            SummaRealizationStyle.Format = "#.0";
            SummaRealizationStyle.HeaderText = "Сумма реализации";

            DataGridTextBoxColumn DateRealizationStyle = new DataGridTextBoxColumn();
            DateRealizationStyle.MappingName = "DateRealization";
            DateRealizationStyle.Width = 100;
            DateRealizationStyle.HeaderText = "Дата реализации";

            DataGridTextBoxColumn noteRealizationStyle = new DataGridTextBoxColumn();
            noteRealizationStyle.MappingName = "Cause";
            noteRealizationStyle.Width = 100;
            noteRealizationStyle.HeaderText = "Заметки";

            PlanRealizationTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                                SummaRealizationStyle,
                                                                                                DateRealizationStyle,
                                                                                                noteRealizationStyle});

            dgPayments.TableStyles.Add(PlanRealizationTableStyle);

            // Стиль таблицы фактической реализации оплат клиента 
            DataGridTableStyle RealizedTableStyle = new DataGridTableStyle();
            RealizedTableStyle.MappingName = "RealizedTable";

            DataGridTextBoxColumn RealizationSummStyle = new DataGridTextBoxColumn();
            RealizationSummStyle.MappingName = "realizedSumm";
            RealizationSummStyle.Width = 150;
            RealizationSummStyle.HeaderText = "Сумма";

            DataGridTextBoxColumn RealizingDateStyle = new DataGridTextBoxColumn();
            RealizingDateStyle.MappingName = "realizingDate";
            RealizingDateStyle.Width = 150;
            RealizingDateStyle.Format = "dd-MMMM-yyyy";
            RealizingDateStyle.HeaderText = "Дата реализации";

            DataGridTextBoxColumn NoteRealizationStyle = new DataGridTextBoxColumn();
            NoteRealizationStyle.MappingName = "note";
            NoteRealizationStyle.Width = 100;
            NoteRealizationStyle.HeaderText = "Заметки";

            RealizedTableStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                         RealizationSummStyle,
                                                                                         RealizingDateStyle,
                                                                                         NoteRealizationStyle});

            dgClientsRealization.TableStyles.Add(RealizedTableStyle);
        }

        private void btnCreateClientPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var dataID = Manager.DataID;
                var clientID = this.clientID;
                var summa = double.Parse(txtIncomeClientSumm.Text);
                var note = txtIncomeNotes.Text;
                var IsRealized = 0;
                var payment_typeID = MySQL.ExecuteQuery($"SELECT `payment_typeID` FROM `payment_type` WHERE `payment_typeName`='{cmbPaymentType.SelectedItem}';");

                if(dataID == 0 )
                {
                    MySQL.ExecuteQuery("INSERT INTO `data`(`dataID`, `currentDate`, `amountYesterday`, `amountToday`, `incomeToday`, `expanseToday`, `note`) " +
                        $"VALUES (NULL,'{DateTime.Now.ToString("yyyy-MM-dd")}','0','0','0','0','')");
                    Manager.DataID = Convert.ToInt32(MySQL.ExecuteQuery("SELECT MAX(`dataID`) FROM `data`"));
                    dataID = Manager.DataID;
                }
                string query = "INSERT INTO `income`(`incomeID`, `IsRealized`, `dataID`, `summa`, `payment_typeID`, `note`, `ClientID`) VALUES " +
                    $"(NULL,'{IsRealized}','{dataID}','{summa}','{payment_typeID}','{note}','{clientID}')";
                MySQL.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnRealizedClients_Click(object sender, EventArgs e)
        {
            try
            {
                var realizedSumm = double.Parse(txtRealizedSumm.Text);
                var realizingDate = dtpRealizedDate.Value;
                var note = txtRealizingNotes.Text;
                var cID = clientID;

                string query = $"INSERT INTO `realizedtable`(`ID`, `realizedSumm`, `realizingDate`, `note`, `clientID`) VALUES " +
                    $"(NULL,'{realizedSumm}','{realizingDate}','{note}','{cID}')";

                MySQL.ExecuteQueryWithoutResponse(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            this.FilterClients();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            this.PasteSelectedClient();
        }

        private void dgFindedClients_MouseUp(object sender, MouseEventArgs e)
        {
            selectedClientIDInDataGrid = this.GetClientIDInSearchDataGrid(dgFindedClients.HitTest(e.X, e.Y));
        }

        private void dgPayments_MouseUp(object sender, MouseEventArgs e)
        {
            DataGrid dataGrid = (DataGrid)sender;
            DataGrid.HitTestInfo hti = dataGrid.HitTest(new Point(e.X, e.Y));

            if ((hti.Row < 0) || (hti.Column < 0))
                return;

            this.ShowDate(dataGrid, hti);
        }

        private void dgClientsRealization_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Client_Activated(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

        private void FilterClients()
        {
            string clientLastName = txtLastName.Text;
            string clientFirstName = txtFirstName.Text;
            string clientFatherName = txtFatherName.Text;

            DataView dataView = new DataView(MySQL.GetDataBase("clients"));
            string filter = "fname = \'" + clientFirstName + "\' OR lname = \'" + clientLastName + "\' OR fathName = \'" + clientFatherName + "\'";
            dataView.RowFilter = filter;

            dgFindedClients.DataSource = dataView;
        }

        private int GetClientIDInSearchDataGrid(DataGrid.HitTestInfo hti)
        {
            if (hti.Row == -1)
                return -1;

            DataView searchDataView = (DataView)dgFindedClients.DataSource;
            return (int)searchDataView[hti.Row].Row["clientID"];
        }

        private void PasteSelectedClient()
        {
            try
            {
                if (selectedClientIDInDataGrid == -1)
                {
                    MessageBox.Show("Не выбран клиент!");
                    return;
                }

                var groupID  = this.GroupID;
                var clientID  = selectedClientIDInDataGrid;
                var IsPaid = 0;

                string query = "INSERT INTO `group_clients`(`GroupClientID`, `groupID`, `clientID`, `IsPaid`, `Notes`) VALUES " +
                    $"(NULL,'{groupID}','{clientID}','{IsPaid}','')";

                MySQL.ExecuteQueryWithoutResponse(query);
                MainForm.IsEdited = true;

                if (this.MainForm != null)
                    MainForm.dgGroups_Click(MainForm.dgGroups, new EventArgs());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        int selectedClientIDInDataGrid = -1;

        private void ShowDate(DataGrid dataGrid, DataGrid.HitTestInfo hti)
        {
            string caption = dataGrid.Tag.ToString();
            dataGrid.CaptionText = "";
            DataView dataView = (DataView)dataGrid.DataSource;
            DataRow row = null;

            row = (DataRow)dataView[hti.Row].Row;

            DateTime date;
            DataRow mainRow = null;
            if (dataGrid.Tag.ToString() == "Payments")
            {
                mainRow = row.GetParentRow("dataincome");

                if (mainRow == null)
                    return;

                date = (DateTime)mainRow["currentDate"];
            }
            else if (dataGrid.Tag.ToString() == "Realization")
            {
                mainRow = row;

                if (mainRow == null)
                    return;

                date = (DateTime)mainRow["DateRealization"];
            }
            else
                return;

            string textFormat = String.Format(" - Date: {0}", date.ToString("dd MMMM yyyy"));
            caption += textFormat;
            dataGrid.CaptionText = caption;
        }
    }
}
