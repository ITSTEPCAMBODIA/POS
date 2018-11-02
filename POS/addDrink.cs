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
    public int number_no { get; set; }
    OpenFileDialog file = new OpenFileDialog();
    public addDrink()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      drinkCode = drink_code.Text;
      drinkName = drinks_name.Text;
      Category = category.Text;
      Price = price.Text;
      Note = note.Text;
      number_no++;
      this.Close();
    }

    private void btn_add_image_Click(object sender, EventArgs e)
    {
      file.Filter = "bmp file (*.jpg)|*.jpg";
      if (file.ShowDialog() == DialogResult.OK)
      {
        image.SizeMode = PictureBoxSizeMode.StretchImage;
        image.Image = Image.FromFile(file.FileName);
        setImage = file.FileName;
        Console.WriteLine(file.FileName);
      }
    }
  }
}
