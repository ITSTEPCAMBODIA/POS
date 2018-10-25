using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace POS
{
  public partial class addCashier : Form
  {
    OpenFileDialog file = new OpenFileDialog();
    public string textfirstname = "", textLastname = "", textSex = "", textBirthDate = "", textLogin = "", textPassword = "", textImage = "";
    XmlSerializer xmlSerial;
    public addCashier()
    {
      InitializeComponent();
      xmlSerial = new XmlSerializer(typeof());
    }

    private void button3_Click(object sender, EventArgs e)
    {
      file.Filter = "bmp file (*.jpg)|*.jpg";
      if ( file.ShowDialog() == DialogResult.OK)
      {
        image.SizeMode = PictureBoxSizeMode.StretchImage;
        image.Image = Image.FromFile(file.FileName);
        Console.WriteLine(file.FileName);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if ( firstName.Text == "" || lastName.Text == "" || sex.Text == "" || birthDate.Text == "" || login.Text == "" || passWord.Text == "")
      {
        MessageBox.Show("Please fill out all your all information!!!");
      }
      else
      {
        textfirstname = firstName.Text; textLastname = lastName.Text; textSex = sex.Text;
        textBirthDate = birthDate.Text; textLogin = login.Text; textPassword = passWord.Text;
        textImage = file.FileName;
        this.Close();
      }
    }
  }
}
