using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettlePayment
{
    public partial class CashReg : Form
    {
        public static double DollarGrandTotal = 23.2 , RielGrandTotal = DollarGrandTotal*4000;
        public double RielChange, DollarChange;
        public double RielCashReceived, DollarCashReceived;
        public void Compute()
        {
            //double RielCashReceived, DollarCashReceived;
            string RCR = Convert.ToString(textBox1.Text);
            string DCR = Convert.ToString(textBox2.Text);


            RielCashReceived = Convert.ToDouble(RCR);
            DollarCashReceived = Convert.ToDouble(DCR);

            if (radioButton1.Checked)
            {
                RielChange = RielCashReceived - RielGrandTotal;
                label6.Text = $"៛​ {RielChange}";
                if (RielChange >= 0)
                {
                    label6.Text = $"៛ {(int)(RielChange / 1000)},{RielChange % 1000}";
                }
            }
            if (radioButton2.Checked)
            {
                DollarChange = DollarCashReceived - DollarGrandTotal;
                label6.Text = $"$ {DollarChange}";
                //label9.Text = "";
            }
            
        }
        
        public CashReg()
        {
            InitializeComponent();

            //Grand Total in Dollar
            label4.Text = $"$ {DollarGrandTotal}";

            //Grand Total in Riel with ","
            label7.Text = $"៛ {(int)(RielGrandTotal / 1000)},{RielGrandTotal % 1000}";
        }     
        
        #region Number Button Clicks
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "1.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "1.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "1";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "2.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "2.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "2";
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "3.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "3.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "4.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "4.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "5.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "5.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "6.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "6.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "7.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "7.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "8.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "8.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "8";
                }
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "9.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "9.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "9";
                }
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0.00" && textBox1.Text != null)
                {
                    textBox1.Text = "0.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0.00" && textBox2.Text != null)
                {
                    textBox2.Text = "0.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "0";
                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "00.00";
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text + "00";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "00.00";
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);
                }
                else
                {
                    textBox2.Text = textBox2.Text + "00";
                }
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = ".";
                }
                else
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = ".";
                }
                else
                {
                    textBox2.Text = textBox2.Text + ".";
                }
            }
            
        }
        #endregion

        #region Radio Button Switch
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = "0.00";
                textBox2.Focus();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Focus();
                textBox2.Text = "0.00";
            }
        }
        #endregion

        #region Text Box Change 
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Compute();
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Compute();
        }
        #endregion

        //Delete Button
        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = "0.00";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - textBox1.Text.Length + 1);
                    textBox1.Text = "0.00";
                }
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text.Length == 1)
                {
                    textBox2.Text = "0.00";
                }
                else
                {
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - textBox2.Text.Length + 1);
                    textBox2.Text = "0.00";
                }
            }
        }

        //Enter Button
        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (RielChange < 0)
                {
                    MessageBox.Show("Insufficient Cash", "Proceeding Error");
                }
                else MessageBox.Show($"Cash Received = ៛{RielCashReceived}\nChange = ៛{RielChange}", "Proceeded");
            }
            if (radioButton2.Checked)
            {
                if (DollarChange < 0)
                {
                    MessageBox.Show("Insufficient Cash", "Proceeding Error");
                }
                else MessageBox.Show($"Cash Received = ${DollarCashReceived}\nChange = ${DollarChange}", "Proceeded");
            }
        }

        //C Button
        private void C_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = "0.000";
                }
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text.Length == 1)
                {
                    textBox2.Text = "0.000";
                }
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            
        }
        
        //Cancel Button
        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
