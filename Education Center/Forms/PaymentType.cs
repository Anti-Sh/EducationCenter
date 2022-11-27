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
        public string[][] paymentTypes;
        public PaymentType()
        {
            InitializeComponent();
            var list = MySQL.ExecuteQuery("SELECT * FROM payment_type", 3);
            dgPaymentType.Rows.Clear();
            if (list != null)
                foreach(string[] l in list)
                {
                    dgPaymentType.Rows.Add(l);
                }
            else
                dgPaymentType.Rows.Add(new string[]{ "1",null, null});

        }

        private void dgPaymentType_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if( dgPaymentType.Rows[e.RowIndex].Cells[1].Value == null  || dgPaymentType.Rows[e.RowIndex].Cells[1].Value.ToString() == "") {
                dgPaymentType.Rows[e.RowIndex].Cells[1].ErrorText = "Заполните ячейку!";
                dgPaymentType.AllowUserToAddRows = false;
                return;
            }
            dgPaymentType.Rows[e.RowIndex].Cells[1].ErrorText = null;
            dgPaymentType.AllowUserToAddRows = true;

        }

        private void dgPaymentType_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = NewPaymentTypeID();
        }
        private int NewPaymentTypeID() => Convert.ToInt32(dgPaymentType.Rows[dgPaymentType.Rows.Count - 2].Cells[0].Value) + 1;

        private void btnOK_Click(object sender, EventArgs e)
        {
            paymentTypes = new string[dgPaymentType.Rows.Count][];
            int counter = 0;
            foreach (DataGridViewRow row in dgPaymentType.Rows)
            {
                if (row.IsNewRow)
                    break;
                paymentTypes[counter] = new string[row.Cells.Count];
                paymentTypes[counter][0] = row.Cells[0].Value.ToString();
                paymentTypes[counter][1] = row.Cells[1].Value.ToString();
                paymentTypes[counter][2] = row.Cells[2].Value != null ? paymentTypes[counter][2] = row.Cells[2].Value.ToString() : "";
                if (row.Cells[2].Value != null)
                    paymentTypes[counter][2] = row.Cells[2].Value.ToString();
                else

                counter++;
            }
        }
    }
}
