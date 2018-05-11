using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "thao";
            string pass = "123";
            if (user.Equals(textBox1.Text)&&pass.Equals(textBox2.Text)){
            string sex = checkBox1.CheckState.Equals(CheckState.Indeterminate) ? "Are you gay!" : (checkBox1.CheckState.Equals(CheckState.Checked) ? "Nam" : "Nữ");
            MessageBox.Show(sex);
            MessageBox.Show("dang nhap thanh cong");
          

            }
            else MessageBox.Show(" that bai");
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

            List<MonAn> thucDon = new List<MonAn>();
            thucDon.Add(new MonAn("Ga Ran KFC", 150000, 120000));
            thucDon.Add(new MonAn("Vit Quay", 130000, 110000));
            thucDon.Add(new MonAn("Tom Ran", 80000, 60000));
            comboBox1.DataSource = thucDon;
        }
        class MonAn
        {
            public string Name;
            public List<int> gia;

            public MonAn(String ten, int a, int b)
            {
                Name = ten;
                gia = new List<int>();
                gia.Add(a);
                gia.Add(b);
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                comboBox2.DataSource = (comboBox1.SelectedValue as MonAn).gia;
            }
        }

        string checkedRadio;
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedRadio);

        }

       
        private void rb_nau_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ra = sender as RadioButton;
            if (ra.Checked)
            {
                checkedRadio = ra.Text;
            }
        }



    }
}
