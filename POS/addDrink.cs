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
  public partial class addDrink : Form
  {
    public string drinkCode { get; set; }
    public string drinkName { get; set; }
    public string Category { get; set; }
    public string Price { get; set; }
    public string Note { get; set; }
    public string setImage { get; set; }
    OpenFileDialog file = new OpenFileDialog();
    public addDrink()
    {
      InitializeComponent();
    }
    public addDrink(string d_code, string d_name, string d_price, string d_category, string d_note, string d_image)
    {
      InitializeComponent();
      drink_code.Text = d_code;
      drinks_name.Text = d_name;
      category.Text = d_category;
      price.Text = d_price;
      note.Text = d_note;
      setImage = d_image;
      image.SizeMode = PictureBoxSizeMode.StretchImage;
      image.Image = Image.FromFile(d_image);
    }
    void setPropertyOfDrink()
    {
      drinkCode = drink_code.Text;
      drinkName = drinks_name.Text;
      Category = category.Text;
      Price = price.Text;
      Note = note.Text;
      Console.WriteLine(drinkCode);
      if ( file.FileName != "") { setImage = file.FileName; }
      if ( file.FileName == "" && setImage == "")
      {
        MessageBox.Show("Please fill out all information!");
      } else
      {
        DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (drink_code.Text != "" && drinks_name.Text != "" && category.Text != "" && price.Text != "" && note.Text != "")
      {
        setPropertyOfDrink();
      }
    }

    private void btn_add_image_Click(object sender, EventArgs e)
    {
      file.Filter = "bmp file (*.jpg)|*.jpg";
      if (file.ShowDialog() == DialogResult.OK)
      {
        image.SizeMode = PictureBoxSizeMode.StretchImage;
        image.Image = Image.FromFile(file.FileName);
        setImage = file.FileName;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void price_KeyPress(object sender, KeyPressEventArgs e)
    {
      Char chr = e.KeyChar;
      if (Char.IsDigit(chr) == true || chr == 8 || chr == 46)
      {
        e.Handled = false;
      }
      else
      {
        e.Handled = true;
      }
    }
  }
}
