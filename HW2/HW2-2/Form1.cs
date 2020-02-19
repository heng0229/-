using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_2
{
    public partial class Form1 : Form
    {
        int a, b, c, d, total;
        //int t1000, t500, t100, t50, t10, t5, t1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SubTotal();
            Conver();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SubTotal();
            Conver();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SubTotal();
            Conver();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SubTotal();
            Conver();
        }
        public Form1()
        {
            InitializeComponent();
            SubTotal();
            Conver();
        }
        public void SubTotal()
        {
            //a = int.Parse(textBox1.Text);
            //b = int.Parse(textBox2.Text);
            //c = int.Parse(textBox3.Text);
            //d = int.Parse(textBox4.Text);
            if (Int32.TryParse(textBox1.Text, out a) && Int32.TryParse(textBox2.Text, out b)
                && Int32.TryParse(textBox3.Text, out c) && Int32.TryParse(textBox4.Text, out d))
            {
                total = a * 30 + b * 15 + c * 15 + d * 40;
                label5.Text = ($"高麗菜{a}份、豆乾{b}份、海帶{c}份、肉片{d}份，應收{total}元");
            }
        }
        public void Conver()
        {
            var c = new calculator(total);
            //t1000 = total / 1000;
            //t500 = total % 1000 / 500;
            //t100 = total % 1000 % 500 / 100;
            //t50 = total % 1000 % 500 % 100 / 50;
            //t10 = total % 1000 % 500 % 100 % 50 / 10;
            //t5 = total % 1000 % 500 % 100 % 50 % 10 / 5;
            //t1 = total % 1000 % 500 % 100 % 50 % 10 % 5 / 1;

            label6.Text = ($"應收1000元{c.onethousand}張、500元{c.fivehundred}張、" +
                $"100元{c.onehundred}張、50元{c.fifty}枚、10元{c.ten}枚、" +
                $"5元{c.five}枚、1元{c.one}枚");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*    int a, b, c, d, total;
                int t1000, t500, t100, t50, t10, t5, t1;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);
                d = int.Parse(textBox4.Text);
                total = a * 30 + b * 15 + c * 15 + d * 40;
                label5.Text = ($"高麗菜{a}份、豆乾{b}份、海帶{c}份、肉片{d}份，應收{total}元");

                t1000 = total / 1000;
                t500 = total % 1000 / 500;
                t100 = total % 1000 % 500 / 100;
                t50 = total % 1000 % 500 % 100 / 50;
                t10 = total % 1000 % 500 % 100 % 50 / 10;
                t5 = total % 1000 % 500 % 100 % 50 % 10 / 5;
                t1 = total % 1000 % 500 % 100 % 50 % 10 % 5 / 1;

                label6.Text = ($"應收1000元{t1000}張、500元{t500}張、100元{t100}張、" +
                    $"50元{t50}枚、10元{t10}枚、5元{t5}枚、1元{t1}枚");
                    */
        }

    }
}
