using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IOminds;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string Color_to_Hex(Color c)
        {
            return ColorTranslator.ToOle(c).ToString("X");
        }
        Color Hex_to_Color(string hx)
        {
            int x = int.Parse(hx, System.Globalization.NumberStyles.HexNumber);
            Color c = ColorTranslator.FromOle(x);
            return c;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = Enum.GetNames(typeof(KnownColor));
            foreach (string s in colors)
            {
                listBox1.Items.Add(s);
            }
            label1.Text = "";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            Color c = Color.FromName(str);
            textBox3.Text = Color_to_Hex(c);
            button1.BackColor = c;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            presenta presentation = new presenta();
            presentation.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox4.Text;
                Color c = Hex_to_Color(str);
                label1.Text = "Name : " + c.Name;
                button3.BackColor = c;
            }
            catch
            {
                label1.Text = "Error !!!";
            }
        }
    }
}
