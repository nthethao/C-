using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 Child = new Form2(textBox1.Text);
            //Child.Show();
            Form2 Child = new Form2();
            Child.Sender(textBox1.Text);
            Child.Show();



        }
    }
}
