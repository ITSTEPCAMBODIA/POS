using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;
using System.IO;

namespace POS
{
    public partial class DrinksCategory : BaseForm
    {
        public string code { get { return txtCode.Text; } }
        public string name { get { return txtName.Text; } }
        public DrinksCategory()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DrinksCategory_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            graphics.DrawRectangle(new Pen(Brushes.Black), rectangle.X,rectangle.Y,rectangle.Width-1,rectangle.Height-1);
            graphics.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
