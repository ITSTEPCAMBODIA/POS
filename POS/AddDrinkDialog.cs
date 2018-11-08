using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class AddDrinkDialog : Form
    {
        string DrinkSize { get; set; }
        public string Drinkname { get; set; }
        public AddDrinkDialog()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            OrderList list = new OrderList();
            list.DrinksName = this.Drinkname;
            if (DrinkSize == null)
            {
                list.DrinksSize = "R";
            }
            else list.DrinksSize = DrinkSize;
            if (chbCream.Checked)
            {
                list.IsCream = true;
            }
            else list.IsCream = false;
            list.SugarLimitation = cbSugar.SelectedItem.ToString();
            list.Zone = cbZone.SelectedItem.ToString();
            MessageBox.Show($"{list.DrinksName} {list.DrinksSize} {list.IsCream} {list.SugarLimitation} {list.Zone}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SizeSelection(object sender, EventArgs e)
        {
            this.DrinkSize = (sender as Button).Text;
        }
    }
}
