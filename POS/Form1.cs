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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "Logan", "freed","Edit");
            dataGridView1.Rows[0].Selected = false;
        }
        private void newCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCashier cashier = new addCashier();
            cashier.ShowDialog();
            Text = cashier.textImage;
            if (cashier.textImage != "")
            {
              imageShow.Image = Image.FromFile(cashier.textImage);
            }
            string[] row = { "2", "God", "god" };
            ListViewItem item = new ListViewItem(row);
            item.Font = new Font("Microsoft Sans Serif", 8.25F);
            //listName.Items.Add(item); 
        }
    }
}
