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
    public partial class DrinkForms : Form
    {
         List<DrinkInfo> drinkMenu = new List<DrinkInfo>();
        //List<OrderList> orderLists = new List<OrderList>();
        public DrinkForms()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            hotCategory1.BringToFront(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotCategory1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coldCatergory1.BringToFront();
        }
    }
    
}
