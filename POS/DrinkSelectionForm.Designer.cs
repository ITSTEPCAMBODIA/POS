namespace POS
{
    partial class DrinkSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkSelectionForm));
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AddDrinkBtn = new System.Windows.Forms.Button();
            this.DrinkPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DownBtn
            // 
            this.DownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DownBtn.FlatAppearance.BorderSize = 2;
            this.DownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownBtn.Location = new System.Drawing.Point(0, 180);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(70, 70);
            this.DownBtn.TabIndex = 0;
            this.DownBtn.Text = "↓";
            this.DownBtn.UseVisualStyleBackColor = false;
            this.DownBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownBtn_MouseDown);
            // 
            // UpBtn
            // 
            this.UpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UpBtn.FlatAppearance.BorderSize = 3;
            this.UpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpBtn.Location = new System.Drawing.Point(1330, 180);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(70, 70);
            this.UpBtn.TabIndex = 1;
            this.UpBtn.Text = "↑";
            this.UpBtn.UseVisualStyleBackColor = false;
            this.UpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBtn_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "I T S T E P  c a f e";
            // 
            // RightPanel
            // 
            this.RightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1400, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(520, 1080);
            this.RightPanel.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.Control;
            //this.HomeBtn.BackgroundImage = global::POS.Properties.Resources.HomeButtonImg;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.Location = new System.Drawing.Point(70, 180);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(70, 70);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // AddDrinkBtn
            // 
            this.AddDrinkBtn.BackColor = System.Drawing.SystemColors.Control;
            //this.AddDrinkBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddDrinkBtn.BackgroundImage")));
            this.AddDrinkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDrinkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddDrinkBtn.FlatAppearance.BorderSize = 0;
            this.AddDrinkBtn.Location = new System.Drawing.Point(1260, 180);
            this.AddDrinkBtn.Name = "AddDrinkBtn";
            this.AddDrinkBtn.Size = new System.Drawing.Size(70, 70);
            this.AddDrinkBtn.TabIndex = 3;
            this.AddDrinkBtn.UseVisualStyleBackColor = false;
            this.AddDrinkBtn.Click += new System.EventHandler(this.AddBtn_Clicked);
            // 
            // DrinkPanel
            // 
            this.DrinkPanel.AutoScroll = true;
            this.DrinkPanel.Location = new System.Drawing.Point(0, 256);
            this.DrinkPanel.Name = "DrinkPanel";
            this.DrinkPanel.Size = new System.Drawing.Size(1400, 824);
            this.DrinkPanel.TabIndex = 4;
            // 
            // DrinkSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.DrinkPanel);
            this.Controls.Add(this.AddDrinkBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.DownBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinkSelectionForm";
            this.Text = "DrinkSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AddDrinkBtn;
        private System.Windows.Forms.Panel DrinkPanel;
    }
}