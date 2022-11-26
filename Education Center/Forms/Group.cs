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
    public partial class Group : Form
    {
        internal CurrencyManager cmEmployees;
        internal CurrencyManager cmGroupStatus;
        private DataRow bindingRow;
        internal DataRow BindingRow
        {
            get { return bindingRow; }
            set { bindingRow = value; }
        }

        public Group()
        {
            InitializeComponent();

            cmbStatus.DataSource = MySQL.GetDataBase("groupstatus");
            cmbStatus.DisplayMember = "StatusName";
            //cmGroupStatus = (CurrencyManager)this.BindingContext[cmbStatus.DataSource, "GroupStatus"];

            cmbEmployee.DataSource = MySQL.GetDataBase("employees");
            cmbEmployee.DisplayMember = "LastName";
            //cmEmployees = (CurrencyManager)this.BindingContext[cmbEmployee.DataSource, "employees"];

            Size labelSize = new Size(this.Width, lblGroupID.Size.Height);
            this.lblGroupID.Size = labelSize;
            
        }

       
        /*public Group(MainDataSet ds, DataRow bindingRow)
        {
            InitializeComponent();
            mainDataSet = ds;

            cmbStatus.DataSource = mainDataSet.GroupStatus;
            cmbStatus.DisplayMember = "StatusName";
            //cmGroup = (CurrencyManager)this.BindingContext[mainDataSet, "GroupStatus"];
            DataView dvStatus = (DataView)cmGroupStatus.List;
            dvStatus.Sort = "StatusID";
            int statusPos = dvStatus.Find(bindingRow["StatusID"]);
            cmbStatus.SelectedIndex = statusPos;

            cmbEmployee.DataSource = mainDataSet.employees;
            cmbEmployee.DisplayMember = "EmployeeName";
            //cmEmployees = (CurrencyManager)this.BindingContext[mainDataSet, "employees"];
            DataView dvEmployee = (DataView)cmEmployees.List;
            dvEmployee.Sort = "employeeID";
            int employeePos = dvEmployee.Find(bindingRow["employeeID"]);
            cmbEmployee.SelectedIndex = employeePos;

            Size labelSize = new Size(this.Width, lblGroupID.Size.Height);
            this.lblGroupID.Size = labelSize;

            this.bindingRow = bindingRow;

            int groupID = (int)bindingRow[0];
            this.lblGroupID.Text += groupID.ToString();

            DateTime beginDate = (DateTime)bindingRow[1];
            this.dtpBeginDate.Value = beginDate;

            DateTime endDate = (DateTime)bindingRow[2];
            this.dtpEndDate.Value = endDate;

            if (bindingRow.ItemArray[3] == null)
            {
                this.dtpBeginTime.Text = "";
            }
            else
            {
                DateTime beginTime = (DateTime)bindingRow[3];
                this.dtpBeginTime.Text = beginTime.ToString("HH:mm");
            }

            if (bindingRow.ItemArray[4] == null)
            {
                this.dtpEndTime.Text = "";
            }
            else
            {
                DateTime endTime = (DateTime)bindingRow[4];
                this.dtpEndTime.Text = endTime.ToString("HH:mm");
            }

            this.txtNotes.Text = bindingRow[9].ToString();
            this.cmbClassNumber.Text = bindingRow[6].ToString();
        }*/

        private void Group_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
        }

        private void dtpBeginDate_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (dtpBeginDate.Value != (DateTime)this.bindingRow["beginDate"])
                {
                    this.bindingRow["beginDate"] = DateTime.Parse(dtpBeginDate.Value.ToString("yyyy-MMMM-dd"));
                }
        }

        private void dtpEndDate_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (dtpEndDate.Value != (DateTime)this.bindingRow["endDate"])
                {
                    this.bindingRow["endDate"] = DateTime.Parse(dtpEndDate.Value.ToString("yyyy-MMMM-dd"));
                }
        }

        private void dtpBeginTime_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (dtpBeginTime.Value != (DateTime)this.bindingRow["beginTime"])
                {
                    this.bindingRow["beginTime"] = DateTime.Parse(dtpBeginTime.Value.ToString("HH:mm"));
                }
        }

        private void dtpEndTime_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (dtpEndTime.Value != (DateTime)this.bindingRow["endTime"])
                {
                    this.bindingRow["endTime"] = DateTime.Parse(dtpEndTime.Value.ToString("HH:mm"));
                }
        }

        private void txtNotes_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (txtNotes.Text != this.bindingRow["note"].ToString())
                {
                    this.bindingRow["note"] = txtNotes.Text;
                }
        }

        private void cmbClassNumber_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (cmbClassNumber.Text != this.bindingRow["classNumber"].ToString())
                {
                    this.bindingRow["classNumber"] = cmbClassNumber.Text;
                }
        }

        private void cmbEmployee_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
            {
                DataRow statusRow = this.bindingRow.GetParentRow("GroupStatusgroups");
                if (cmbEmployee.Text != statusRow["StatusName"].ToString())
                {
                    this.bindingRow["employeeID"] = cmbEmployee.SelectedIndex + 1;
                }
            }
        }

        private void cmbStatus_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
            {
                DataRow statusRow = this.bindingRow.GetParentRow("GroupStatusgroups");
                if (cmbStatus.Text != statusRow["StatusName"].ToString())
                {
                    this.bindingRow["StatusID"] = cmbStatus.SelectedIndex + 1;
                }
            }
        }

    }
}
