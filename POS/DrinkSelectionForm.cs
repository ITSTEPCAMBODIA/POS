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

/// <summary>
///    
///     OK i have an idea for the category button stuff
///     we gon add all drinks controls to GroupBox
///     then List (already DONE)
///     Then when new category is clicked we just delete the current Controls
///     And Generate a new one by just adding the list of new controls
/// 
///     can get complicated if we were to add alot of category
/// 
/// </summary>
namespace POS
{
    
    public partial class DrinkSelectionForm : Form
    {
        public static List<OrderList> orderLists = new List<OrderList>();
        List<Button> CategoryBtn = new List<Button>();
        List<Button> DrinkBtn = new List<Button>();
        List<DrinkInfo> DrinksList = new List<DrinkInfo>();
        List<CategoryData> CategoryList = new List<CategoryData>();
        List<DrinkInfo>[] DrinksInEachCategory;
        XmlSerializer Xml_Drink = new XmlSerializer(typeof(List<DrinkInfo>));
        XmlSerializer Xml_Category = new XmlSerializer(typeof(List<CategoryData>));
        public event EventHandler AHandler;
        public void Get_DrinkData()
        {
            try
            {
                using (FileStream file = new FileStream(Environment.CurrentDirectory + "..\\..\\..\\Data\\Category.xml", FileMode.Open, FileAccess.Read))
                {
                    CategoryList = Xml_Category.Deserialize(file) as List<CategoryData>;
                }
                using (Stream file = new FileStream(Environment.CurrentDirectory + "..\\..\\..\\Data\\Drinks.xml", FileMode.Open, FileAccess.Read))
                {
                    DrinksList = Xml_Drink.Deserialize(file) as List<DrinkInfo>;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("NO Drinks Category Data Found.");
                Close();
            }
            DrinksInEachCategory = new List<DrinkInfo>[CategoryList.Count()];
            int i = 0;
            foreach (CategoryData CD in CategoryList)
            {
                DrinksInEachCategory[i] = (from drink in DrinksList
                                           where drink.Category == CD.Name
                                           select drink).Distinct().ToList();
                i++;
            }
        }

        //Create Category buttons 
        public void Initialize_CategoryBtn()
        {
            int Width = 1122 / CategoryList.Count();
            int BtnX = 140;
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


        //Create Drinks Button and Label
        public void Initialize_Drinks()
        {
            int Col = 0;
            int DrinkBtnX = 130;
            int DrinkBtnY = 100;
            //MessageBox.Show(DrinksInEachCategory[0].Count().ToString());
            foreach (DrinkInfo D in DrinksInEachCategory[0])
            { 
                Label DrinkName = new Label()
                {
                    Text = D.Name,
                    AutoSize = true,
                    Location = new Point(DrinkBtnX, DrinkBtnY+250),
                    Font = new Font("Arial", 16, FontStyle.Bold)
                };
                Label DrinkPriceR = new Label()
                {
                    AutoSize = true,
                    Text = ("R _______________ $"+ D.Price.ToString()),
                    Location = new Point(DrinkBtnX , DrinkBtnY+280),                                 
                    Font = new Font("Arial", 14, FontStyle.Regular)
                };
                Label DrinkPriceL = new Label()
                {
                    AutoSize = true,
                    Text = ("L _______________ $" +  Convert.ToString(D.Price + 0.50)),
                    Location = new Point(DrinkBtnX, DrinkBtnY + 300),
                    Font = new Font("Arial", 14, FontStyle.Regular)
                };
                Label DrinkPriceG = new Label()
                {
                    AutoSize = true,
                    Text = ("G _______________ $" + Convert.ToString(D.Price + 1.00)),
                    Location = new Point(DrinkBtnX, DrinkBtnY + 320),
                    Font = new Font("Arial", 14, FontStyle.Regular)
                };
                try
                {
                    Button Drink = new Button()
                    {
                        Tag = D.Name,
                        Size = new Size(250, 250),
                        Location = new Point(DrinkBtnX, DrinkBtnY),        
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    if (Col < 2)
                    { DrinkBtnX += 450; }
                    else
                    {
                        Col = 0;
                        DrinkBtnX = 130;
                        DrinkBtnY += 450;
                    }
                    if (string.IsNullOrEmpty(D.Path))
                    {
                        Drink.Image = SystemIcons.Error.ToBitmap();                       
                    }
                    else
                    {
                        Drink.BackgroundImage = Image.FromFile(D.Path);
                    }
                    DrinkPanel.Controls.Add(Drink);
                    Drink.Click += B_Click;
                }
                catch (FileNotFoundException) { MessageBox.Show("Image not found"); }
                DrinkPanel.Controls.Add(DrinkName);
                DrinkPanel.Controls.Add(DrinkPriceR);
                DrinkPanel.Controls.Add(DrinkPriceL);
                DrinkPanel.Controls.Add(DrinkPriceG);
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
        
        private void B_Click(object sender, EventArgs e)
        {
            // add order drink
            AddDrinkDialog f = new AddDrinkDialog();
            f.Drinkname = (sender as Button).Tag.ToString();
            f.ShowDialog();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            AddDrinks addDrinks = new AddDrinks ();
            addDrinks.Show();
        }
            
        private void UpBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void DownBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (DrinkPanel.VerticalScroll.Value < DrinkPanel.VerticalScroll.Maximum)
                DrinkPanel.VerticalScroll.Value += 200;
        }

        private void UpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            DrinkPanel.VerticalScroll.Minimum = 0;
            if (DrinkPanel.VerticalScroll.Value <= 200)
                DrinkPanel.VerticalScroll.Value = 0;
            else
                DrinkPanel.VerticalScroll.Value -= 200;
        }
    }
}
