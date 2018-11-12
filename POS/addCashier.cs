using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace POS
{
  public partial class addCashier : Form
  {
    public string textfirstname { get; set; }
    public string textLastname { get; set; }
    public string textSex { get; set; }
    public string textBirthDate { get; set; }
    public string textLogin { get; set; }
    public string textPassword { get; set; }
    public string textImage { get; set; }
    public string hired_Date { get; set; }
    public int Served { get; set; }
    public string last_login { get; set; }
    public string User_age { get; set; }

    OpenFileDialog file = new OpenFileDialog();
    //XmlSerializer xml = new XmlSerializer(typeof(data_Cashier));
    //List<data_Cashier> employee = new List<data_Cashier>();
    //XmlTextReader read = new XmlTextReader("G:\\Employee.Xml");
    //TextWriter CreateFile = new StreamWriter("G:\\Employee.Xml");

    public addCashier()
    {
      InitializeComponent();
      textImage = "";
      //image.Image = Image.FromFile("");
    }
    public addCashier(string nameFirst, string nameLast, string sexUser, string birth, string userlogin, string password, string ageUser, string imagetext)
    {
      InitializeComponent();
      firstName.Text = nameFirst;
      lastName.Text = nameLast;
      sex.Text = sexUser;
      birthDateButton.Text = birth;
      login.Text = userlogin;
      passWord.Text = password;
      age.Text = ageUser;
      textImage = imagetext;
      image.SizeMode = PictureBoxSizeMode.StretchImage;
      image.Image = Image.FromFile(imagetext);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      file.Filter = "bmp file (*.jpg)|*.jpg";
      if ( file.ShowDialog() == DialogResult.OK)
      {
        image.SizeMode = PictureBoxSizeMode.StretchImage;
        image.Image = Image.FromFile(file.FileName);
        textImage = file.FileName;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (firstName.Text == "" || lastName.Text == "" || sex.Text == "" || birthDate.Text == "" || login.Text == "" || passWord.Text == "" || textImage == "")
      {
        MessageBox.Show("Please fill out all your all information!!!");
      }
      else
      {
        textfirstname = firstName.Text;
        textLastname = lastName.Text;
        textSex = sex.Text;
        textBirthDate = birthDateButton.Text;
        //Endline
        hired_Date = DateTime.Now.ToString("MM/dd/yyyy");
        textLogin = login.Text;
        textPassword = passWord.Text;
        Served = 0;
        User_age = age.Text;
        if (file.FileName != "") { textImage = file.FileName; }
        last_login = "";
        DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void age_KeyPress(object sender, KeyPressEventArgs e)
    {
      Char chr = e.KeyChar;
      if (Char.IsDigit(chr) == true || chr == 8)
      {
        e.Handled = false;
      }
      else
      {
        e.Handled = true;
      }
    }

    private void birthDateButton_ValueChanged(object sender, EventArgs e)
    {
      birthDate.Text = birthDateButton.Text;
    }
  }
}
