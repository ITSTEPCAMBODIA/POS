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
            this.LeftShiftBtn = new System.Windows.Forms.Button();
            this.RightShiftBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LeftShiftBtn
            // 
            this.LeftShiftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftShiftBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftShiftBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LeftShiftBtn.FlatAppearance.BorderSize = 2;
            this.LeftShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftShiftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftShiftBtn.Location = new System.Drawing.Point(0, 180);
            this.LeftShiftBtn.Name = "LeftShiftBtn";
            this.LeftShiftBtn.Size = new System.Drawing.Size(70, 70);
            this.LeftShiftBtn.TabIndex = 0;
            this.LeftShiftBtn.Text = "<";
            this.LeftShiftBtn.UseVisualStyleBackColor = false;
            // 
            // RightShiftBtn
            // 
            this.RightShiftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightShiftBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightShiftBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RightShiftBtn.FlatAppearance.BorderSize = 3;
            this.RightShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightShiftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightShiftBtn.Location = new System.Drawing.Point(1330, 180);
            this.RightShiftBtn.Name = "RightShiftBtn";
            this.RightShiftBtn.Size = new System.Drawing.Size(70, 70);
            this.RightShiftBtn.TabIndex = 1;
            this.RightShiftBtn.Text = ">";
            this.RightShiftBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
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
            // DrinkSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightShiftBtn);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftShiftBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinkSelectionForm";
            this.Text = "DrinkSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LeftShiftBtn;
        private System.Windows.Forms.Button RightShiftBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RightPanel;
    }
}