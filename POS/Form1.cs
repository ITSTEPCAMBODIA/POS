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
    addCashier cashier = new addCashier();
    addDrink drink = new addDrink();
    //XmlTextReader read = new XmlTextReader();
    List<inFoEmployee> cashiers = new List<inFoEmployee>();
    public Form1()
    {
      InitializeComponent();
    }
    private void newCashierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cashier.ShowDialog();
      if ( cashier.textImage != "" )
      {
        imageShow.Image = Image.FromFile(cashier.textImage);
      }
      string[] row = { cashier.ID.ToString(), cashier.textfirstname + " " + cashier.textLastname, cashier.textLogin };
      ListViewItem item = new ListViewItem(row);
      item.Font = new Font("Microsoft Sans Serif", 8.25F);
      list_cashier.Rows.Add(cashier.ID.ToString(), cashier.textfirstname + " " + cashier.textLastname, cashier.textLogin);
      SetInfoCashier();
      list_cashier.Rows[0].Selected = false;
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
    void SetInfoCashier()
    {
      fullName.Text = cashier.textfirstname + " " + cashier.textLastname;
      sex.Text = cashier.textSex;
      age.Text = cashier.User_age;
      hireDate.Text = cashier.hired_Date;
      serve.Text = cashier.Served.ToString();
      login.Text = cashier.textLogin;
      passWord.Text = cashier.textPassword;
      login.Text = "30/10/2018";
      loginDatetime.Text = "30/10/2018";
      lastOrderNo.Text = cashier.Served.ToString();
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
  }
}
