using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyasifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dlg.FileName;
                textBox1.Text = dlg.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        { try
            {
                Byte[] dosya = File.ReadAllBytes(label1.Text);
                for (int i = 0; i < dosya.Length; i++)
                {
                    dosya[i] = (Byte)((int)dosya[i] + 1);
                    if (dosya[i] > 255)
                    {
                        dosya[i] = 0;
                    }
                }

                File.WriteAllBytes(textBox1.Text, dosya);

                MessageBox.Show("ŞİFRELEME BAŞARILI");
            }
            catch (Exception)
            {

                MessageBox.Show("ŞİFRELEME BAŞARISIZ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] dosya = File.ReadAllBytes(label1.Text);
                for (int i = 0; i < dosya.Length; i++)
                {

                    if ((Byte)((int)dosya[i] - 1) < 0)
                    {
                        dosya[i] = 255;
                    }
                    else
                    {
                        dosya[i] = (Byte)((int)dosya[i] - 1);
                    }
                }

                File.WriteAllBytes(textBox1.Text, dosya);

                MessageBox.Show("ŞİFRE ÇÖZÜLDÜ");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
        }

       
        
        public void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
