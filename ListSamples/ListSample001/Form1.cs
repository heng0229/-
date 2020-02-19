using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
        }
        private void CreateList()
        {
            _list = new List<MyRectangle>();
            _list.Add(new MyRectangle { name = "D1", width = 5, height = 5 });
            _list.Add(new MyRectangle { name = "D2", width = 10, height = 10 });
            _list.Add(new MyRectangle { name = "D3", width = 20, height = 20 });
            _list.Add(new MyRectangle { name = "D4", width = 100, height = 100 });

            //_list = new List<MyRectangle>();
            //{
            //    (new MyRectangle { name = "D1", width = 5, height = 5 },
            //    (new MyRectangle { name = "D2", width = 10, height = 10 },
            //    (new MyRectangle { name = "D3", width = 20, height = 20 },
            //    (new MyRectangle { name = "D4", width = 100, height = 100 }
            //};
        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            MessageBox.Show($"{item.name}的面積為:{item.GetArea()}");
        }
    }
}
