using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LauncherTemplate
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

 /*       private void About_Load(object sender, EventArgs e)
        {
            CreditsBox.Text = Properties.Resources.CreditsText;
        }*/

/*        private void CreditsBox_TextChanged(object sender, EventArgs e)
        {

        }*/

/*        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.SuspendLayout();
            // 
            // About
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        private void About_Load(object sender, System.EventArgs e)
        {

        }
    }
}
