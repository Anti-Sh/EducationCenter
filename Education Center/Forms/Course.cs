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
    public partial class Course : Form
    {
        private DataRow bindingRow;
        internal DataRow BindingRow
        {
            get { return bindingRow; }
            set { bindingRow = value; }
        }
        public Course()
        {
            InitializeComponent();
        }
        public Course(DataRow bindingRow)
        {

            InitializeComponent();
            this.bindingRow = bindingRow;
            this.lblClientID.Text += bindingRow.ItemArray[0].ToString();
            this.txtCourseName.Text = bindingRow.ItemArray[1].ToString();
            this.txtCoursePrice.Text = bindingRow.ItemArray[4].ToString();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            txtCourseName.Focus();
        }

        private void txtCourseName_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (txtCourseName.Text != this.bindingRow["courseName"].ToString())
                {
                    this.bindingRow["courseName"] = txtCourseName.Text;
                }
        }

        private void txtCoursePrice_Validated(object sender, EventArgs e)
        {
            if (this.bindingRow != null)
                if (double.Parse(txtCourseName.Text) != (double)this.bindingRow["priceNumber"])
                {
                    this.bindingRow["priceNumber"] = double.Parse(txtCourseName.Text);
                }
        }
    }
}
