using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Billing
{
    public partial class Receipt : Form
    {
        List<Bill> bills;
        Dictionary<string, object> infos;

        public Image LogoImage { get; set; } = null;
        public Dictionary<string, object> Infos
        {
            get
            {
                if (this.infos == null)
                {
                    this.infos = new Dictionary<string, object>();
                }
                return this.infos;
            }
            set => this.infos = value;
        }
        public List<Bill> Bills
        {
            get
            {
                if (this.bills == null)
                {
                    this.bills = new List<Bill>();
                }
                return this.bills;
            }
            set => this.bills = value;
        }

        public Receipt()
        {
            InitializeComponent();
        }

        public new DialogResult ShowDialog()
        {
            ControlGenerator[] Generators = {
                this.GenerateLogo,
                this.GenerateInfos,
                this.GenerateBills,
                this.GenerateTotalBill
            };

            Control LastVisibleControl = null;
            foreach (ControlGenerator Generator in Generators)
            {
                Control CurrentControl = Generator();
                if (CurrentControl != null)
                {
                    this.Positioning(CurrentControl, LastVisibleControl);
                    LastVisibleControl = CurrentControl;
                }
            }
            this.Height = LastVisibleControl.Location.Y + LastVisibleControl.Height + 50;
            return base.ShowDialog();
        }

        delegate Control ControlGenerator();

        Control GenerateLogo()
        {
            this.Logo.Image = this.LogoImage;
            bool Visibility = (this.LogoImage != null);
            this.Logo.Visible = Visibility;
            return Visibility ? this.Logo : null;
        }

        Control GenerateInfos()
        {
            int i = 0;
            foreach (KeyValuePair<string, object> Info in this.Infos)
            {
                Panel Panel = new Panel();
                Panel.Controls.AddRange(new Control[]
                {
            this.CreateLabel(Info.Key, 5),
            this.CreateLabel($": {Info.Value}", 75)
                });
                Panel.AutoSize = true;
                Panel.Location = new Point(225 * (i % 2), 20 * (i / 2));
                Panel.Height = 20;
                this.Info.Controls.Add(Panel);
                i++;
            }
            bool Visibility = (this.Infos.Count > 0);
            this.InfoGrp.Visible = Visibility;
            return Visibility ? this.InfoGrp : null;
        }

        Control GenerateBills()
        {
            int i = 0;
            foreach (Bill B in this.Bills)
            {
                Panel Panel = new Panel();
                Panel.Controls.AddRange(new Control[]
                {
                this.CreateLabel(B.Description, 5),
                this.CreateLabel(B.Quantity.ToString(), 223),
                this.CreateLabel(B.Price.ToString("0.00"), 275),
                this.CreateLabel(B.Amount.ToString("0.00"), 376),
                });
                Panel.AutoSize = true;
                Panel.Location = new Point(0, 20 * i);
                Panel.Height = 20;
                this.Bill.Controls.Add(Panel);
                i++;
            }
            bool Visibility = (this.Bills.Count > 0);
            this.BillGrp.Visible = Visibility;
            return Visibility ? this.BillGrp : null;
        }

        Control GenerateTotalBill()
        {
            bool Visibility = (this.Bills.Count > 0);
            this.TotalGrp.Visible = Visibility;
            if (Visibility)
            {
                double usd = 0;
                foreach (Bill B in this.Bills)
                {
                    usd += B.Amount;
                }
                this.USD.Text = usd.ToString("0.00");
                this.KHR.Text = (usd * 4000).ToString("0");
            }
            return Visibility ? this.TotalGrp : null;
        }

        void Positioning(Control below, Control above)
        {
            int Y = above == null ? 10 : (above.Location.Y + above.Height + 10);
            below.Location = new Point(below.Location.X, Y);
        }

        Label CreateLabel(string text, int x)
        {
            Label Label = new Label();
            Label.Text = text;
            Label.Location = new Point(x, 0);
            Label.AutoSize = true;
            return Label;
        }

        public static DialogResult Show(Image image, Dictionary<string, object> infos, List<Bill> bills)
        {
            Receipt R = new Receipt();
            R.LogoImage = image;
            R.Infos = infos;
            R.Bills = bills;
            return R.ShowDialog();
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
    }
}
