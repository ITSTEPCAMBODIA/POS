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
namespace POS
{
    
    public partial class DrinkSelectionForm : Form
    {
        public static List<OrderList> orderLists = new List<OrderList>();
        List<Button> CategoryBtn = new List<Button>();
        List<Button> DrinkBtn = new List<Button>();
        List<DrinkInfo> DrinksList = new List<DrinkInfo>();
        List<CategoryData> CategoryList = new List<CategoryData>();
        XmlSerializer Xml_Drink = new XmlSerializer(typeof(List<DrinkInfo>));
        XmlSerializer Xml_Category = new XmlSerializer(typeof(List<CategoryData>));

        public void Get_DrinkData()
        {
            try
            {
                using (FileStream file = new FileStream(Environment.CurrentDirectory + "\\Category.xml", FileMode.Open, FileAccess.Read))
                {
                    CategoryList = Xml_Category.Deserialize(file) as List<CategoryData>;
                }
                using (Stream file = new FileStream(Environment.CurrentDirectory + "\\Drinks.xml", FileMode.Open, FileAccess.Read))
                {
                    DrinksList = Xml_Drink.Deserialize(file) as List<DrinkInfo>;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("NO Drinks Category Data Found.");
                Close();
            }
        }

        //Create Category buttons 
        public void Initialize_CategoryBtn()
        {
            int Width = 1300 / CategoryList.Count();
            int BtnX = 70;
            foreach (CategoryData C in CategoryList)
            {
                Button b = new Button
                {
                    Tag = C.Name,
                    Text = C.Name,
                    Location = new Point(BtnX,180),
                    Size = new Size(Width, 70),
                    Font = new Font("Arial", 26, FontStyle.Regular)
                };
                BtnX += Width;
                Controls.Add(b);
                CategoryBtn.Add(b);
            }
            
        }

        private void B_Click(object sender, EventArgs e)
        {
            // add order drink
            AddDrinkDialog f = new AddDrinkDialog((sender as Button).Tag.ToString());
            f.ShowDialog();
        }

        //Create Drinks Button and Label
        public void Initialize_Drinks()
        {
            int Col = 0;
            int DrinkBtnX = 200;
            int DrinkBtnY = 300;
            foreach (DrinkInfo D in DrinksList)
            { 
                Label DrinkName = new Label()
                {
                    Text = D.Name,
                    Font = new Font("Arial", 16, FontStyle.Regular),
                    Location = new Point(DrinkBtnX, DrinkBtnY+250)
                };
                Label DrinkPrice = new Label()
                {
                    Text = ($"23412847214${D.Price.ToString()}"),
                    //AutoEllipsis = true,
                    Font = new Font("Arial", 15, FontStyle.Regular),
                    Location = new Point(DrinkBtnX, DrinkBtnY+270),
                    //TextAlign = ContentAlignment.BottomCenter
                };
                try
                {
                    Button Drink = new Button()
                    {
                        Tag = D.Name,
                        Size = new Size(250, 250),
                        Location = new Point(DrinkBtnX, DrinkBtnY),
                        //BackgroundImage = Image.FromFile(D.Path),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    if (Col < 3)
                    { DrinkBtnX += 450; }
                    else
                    { DrinkBtnY = 700; }
                    Controls.Add(Drink);
                    Drink.Click += B_Click;
                }
                catch (FileNotFoundException) { }
                Controls.Add(DrinkName);
                Controls.Add(DrinkPrice);
                Col++;
            }
        }
            
        public DrinkSelectionForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Get_DrinkData();
            Initialize_Drinks();
            Initialize_CategoryBtn();
        }
        
    }
}
