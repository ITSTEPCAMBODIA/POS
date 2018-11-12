using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Keyboard : Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlphos;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnZero;
        public System.Windows.Forms.Button btnNine;
        public System.Windows.Forms.Button btnEight;
        public System.Windows.Forms.Button btnSeven;
        public System.Windows.Forms.Button btnSix;
        public System.Windows.Forms.Button btnFive;
        public System.Windows.Forms.Button btnFour;
        public System.Windows.Forms.Button btnThree;
        public System.Windows.Forms.Button btnTwo;
        public System.Windows.Forms.Button btnOne;
        public System.Windows.Forms.Button btnM;
        public System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnRIghtAlt;
        public System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnRightCtrl;
        public System.Windows.Forms.Button btnV;
        public System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Button btnC;
        public System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnsemi;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.Button btnL;
        public System.Windows.Forms.Button btnK;
        public System.Windows.Forms.Button btnJ;
        public System.Windows.Forms.Button btnH;
        public System.Windows.Forms.Button btnG;
        public System.Windows.Forms.Button btnF;
        public System.Windows.Forms.Button btnD;
        public System.Windows.Forms.Button btnS;
        public System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnCaps;
        private System.Windows.Forms.Button btnRightScrip;
        private System.Windows.Forms.Button btnLeftScrip;
        public System.Windows.Forms.Button btnP;
        public System.Windows.Forms.Button btnO;
        public System.Windows.Forms.Button btnI;
        public System.Windows.Forms.Button btnU;
        public System.Windows.Forms.Button btnY;
        public System.Windows.Forms.Button btnT;
        public System.Windows.Forms.Button btnR;
        public System.Windows.Forms.Button btnE;
        public System.Windows.Forms.Button btnW;
        public System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnArrowUp;
        private System.Windows.Forms.Button btnBackSlash;
        private System.Windows.Forms.Button btnComa;
        public System.Windows.Forms.Button btnDot;
        public System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnLeftAlt;
        private System.Windows.Forms.Button btnLeftCtrl;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnFn;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnquot;
        private System.Windows.Forms.Button btnSlash;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnArrowDown;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button69;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.Button btnESC;

        public event EventHandler<Keypress> keypress;
        public Keyboard()
        {
            InitializeComponent();
            InitKeyboard();
            btnA.Click += ButtonPress;
            btnB.Click += ButtonPress;
            btnC.Click += ButtonPress;
            btnD.Click += ButtonPress;
            btnE.Click += ButtonPress;
            btnF.Click += ButtonPress;
            btnG.Click += ButtonPress;
            btnH.Click += ButtonPress;
            btnI.Click += ButtonPress;
            btnJ.Click += ButtonPress;
            btnK.Click += ButtonPress;
            btnL.Click += ButtonPress;
            btnM.Click += ButtonPress;
            btnN.Click += ButtonPress;
            btnO.Click += ButtonPress;
            btnP.Click += ButtonPress;
            btnQ.Click += ButtonPress;
            btnR.Click += ButtonPress;
            btnS.Click += ButtonPress;
            btnT.Click += ButtonPress;
            btnU.Click += ButtonPress;
            btnV.Click += ButtonPress;
            btnW.Click += ButtonPress;
            btnX.Click += ButtonPress;
            btnY.Click += ButtonPress;
            btnZ.Click += ButtonPress;
            btnOne.Click += ButtonPress;
            btnTwo.Click += ButtonPress;
            btnThree.Click += ButtonPress;
            btnFour.Click += ButtonPress;
            btnFive.Click += ButtonPress;
            btnSix.Click += ButtonPress;
            btnSeven.Click += ButtonPress;
            btnEight.Click += ButtonPress;
            btnNine.Click += ButtonPress;
            btnZero.Click += ButtonPress;
            btnSub.Click += ButtonPress;
            btnDel.Click += DeletePress;
            btnDot.Click += ButtonPress;
            btnLeftShift.Click += ShiftPress;
            btnRightShift.Click += ShiftPress;
            btnSpace.Click += ButtonPress;
            this.FormClosing += Keyboard_FormClosing;
            btnA.MouseDown += BtnA_MouseDown;
            btnA.MouseUp += BtnA_MouseUp;
        }

        private void BtnA_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        private void BtnA_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void ShiftPress(object sender, EventArgs e)
        {
            foreach(Control control in this.panel1.Controls)
            {
                if (control.Tag != null)
                {
                    object Temp = control.Tag;
                    control.Tag = control.Text;
                    if (Temp != null) control.Text = Temp.ToString();
                }
            }            
        }

        private void Keyboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ButtonPress(object sender, EventArgs e)
        {
            Button b = sender as Button;
            keypress?.Invoke(this, new Keypress { KeyCharecter = b.Text[0]});
        }
        private void DeletePress(object sender, EventArgs e)
        {
            keypress?.Invoke(this, new Keypress { KeyCharecter = (char)Keys.Back });
        }
        private void InitKeyboard()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnESC = new System.Windows.Forms.Button();
            this.button69 = new System.Windows.Forms.Button();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnArrowUp = new System.Windows.Forms.Button();
            this.btnBackSlash = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnLeftAlt = new System.Windows.Forms.Button();
            this.btnLeftCtrl = new System.Windows.Forms.Button();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnFn = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnquot = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnArrowDown = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnRIghtAlt = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnRightCtrl = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnsemi = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnCaps = new System.Windows.Forms.Button();
            this.btnRightScrip = new System.Windows.Forms.Button();
            this.btnLeftScrip = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnAlphos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnESC);
            this.panel1.Controls.Add(this.button69);
            this.panel1.Controls.Add(this.btnRightShift);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnArrowUp);
            this.panel1.Controls.Add(this.btnBackSlash);
            this.panel1.Controls.Add(this.btnComa);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btnSpace);
            this.panel1.Controls.Add(this.btnLeftAlt);
            this.panel1.Controls.Add(this.btnLeftCtrl);
            this.panel1.Controls.Add(this.btnWin);
            this.panel1.Controls.Add(this.btnFn);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnquot);
            this.panel1.Controls.Add(this.btnSlash);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnArrowDown);
            this.panel1.Controls.Add(this.btnArrowLeft);
            this.panel1.Controls.Add(this.btnM);
            this.panel1.Controls.Add(this.btnN);
            this.panel1.Controls.Add(this.btnRIghtAlt);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.btnRightCtrl);
            this.panel1.Controls.Add(this.btnV);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnZ);
            this.panel1.Controls.Add(this.btnLeftShift);
            this.panel1.Controls.Add(this.btnsemi);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnK);
            this.panel1.Controls.Add(this.btnJ);
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Controls.Add(this.btnG);
            this.panel1.Controls.Add(this.btnF);
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.btnCaps);
            this.panel1.Controls.Add(this.btnRightScrip);
            this.panel1.Controls.Add(this.btnLeftScrip);
            this.panel1.Controls.Add(this.btnP);
            this.panel1.Controls.Add(this.btnO);
            this.panel1.Controls.Add(this.btnI);
            this.panel1.Controls.Add(this.btnU);
            this.panel1.Controls.Add(this.btnY);
            this.panel1.Controls.Add(this.btnT);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Controls.Add(this.btnW);
            this.panel1.Controls.Add(this.btnQ);
            this.panel1.Controls.Add(this.btnTab);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnAlphos);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 259);
            this.panel1.TabIndex = 1;
            // 
            // btnESC
            // 
            this.btnESC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnESC.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnESC.FlatAppearance.BorderSize = 0;
            this.btnESC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESC.Location = new System.Drawing.Point(4, 5);
            this.btnESC.Margin = new System.Windows.Forms.Padding(1);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(52, 48);
            this.btnESC.TabIndex = 67;
            this.btnESC.Text = "ESC";
            this.btnESC.UseVisualStyleBackColor = false;
            this.btnESC.Enabled = false;
            // 
            // button69
            // 
            this.button69.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button69.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button69.FlatAppearance.BorderSize = 0;
            this.button69.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button69.Location = new System.Drawing.Point(798, 205);
            this.button69.Margin = new System.Windows.Forms.Padding(1);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(52, 48);
            this.button69.TabIndex = 66;
            this.button69.UseVisualStyleBackColor = false;
            this.button69.Enabled = false;
            // 
            // btnRightShift
            // 
            this.btnRightShift.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightShift.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightShift.FlatAppearance.BorderSize = 0;
            this.btnRightShift.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRightShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightShift.Location = new System.Drawing.Point(744, 155);
            this.btnRightShift.Margin = new System.Windows.Forms.Padding(1);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(106, 48);
            this.btnRightShift.TabIndex = 65;
            this.btnRightShift.Text = "Shift";
            this.btnRightShift.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(706, 5);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(1);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(52, 48);
            this.btnEqual.TabIndex = 63;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Enabled = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(760, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 48);
            this.btnDel.TabIndex = 12;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(798, 55);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 48);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Del";
            this.btnDelete.Enabled = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnArrowUp
            // 
            this.btnArrowUp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowUp.FlatAppearance.BorderSize = 0;
            this.btnArrowUp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnArrowUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowUp.Image = ((System.Drawing.Image)(resources.GetObject("Arrow_up")));
            this.btnArrowUp.Location = new System.Drawing.Point(690, 155);
            this.btnArrowUp.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowUp.Name = "btnArrowUp";
            this.btnArrowUp.Size = new System.Drawing.Size(52, 48);
            this.btnArrowUp.TabIndex = 60;
            this.btnArrowUp.UseVisualStyleBackColor = false;
            // 
            // btnBackSlash
            // 
            this.btnBackSlash.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBackSlash.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBackSlash.FlatAppearance.BorderSize = 0;
            this.btnBackSlash.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBackSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSlash.Location = new System.Drawing.Point(636, 155);
            this.btnBackSlash.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackSlash.Name = "btnBackSlash";
            this.btnBackSlash.Size = new System.Drawing.Size(52, 48);
            this.btnBackSlash.TabIndex = 59;
            this.btnBackSlash.Text = "/";
            this.btnBackSlash.UseVisualStyleBackColor = false;
            this.btnBackSlash.Enabled = false;
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnComa.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnComa.FlatAppearance.BorderSize = 0;
            this.btnComa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(528, 155);
            this.btnComa.Margin = new System.Windows.Forms.Padding(1);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(52, 48);
            this.btnComa.TabIndex = 58;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = false;
            this.btnComa.Enabled = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(582, 155);
            this.btnDot.Margin = new System.Windows.Forms.Padding(1);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(52, 48);
            this.btnDot.TabIndex = 57;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Enabled = true;
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSpace.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSpace.FlatAppearance.BorderSize = 0;
            this.btnSpace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(220, 205);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(1);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(306, 48);
            this.btnSpace.TabIndex = 56;
            this.btnSpace.Text = " ";
            this.btnSpace.UseVisualStyleBackColor = false;
            // 
            // btnLeftAlt
            // 
            this.btnLeftAlt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftAlt.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftAlt.FlatAppearance.BorderSize = 0;
            this.btnLeftAlt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeftAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftAlt.Location = new System.Drawing.Point(166, 205);
            this.btnLeftAlt.Margin = new System.Windows.Forms.Padding(1);
            this.btnLeftAlt.Name = "btnLeftAlt";
            this.btnLeftAlt.Size = new System.Drawing.Size(52, 48);
            this.btnLeftAlt.TabIndex = 55;
            this.btnLeftAlt.Text = "Alt";
            this.btnLeftAlt.UseVisualStyleBackColor = false;
            this.btnLeftAlt.Enabled = false;
            // 
            // btnLeftCtrl
            // 
            this.btnLeftCtrl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftCtrl.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftCtrl.FlatAppearance.BorderSize = 0;
            this.btnLeftCtrl.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeftCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftCtrl.Location = new System.Drawing.Point(58, 205);
            this.btnLeftCtrl.Margin = new System.Windows.Forms.Padding(1);
            this.btnLeftCtrl.Name = "btnLeftCtrl";
            this.btnLeftCtrl.Size = new System.Drawing.Size(52, 48);
            this.btnLeftCtrl.TabIndex = 53;
            this.btnLeftCtrl.Text = "Ctrl";
            this.btnLeftCtrl.UseVisualStyleBackColor = false;
            this.btnLeftCtrl.Enabled = false;
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnWin.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnWin.FlatAppearance.BorderSize = 0;
            this.btnWin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWin.Image = ((System.Drawing.Image)(resources.GetObject("windowLogo")));
            this.btnWin.Location = new System.Drawing.Point(112, 205);
            this.btnWin.Margin = new System.Windows.Forms.Padding(1);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(52, 48);
            this.btnWin.TabIndex = 54;
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Enabled = false;
            // 
            // btnFn
            // 
            this.btnFn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFn.FlatAppearance.BorderSize = 0;
            this.btnFn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFn.Location = new System.Drawing.Point(4, 205);
            this.btnFn.Margin = new System.Windows.Forms.Padding(1);
            this.btnFn.Name = "btnFn";
            this.btnFn.Size = new System.Drawing.Size(52, 48);
            this.btnFn.TabIndex = 52;
            this.btnFn.Text = "Fn";
            this.btnFn.UseVisualStyleBackColor = false;
            this.btnFn.Enabled = false;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("Arrow_Right")));
            this.btnRight.Location = new System.Drawing.Point(744, 205);
            this.btnRight.Margin = new System.Windows.Forms.Padding(1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(52, 48);
            this.btnRight.TabIndex = 51;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnquot
            // 
            this.btnquot.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnquot.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnquot.FlatAppearance.BorderSize = 0;
            this.btnquot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnquot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquot.Location = new System.Drawing.Point(652, 105);
            this.btnquot.Margin = new System.Windows.Forms.Padding(1);
            this.btnquot.Name = "btnquot";
            this.btnquot.Size = new System.Drawing.Size(52, 48);
            this.btnquot.TabIndex = 50;
            this.btnquot.Text = "\'";
            this.btnquot.UseVisualStyleBackColor = false;
            this.btnquot.Enabled = false;
            // 
            // btnSlash
            // 
            this.btnSlash.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSlash.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSlash.FlatAppearance.BorderSize = 0;
            this.btnSlash.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlash.Location = new System.Drawing.Point(744, 55);
            this.btnSlash.Margin = new System.Windows.Forms.Padding(1);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(52, 48);
            this.btnSlash.TabIndex = 49;
            this.btnSlash.Text = "\\";
            this.btnSlash.UseVisualStyleBackColor = false;
            this.btnSlash.Enabled = false;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(652, 5);
            this.btnSub.Margin = new System.Windows.Forms.Padding(1);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(52, 48);
            this.btnSub.TabIndex = 48;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowDown.FlatAppearance.BorderSize = 0;
            this.btnArrowDown.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnArrowDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowDown.Image = ((System.Drawing.Image)(resources.GetObject("Arrow_DOWN")));
            this.btnArrowDown.Location = new System.Drawing.Point(690, 205);
            this.btnArrowDown.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(52, 48);
            this.btnArrowDown.TabIndex = 47;
            this.btnArrowDown.UseVisualStyleBackColor = false;
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArrowLeft.FlatAppearance.BorderSize = 0;
            this.btnArrowLeft.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnArrowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("Arrow_Left")));
            this.btnArrowLeft.Location = new System.Drawing.Point(636, 205);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(52, 48);
            this.btnArrowLeft.TabIndex = 46;
            this.btnArrowLeft.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnM.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnM.FlatAppearance.BorderSize = 0;
            this.btnM.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(474, 155);
            this.btnM.Margin = new System.Windows.Forms.Padding(1);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(52, 48);
            this.btnM.TabIndex = 45;
            this.btnM.Text = "M";
            this.btnM.Tag = "m";
            this.btnM.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnN.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnN.FlatAppearance.BorderSize = 0;
            this.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(420, 155);
            this.btnN.Margin = new System.Windows.Forms.Padding(1);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(52, 48);
            this.btnN.TabIndex = 44;
            this.btnN.Text = "N";
            this.btnN.Tag = "n";
            this.btnN.UseVisualStyleBackColor = false;
            // 
            // btnRIghtAlt
            // 
            this.btnRIghtAlt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRIghtAlt.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRIghtAlt.FlatAppearance.BorderSize = 0;
            this.btnRIghtAlt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRIghtAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRIghtAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRIghtAlt.Location = new System.Drawing.Point(528, 205);
            this.btnRIghtAlt.Margin = new System.Windows.Forms.Padding(1);
            this.btnRIghtAlt.Name = "btnRIghtAlt";
            this.btnRIghtAlt.Size = new System.Drawing.Size(52, 48);
            this.btnRIghtAlt.TabIndex = 43;
            this.btnRIghtAlt.Text = "Alt";
            this.btnRIghtAlt.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(366, 155);
            this.btnB.Margin = new System.Windows.Forms.Padding(1);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(52, 48);
            this.btnB.TabIndex = 42;
            this.btnB.Text = "B";
            this.btnB.Tag = "b";
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnRightCtrl
            // 
            this.btnRightCtrl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightCtrl.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightCtrl.FlatAppearance.BorderSize = 0;
            this.btnRightCtrl.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRightCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightCtrl.Location = new System.Drawing.Point(582, 205);
            this.btnRightCtrl.Margin = new System.Windows.Forms.Padding(1);
            this.btnRightCtrl.Name = "btnRightCtrl";
            this.btnRightCtrl.Size = new System.Drawing.Size(52, 48);
            this.btnRightCtrl.TabIndex = 42;
            this.btnRightCtrl.Text = "Ctrl";
            this.btnRightCtrl.UseVisualStyleBackColor = false;
            this.btnRightCtrl.Enabled = false;
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnV.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnV.FlatAppearance.BorderSize = 0;
            this.btnV.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(312, 155);
            this.btnV.Margin = new System.Windows.Forms.Padding(1);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(52, 48);
            this.btnV.TabIndex = 41;
            this.btnV.Text = "V";
            this.btnV.Tag = "v";
            this.btnV.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(204, 155);
            this.btnX.Margin = new System.Windows.Forms.Padding(1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(52, 48);
            this.btnX.TabIndex = 40;
            this.btnX.Text = "X";
            this.btnX.Tag = "x";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(258, 155);
            this.btnC.Margin = new System.Windows.Forms.Padding(1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 48);
            this.btnC.TabIndex = 40;
            this.btnC.Text = "C";
            this.btnC.Tag = "c";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnZ.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnZ.FlatAppearance.BorderSize = 0;
            this.btnZ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(150, 155);
            this.btnZ.Margin = new System.Windows.Forms.Padding(1);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(52, 48);
            this.btnZ.TabIndex = 39;
            this.btnZ.Text = "Z";
            this.btnZ.Tag = "z";
            this.btnZ.UseVisualStyleBackColor = false;
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftShift.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftShift.FlatAppearance.BorderSize = 0;
            this.btnLeftShift.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeftShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShift.Location = new System.Drawing.Point(4, 155);
            this.btnLeftShift.Margin = new System.Windows.Forms.Padding(1);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(144, 48);
            this.btnLeftShift.TabIndex = 37;
            this.btnLeftShift.Text = "Shift";
            this.btnLeftShift.UseVisualStyleBackColor = false;
            // 
            // btnsemi
            // 
            this.btnsemi.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsemi.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsemi.FlatAppearance.BorderSize = 0;
            this.btnsemi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsemi.Location = new System.Drawing.Point(598, 105);
            this.btnsemi.Margin = new System.Windows.Forms.Padding(1);
            this.btnsemi.Name = "btnsemi";
            this.btnsemi.Size = new System.Drawing.Size(52, 48);
            this.btnsemi.TabIndex = 36;
            this.btnsemi.Text = ";";
            this.btnsemi.UseVisualStyleBackColor = false;
            this.btnsemi.Enabled = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(706, 105);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(1);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(144, 48);
            this.btnEnter.TabIndex = 36;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(544, 105);
            this.btnL.Margin = new System.Windows.Forms.Padding(1);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(52, 48);
            this.btnL.TabIndex = 35;
            this.btnL.Text = "L";
            this.btnL.Tag = "l";
            this.btnL.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnK.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnK.FlatAppearance.BorderSize = 0;
            this.btnK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(490, 105);
            this.btnK.Margin = new System.Windows.Forms.Padding(1);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(52, 48);
            this.btnK.TabIndex = 34;
            this.btnK.Text = "K";
            this.btnK.Tag = "k";
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnJ.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnJ.FlatAppearance.BorderSize = 0;
            this.btnJ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(436, 105);
            this.btnJ.Margin = new System.Windows.Forms.Padding(1);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(52, 48);
            this.btnJ.TabIndex = 33;
            this.btnJ.Text = "J";
            this.btnJ.Tag = "j";
            this.btnJ.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnH.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnH.FlatAppearance.BorderSize = 0;
            this.btnH.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(382, 105);
            this.btnH.Margin = new System.Windows.Forms.Padding(1);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(52, 48);
            this.btnH.TabIndex = 32;
            this.btnH.Text = "H";
            this.btnH.Tag = "h";
            this.btnH.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnG.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnG.FlatAppearance.BorderSize = 0;
            this.btnG.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(328, 105);
            this.btnG.Margin = new System.Windows.Forms.Padding(1);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(52, 48);
            this.btnG.TabIndex = 31;
            this.btnG.Text = "G";
            this.btnG.Tag = "g";
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnF.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(274, 105);
            this.btnF.Margin = new System.Windows.Forms.Padding(1);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(52, 48);
            this.btnF.TabIndex = 30;
            this.btnF.Text = "F";
            this.btnF.Tag = "f";
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(220, 105);
            this.btnD.Margin = new System.Windows.Forms.Padding(1);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(52, 48);
            this.btnD.TabIndex = 29;
            this.btnD.Text = "D";
            this.btnD.Tag = "d";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(166, 105);
            this.btnS.Margin = new System.Windows.Forms.Padding(1);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(52, 48);
            this.btnS.TabIndex = 28;
            this.btnS.Text = "S";
            this.btnS.Tag = "s";
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(112, 105);
            this.btnA.Margin = new System.Windows.Forms.Padding(1);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(52, 48);
            this.btnA.TabIndex = 27;
            this.btnA.Text = "A";
            this.btnA.Tag = "a";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // btnCaps
            // 
            this.btnCaps.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCaps.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCaps.FlatAppearance.BorderSize = 0;
            this.btnCaps.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaps.Location = new System.Drawing.Point(4, 105);
            this.btnCaps.Margin = new System.Windows.Forms.Padding(1);
            this.btnCaps.Name = "btnCaps";
            this.btnCaps.Size = new System.Drawing.Size(106, 48);
            this.btnCaps.TabIndex = 26;
            this.btnCaps.Text = "Caps";
            this.btnCaps.UseVisualStyleBackColor = false;
            // 
            // btnRightScrip
            // 
            this.btnRightScrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightScrip.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRightScrip.FlatAppearance.BorderSize = 0;
            this.btnRightScrip.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRightScrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightScrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightScrip.Location = new System.Drawing.Point(690, 55);
            this.btnRightScrip.Margin = new System.Windows.Forms.Padding(1);
            this.btnRightScrip.Name = "btnRightScrip";
            this.btnRightScrip.Size = new System.Drawing.Size(52, 48);
            this.btnRightScrip.TabIndex = 25;
            this.btnRightScrip.Text = "]";
            this.btnRightScrip.UseVisualStyleBackColor = false;
            this.btnRightScrip.Enabled = false;
            // 
            // btnLeftScrip
            // 
            this.btnLeftScrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftScrip.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeftScrip.FlatAppearance.BorderSize = 0;
            this.btnLeftScrip.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeftScrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftScrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftScrip.Location = new System.Drawing.Point(636, 55);
            this.btnLeftScrip.Margin = new System.Windows.Forms.Padding(1);
            this.btnLeftScrip.Name = "btnLeftScrip";
            this.btnLeftScrip.Size = new System.Drawing.Size(52, 48);
            this.btnLeftScrip.TabIndex = 24;
            this.btnLeftScrip.Text = "[";
            this.btnLeftScrip.UseVisualStyleBackColor = false;
            this.btnLeftScrip.Enabled = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(582, 55);
            this.btnP.Margin = new System.Windows.Forms.Padding(1);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(52, 48);
            this.btnP.TabIndex = 23;
            this.btnP.Text = "P";
            this.btnP.Tag = "p";
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnO.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnO.FlatAppearance.BorderSize = 0;
            this.btnO.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(528, 55);
            this.btnO.Margin = new System.Windows.Forms.Padding(1);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(52, 48);
            this.btnO.TabIndex = 22;
            this.btnO.Text = "O";
            this.btnO.Tag = "o";
            this.btnO.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnI.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnI.FlatAppearance.BorderSize = 0;
            this.btnI.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(474, 55);
            this.btnI.Margin = new System.Windows.Forms.Padding(1);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(52, 48);
            this.btnI.TabIndex = 21;
            this.btnI.Text = "I";
            this.btnI.Tag = "i";
            this.btnI.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnU.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnU.FlatAppearance.BorderSize = 0;
            this.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(420, 55);
            this.btnU.Margin = new System.Windows.Forms.Padding(1);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(52, 48);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "U";
            this.btnU.Tag = "u";
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnY.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnY.FlatAppearance.BorderSize = 0;
            this.btnY.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(366, 55);
            this.btnY.Margin = new System.Windows.Forms.Padding(1);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(52, 48);
            this.btnY.TabIndex = 19;
            this.btnY.Text = "Y";
            this.btnY.Tag = "y";
            this.btnY.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnT.FlatAppearance.BorderSize = 0;
            this.btnT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(312, 55);
            this.btnT.Margin = new System.Windows.Forms.Padding(1);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(52, 48);
            this.btnT.TabIndex = 18;
            this.btnT.Text = "T";
            this.btnT.Tag = "t";
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnR.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(258, 55);
            this.btnR.Margin = new System.Windows.Forms.Padding(1);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(52, 48);
            this.btnR.TabIndex = 17;
            this.btnR.Text = "R";
            this.btnR.Tag = "r";
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(204, 55);
            this.btnE.Margin = new System.Windows.Forms.Padding(1);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(52, 48);
            this.btnE.TabIndex = 16;
            this.btnE.Text = "E";
            this.btnE.Tag = "e";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnW.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnW.FlatAppearance.BorderSize = 0;
            this.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(150, 55);
            this.btnW.Margin = new System.Windows.Forms.Padding(1);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(52, 48);
            this.btnW.TabIndex = 15;
            this.btnW.Text = "W";
            this.btnW.Tag = "w";
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnQ.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnQ.FlatAppearance.BorderSize = 0;
            this.btnQ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(96, 55);
            this.btnQ.Margin = new System.Windows.Forms.Padding(1);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(52, 48);
            this.btnQ.TabIndex = 14;
            this.btnQ.Text = "Q";
            this.btnQ.Tag = "q";
            this.btnQ.UseVisualStyleBackColor = false;
            // 
            // btnTab
            // 
            this.btnTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTab.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTab.FlatAppearance.BorderSize = 0;
            this.btnTab.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.Location = new System.Drawing.Point(4, 55);
            this.btnTab.Margin = new System.Windows.Forms.Padding(1);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(90, 48);
            this.btnTab.TabIndex = 13;
            this.btnTab.Text = "Tab";
            this.btnTab.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(598, 5);
            this.btnZero.Margin = new System.Windows.Forms.Padding(1);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(52, 48);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(544, 5);
            this.btnNine.Margin = new System.Windows.Forms.Padding(1);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(52, 48);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(490, 5);
            this.btnEight.Margin = new System.Windows.Forms.Padding(1);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(52, 48);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(436, 5);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(52, 48);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(382, 5);
            this.btnSix.Margin = new System.Windows.Forms.Padding(1);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(52, 48);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(328, 5);
            this.btnFive.Margin = new System.Windows.Forms.Padding(1);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(52, 48);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(274, 5);
            this.btnFour.Margin = new System.Windows.Forms.Padding(1);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(52, 48);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(220, 5);
            this.btnThree.Margin = new System.Windows.Forms.Padding(1);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(52, 48);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(166, 5);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(1);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(52, 48);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(112, 5);
            this.btnOne.Margin = new System.Windows.Forms.Padding(1);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(52, 48);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            // 
            // btnAlphos
            // 
            this.btnAlphos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAlphos.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAlphos.FlatAppearance.BorderSize = 0;
            this.btnAlphos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlphos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlphos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphos.Location = new System.Drawing.Point(58, 5);
            this.btnAlphos.Margin = new System.Windows.Forms.Padding(1);
            this.btnAlphos.Name = "btnAlphos";
            this.btnAlphos.Size = new System.Drawing.Size(52, 48);
            this.btnAlphos.TabIndex = 1;
            this.btnAlphos.Text = "`";
            this.btnAlphos.UseVisualStyleBackColor = false;
            this.btnAlphos.Enabled = false;
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Keyboard";
            this.Text = "Keyboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void Keyboard_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseMove += Keyboard_MouseMove;
        }

        private void Keyboard_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(e.X, e.Y);
        }

        private void Keyboard_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= Keyboard_MouseMove;
        }
    }
    public class Keypress : EventArgs
    {
        public char KeyCharecter { get; set; }
    }
}
