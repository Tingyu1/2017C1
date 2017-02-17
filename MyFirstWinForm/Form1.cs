using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()//建構式 初始化類別欄位成員
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//事件執行動作
        {
            MessageBox.Show("Hello Windows Forms");//show跳出一訊息盒
        }
    }
}
