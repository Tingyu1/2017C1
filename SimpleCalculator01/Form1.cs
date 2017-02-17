using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);//text傳到textbox3的屬性
            int y = int.Parse(textBox4.Text);
            label2.Text = (x + y).ToString();//text屬性型別是字串
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);
            label2.Text = (x - y).ToString();
        }
    }
}
