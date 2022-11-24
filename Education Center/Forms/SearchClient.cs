using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Center.Forms
{
    public partial class SearchClient : Form
    {
        private DataTable dtClients;
        public DataView dvSearchRez;

        private CurrencyManager currManagerClients;
        public CurrencyManager CurrencyManagerClients
        {
            get { return currManagerClients; }
            set { currManagerClients = value; }
        }
        public SearchClient(MainDataSet mainDataSet)
        {
            InitializeComponent();
            this.MakeStyleForDataGrid();
            // ВАЖНО
            // https://stackoverflow.com/questions/14020038/filling-a-datatable-in-c-sharp-using-mysql
            dtClients = new DataTable();

            dtClients.RowChanged += new DataRowChangeEventHandler(dtSearchRez_RowChanged);
            dgSearchRez.MouseUp += new MouseEventHandler(dgSearchRez_MouseUp);
            currManagerClients = (CurrencyManager)this.BindingContext[mainDataSet, "income"];
        }

        private void MakeStyleForDataGrid()
        {
            DataGridTableStyle clientsTableStyle = new DataGridTableStyle();
            clientsTableStyle.MappingName = "clients";

            DataGridTextBoxColumn clientIDStyle = new DataGridTextBoxColumn();
            clientIDStyle.MappingName = "clientID";
            clientIDStyle.Width = 50;
            clientIDStyle.HeaderText = "ID";

            DataGridTextBoxColumn clientFirstNameStyle = new DataGridTextBoxColumn();
            clientFirstNameStyle.MappingName = "fname";
            clientFirstNameStyle.Width = 150;
            clientFirstNameStyle.HeaderText = "Имя";

            DataGridTextBoxColumn clientLastNameStyle = new DataGridTextBoxColumn();
            clientLastNameStyle.MappingName = "lname";
            clientLastNameStyle.Width = 150;
            clientLastNameStyle.HeaderText = "Фамилия";

            DataGridTextBoxColumn clientFatherNameStyle = new DataGridTextBoxColumn();
            clientFatherNameStyle.MappingName = "fathName";
            clientFatherNameStyle.Width = 150;
            clientFatherNameStyle.HeaderText = "Отчество";

            DataGridTextBoxColumn clientLinkDataStyle = new DataGridTextBoxColumn();
            clientLinkDataStyle.MappingName = "linkData";
            clientLinkDataStyle.Width = 150;
            clientLinkDataStyle.HeaderText = "Контакты";

            DataGridTextBoxColumn clientRecordDateStyle = new DataGridTextBoxColumn();
            clientRecordDateStyle.MappingName = "recorddate";
            clientRecordDateStyle.Width = 150;
            clientRecordDateStyle.HeaderText = "Дата записи";

            DataGridTextBoxColumn clientNotesStyle = new DataGridTextBoxColumn();
            clientNotesStyle.MappingName = "note";
            clientNotesStyle.Width = 150;
            clientNotesStyle.HeaderText = "Заметки";

            DataGridTextBoxColumn clientPaymentTypeStyle = new DataGridTextBoxColumn();
            clientPaymentTypeStyle.MappingName = "paymentType";
            clientPaymentTypeStyle.Width = 150;
            clientPaymentTypeStyle.HeaderText = "Вид оплаты";

            clientsTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
                                                                                      clientIDStyle,
                                                                                      clientFirstNameStyle,
                                                                                      clientLastNameStyle,
                                                                                      clientFatherNameStyle,
                                                                                      clientLinkDataStyle,
                                                                                      clientRecordDateStyle,
                                                                                      clientNotesStyle,
                                                                                      clientPaymentTypeStyle});

            dgSearchRez.TableStyles.Add(clientsTableStyle);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnGetChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //daSearch.Update(dtClients.GetChanges());
                btnGetChanges.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgSearchRez_ShowParentDetailsButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void dtSearchRez_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            btnGetChanges.Enabled = true;
        }

        private void dgSearchRez_MouseUp(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int rowIndex = dgSearchRez.CurrentRowIndex;

            if (rowIndex >= 0)
            {
                DataGrid.HitTestInfo hti = dgSearchRez.HitTest(point);
                this.SelectedRow = dvSearchRez[hti.Row].Row;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        #region IFindingForm Members

        private DataRow selectedRow;
        public DataRow SelectedRow
        {
            get
            {
                return selectedRow;
            }
            set
            {
                selectedRow = value;
            }
        }

        #endregion
    }
}
