using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyasifre
{
    public partial class SifreGiris : Form
    {
        public SifreGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "Yalova771907...";
            if(textBox1.Text == sifre)
            {
                Form1 frm = new Form1();
                MessageBox.Show("GİRİŞ BAŞARILI", "YÖNLENDİRİLİYOR", MessageBoxButtons.OK , MessageBoxIcon.Information);
                frm.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARSIZI", "YENİDEN DENE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
