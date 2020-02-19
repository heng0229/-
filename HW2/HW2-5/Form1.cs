using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_5
{
    public partial class Form1 : Form
    {
        private List<string> _southList;
        private List<string> _northList;
        private List<string> _EndList;
        private Ticket _ticket;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            _ticket = new Ticket();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        _EndList = new List<string> { "新竹", "台中", "嘉義", "台南", "高雄" };
                        break;
                    case 1:
                        _EndList = new List<string> { "台中", "嘉義", "台南", "高雄" };
                        break;
                    case 2:
                        _EndList = new List<string> { "嘉義", "台南", "高雄" };
                        break;
                    case 3:
                        _EndList = new List<string> { "台南", "高雄" };
                        break;
                    case 4:
                        _EndList = new List<string> { "高雄" };
                        break;
                    default:
                        radioButton2.Checked = true;
                        break;
                }
                ChangeDate();
            }
            else
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        _EndList = new List<string> { "台南", "嘉義", "台中", "新竹", "台北" };
                        break;
                    case 1:
                        _EndList = new List<string> { "嘉義", "台中", "新竹", "台北" };
                        break;
                    case 2:
                        _EndList = new List<string> { "台中", "新竹", "台北" };
                        break;
                    case 3:
                        _EndList = new List<string> { "新竹", "台北" };
                        break;
                    case 4:
                        _EndList = new List<string> { "台北" };
                        break;
                    default:
                        radioButton1.Checked = true;
                        break;
                }
                ChangeDate();
            }
        }
        private void CreateList()
        {
            _southList = new List<string>
            {"台北","新竹","台中","嘉義" ,"台南","高雄"};
            _northList = new List<string>
            { "高雄","台南","嘉義","台中" ,"新竹","台北"};
            _EndList = new List<string>
            { "新竹", "台中", "嘉義", "台南", "高雄" };
        }
        static List<Ticket> TicketList()
        {
            return new List<Ticket>()
            {new Ticket{Name="台北",Taipei=0,Hsinchu=177,Taichung=375, Chiayi=598,Tainan=738,Kaohsiung=842},
             new Ticket{Name="新竹",Taipei=177,Hsinchu=0,Taichung=197, Chiayi=421,Tainan=560,Kaohsiung=755},
             new Ticket{Name="台中",Taipei=375,Hsinchu=197,Taichung=0, Chiayi=224,Tainan=363,Kaohsiung=469},
             new Ticket{Name="嘉義",Taipei=598,Hsinchu=421,Taichung=224, Chiayi=0,Tainan=139,Kaohsiung=245},
             new Ticket{Name="台南",Taipei=738,Hsinchu=560,Taichung=363, Chiayi=139,Tainan=0,Kaohsiung=106},
             new Ticket{Name="高雄",Taipei=842,Hsinchu=755,Taichung=469, Chiayi=245,Tainan=106,Kaohsiung=0}
            };
        }
        private void SetCombobox()
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.DataSource = _southList;
                comboBox2.DataSource = _EndList;
            }
            else
            {
                comboBox1.DataSource = _northList;
                comboBox2.DataSource = _EndList;
            }
        }
        private void ChangeDate()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = _EndList;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetCombobox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ticket = new Ticket();
            var list = TicketList();
            string item = (string)comboBox1.SelectedItem;
            string pick = (string)comboBox2.SelectedItem;
            var ticket1 = list.Find((x) => x.Name == pick);
            if (item == "台北")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        label3.Text = "票價為:" + ticket1.Taipeicost2.ToString();
                    }
                    else
                    {
                        label3.Text = "票價為:" + ticket1.Taipeicost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {
                    label3.Text = "票價為:" + ticket1.Taipeicost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Taipei}");
                }
            }
            if (item == "新竹")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        label3.Text = "票價為:" + ticket1.Hsinchucost2.ToString();
                    }
                    else
                    {
                        label3.Text = "票價為:" + ticket1.Hsinchucost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {
                    label3.Text = "票價為:" + ticket1.Hsinchucost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Hsinchu}");
                }
            }
            if (item == "台中")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        label3.Text = "票價為:" + ticket1.Taichungcost2.ToString();
                    }
                    else
                    {
                        label3.Text = "票價為:" + ticket1.Taichungcost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {
                    label3.Text = "票價為:" + ticket1.Taichungcost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Taichung}");
                }
            }
            if (item == "嘉義")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        label3.Text = "票價為:" + ticket1.Chiayicost2.ToString();
                    }
                    else
                    {
                        label3.Text = "票價為:" + ticket1.Chiayicost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {
                    label3.Text = "票價為:" + ticket1.Chiayicost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Chiayi}");
                }
            }
            if (item == "台南")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        label3.Text = "票價為:" + ticket1.Tainancost2.ToString();
                    }
                    else
                    {
                        label3.Text = "票價為:" + ticket1.Tainancost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {
                    label3.Text = "票價為:" + ticket1.Tainancost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Tainan}");
                }
            }
            if (item == "高雄")
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {

                        label3.Text = "票價為:" + ticket1.Kaohsiungcost2.ToString();
                    }
                    else
                    {

                        label3.Text = "票價為:" + ticket1.Kaohsiungcost.ToString();
                    }
                }
                else if (checkBox2.Checked)
                {

                    label3.Text = "票價為:" + ticket1.Kaohsiungcost1.ToString();
                }
                else
                {
                    label3.Text = ($"票價為:{ticket1.Kaohsiung}");
                }
            }
        }
    }
}
