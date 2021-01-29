namespace LauncherTemplate
{
    partial class MainWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.play = new System.Windows.Forms.Button();
            this.readme = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.PictureBox();
            this.underscore = new System.Windows.Forms.PictureBox();
            this.youtube = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.twitter = new System.Windows.Forms.PictureBox();
            this.website = new System.Windows.Forms.PictureBox();
            this.handbook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Red;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Image = global::LauncherTemplate.Properties.Resources.playidle;
            this.play.Location = new System.Drawing.Point(388, 248);
            this.play.Name = "play";
            this.play.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.play.Size = new System.Drawing.Size(145, 45);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // readme
            // 
            this.readme.BackColor = System.Drawing.Color.DarkRed;
            this.readme.FlatAppearance.BorderSize = 0;
            this.readme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readme.Image = global::LauncherTemplate.Properties.Resources.suppidle;
            this.readme.Location = new System.Drawing.Point(388, 197);
            this.readme.Name = "readme";
            this.readme.Size = new System.Drawing.Size(145, 45);
            this.readme.TabIndex = 2;
            this.readme.UseVisualStyleBackColor = false;
            this.readme.Click += new System.EventHandler(this.readme_Click);
            // 
            // cross
            // 
            this.cross.Image = global::LauncherTemplate.Properties.Resources.xidle;
            this.cross.Location = new System.Drawing.Point(530, -1);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(31, 25);
            this.cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross.TabIndex = 3;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // underscore
            // 
            this.underscore.Image = global::LauncherTemplate.Properties.Resources.crossidle;
            this.underscore.Location = new System.Drawing.Point(503, -1);
            this.underscore.Name = "underscore";
            this.underscore.Size = new System.Drawing.Size(30, 25);
            this.underscore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.underscore.TabIndex = 4;
            this.underscore.TabStop = false;
            this.underscore.Click += new System.EventHandler(this.underscore_Click);
            // 
            // youtube
            // 
            this.youtube.BackColor = System.Drawing.Color.Transparent;
            this.youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtube.Image = global::LauncherTemplate.Properties.Resources.Youtube;
            this.youtube.Location = new System.Drawing.Point(12, 271);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(32, 32);
            this.youtube.TabIndex = 5;
            this.youtube.TabStop = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // facebook
            // 
            this.facebook.BackColor = System.Drawing.Color.Transparent;
            this.facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebook.Image = global::LauncherTemplate.Properties.Resources.Facebook;
            this.facebook.Location = new System.Drawing.Point(88, 271);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(32, 32);
            this.facebook.TabIndex = 6;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // twitter
            // 
            this.twitter.BackColor = System.Drawing.Color.Transparent;
            this.twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitter.Image = global::LauncherTemplate.Properties.Resources.OIP;
            this.twitter.Location = new System.Drawing.Point(50, 271);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(32, 32);
            this.twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twitter.TabIndex = 7;
            this.twitter.TabStop = false;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // website
            // 
            this.website.BackColor = System.Drawing.Color.Transparent;
            this.website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.website.Image = global::LauncherTemplate.Properties.Resources.Website;
            this.website.Location = new System.Drawing.Point(126, 271);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(32, 32);
            this.website.TabIndex = 8;
            this.website.TabStop = false;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // handbook
            // 
            this.handbook.BackColor = System.Drawing.Color.DarkRed;
            this.handbook.FlatAppearance.BorderSize = 0;
            this.handbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.handbook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.handbook.Image = global::LauncherTemplate.Properties.Resources.abidle;
            this.handbook.Location = new System.Drawing.Point(388, 146);
            this.handbook.Name = "handbook";
            this.handbook.Size = new System.Drawing.Size(145, 45);
            this.handbook.TabIndex = 9;
            this.handbook.Text = "\r\n";
            this.handbook.UseVisualStyleBackColor = false;
            this.handbook.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LauncherTemplate.Properties.Resources.js;
            this.button1.Location = new System.Drawing.Point(164, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 62);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LauncherTemplate.Properties.Resources.dowidle;
            this.button2.Location = new System.Drawing.Point(13, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.DarkRed;
            this.credits.FlatAppearance.BorderSize = 0;
            this.credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits.Image = global::LauncherTemplate.Properties.Resources.black;
            this.credits.Location = new System.Drawing.Point(237, 293);
            this.credits.Margin = new System.Windows.Forms.Padding(0);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(10, 10);
            this.credits.TabIndex = 1;
            this.credits.UseVisualStyleBackColor = false;
            this.credits.Click += new System.EventHandler(this.credis_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.BackgroundImage = global::LauncherTemplate.Properties.Resources.black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::LauncherTemplate.Properties.Resources.black;
            this.button3.Location = new System.Drawing.Point(-4, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(565, 288);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::LauncherTemplate.Properties.Resources.download;
            this.button4.Location = new System.Drawing.Point(13, 271);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 32);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LauncherTemplate.Properties.Resources.black;
            this.ClientSize = new System.Drawing.Size(560, 315);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.underscore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.handbook);
            this.Controls.Add(this.website);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.readme);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.play);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "o_0 Games Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button readme;
        private System.Windows.Forms.PictureBox cross;
        private System.Windows.Forms.PictureBox underscore;
        private System.Windows.Forms.PictureBox youtube;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox twitter;
        private System.Windows.Forms.PictureBox website;
        private System.Windows.Forms.Button handbook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}