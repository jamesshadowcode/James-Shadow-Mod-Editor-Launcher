using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace LauncherTemplate
{
    public partial class MainWindow : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string gameFile;
        public string readmeFile;
        public string handbookFile;
        public string youtubeLink;
        public string twitterLink;
        public string facebookLink;
        public string websiteLink;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // PLAY
            this.play.MouseEnter += new System.EventHandler(this.play_e);
            this.play.MouseLeave += new System.EventHandler(this.play_l);
            // README
            this.readme.MouseEnter += new System.EventHandler(this.readme_e);
            this.readme.MouseLeave += new System.EventHandler(this.readme_l);
            // CREDITS
            this.credits.MouseEnter += new System.EventHandler(this.credits_e);
            this.credits.MouseLeave += new System.EventHandler(this.credits_l);
            // DOCS
            this.handbook.MouseEnter += new System.EventHandler(this.handbook_e);
            this.handbook.MouseLeave += new System.EventHandler(this.handbook_l);
            // EXIT
            this.cross.MouseEnter += new System.EventHandler(this.crosss_e);
            this.cross.MouseLeave += new System.EventHandler(this.crosss_l);
            // MINIMIZED
            this.underscore.MouseEnter += new System.EventHandler(this.underscore_e);
            this.underscore.MouseLeave += new System.EventHandler(this.underscore_l);

            SetupCustomInfos();
        }

        // START

        public void SetupCustomInfos() {
            gameFile = "James reborn ML Editor"; 
            readmeFile = "readme.txt"; 
            handbookFile = "hand.pdf"; 
            this.Text = "LauncherTemplate"; 
            youtubeLink = "https://www.youtube.com/"; 
            twitterLink = "https://instagram.com/usbo_0/"; 
            facebookLink = "https://www.facebook.com/"; 
            websiteLink = "https://www.google.com/"; 
        }

        // END

        private void play_Click(object sender, EventArgs e)
        {
                Process.Start(@"C:\Users\UsBo_0\Desktop\James reborn ML Editor\James reborn ML Editor"); 
        }

        private void readme_Click(object sender, EventArgs e)
        {
            
            Process.Start(@"https://www.discord.plus/JAMESSHADOW/");
        }

        private void credis_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void underscore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void play_e(object s, EventArgs e) {
            play.Image = Properties.Resources.playaction;
        }

        private void play_l(object s, EventArgs e)
        {
            play.Image = Properties.Resources.playidle;
        }

        private void readme_e(object s, EventArgs e)
        {
            readme.Image = Properties.Resources.suppaction;
        }

        private void readme_l(object s, EventArgs e)
        {
            readme.Image = Properties.Resources.suppidle;
        }

        private void credits_e(object s, EventArgs e)
        {
            credits.Image = Properties.Resources.black;
        }

        private void credits_l(object s, EventArgs e)
        {
            credits.Image = Properties.Resources.black;
        }

        private void handbook_e(object s, EventArgs e)
        {
            handbook.Image = Properties.Resources.abaction;
        }

        private void handbook_l(object s, EventArgs e)
        {
            handbook.Image = Properties.Resources.abidle;
        }

        private void crosss_e(object s, EventArgs e)
        {
            cross.Image = Properties.Resources.xaction;
        }

        private void crosss_l(object s, EventArgs e)
        {
            cross.Image = Properties.Resources.xidle;
        }


        private void underscore_e(object s, EventArgs e)
        {
            underscore.Image = Properties.Resources.crossaction;
        }

        private void underscore_l(object s, EventArgs e)
        {
            underscore.Image = Properties.Resources.crossidle;
        }

        private void button2_e(object s, EventArgs e)
        {
            button2.Image = Properties.Resources.dowaction;
        }

        private void button2_l(object s, EventArgs e)
        {
            button2.Image = Properties.Resources.dowidle;
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            Process.Start(youtubeLink);
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            Process.Start(twitterLink);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            Process.Start(facebookLink);
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start(websiteLink);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About c = new About();
            c.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start(facebookLink);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"https://tiny.cc/JRMODLOADEREDITOR");
        }
    }
}

