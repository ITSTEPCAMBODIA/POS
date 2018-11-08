using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace POS.Login
{
    public partial class Form1 : Form
    {
        List<data_Cashier> addcashier = new List<data_Cashier>();
        XmlSerializer xml = new XmlSerializer(typeof(List<data_Cashier>));
        string path = @"C:\Users\Daveth\Desktop\POS\dataCashier.xml";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                addcashier = (List<data_Cashier>)xml.Deserialize(file);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < addcashier.Count; i++)
            {
                if ( UserName.Text == addcashier[i].set_Cashier_Login && passWord.Text == addcashier[i].set_password)
                {
                    break;
                }
            }
            if ( i < addcashier.Count && UserName.Text == addcashier[i].set_Cashier_Login && passWord.Text == addcashier[i].set_password)
            { 
                MessageBox.Show("Login success");
            } else
            { 
                MessageBox.Show("Your input not correct"); 
            }
        }
    }
}
