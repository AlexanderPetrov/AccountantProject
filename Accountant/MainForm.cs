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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lnkGoods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoodsForm frmGoods = new GoodsForm();
            this.Hide();
            frmGoods.ShowDialog();
            this.Show();
        }

        private void lnkProviders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProvidersForm frmProviders = new ProvidersForm();
            this.Hide();
            frmProviders.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
