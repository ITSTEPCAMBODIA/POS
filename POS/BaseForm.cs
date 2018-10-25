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
