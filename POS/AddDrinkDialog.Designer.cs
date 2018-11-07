namespace POS
{
    partial class AddDrinkDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGsize = new System.Windows.Forms.Button();
            this.btnLsize = new System.Windows.Forms.Button();
            this.btnRsize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbZone = new System.Windows.Forms.ComboBox();
            this.cbSugar = new System.Windows.Forms.ComboBox();
            this.chbCream = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGsize);
            this.groupBox1.Controls.Add(this.btnLsize);
            this.groupBox1.Controls.Add(this.btnRsize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(216, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // btnGsize
            // 
            this.btnGsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGsize.Location = new System.Drawing.Point(152, 28);
            this.btnGsize.Margin = new System.Windows.Forms.Padding(2);
            this.btnGsize.Name = "btnGsize";
            this.btnGsize.Size = new System.Drawing.Size(57, 43);
            this.btnGsize.TabIndex = 2;
            this.btnGsize.Text = "G";
            this.btnGsize.UseVisualStyleBackColor = true;
            this.btnGsize.Click += new System.EventHandler(this.SizeSelection);
            // 
            // btnLsize
            // 
            this.btnLsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLsize.Location = new System.Drawing.Point(79, 28);
            this.btnLsize.Margin = new System.Windows.Forms.Padding(2);
            this.btnLsize.Name = "btnLsize";
            this.btnLsize.Size = new System.Drawing.Size(57, 43);
            this.btnLsize.TabIndex = 1;
            this.btnLsize.Text = "L";
            this.btnLsize.UseVisualStyleBackColor = true;
            this.btnLsize.Click += new System.EventHandler(this.SizeSelection);
            // 
            // btnRsize
            // 
            this.btnRsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsize.Location = new System.Drawing.Point(6, 28);
            this.btnRsize.Margin = new System.Windows.Forms.Padding(2);
            this.btnRsize.Name = "btnRsize";
            this.btnRsize.Size = new System.Drawing.Size(57, 43);
            this.btnRsize.TabIndex = 0;
            this.btnRsize.Text = "R";
            this.btnRsize.UseVisualStyleBackColor = true;
            this.btnRsize.Click += new System.EventHandler(this.SizeSelection);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbZone);
            this.groupBox2.Controls.Add(this.cbSugar);
            this.groupBox2.Controls.Add(this.chbCream);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(376, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // cbZone
            // 
            this.cbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZone.FormattingEnabled = true;
            this.cbZone.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbZone.Location = new System.Drawing.Point(188, 90);
            this.cbZone.Margin = new System.Windows.Forms.Padding(2);
            this.cbZone.Name = "cbZone";
            this.cbZone.Size = new System.Drawing.Size(160, 30);
            this.cbZone.TabIndex = 5;
            // 
            // cbSugar
            // 
            this.cbSugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSugar.FormattingEnabled = true;
            this.cbSugar.Items.AddRange(new object[] {
            "10%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cbSugar.Location = new System.Drawing.Point(188, 57);
            this.cbSugar.Margin = new System.Windows.Forms.Padding(2);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(160, 30);
            this.cbSugar.TabIndex = 4;
            // 
            // chbCream
            // 
            this.chbCream.AutoSize = true;
            this.chbCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCream.Location = new System.Drawing.Point(188, 32);
            this.chbCream.Margin = new System.Windows.Forms.Padding(2);
            this.chbCream.Name = "chbCream";
            this.chbCream.Size = new System.Drawing.Size(15, 14);
            this.chbCream.TabIndex = 3;
            this.chbCream.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sugar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cream";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(304, 232);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 33);
            this.btnCancel.TabIndex = 9;
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
            this.btnOK.Location = new System.Drawing.Point(85, 232);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(204, 33);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddDrinkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDrinkDialog";
            this.Text = "AddDrinkDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGsize;
        private System.Windows.Forms.Button btnLsize;
        private System.Windows.Forms.Button btnRsize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbZone;
        private System.Windows.Forms.ComboBox cbSugar;
        private System.Windows.Forms.CheckBox chbCream;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}