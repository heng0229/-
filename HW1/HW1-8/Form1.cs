using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = 1911 + a;
            DateTime startDate = new DateTime(b, 01, 01);
            DateTime endDate = new DateTime(b, 12, 31);
            int sun = 0;
            int sat = 0;
            while (startDate <= endDate)
            {
                if ((int)startDate.DayOfWeek == 0)
                {
                    sun += 1;
                }
                else if ((int)startDate.DayOfWeek == 6)
                {
                    sat += 1;
                }

                startDate = startDate.AddDays(1);

            }
            label1.Text = $"民國{a}年," + "星期六有" + sat.ToString() + "天,星期日有" + sun.ToString() + "天";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = 1911 + a;
            DateTime startDate = new DateTime(b, 01, 01);
            DateTime endDate = new DateTime(b + 1, 01, 01);
            int sun = 0;
            int sat = 0;
            if (DateTime.IsLeapYear(b))
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
                else
                {
                    sun = 365 / 7;
                    sat = 365 / 7;
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
            label1.Text = $"民國{a}年," + "星期六有" + sat.ToString() + "天,星期日有" + sun.ToString() + "天";
        }
    }
}
