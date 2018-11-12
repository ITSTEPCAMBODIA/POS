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

        //List for storing all the Drinks and category
        List<DrinkInfo> DrinksList = new List<DrinkInfo>();
        List<CategoryData> CategoryList = new List<CategoryData>();
        
        //Array of List for storing all Controls
        List<Button>[] DrinkBtnALL ;
        List<Label>[] DrinkLabelALL ;
        List<Button>[] CategoryBtnALL;

        //Self Explained
        List<Button> CategoryBtn = new List<Button>();
        
        //list for storing Controls per category
        List<Button> DrinkBtnList = new List<Button>();
        List<Label> DrinksLabel = new List<Label>();

        //Array for storing drinks in each of their own category
        List<DrinkInfo>[] DrinksInEachCategory;
        
        //Array of categories
        //only nesscary for when they are alot of categories
        List<CategoryData>[] CategoriesInPanel;

        int CategoryPanelIndex;

        XmlSerializer Xml_Drink = new XmlSerializer(typeof(List<DrinkInfo>));
        XmlSerializer Xml_Category = new XmlSerializer(typeof(List<CategoryData>));

        public void Get_DrinkData()
        {
            //get data from XML to Lists
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

            {
                //if have more than 3 button Initialize more category panels
                double CateogryPanels = CategoryList.Count() / 3.00;
                if (CateogryPanels > 1.00)
                    CateogryPanels++;
                int CateogryPanelsInt = Convert.ToInt32(CateogryPanels);
                CategoriesInPanel = new List<CategoryData>[CateogryPanelsInt];
                CategoryBtnALL = new List<Button>[CateogryPanelsInt];
                //MessageBox.Show("Size of Category BTN = " + CateogryPanelsInt.ToString()+" OR "+CategoryBtnALL.Length.ToString());
            }

            {
                int i = 0;
                foreach (CategoryData CD in CategoryList)
                {

                    DrinksInEachCategory[i++] = (from drink in DrinksList
                                                 where drink.Category == CD.Name
                                                 select drink).Distinct().ToList();

                }
            }
            //add to a new index of category every 3rd category
            //this is done 
            //So we can shift left right when there are way too many categories
            DrinkBtnALL = new List<Button>[CategoryList.Count];
            DrinkLabelALL = new List<Label>[CategoryList.Count];  
            for(int j = 0; j < CategoryList.Count ; j++)
            {
                DrinkBtnALL[j] = new List<Button>();
                DrinkLabelALL[j] = new List<Label>();
            }
            for (int j = 0; j < CategoriesInPanel.Count(); j++)
            {
                CategoriesInPanel[j] = new List<CategoryData>();
                CategoryBtnALL[j] = new List<Button>();
                CategoriesInPanel[j] = CategoryList.Skip(j*3).Take((j+1)*3).ToList();                  
            }
        }

        //Create Category buttons 
        public void Initialize_CategoryBtn()
        {
            int BtnWidth = categoryPanel.Width/3;
            int Index = 0;
            int CategoryIndex = 0;
            foreach (List<CategoryData> LC in CategoriesInPanel)
            {
                int X = 0;
                foreach (CategoryData C in LC)
                {
                    Button b = new Button
                    {
                        Tag = Index++,
                        Text = C.Name,
                        Location = new Point(X, 0),
                        Size = new Size(BtnWidth, categoryPanel.Height),
                        Font = new Font("Arial", 26, FontStyle.Regular),
                        BackColor = Color.DarkGray,
                    };
                    X += BtnWidth;
                    b.FlatAppearance.BorderSize = 3;
                    b.Click += new EventHandler(CategoryBtn_Clicked);
                    categoryPanel.Controls.Add(b);
                    CategoryBtnALL[CategoryIndex].Add(b);                   
                }
                CategoryIndex++;
            }
        }

        //Create Drinks Button and Label
        public void Initialize_Drinks()
        {
            int Index = 0;
            foreach(List<DrinkInfo> DrinksPerCategory in DrinksInEachCategory )
            {
                int Col = 0;
                int DrinkBtnX = 130;
                int DrinkBtnY = 50;
                foreach (DrinkInfo D in DrinksPerCategory)
                {
                    Label DrinkName = new Label()
                    {
                        Text = D.Name,
                        AutoSize = true,
                        Location = new Point(DrinkBtnX, DrinkBtnY + 250),
                        Font = new Font("Arial", 16, FontStyle.Bold)
                    };
                    Label DrinkPriceR = new Label()
                    {
                        AutoSize = true,
                        Text = ("R _______________ $" + D.Price.ToString()),
                        Location = new Point(DrinkBtnX, DrinkBtnY + 280),
                        Font = new Font("Arial", 14, FontStyle.Regular)
                    };
                    Label DrinkPriceL = new Label()
                    {
                        AutoSize = true,
                        Text = ("L _______________ $" + Convert.ToString(D.Price + 0.50)),
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
                    Button DrinkBtn = new Button();
                    try
                    {
                        DrinkBtn.Tag = D.Name;
                        DrinkBtn.Size = new Size(250, 250);
                        DrinkBtn.Location = new Point(DrinkBtnX, DrinkBtnY);
                        DrinkBtn.BackgroundImageLayout = ImageLayout.Stretch;
                        if (Col < 2)
                        {
                            Col++;
                            DrinkBtnX += 450;
                        }
                        else
                        {
                            Col = 0;
                            DrinkBtnX = 130;
                            DrinkBtnY += 450;
                            DrinkPanel.VerticalScroll.Maximum += 700;
                        }
                        if (string.IsNullOrEmpty(D.Path))
                        { DrinkBtn.Image = SystemIcons.Error.ToBitmap(); }
                        else
                        { DrinkBtn.BackgroundImage = Image.FromFile(D.Path); }
                    }
                    catch (FileNotFoundException) { MessageBox.Show("Image not found"); }
                    DrinkBtn.Click += B_Click;                 
                    DrinkLabelALL[Index].Add(DrinkName);
                    DrinkLabelALL[Index].Add(DrinkPriceR);
                    DrinkLabelALL[Index].Add(DrinkPriceL);
                    DrinkLabelALL[Index].Add(DrinkPriceG);
                    DrinkBtnALL[Index].Add(DrinkBtn);
                    //here we save them to a List
                }
                Index++;
               
            }
        }
        //Just a bunch of button to show stuff
        private void B_Click(object sender, EventArgs e)
        {
            // add order drink
            AddDrinkDialog f = new AddDrinkDialog();
            f.Drinkname = (sender as Button).Tag.ToString();
            f.ShowDialog();
        }

        private void CategoryBtn_Clicked(object sender,EventArgs e)
        {
            int Index = Convert.ToInt32((sender as Button).Tag);
            DrinkPanel.Controls.Clear();
            DrinkPanel.Controls.AddRange(DrinkLabelALL[Index].ToArray());
            DrinkPanel.Controls.AddRange(DrinkBtnALL[Index].ToArray());
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            AddDrinks addDrinks = new AddDrinks ();
            addDrinks.Show();
        }

        private void DownBtn_MouseDown(object sender, MouseEventArgs e)
        {

            if (DrinkPanel.VerticalScroll.Value < DrinkPanel.VerticalScroll.Maximum)
                DrinkPanel.VerticalScroll.Value += 50;
            
        }

        private void UpBtn_MouseDown(object sender, MouseEventArgs e)
        {

            DrinkPanel.VerticalScroll.Minimum = 0;
            if (DrinkPanel.VerticalScroll.Value <= 50)
                DrinkPanel.VerticalScroll.Value = 0;
            else
                DrinkPanel.VerticalScroll.Value -= 50;
        }

        private void LeftShiftBtn_Click(object sender, EventArgs e)
        {
            if (CategoryPanelIndex > 0)
            {
                CategoryPanelIndex--;
                categoryPanel.Controls.Clear();
                categoryPanel.Controls.AddRange(CategoryBtnALL[CategoryPanelIndex].ToArray());
            }
        }

        private void RightShiftBtn_Click(object sender, EventArgs e)
        {         
                if (CategoryPanelIndex < CategoriesInPanel.Count()-1)
                {
                    CategoryPanelIndex++;
                    categoryPanel.Controls.Clear();
                    categoryPanel.Controls.AddRange(CategoryBtnALL[CategoryPanelIndex].ToArray());
                }
           
        }

        public DrinkSelectionForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Get_DrinkData();
            Initialize_Drinks();
            Initialize_CategoryBtn();
            /*
            MessageBox.Show(DrinkPanel.VerticalScroll.Value.ToString());
            MessageBox.Show(DrinkPanel.VerticalScroll.Minimum.ToString());
            MessageBox.Show(DrinkPanel.VerticalScroll.Maximum.ToString());
            */
        }

    }
}
