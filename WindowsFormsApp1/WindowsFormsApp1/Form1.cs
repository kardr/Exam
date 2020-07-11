using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                webBrowser1.Url = new Uri(s);
                this.Width = 800;

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Дроздова Карина Александровна",
        "Информация об авторе",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string t = System.IO.Path.GetFileName(s);

            double x, y;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            if (t == "str1.html")
            {


                if ((x >= -2 && x <= 3 && y >= 2 && y <= 5) || (x >= 3 && x <= 5 && y >= 2 && y <= 3))
                {
                    MessageBox.Show(
            "Принадлежит",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
                    toolStripStatusLabel2.Text = "Принадлежит";

                }
                else
                {
                    MessageBox.Show(
            "Не принадлежит",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
                    toolStripStatusLabel2.Text = "Не принадлежит";
                }
            }
            else if(t== "str2.html")
            {
                if ((y<=0 && (x*x+y*y)>=1) || (y>=0 && x*x<=y))
                {
                    MessageBox.Show(
            "Принадлежит",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
                    toolStripStatusLabel2.Text = "Принадлежит";

                }
                else
                {
                    MessageBox.Show(
            "Не принадлежит",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
                    toolStripStatusLabel2.Text = "Не принадлежит";
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 550;
        }
    }
}
