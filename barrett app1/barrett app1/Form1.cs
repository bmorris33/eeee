using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrett_app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Launch browser to youtube...
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSctvfu0S1_6rGp3h13rWxeCb65CHwhBa6VWlZxjeKJgdbwu7A/viewform?pli=1&pli=1");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Launch browser to youtube...
            System.Diagnostics.Process.Start("https://mrwachs.wordpress.com/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
