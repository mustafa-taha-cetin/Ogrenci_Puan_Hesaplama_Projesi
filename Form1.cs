using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_puan_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yazili1, yazili2, sozlu1, sozlu2, ortalama;
            yazili1 = Convert.ToInt32(textBox1.Text);
            yazili2 = Convert.ToInt32(textBox2.Text);
            sozlu1 = Convert.ToInt32(textBox3.Text);
            sozlu2 = Convert.ToInt32(textBox4.Text);
            ortalama = (yazili1 + yazili2 + sozlu1 + sozlu2) / 4;
            listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " adındaki " + maskedTextBox3.Text + " sınıfındaki " + maskedTextBox4.Text + " numaralı öğrencimizin ortalaması = " + ortalama);
        }
    }
}
