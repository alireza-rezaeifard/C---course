using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            if (name_text.Text != "")
            {
                hello_label.ForeColor = Color.Green;
                hello_label.Text = $"hello {name_text.Text}";
            }
            else
            {
                hello_label.ForeColor = Color.Red;
                hello_label.Text = $"pls enter a name";
            }
            //MessageBox.Show($"hello {name_text.Text}");
        }
    }
}
