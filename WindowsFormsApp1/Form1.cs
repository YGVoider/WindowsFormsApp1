using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.AppendText("This is new text\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int n = 0;
            n = listBox1.Items.Count + 1;
            listBox1.Items.Add("This is line number " + n +".");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
