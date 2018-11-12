using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public class BaseForm : Form
    {
        public TextBox ActiveTextBox { get; set; }
        public Keyboard Keyboard = new Keyboard();
        bool isNumber;
        public bool IsNumber
        {
            get
            {
                return isNumber;
            }
            set
            {
                isNumber = value;
                if(isNumber)
                {
                    Keyboard.btnA.Enabled = false;
                    Keyboard.btnB.Enabled = false;
                    Keyboard.btnC.Enabled = false;
                    Keyboard.btnD.Enabled = false;
                    Keyboard.btnE.Enabled = false;
                    Keyboard.btnF.Enabled = false;
                    Keyboard.btnG.Enabled = false;
                    Keyboard.btnH.Enabled = false;
                    Keyboard.btnI.Enabled = false;
                    Keyboard.btnJ.Enabled = false;
                    Keyboard.btnK.Enabled = false;
                    Keyboard.btnL.Enabled = false;
                    Keyboard.btnM.Enabled = false;
                    Keyboard.btnN.Enabled = false;
                    Keyboard.btnO.Enabled = false;
                    Keyboard.btnP.Enabled = false;
                    Keyboard.btnQ.Enabled = false;
                    Keyboard.btnR.Enabled = false;
                    Keyboard.btnS.Enabled = false;
                    Keyboard.btnT.Enabled = false;
                    Keyboard.btnU.Enabled = false;
                    Keyboard.btnV.Enabled = false;
                    Keyboard.btnW.Enabled = false;
                    Keyboard.btnX.Enabled = false;
                    Keyboard.btnY.Enabled = false;
                    Keyboard.btnZ.Enabled = false;
                }
                else
                {
                    Keyboard.btnA.Enabled = true;
                    Keyboard.btnB.Enabled = true;
                    Keyboard.btnC.Enabled = true;
                    Keyboard.btnD.Enabled = true;
                    Keyboard.btnE.Enabled = true;
                    Keyboard.btnF.Enabled = true;
                    Keyboard.btnG.Enabled = true;
                    Keyboard.btnH.Enabled = true;
                    Keyboard.btnI.Enabled = true;
                    Keyboard.btnJ.Enabled = true;
                    Keyboard.btnK.Enabled = true;
                    Keyboard.btnL.Enabled = true;
                    Keyboard.btnM.Enabled = true;
                    Keyboard.btnN.Enabled = true;
                    Keyboard.btnO.Enabled = true;
                    Keyboard.btnP.Enabled = true;
                    Keyboard.btnQ.Enabled = true;
                    Keyboard.btnR.Enabled = true;
                    Keyboard.btnS.Enabled = true;
                    Keyboard.btnT.Enabled = true;
                    Keyboard.btnU.Enabled = true;
                    Keyboard.btnV.Enabled = true;
                    Keyboard.btnW.Enabled = true;
                    Keyboard.btnX.Enabled = true;
                    Keyboard.btnY.Enabled = true;
                    Keyboard.btnZ.Enabled = true;
                }
            }
        }
        public BaseForm()
        {
            this.Load += BaseForm_Load;
            this.FormClosing += BaseForm_FormClosing;
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Keyboard?.Dispose();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            IsNumber = false;
            if(this.Site == null || !this.Site.DesignMode)
            {
                Keyboard.keypress += Keyboard_keypress;
                for(int i = 0; i < Controls.Count; i++)
                {
                    if(Controls[i] is TextBox)
                    {
                        ActiveTextBox = Controls[i] as TextBox;
                        ActiveTextBox.Enter += ActiveTextBox_Enter;
                        ActiveTextBox.Leave += ActiveTextBox_Leave;
                    }
                }
            }
        }

        private void Keyboard_keypress(object sender, Keypress e)
        {
            if (ActiveTextBox != null)
            {
                if (e.KeyCharecter == 8)
                {
                    if (ActiveTextBox.Text.Length > 0) ActiveTextBox.Text = ActiveTextBox.Text.Remove(ActiveTextBox.Text.Length - 1, 1);
                }
                else
                {
                    ActiveTextBox.Text += e.KeyCharecter;

                }
                ActiveTextBox.Select(ActiveTextBox.Text.Length, 0);
            }
        }

        private void ActiveTextBox_Leave(object sender, EventArgs e)
        {
            ActiveTextBox = null;
            Keyboard?.Hide();           
        }

        private void ActiveTextBox_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
            if (Keyboard != null) Keyboard.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 300);
            Keyboard?.Show();
        }
    }
}
