using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bll;

namespace testgit
{
    public partial class Form1 : Form
    {
        bll.Class1 b = new bll.Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string add = b.Add();
            string add2 = b.Add2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(b.HelloWorld());
        }
    }
}
