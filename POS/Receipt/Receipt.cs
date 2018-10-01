using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptNS
{
    public partial class Receipt : Form
    {
        public List<Bill> Bills = new List<Bill>();

        public Receipt()
        {
            InitializeComponent();
        }

        public new DialogResult ShowDialog()
        {
            int i = 0;
            double usd = 0;
            foreach (Bill B in Bills)
            {
                Panel Panel = B.Create();
                Panel.Location = new Point(0, 20 * i);
                Panel.Height = 20;
                this.bill.Controls.Add(Panel);
                usd += B.Amount;
                i++;
            }
            this.USD.Text = usd.ToString("0.00");
            this.KHR.Text = (usd * 4000).ToString("0");
            this.total_grp.Location = new Point(this.total_grp.Location.X, bill_grp.Location.Y + bill_grp.Height);
            this.Height = this.total_grp.Location.Y + this.total_grp.Height + 50;
            return base.ShowDialog();
        }

        public static DialogResult Show(List<Bill> bills)
        {
            Receipt Receipt = new Receipt();
            Receipt.Bills = bills;
            return Receipt.ShowDialog();
        }
    }

    public class Bill
    {
        public string Description;
        public int Quantity;
        public double Price;
        public double Amount;
        public Bill(string description, int quantiy, double price)
        {
            Description = description;
            Quantity = quantiy;
            Price = price;
            Amount = price * quantiy;
        }
        public Panel Create()
        {
            Label Description = new Label();
            Description.Text = this.Description;
            Description.Location = new Point(11, 0);
            Description.AutoSize = true;
            Label Quantity = new Label();
            Quantity.Text = this.Quantity.ToString();
            Quantity.Location = new Point(223, 0);
            Quantity.AutoSize = true;
            Label Price = new Label();
            Price.Text = this.Price.ToString("0.00");
            Price.Location = new Point(275, 0);
            Price.AutoSize = true;
            Label Amount = new Label();
            Amount.Text = this.Amount.ToString("0.00");
            Amount.Location = new Point(376, 0);
            Amount.AutoSize = true;
            Panel Panel = new Panel();
            Panel.Controls.Add(Description);
            Panel.Controls.Add(Quantity);
            Panel.Controls.Add(Price);
            Panel.Controls.Add(Amount);
            Panel.AutoSize = true;
            return Panel;
        }
    }
}
