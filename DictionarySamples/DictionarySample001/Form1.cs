using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySample001
{
    public partial class Form1 : Form
    {
        private Dictionary<string, MyRectangle> _dictionary;
        public Form1()
        {
            InitializeComponent();
            CreatDictionary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show($"{key}的面積為:{area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
        private void CreatDictionary()
        {
            _dictionary = new Dictionary<string, MyRectangle>();
            _dictionary.Add("D1", new MyRectangle { width = 5, height = 5 });
            _dictionary.Add("D2", new MyRectangle { width = 10, height = 10 });
            _dictionary.Add("D3", new MyRectangle { width = 20, height = 20 });
            _dictionary.Add("D4", new MyRectangle { width = 100, height = 100 });


            // 另一種方式
            //_dictionary = new List<MyRectangle>()
            //{
            //    "D1", new MyRectangle { width = 5, height = 5 });
            //    "D2", new MyRectangle { width = 10, height = 10 }),
            //    "D3", new MyRectangle { width = 20, height = 20 }),
            //    "D4", new MyRectangle { width = 100, height = 100 })
            //};
        }
    }
}
