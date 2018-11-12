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
    data_Cashier dataCashier;
    data_Drink dataDrink;
    addCashier cashier;
    addDrink drink;
    List<data_Cashier> addCashiers = new List<data_Cashier>();
    List<data_Drink> addDrinks = new List<data_Drink>();
    XmlSerializer xml;
    DialogResult result;
    string path = Environment.CurrentDirectory;
    bool firstRowCashier = false; bool firstRowDrink = false;
    public Form1()
    {
      InitializeComponent();
      if (File.Exists(path + "\\data_Cashier.xml"))
      {
        cashier = new addCashier();
        xml = new XmlSerializer(typeof(List<data_Cashier>));
        FileStream file = new FileStream(path + "\\data_Cashier.xml", FileMode.Open, FileAccess.Read);
        addCashiers = (List<data_Cashier>)xml.Deserialize(file);
        for (int i = 0; i < addCashiers.Count; i++)
        {
          add_Cashier_into_Row("", addCashiers[i].set_firstName + " " + addCashiers[i].set_lastName, addCashiers[i].set_Cashier_Login);
        }
        file.Close();
      }
      if (File.Exists(path + "\\data_Drink.xml"))
      {
        drink = new addDrink();
        xml = new XmlSerializer(typeof(List<data_Drink>));
        FileStream file = new FileStream(path + "\\data_Drink.xml", FileMode.Open, FileAccess.Read);
        addDrinks = (List<data_Drink>)xml.Deserialize(file);
        for (int i = 0; i < addDrinks.Count; i++)
        {
          add_Drink_into_Row("", addDrinks[i].drink_Code, addDrinks[i].drink_Name, addDrinks[i].drink_Price);
        }
        file.Close();
      }
    }
    private void newCashierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      xml = new XmlSerializer(typeof(List<data_Cashier>));
      dataCashier = new data_Cashier();
      cashier = new addCashier();
      cashier.ShowDialog();
      DialogResult = cashier.DialogResult;
      if (DialogResult == DialogResult.OK)
      {
        FileStream file = new FileStream(path + "\\data_Cashier.xml", FileMode.Create, FileAccess.Write);
        dataCashier.set_firstName = cashier.textfirstname;
        set_data_cashier();
        addCashiers.Add(dataCashier);
        xml.Serialize(file, addCashiers);
        file.Close();
        add_Cashier_into_Row("", dataCashier.set_firstName + " " + dataCashier.set_lastName, dataCashier.set_Cashier_Login);
        list_cashier.Rows[0].Selected = false;
      }
    }

    private void newDrinksToolStripMenuItem_Click(object sender, EventArgs e)
    {
      xml = new XmlSerializer(typeof(List<data_Drink>));
      dataDrink = new data_Drink();
      drink = new addDrink();
      if (drink.ShowDialog() == DialogResult.OK)
      {
        FileStream f = new FileStream(path + "\\data_Drink.xml", FileMode.Create, FileAccess.Write);
        set_data_drink();
        SetInfo_Drink_For_Display();
        addDrinks.Add(dataDrink);
        xml.Serialize(f, addDrinks);
        f.Close();
        list_drink.Rows.Add(1, drink.drinkCode, drink.drinkName, drink.Price);
        list_drink.Rows[0].Selected = false;
      }
    }
    void add_Cashier_into_Row(string space, string namefull, string cashierLogin)
    {
      list_cashier.Rows.Add(space, namefull, cashierLogin);
    }
    void add_Drink_into_Row(string space, string codeDrink, string nameDrink, string priceDrink)
    {
      list_drink.Rows.Add(space, codeDrink, nameDrink, priceDrink);
    }

    //For Cashier
    void set_data_cashier()
    {
      dataCashier.set_firstName = cashier.textfirstname;
      dataCashier.set_lastName = cashier.textLastname;
      dataCashier.set_age = cashier.User_age;
      dataCashier.set_sex = cashier.textSex;
      dataCashier.set_hiredate = cashier.hired_Date;
      dataCashier.set_Cashier_Login = cashier.textLogin;
      dataCashier.set_password = cashier.textPassword;
      dataCashier.set_served = cashier.Served;
      dataCashier.set_Image = cashier.textImage;
      dataCashier.set_lastLogin = cashier.last_login;
      dataCashier.set_birthDate = cashier.textBirthDate;
    }
    void SetInfo_Cashier_For_Display()
    {
      fullName.Text = dataCashier.set_firstName + " " + dataCashier.set_lastName;
      sex.Text = dataCashier.set_sex;
      age.Text = dataCashier.set_age;
      hireDate.Text = dataCashier.set_hiredate;
      serve.Text = dataCashier.set_served.ToString();
      login.Text = dataCashier.set_Cashier_Login;
      passWord.Text = dataCashier.set_password;
      loginDatetime.Text = dataCashier.set_lastLogin;
      lastOrderNo.Text = dataCashier.set_served.ToString();
      imageShow.Image = Image.FromFile(dataCashier.set_Image);
    }

    //For Drink
    void set_data_drink()
    {
      dataDrink.drink_Code = drink.drinkCode;
      dataDrink.drink_Name = drink.drinkName;
      dataDrink.drink_Category = drink.Category;
      dataDrink.drink_Price = drink.Price;
      dataDrink.drink_Order = 0;
      dataDrink.drink_Note = drink.Note;
      dataDrink.drink_Image = drink.setImage;
    }
    void SetInfo_Drink_For_Display()
    {
      drinkCode.Text = dataDrink.drink_Code;
      drinkName.Text = dataDrink.drink_Name;
      drinkCategory.Text = dataDrink.drink_Category;
      drinkPrice.Text = dataDrink.drink_Price + " $";
      orderAmount.Text = dataDrink.drink_Order.ToString();
      drinkNote.Text = dataDrink.drink_Note;
      image_Drink.Image = Image.FromFile(dataDrink.drink_Image);
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
      xml = new XmlSerializer(typeof(List<data_Cashier>));
      if (list_cashier.CurrentCell.ColumnIndex == 3)
      {
        Console.WriteLine(list_cashier.CurrentCell.Selected);
        list_cashier.CurrentCell.Selected = false;
        dataCashier = new data_Cashier();
        dataCashier = addCashiers[list_cashier.CurrentCell.RowIndex];
        cashier = new addCashier(dataCashier.set_firstName, dataCashier.set_lastName, dataCashier.set_sex, dataCashier.set_birthDate,
          dataCashier.set_Cashier_Login, dataCashier.set_password, dataCashier.set_age, dataCashier.set_Image);
        result = cashier.ShowDialog();
        if (result == DialogResult.OK)
        {
          set_data_cashier();
          SetInfo_Cashier_For_Display();
          update_list_cashier();
        }
      }
      else if ( list_cashier.CurrentCell.ColumnIndex == 4 )
      {
        FileStream file = new FileStream(path + "\\data_Cashier.xml", FileMode.Create, FileAccess.Write);
        result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
        if ( result == DialogResult.Yes)
        {
          if (list_cashier.RowCount > 1)
          {
            list_cashier.Rows.RemoveAt(list_cashier.CurrentCell.RowIndex);
            addCashiers.RemoveAt(list_cashier.CurrentCell.RowIndex);
          }
          else
          {
            list_cashier.Rows.RemoveAt(list_cashier.CurrentCell.RowIndex);
            File.Delete(path + "\\data_Cashier.xml");
          }
          xml.Serialize(file, addCashiers);
        }
      }
    }
    void selectedCashier(int index)
    {
      dataCashier = addCashiers[index];
      SetInfo_Cashier_For_Display();
    }
    void update_list_cashier()
    {
      list_cashier[1, list_cashier.CurrentRow.Index].Value = dataCashier.set_firstName + " " + dataCashier.set_lastName;
      list_cashier[2, list_cashier.CurrentRow.Index].Value = dataCashier.set_Cashier_Login;
    }
    void update_list_drink()
    {
      list_drink[1, list_drink.CurrentCell.RowIndex].Value = dataDrink.drink_Code;
      list_drink[2, list_drink.CurrentCell.RowIndex].Value = dataDrink.drink_Name;
      list_drink[3, list_drink.CurrentCell.RowIndex].Value = dataDrink.drink_Price;
    }

    private void newFoodToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Console.WriteLine(addCashiers[0].set_firstName);
    }

    private void list_cashier_Click(object sender, EventArgs e)
    {
      //clearSelected = true;
      //if (clearSelected == true) { list_cashier.ClearSelection(); }
    }

    private void list_cashier_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      dataCashier = new data_Cashier();
      dataCashier = addCashiers[list_cashier.CurrentCell.RowIndex];
      SetInfo_Cashier_For_Display();
    }

    private void list_drink_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      dataDrink = new data_Drink();
      dataDrink = addDrinks[list_drink.CurrentCell.RowIndex];
      SetInfo_Drink_For_Display();
    }

    private void list_drink_Click(object sender, EventArgs e)
    {
      list_drink.ClearSelection();
    }

    //Selected Changed
    private void list_cashier_SelectionChanged(object sender, EventArgs e)
    {
      if (firstRowCashier == false) { list_cashier.Rows[0].Selected = false; }
      firstRowCashier = true;
    }
    private void list_drink_SelectionChanged(object sender, EventArgs e)
    {
      if ( firstRowDrink == false) { list_drink.Rows[0].Selected = false; }
      firstRowDrink = true;
    }

    private void list_drink_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      FileStream file;
      if (list_drink.CurrentCell.ColumnIndex == 4)
      {
        dataDrink = new data_Drink();
        dataDrink = addDrinks[list_drink.CurrentCell.RowIndex];
        drink = new addDrink(
          dataDrink.drink_Code, dataDrink.drink_Name, dataDrink.drink_Price, dataDrink.drink_Category,
          dataDrink.drink_Note, dataDrink.drink_Image
        );
        if ( drink.ShowDialog() == DialogResult.OK )
        {
          file = new FileStream(path + "\\data_Drink.xml", FileMode.Create, FileAccess.Write);
          set_data_drink();
          update_list_drink();
          xml.Serialize(file, addDrinks);
          file.Close();
        }
      } else if (list_drink.CurrentCell.ColumnIndex == 5)
      {
        DialogResult result = MessageBox.Show("Are you sure", "",MessageBoxButtons.OKCancel);
        if ( result == DialogResult.OK)
        {
          if (addDrinks.Count > 1)
          {
            list_drink.Rows.RemoveAt(list_drink.CurrentCell.RowIndex);
            addDrinks.RemoveAt(list_drink.CurrentCell.RowIndex);
          } else
          {
            list_drink.Rows.RemoveAt(list_drink.CurrentCell.RowIndex);
            File.Delete(path + "\\data_Drink.xml");
          }
        }
      }
    }
    
  }
}
