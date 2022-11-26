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
    public partial class PaymentType : Form
    {
        private DataRow selectedRow = null;
        public DataRow SelectedRow
        {
            get { return selectedRow; }
            set { selectedRow = value; }
        }
        public PaymentType()
        {
            InitializeComponent();
            DesignDataGrid();
            dqPaymentType.DataSource = MySQL.GetDataBase("payment_type");
        }

        private void dqPaymentType_Click(object sender, EventArgs e)
        {
            if ((dqPaymentType.CurrentCell.RowNumber != -1) && (dqPaymentType.CurrentCell.ColumnNumber != -1))
                dqPaymentType_CurrentCellChanged(dqPaymentType, new EventArgs());
        }

        private void dqPaymentType_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                //this.SelectedRow = mainDataSet.payment_type.Rows[dqPaymentType.CurrentRowIndex];
                var test = dqPaymentType.CurrentRowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void DesignDataGrid()
        {
            // Дизайн таблицы payment_type
            DataGridTableStyle paymentTypeStyle = new DataGridTableStyle();
            paymentTypeStyle.MappingName = "payment_type";

            DataGridTextBoxColumn paymentTypeIDStyle = new DataGridTextBoxColumn();
            paymentTypeIDStyle.MappingName = "payment_typeID";
            paymentTypeIDStyle.Width = 50;
            paymentTypeIDStyle.HeaderText = "ID";


            DataGridTextBoxColumn paymentTypeNameStyle = new DataGridTextBoxColumn();
            paymentTypeNameStyle.MappingName = "payment_typeName";
            paymentTypeNameStyle.Width = 100;
            paymentTypeNameStyle.HeaderText = "Name";


            DataGridTextBoxColumn paymentTypeNoteStyle = new DataGridTextBoxColumn();
            paymentTypeNoteStyle.MappingName = "note";
            paymentTypeNoteStyle.Width = 200;
            paymentTypeNoteStyle.HeaderText = "Notes";

            paymentTypeStyle.GridColumnStyles.AddRange(new DataGridTextBoxColumn[] {
                                                                                        paymentTypeIDStyle,
                                                                                        paymentTypeNameStyle,
                                                                                        paymentTypeNoteStyle});

            dqPaymentType.TableStyles.Add(paymentTypeStyle);
        }
    }
}
