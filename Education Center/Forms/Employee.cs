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
    public partial class Employee : Form
    {
        public bool isEdited = false;
        public Employee()
        {
            InitializeComponent();
            fillTable();
            

        }

        private void fillTable()
        {
            string query = $"SELECT * FROM `employees`";
            var list = MySQL.ExecuteQuery(query, 9);
            dgEmployees.Rows.Clear();
            if (list != null)
            {
                foreach (string[] l in list)
                {
                    string[] date = l[5].Split(' ')[0].Split('.');
                    l[5] = date[2] + "-" + date[1] + "-" + date[0];
                    dgEmployees.Rows.Add(l);
                }
                dgEmployees.Rows[0].Selected = true;
            }
                

        }
        int selectedID = 0 ;
        bool disableEvents = false;
        private void fillTxt(int numIntTab)
        {
            disableEvents= true;

            string id = dgEmployees.Rows[numIntTab].Cells[0].Value.ToString();
            string query = $"SELECT * FROM `employees` WHERE `employeeID`='{id}'";
            selectedID = Convert.ToInt32(id);
            var result = MySQL.ExecuteQuery(query, 9);
            txtEmployeeLastName.Text = result[0][1];
            txtEmployeeFirstName.Text = result[0][2];
            txtEmployeeFatherName.Text = result[0][3];
            txtEmployeeNotes.Text = result[0][4];

            string res = result[0][5];
            DateTime bd = DateTime.ParseExact(result[0][5].Split(' ')[0], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtpBirthDay.Value = bd;

            var directions = MySQL.ExecuteQuery("SELECT * FROM `directions`", 2);
            cmbDirections.Items.Clear();
            foreach (string[] d in directions)
            {
                cmbDirections.Items.Add(d[1]);
            }
            cmbDirections.SelectedIndex = Convert.ToInt32(result[0][6]);

            disableEvents= false;

        }
        
        private void txtEmployeeNotes_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `linkData`='{txtEmployeeNotes.Text}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void cmbDirections_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `directionID`='{cmbDirections.SelectedIndex}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void dtpBirthDay_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `LastName`='{dtpBirthDay.Value.ToString("yyyy-MM-dd")}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void txtEmployeeFatherName_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `FatherName`='{txtEmployeeFatherName.Text}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void txtEmployeeLastName_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `LastName`='{txtEmployeeLastName.Text}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void txtEmployeeFirstName_Validated(object sender, EventArgs e)
        {
            if (disableEvents) return;
            MySQL.ExecuteQueryWithoutResponse($"UPDATE `employees` SET `FirstName`='{txtEmployeeFirstName.Text}' WHERE `employeeID`='{selectedID}'");
            isEdited = true;
            fillTable();
        }

        private void dgEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                int id = dgEmployees.SelectedRows[0].Index;
                fillTxt(id);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int tmp = dgEmployees.SelectedRows[0].Index;
            if (tmp + 1 < dgEmployees.Rows.Count)
            {
                dgEmployees.ClearSelection();
                dgEmployees.Rows[tmp + 1].Selected = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int tmp = dgEmployees.SelectedRows[0].Index;
            if (tmp - 1 >= 0)
            {
                dgEmployees.ClearSelection();
                dgEmployees.Rows[tmp - 1].Selected = true;
            }
                
        }
    }
}
