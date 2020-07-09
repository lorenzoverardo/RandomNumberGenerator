namespace RandomNumberGenerator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPictureBox = new System.Windows.Forms.PictureBox();
            this.generatedNumberLabel = new System.Windows.Forms.Label();
            this.upperBoundLabel = new System.Windows.Forms.Label();
            this.lowerBoundLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.generatedNumberTextBox = new System.Windows.Forms.TextBox();
            this.upperBoundTextBox = new System.Windows.Forms.TextBox();
            this.lowerBoundTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(317, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // copyPictureBox
            // 
            this.copyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("copyPictureBox.Image")));
            this.copyPictureBox.Location = new System.Drawing.Point(93, 155);
            this.copyPictureBox.Name = "copyPictureBox";
            this.copyPictureBox.Size = new System.Drawing.Size(19, 20);
            this.copyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copyPictureBox.TabIndex = 17;
            this.copyPictureBox.TabStop = false;
            this.copyPictureBox.Click += new System.EventHandler(this.copyPictureBox_Click);
            // 
            // generatedNumberLabel
            // 
            this.generatedNumberLabel.AutoSize = true;
            this.generatedNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedNumberLabel.Location = new System.Drawing.Point(136, 178);
            this.generatedNumberLabel.Name = "generatedNumberLabel";
            this.generatedNumberLabel.Size = new System.Drawing.Size(46, 17);
            this.generatedNumberLabel.TabIndex = 16;
            this.generatedNumberLabel.Text = "Result";
            // 
            // upperBoundLabel
            // 
            this.upperBoundLabel.AutoSize = true;
            this.upperBoundLabel.Location = new System.Drawing.Point(216, 49);
            this.upperBoundLabel.Name = "upperBoundLabel";
            this.upperBoundLabel.Size = new System.Drawing.Size(27, 13);
            this.upperBoundLabel.TabIndex = 15;
            this.upperBoundLabel.Text = "Max";
            // 
            // lowerBoundLabel
            // 
            this.lowerBoundLabel.AutoSize = true;
            this.lowerBoundLabel.Location = new System.Drawing.Point(76, 49);
            this.lowerBoundLabel.Name = "lowerBoundLabel";
            this.lowerBoundLabel.Size = new System.Drawing.Size(24, 13);
            this.lowerBoundLabel.TabIndex = 14;
            this.lowerBoundLabel.Text = "Min";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(118, 114);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(80, 20);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // generatedNumberTextBox
            // 
            this.generatedNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.generatedNumberTextBox.Location = new System.Drawing.Point(118, 155);
            this.generatedNumberTextBox.Name = "generatedNumberTextBox";
            this.generatedNumberTextBox.ReadOnly = true;
            this.generatedNumberTextBox.Size = new System.Drawing.Size(80, 20);
            this.generatedNumberTextBox.TabIndex = 12;
            this.generatedNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generatedNumberTextBox.Enter += new System.EventHandler(this.generatedNumberTextBox_Enter);
            // 
            // upperBoundTextBox
            // 
            this.upperBoundTextBox.Location = new System.Drawing.Point(189, 65);
            this.upperBoundTextBox.Name = "upperBoundTextBox";
            this.upperBoundTextBox.Size = new System.Drawing.Size(80, 20);
            this.upperBoundTextBox.TabIndex = 11;
            this.upperBoundTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lowerBoundTextBox
            // 
            this.lowerBoundTextBox.Location = new System.Drawing.Point(48, 65);
            this.lowerBoundTextBox.Name = "lowerBoundTextBox";
            this.lowerBoundTextBox.Size = new System.Drawing.Size(80, 20);
            this.lowerBoundTextBox.TabIndex = 10;
            this.lowerBoundTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 218);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.copyPictureBox);
            this.Controls.Add(this.generatedNumberLabel);
            this.Controls.Add(this.upperBoundLabel);
            this.Controls.Add(this.lowerBoundLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generatedNumberTextBox);
            this.Controls.Add(this.upperBoundTextBox);
            this.Controls.Add(this.lowerBoundTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Random Number Generator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox copyPictureBox;
        private System.Windows.Forms.Label generatedNumberLabel;
        private System.Windows.Forms.Label upperBoundLabel;
        private System.Windows.Forms.Label lowerBoundLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox generatedNumberTextBox;
        private System.Windows.Forms.TextBox upperBoundTextBox;
        private System.Windows.Forms.TextBox lowerBoundTextBox;
    }
}

