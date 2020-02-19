using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);
            DateTime startDate = new DateTime(a-1, 12, 31);
            DateTime endDate = new DateTime(a, 12, 31);
            int sun = 0;
            int sat = 0;
            if (DateTime.IsLeapYear(a))
            {
                if ((int)startDate.DayOfWeek == 0)
                {
                    sun = (366 / 7) + 1;
                    sat = 366 / 7;
                }
                else if ((int)startDate.DayOfWeek == 6)
                {
                    sun = (366 / 7) + 1;
                    sat = (366 / 7) + 1;
                }
                else if ((int)startDate.DayOfWeek == 5)
                {
                    sun = 366 / 7;
                    sat = (366 / 7) + 1;
                }
            }
            else
            {
                if ((int)startDate.DayOfWeek == 0)
                {
                    sun = (365 / 7) + 1;
                    sat = 365 / 7;
                }
                else if ((int)startDate.DayOfWeek == 6)
                {
                    sun = 365 / 7;
                    sat = (365 / 7) + 1;
                }
                else
                {
                    sun = 365 / 7;
                    sat = 365 / 7;
                }
            }
            /*if (DateTime.IsLeapYear(a))
            {
                sun = 366 / 7;
                sat = 365 / 7;
                Console.WriteLine($"民國{a}年 是閏年");
            }
            else
            {
                sun = 365 / 7;
                sat = 365 / 7;
                Console.WriteLine($"民國{a}年 不是閏年");
            }*/
            label1.Text = $"西元{a}年,"+"星期六有" + sat.ToString() + "天,星期日有" + sun.ToString() + "天";
        }
    }
}
