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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void tbMain_Click(object sender, EventArgs e)
        {

            return;
            /*if (e.Button.Equals(tbnFind))
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
            }*/
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            //this.AddNewGroupWaitingRoom();
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

                /* MainDataSet.groupsRow groupRow = mainDataSet.groups.FindBygroupID((int)btnDeleteGroup.Tag);
                //mainDataSet.groups.RemovegroupsRow(groupRow);
                groupRow.Delete();
                btnDeleteGroup.Enabled = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            //this.AddNewClientWaitingRoom();
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
                /*MainDataSet.clientsRow clientRow = mainDataSet.clients.FindByclientID(clientID);
                btnDeleteClient.Enabled = false;


                clientRow.Delete();
                dgGroups_Click(dgGroups, new EventArgs());*/
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
            /*dgGroups.DataSource = null;
            dgClients.DataSource = null;

            if (cmbDirections.SelectedIndex >= 0)
            {
                this.LoadCoursesDataGrid(cmbDirections.SelectedIndex + 1);
            }*/

            btnCreateGroup.Enabled = false;
            btnCreateClient.Enabled = false;
            btnShowGroups.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnDeleteGroup.Enabled = false;
        }
    }
}
