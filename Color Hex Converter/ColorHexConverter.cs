using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.Opacity = 0.95;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            Color c = Color.FromName(str);
            textBox1.Text = Color_to_Hex(c);
            button1.BackColor = c;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string str = textBox2.Text;
                Color c = Hex_to_Color(str);
                label1.Text = "Name : " + c.Name;
                button3.BackColor = c;
            }
            catch
            {
                label1.Text = "Error !!!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "مرداد 88 ";
            MessageBox.Show(about, "درباره سازنده نرم افزار ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
