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
using POS.Kimly;

namespace POS.Satya
{
    public partial class tbFoodPrice : BaseForm
    {
        List<Foods> FoodList = new List<Foods>();
        private string ImagePath;
        public tbFoodPrice()
        {
            InitializeComponent();
        }
        private void PbFood_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.ShowDialog();
            file.RestoreDirectory = true;
            try
            {
                PbFood.Image = Image.FromFile(file.FileName);
                ImagePath = file.InitialDirectory;
            }
            catch (ArgumentException) { }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods()
            {
                Code = tbFoodCode.Text,
                Name = tbFoodName.Text,
                Note = tbFoodNote.Text,
                Price = Convert.ToDouble(textBox6.Text),
                ImgPath = ImagePath
            };
            FoodList.Add(foods);
            XmlSerializer xml = new XmlSerializer(typeof(List<Foods>));
            using (Stream file = new FileStream(Environment.CurrentDirectory + "\\Foods.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                xml.Serialize(file, FoodList);
            }
                this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
