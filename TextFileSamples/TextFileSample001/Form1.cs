using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSample001
{
    public partial class Form1 : Form
    {
        private string filename;
        public Form1()
        {
            InitializeComponent();
            filename = "test.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if(File.Exists(filename))
            { textBox1.Text = File.ReadAllText(filename); }
            else
            { MessageBox.Show("檔案不存在"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filename,textBox1.Text);
            MessageBox.Show("存檔完成");
            textBox1.Clear();
        }
    }
}
