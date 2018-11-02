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
    public int ID { get; set; }

    XmlSerializer xml = new XmlSerializer(typeof(inFoEmployee));
    List<inFoEmployee> employee = new List<inFoEmployee>();
    OpenFileDialog file = new OpenFileDialog();
    XmlTextReader read = new XmlTextReader("G:\\Employee.Xml");
    TextWriter CreateFile = new StreamWriter("G:\\Employee.Xml");

    public addCashier()
    {
      InitializeComponent();
      //image.Image = Image.FromFile("");
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
      //this.Close();
      //XmlSerializer xml = new XmlSerializer(typeof(inFoEmployee));
      //List<inFoEmployee> employee = new List<inFoEmployee>();
      //FileStream repos = new FileStream("G:\\Employee.Xml", FileMode.Open, FileAccess.Read);
      //Console.WriteLine(xml.Deserialize(repos) as List<inFoEmployee>);
      //dataGridView1.DataSource = (List<inFoEmployee>)xml.Deserialize(repos);
      //repos.Close();
      //inFoEmployee emp = new inFoEmployee();
      //while (read.Read())
      //{
      //  if (read.Name == "textLogin")
      //  {
      //    string str = read.ReadElementContentAsString();
      //  }
      //}
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //if (firstName.Text == "" || lastName.Text == "" || sex.Text == "" || birthDate.Text == "" || login.Text == "" || passWord.Text == "")
      //{
      //  MessageBox.Show("Please fill out all your all information!!!");
      //}
      //else
      //{
      textfirstname = "Corn";
      textLastname = "Da Veat";
      textSex = "Male";
      textBirthDate = birthDate.Text;
      //Endline
      hired_Date = DateTime.Now.ToString("MM/dd/yyyy");
      textLogin = "Daveat";
      textPassword = "12345";
      textImage = file.FileName;
      Served = 1;
      ID = 1;
      User_age = "19";
      textImage = file.FileName;
      this.Close();
      //employee.Add(info);
      //xml.Serialize(CreateFile, info);
      //CreateFile.Close();
      //}
    }
  }
}
