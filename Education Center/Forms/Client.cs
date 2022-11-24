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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            this.DesigneDataGrids();
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
    }
}
