using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace POS
{
  public partial class Form1 : Form
  {
    data_Cashier data_of_cashier;
    addCashier cashier;
    addDrink drink = new addDrink();
    List<data_Cashier> add_Cashier = new List<data_Cashier>();
    XmlSerializer write = new XmlSerializer(typeof(List<data_Cashier>));
    string path = @"C:\Users\Daveth\Desktop\POS\dataCashier.xml";
    int increaseId;
    public Form1()
    {
      InitializeComponent();
      increaseId = 1;
      if (File.Exists(path))
      {
        //add_Cashier
      }
    }
    private void newCashierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      data_of_cashier = new data_Cashier();
      cashier = new addCashier();
      DialogResult result = cashier.ShowDialog();
      FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
      if ( result == DialogResult.OK )
      {
        set_data_cashier();
        Set_Info_Cashier_For_Display();
        add_Cashier_into_Row(data_of_cashier.set_id, data_of_cashier.set_firstName + " " + data_of_cashier.set_lastName, data_of_cashier.set_Cashier_Login);
        add_Cashier.Add(data_of_cashier);
        write.Serialize(file, add_Cashier);
        file.Close();
        increaseId++;
      }
      //string[] row = { cashier.ID.ToString(), cashier.textfirstname + " " + cashier.textLastname, cashier.textLogin };
      //ListViewItem item = new ListViewItem(row);
      //item.Font = new Font("Microsoft Sans Serif", 8.25F);
      //list_cashier.Rows[0].Selected = false;
      //listName.Items.Add(item);
    }

    private void newDrinksToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //FileStream f = new FileStream("G:\\Employee.Xml", FileMode.Open, FileAccess.Read);
      ListViewItem item = new ListViewItem();
      drink.ShowDialog();
      //if ( drink.setImage == "")
      //{
      //image_Drink.Image = Image.FromFile(drink.setImage);
      item.Font = new Font("Microsoft Sans Serif", 8.25F);
      list_drink.Rows.Add("1", "123", "Ice latte", "2", "");
        //list_drink.Rows.Add(drink.number_no, drink.drinkCode, drink.drinkName, drink.Price, "");
      SetInfoDrink();
      list_drink.Rows[0].Selected = false;
      //}
      //Console.WriteLine((List<inFoEmployee>)xml.Deserialize(f));
      //dataGridView1.DataSource = cashiers;
      //f.Close();
    }
    void add_Cashier_into_Row(int id, string namefull, string cashierLogin)
    {
      list_cashier.Rows.Add(id, namefull, cashierLogin);
    }
    void Set_Info_Cashier_For_Display()
    {
      fullName.Text = data_of_cashier.set_firstName + " " + data_of_cashier.set_lastLogin;
      sex.Text = data_of_cashier.set_sex;
      age.Text = data_of_cashier.set_age;
      hireDate.Text = data_of_cashier.set_hiredate;
      serve.Text = data_of_cashier.set_served.ToString();
      login.Text = data_of_cashier.set_Cashier_Login;
      passWord.Text = data_of_cashier.set_password;
      loginDatetime.Text = data_of_cashier.set_lastLogin;
      lastOrderNo.Text = data_of_cashier.set_served.ToString();
      imageShow.Image = Image.FromFile(data_of_cashier.set_Image);
    }
    void set_data_cashier()
    {
      data_of_cashier.set_id = increaseId;
      data_of_cashier.set_firstName = cashier.textfirstname;
      data_of_cashier.set_lastLogin = cashier.textLastname;
      data_of_cashier.set_age = cashier.User_age;
      data_of_cashier.set_sex = cashier.textSex;
      data_of_cashier.set_hiredate = cashier.hired_Date;
      data_of_cashier.set_Cashier_Login = cashier.textLogin;
      data_of_cashier.set_password = cashier.textPassword;
      data_of_cashier.set_served = cashier.Served;
      data_of_cashier.set_Image = cashier.textImage;
      data_of_cashier.set_lastLogin = cashier.last_login;
    }
    void SetInfoDrink()
    {
      drink_code.Text = drink.drinkCode;
      drink_name.Text = drink.drinkName;
      drink_category.Text = drink.Category;
      drink_price.Text = drink.Price;
      drink_note.Text = drink.Note;
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      drink_Info_Display.Visible = false;
      list_drink.Visible = false;
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      drink_Info_Display.Visible = true;
      list_drink.Visible = true;
    }

    private void list_cashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (list_cashier.CurrentCell.ColumnIndex == 3)
      {
        cashier = new addCashier();
        cashier.ShowDialog();
      }
    }
  }
}
