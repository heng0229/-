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

namespace TextFileSamples003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = createdata();
            dataGridView1.DataSource = list;
            //dataGridView1.DataSource = createdata();
        }
        private List<Restaurant> createdata()
        {
            //char[] splits = new char[] { ',' };
            string filename = "102015.csv";
            List<Restaurant> result = new List<Restaurant>();
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                for (int i = 1; i < lines.Count(); i++)
                {
                    //string[] items = lines[i].Split(splits);
                    string[] items = lines[i].Split(',');

                    var restaurant = new Restaurant
                    {
                        Seq = int.Parse(items[0]),
                        DishName = items[1],
                        Shop = items[3],
                        Address = items[4],
                        Tel = items[5]
                    };
                    result.Add(restaurant);
                }
            }
            return result;
        }
    }
}

