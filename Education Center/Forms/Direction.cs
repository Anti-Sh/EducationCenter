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
    public partial class Direction : Form
    {
        private DataRow bindingRow;
        internal DataRow BindingRow
        {
            get { return bindingRow; }
            set { bindingRow = value; }
        }
        public Direction(DataRow bindingRow)
        {
            InitializeComponent();

            this.bindingRow = bindingRow;

            this.txtDirectionName.Text = bindingRow["directName"].ToString();
            this.txtDirectionNote.Text = bindingRow["note"].ToString();
        }
        public Direction()
        {
            InitializeComponent();
        }

        private void txtDirectionName_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (txtDirectionName.Text != this.bindingRow["directName"].ToString())
                {
                    this.bindingRow["directName"] = txtDirectionName.Text;
                }
        }

        private void txtDirectionNote_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (txtDirectionNote.Text != this.bindingRow["note"].ToString())
                {
                    this.bindingRow["note"] = txtDirectionNote.Text;
                }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Direction_Load(object sender, EventArgs e)
        {
            txtDirectionName.Focus();
        }
    }
}
