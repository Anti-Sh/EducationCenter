using Education_Center.Classes;
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
        public bool isEdited = false;
        
        public SearchClient()
        {
            InitializeComponent();
            btnFind.Enabled = false;
            btnGetChanges.Enabled = false;
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string partOfQuery = "";
            if (isDateEdited)
            {
                string date = dtpRecDate.Value.ToString("yyyy-MM-dd");
                partOfQuery = $" AND `recorddate`='{date}'";
            }
            string query = $"SELECT * FROM `clients` WHERE `fname` LIKE '%{txtFName.Text}%' AND `lname` LIKE '%{txtLName.Text}%'" + partOfQuery;
            var list = MySQL.ExecuteQuery(query, 9);
            dgSearchRez.Rows.Clear();
            if (list != null)
                foreach (string[] l in list)
                {
                    string[] date = l[5].Split(' ')[0].Split('.');
                    l[5] = date[2] + "-" + date[1] + "-" + date[0];
                    dgSearchRez.Rows.Add(l);
                }
            

        }

        private void btnGetChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string date = rowChanged[5].Value.ToString();

                string query = $"UPDATE `clients` SET `fname`='{rowChanged[1].Value}', `lname`='{rowChanged[2].Value}', `fathName`='{rowChanged[3].Value}', " +
                    $"`linkData`='{rowChanged[4].Value}', `recorddate`='{date}', `note`='{rowChanged[6].Value}', `paymentType`='{rowChanged[7].Value}', " +
                    $"`isRinged`='{(Convert.ToBoolean(rowChanged[8].Value.ToString()) ? 1 : 0)}' WHERE `clientID`='{rowChanged[0].Value}'";
                MySQL.ExecuteQueryWithoutResponse(query);
                isEdited = true;
                btnGetChanges.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        bool isDateEdited = false;

        private void txtLName_Validated(object sender, EventArgs e)
        {
            if(sender.ToString() == dtpRecDate.ToString())
                isDateEdited = true;
            if(!string.IsNullOrEmpty(txtFName.Text) || !string.IsNullOrEmpty(txtLName.Text))
                btnFind.Enabled = true;
            else
                btnFind.Enabled = false;
        }

        private void dgSearchRez_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cells = dgSearchRez.Rows[e.RowIndex].Cells;
            if (cells[1].Value == null || cells[2].Value == null)
                e.Cancel= true;
            else
                e.Cancel= false;
        }

        DataGridViewCellCollection rowChanged;
        private void dgSearchRez_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            rowChanged = dgSearchRez.Rows[e.RowIndex].Cells;
            btnGetChanges.Enabled = true;
        }
    }
}
