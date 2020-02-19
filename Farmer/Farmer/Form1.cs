using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        private List<string> _leftlist;
        private List<string> _rightlist;
        public Form1()
        {
            InitializeComponent();
            creatlist();
            SetListBoxDataSource();
            ChangeData();
        }
        private void creatlist()
        {
            _leftlist = new List<string>
            {
                "農夫","狼","羊","菜"
            };
            _rightlist = new List<string>();
        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftlist;
            listBox2.DataSource = _rightlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem;
                _leftlist.Remove(item);
                _rightlist.Add(item);
                if (item != "農夫" && _leftlist.Any(x => x == "農夫"))
                {
                    _leftlist.Remove("農夫");
                    _rightlist.Add("農夫");
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else if (item == "農夫" && _rightlist.Any(x => x == "農夫"))
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                ChangeData();
                if (_leftlist.Count == 3)
                {
                    MessageBox.Show("羊吃菜，狼吃羊");
                    button2.Enabled = false;
                }
                else if (_leftlist.Any(x => x == "狼") && _leftlist.Any(x => x == "羊"))
                {
                    MessageBox.Show("狼吃羊");
                    button2.Enabled = false;
                }
                else if (_leftlist.Any(x => x == "羊") && _leftlist.Any(x => x == "菜"))
                {
                    MessageBox.Show("羊吃菜");
                    button2.Enabled = false;
                }
                else if (_rightlist.Count == 4)
                {
                    MessageBox.Show("通關");
                    button2.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                _leftlist.Add(item);
                _rightlist.Remove(item);
                if (item != "農夫" && _rightlist.Any(x => x == "農夫"))
                {
                    _leftlist.Add("農夫");
                    _rightlist.Remove("農夫");
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else if (item == "農夫" && _leftlist.Any(x => x == "農夫"))
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                ChangeData();
                if (_rightlist.Any(x => x == "狼") && _rightlist.Any(x => x == "羊"))
                {
                    MessageBox.Show("狼吃羊");
                    button1.Enabled = false;
                }
                else if (_rightlist.Any(x => x == "羊") && _rightlist.Any(x => x == "菜"))
                {
                    MessageBox.Show("羊吃菜");
                    button1.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creatlist();
            ChangeData();
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
