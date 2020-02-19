using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_6
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
            DateTime startDate = new DateTime(a, 01, 01);
            DateTime endDate = new DateTime(a, 12, 31);
            int sun = 0;
            int sat = 0;
            while (startDate < endDate)
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
            label1.Text = $"西元{a}年," + "星期六有" + sat.ToString() + "天,星期日有" + sun.ToString() + "天";
        }
    }
}
