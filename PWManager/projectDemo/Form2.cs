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
    public partial class Form2 : Form
    {
        string ABC;
        string _123_;
        string abc;
        string operators;

        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sifreUzunluguLabel.Text = trackBar1.Value.ToString();
        }

        private void ABCcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ABCcheckBox.Checked)
            {
                ABC = "1";
            }
            else
            {
                ABC = "";
            }
        }

        private void _123checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_123checkBox.Checked)
            {
                _123_ = "1";
            }
            else
            {
                _123_ = "";
            }
        }

        private void abc_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (abc_checkBox.Checked)
            {
                abc = "1";
            }
            else
            {
                abc = "";
            }
        }

        private void operators_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (operators_checkBox.Checked)
            {
                operators = "1";
            }
            else
            {
                operators = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string _abc = "qwertyuopasdfghjklizxcvbnm";
            string _ABC = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string _123 = "0123456789";
            string _operators = "!'^+%&/()=?_>£#$½{[]}*-,.";

            string karakterler = string.Empty;

            string sifre = string.Empty;

            for (int i = 0; i < trackBar1.Value; i++)
            {
                karakterler = string.Empty;

                if (ABC == "1")
                {
                    karakterler += _ABC;
                }

                if (abc == "1")
                {
                    karakterler += _abc;
                }

                if (_123_ == "1")
                {
                    karakterler += _123;
                }

                if (operators == "1")
                {
                    karakterler += _operators;
                }

                if (string.IsNullOrEmpty(karakterler))
                {
                    MessageBox.Show("En az 1 karakter kümesini seçmelisiniz.");

                    break;
                }

                sifre += karakterler[rnd.Next(karakterler.Length)];

                textBox1.Text = sifre;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);

            MessageBox.Show("Yeni şifre kopyalandı.");

            this.Close();
        }
    }
}
