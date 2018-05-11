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
    public partial class Form2 : Form
    {
        //private string _message;
        //public Form2()
        //{
        //    InitializeComponent();
        //}
        //public Form2(string Message)
        //    : this()
        //{
        //    _message = Message;
        //    label1.Text = _message;
        //}
        public delegate void SendMessage(string Massage);
        public SendMessage Sender;
        public Form2()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);

        }
        private void GetMessage(string Message)
        {
            label1.Text = Message;
        }

    }
}
