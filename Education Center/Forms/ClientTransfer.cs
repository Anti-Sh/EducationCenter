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
    public partial class ClientTransfer : Form
    {
        public ClientTransfer()
        {
            InitializeComponent();
        }

        private void ClientTransfer_Load(object sender, EventArgs e)
        {
            txtClientName.Focus();
        }
    }
}
