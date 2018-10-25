namespace POS
{
    partial class AddDrinks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.pbDrink = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.NewCategory = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // Keyboard
            // 
            this.Keyboard.Location = new System.Drawing.Point(294, 294);
            // 
            // pbDrink
            // 
            this.pbDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrink.Location = new System.Drawing.Point(692, 86);
            this.pbDrink.Name = "pbDrink";
            this.pbDrink.Size = new System.Drawing.Size(500, 500);
            this.pbDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrink.TabIndex = 3;
            this.pbDrink.TabStop = false;
            this.pbDrink.Click += new System.EventHandler(this.pbDrink_Click);
            this.pbDrink.MouseEnter += new System.EventHandler(this.pbDrink_MouseEnter);
            this.pbDrink.MouseLeave += new System.EventHandler(this.pbDrink_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drinks code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drinks name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Note";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(224, 80);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(319, 44);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(224, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 44);
            this.txtName.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(224, 236);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(319, 45);
            this.cbCategory.TabIndex = 3;
            // 
            // NewCategory
            // 
            this.NewCategory.AutoSize = true;
            this.NewCategory.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.NewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewCategory.Location = new System.Drawing.Point(556, 234);
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Size = new System.Drawing.Size(42, 43);
            this.NewCategory.TabIndex = 8;
            this.NewCategory.Text = "+";
            this.NewCategory.UseVisualStyleBackColor = false;
            this.NewCategory.Click += new System.EventHandler(this.NewCategory_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(224, 304);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(319, 44);
            this.txtPrice.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(224, 388);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(319, 223);
            this.txtNote.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(458, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 63);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOK.Location = new System.Drawing.Point(19, 636);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(409, 63);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1212, 40);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "New Drink";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddDrinks
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 725);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.NewCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDrink);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDrinks";
            this.Text = "Add Drink";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDrinks_FormClosing);
            this.Load += new System.EventHandler(this.AddDrinks_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddDrinks_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox pbDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button NewCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
    }
}

