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
    public partial class AddDrinks : BaseForm
    {
        public event EventHandler<EventDrink> onSave;
        public event EventHandler<EventDrink> onCancel;
        List<CategoryData> categories = new List<CategoryData>();
        List<DrinkInfo> drinks = new List<DrinkInfo>();
        private bool IsChangeCategory = false;
        string ImagePath = null;
        public AddDrinks()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDrink_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.ShowDialog();
            try
            {
                pbDrink.Image = Image.FromFile(file.FileName);
                ImagePath = file.FileName;
            }
            catch(ArgumentException) {}
        }

        private void NewCategory_Click(object sender, EventArgs e)
        {
            DrinksCategory category = new DrinksCategory();
            category.StartPosition = FormStartPosition.CenterParent;
            if(category.ShowDialog() == DialogResult.OK)
            {
                if (category.code != "" && category.name != "")
                {
                    CategoryData data = new CategoryData() { Code = category.code, Name = category.name };
                    categories.Add(data);
                    IEnumerable<string> categoryName = from cate in categories
                                                       select cate.Name;
                    cbCategory.DataSource = categoryName.Cast<object>().ToList();
                    cbCategory.SelectedItem = data.Name;
                    IsChangeCategory = true;
                }
            }
        }

        private void AddDrinks_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            graphics.DrawRectangle(new Pen(Brushes.Black), rectangle.X, rectangle.Y, rectangle.Width - 1, rectangle.Height - 1);
            graphics.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FormClosing -= new FormClosingEventHandler(AddDrinks_FormClosing);
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<CategoryData>));
                if (IsChangeCategory == false) throw new Exception("File not change");
                using (FileStream file = new FileStream(Environment.CurrentDirectory + "\\Category.xml", FileMode.Create, FileAccess.Write))
                {
                    xml.Serialize(file, categories);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception) { }
            onCancel?.Invoke(this, new EventDrink { });
            this.Close();
        }

        private void AddDrinks_Load(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<CategoryData>));
            try
            {
                using(FileStream file = new FileStream(Environment.CurrentDirectory + "\\Category.xml", FileMode.Open, FileAccess.Read))
                {
                    categories = xml.Deserialize(file) as List<CategoryData>;
                }
                IEnumerable<string> categoryName = from cate in categories
                                                   select cate.Name;
                cbCategory.DataSource = categoryName.Cast<object>().ToList();
            }
            catch(FileNotFoundException) {}

            xml = new XmlSerializer(typeof(List<DrinkInfo>));
            try
            {
                using(FileStream file = new FileStream(Environment.CurrentDirectory + "\\Drinks.xml", FileMode.Open, FileAccess.Read))
                {
                    drinks = xml.Deserialize(file) as List<DrinkInfo>;
                }
            }
            catch(FileNotFoundException) { }
        }

        private void Keyboard_keypress(object sender, Keypress e)
        {
            ActiveTextBox.Text += e.KeyCharecter;
        }

        private void AddDrinks_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            XmlSerializer xml = new XmlSerializer(typeof(List<CategoryData>));
                if (IsChangeCategory == false) throw new Exception("File not change");
                using (FileStream file = new FileStream(Environment.CurrentDirectory + "\\Category.xml", FileMode.Create, FileAccess.Write))
                {
                    xml.Serialize(file, categories);
                }
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            catch(IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch(Exception) { }

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<DrinkInfo>));
                DrinkInfo drink = new DrinkInfo();
                drink.Code = txtCode.Text;
                drink.Name = txtName.Text;
                drink.Category = cbCategory.SelectedItem.ToString();
                    try
                    {
                        drink.Price = Double.Parse(txtPrice.Text);
                    }
                    catch(ArgumentNullException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    catch(FormatException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    catch(OverflowException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                drink.Note = txtNote.Text;
                drink.Path = ImagePath;
                drinks.Add(drink);
                using (FileStream file = new FileStream(Environment.CurrentDirectory + "\\Drinks.xml", FileMode.Create, FileAccess.Write))
                {
                    xml.Serialize(file, drinks);
                    onSave?.Invoke(this, new EventDrink { newDrink = drink });
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch(IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void pbDrink_MouseEnter(object sender, EventArgs e)
        {
            pbDrink.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbDrink_MouseLeave(object sender, EventArgs e)
        {
            pbDrink.BorderStyle = BorderStyle.FixedSingle;
        }
    }
    public class EventDrink : EventArgs
    {
        public DrinkInfo newDrink { get; set; }
    }
}
