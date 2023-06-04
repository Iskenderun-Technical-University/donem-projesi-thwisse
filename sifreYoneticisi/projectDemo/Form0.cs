using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDemo
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        string username = "thwisse";

        string password = "18811938";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.");
            }
        }
    }
}
