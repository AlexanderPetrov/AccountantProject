using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountant
{
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditGoodForm frmAddNewProduct = new AddEditGoodForm();
            if (frmAddNewProduct.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
