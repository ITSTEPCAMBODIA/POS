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
    XmlSerializer xml = new XmlSerializer(typeof(List<data_Cashier>));
    DialogResult result;
    string path = @"C:\Users\Daveth\Desktop\POS\dataCashier.xml";
    int increaseId;
    public Form1()
    {
      InitializeComponent();
      increaseId = 1;
      if (File.Exists(path))
      {
        cashier = new addCashier();
        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
        add_Cashier = (List<data_Cashier>)xml.Deserialize(file);
        for (int i = 0; i < add_Cashier.Count; i++)
        {
          add_Cashier_into_Row(add_Cashier[i].set_id, add_Cashier[i].set_firstName + " " + add_Cashier[i].set_lastName, add_Cashier[i].set_Cashier_Login);
        }
        list_cashier.Rows[0].Selected = false;
        increaseId = add_Cashier.Count;
        file.Close();
      } 
    }
    private void newCashierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
      data_of_cashier = new data_Cashier();
      cashier = new addCashier();
      if (cashier.ShowDialog() == DialogResult.OK )
      {
        set_data_cashier();
        Set_Info_Cashier_For_Display();
        add_Cashier_into_Row(data_of_cashier.set_id, data_of_cashier.set_firstName + " " + data_of_cashier.set_lastName, data_of_cashier.set_Cashier_Login);
        add_Cashier.Add(data_of_cashier);
        Console.WriteLine(add_Cashier.Count);
        xml.Serialize(file, add_Cashier);
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
      fullName.Text = data_of_cashier.set_firstName + " " + data_of_cashier.set_lastName;
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
      data_of_cashier.set_lastName = cashier.textLastname;
      data_of_cashier.set_age = cashier.User_age;
      data_of_cashier.set_sex = cashier.textSex;
      data_of_cashier.set_hiredate = cashier.hired_Date;
      data_of_cashier.set_Cashier_Login = cashier.textLogin;
      data_of_cashier.set_password = cashier.textPassword;
      data_of_cashier.set_served = cashier.Served;
      data_of_cashier.set_Image = cashier.textImage;
      data_of_cashier.set_lastLogin = cashier.last_login;
      data_of_cashier.set_birthDate = cashier.textBirthDate;
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
        selectedCashier(list_cashier.CurrentCell.RowIndex);
        cashier = new addCashier(data_of_cashier.set_firstName, data_of_cashier.set_lastName, data_of_cashier.set_sex, data_of_cashier.set_birthDate,
          data_of_cashier.set_Cashier_Login, data_of_cashier.set_password, data_of_cashier.set_age, data_of_cashier.set_Image);
        result = cashier.ShowDialog();
        if ( result == DialogResult.OK )
        {
          set_data_cashier();
          Set_Info_Cashier_For_Display();
          update_list_cashier();
        }
      }
      else if ( list_cashier.CurrentCell.ColumnIndex == 4 )
      {
        result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
        if ( result == DialogResult.Yes)
        {
          if (list_cashier.RowCount > 1)
            list_cashier.Rows.RemoveAt(list_cashier.CurrentCell.RowIndex);
          else
            File.Delete(path);
        }
      }
    }

    private void list_cashier_SelectionChanged(object sender, EventArgs e)
    {
      //selectedCashier(list_cashier.CurrentCell.RowIndex);
      data_of_cashier = new data_Cashier();
    }
    void selectedCashier(int index)
    {
      data_of_cashier = add_Cashier[index];
      Set_Info_Cashier_For_Display();
    }
    void update_list_cashier()
    {
      list_cashier[1, list_cashier.CurrentRow.Index].Value = data_of_cashier.set_firstName + " " + data_of_cashier.set_lastName;
      list_cashier[2, list_cashier.CurrentRow.Index].Value = data_of_cashier.set_Cashier_Login;
    }
  }
}
