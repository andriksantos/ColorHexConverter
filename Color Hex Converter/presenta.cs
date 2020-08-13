using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOminds
{
    public partial class presenta : Form
    {
        public presenta()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void presenta_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            string year;
            year = DateTime.Today.Year.ToString();
            CopyRight.Text = "Copyright © " + year + " All rights reserved";
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://andriksantos.github.io");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andriksantos");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andriksantos/FileCompressor");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/andrik_rsm");
        }
    }
}
