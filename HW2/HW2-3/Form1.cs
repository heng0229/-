using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
            count();
        }
        public void SetMyCustomFormat()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            //可有可無
            //dateTimePicker1.CustomFormat = "M'月'dd'日'HH':'mm";
            //dateTimePicker2.CustomFormat = "M'月'dd'日'HH':'mm";
        }
        public void count()
        {
            var p = new park();
            TimeSpan time = dateTimePicker2.Value - dateTimePicker1.Value;
            var input = p.getparkingfee((int)time.TotalMinutes);
            if (input < 0)
            {
                label3.Text = "輸入正確時間";
            }
            else
            {
                label3.Text = ($"停車費用:{input}元");
            }
            //var half1 = input / 30;
            //var hh = input / 60;
            //var mm = input % 60;
            //int output = input;
            //if (half1 > 0 && half1 <= 4)
            //{
            //    output = (output / 30) * 30;
            //    label3.Text = ($"停車費用:{output}元 停車時間:{hh}時{mm}分");
            //}
            //else if (half1 > 4 && half1 <= 8)
            //{
            //    output = (4 * 30) + ((output) / 30 - 4) * 40;
            //    label3.Text = ($"停車費用:{output}元 停車時間:{hh}時{mm}分");
            //}
            //else if (half1 > 8)
            //{
            //    output = (4 * 30) + (4 * 40) + ((output) / 30 - 8) * 60;
            //    label3.Text = ($"停車費用:{output}元 停車時間:{hh}時{mm}分");
            //}
            //else
            //{
            //    label3.Text = "請輸入";
            //}
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            count();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            count();
        }
    }
}
