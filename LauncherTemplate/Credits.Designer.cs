namespace LauncherTemplate
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(146, 12);
            this.creditsBox.Multiline = true;
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.ReadOnly = true;
            this.creditsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.creditsBox.Size = new System.Drawing.Size(257, 242);
            this.creditsBox.TabIndex = 0;
            this.creditsBox.TextChanged += new System.EventHandler(this.creditsBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LauncherTemplate.Properties.Resources.CreditsLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creditsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Credits";
            this.Text = "Crediti";
            this.Load += new System.EventHandler(this.Credits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}