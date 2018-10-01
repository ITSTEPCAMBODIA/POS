using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.History
{
    public partial class History : Form
    {
        public History(ListViewItem[] item)
        {
            InitializeComponent();
            listView1.Items.AddRange(item);
        }
    }
}
