using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountant
{
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath p = new GraphicsPath( FillMode.Alternate);

            p.AddEllipse(new Rectangle(2, 2, this.Width - 5, this.Height - 5));
            
            ((Button)sender).Region = new System.Drawing.Region(p);
            
            // Demonstrate the clip region by drawing a string
            // at the outer edge of the region.
            //g.DrawString("Outside of Clip", new Font("Arial",
            //    12.0F, FontStyle.Regular), Brushes.Black, 0.0F, 0.0F);

            //// Set the Clip property to a new region.
            //e.Graphics.Clip = new Region(new Rectangle(10, 10, 100, 200));

            //// Fill the region.
            //e.Graphics.FillRegion(Brushes.LightSalmon, e.Graphics.Clip);

            //// Demonstrate the clip region by drawing a string
            //// at the outer edge of the region.
            //e.Graphics.DrawString("Outside of Clip", new Font("Arial",
            //    12.0F, FontStyle.Regular), Brushes.Black, 0.0F, 0.0F);
        }
    }
}
