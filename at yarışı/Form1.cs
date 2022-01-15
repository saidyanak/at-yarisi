using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random hız = new Random();
        int bir,iki,uc;
        


        public void timer1_Tick(object sender, EventArgs e)
        {
           




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double para = Convert.ToInt32(textBox1.Text);
            double kpara = Convert.ToInt32(textBox2.Text);

            bir = hız.Next(5, 10);
            int a = 0;
            a += bir;
            pictureBox1.Left += a;
            if (pictureBox1.Left>=970)
            {
                if (pictureBox2.Left<970 && pictureBox3.Left<970)
                {
                    listBox1.Items.Add("Birinci at kazandı");
                    timer2.Enabled = false;
                    if (radioButton1.Checked == true)

                    {

                        double fark = para - kpara;
                        kpara += kpara * 0.5;
                        double toplam = kpara + fark;

                        label8.Text = toplam.ToString();
                    }
                }
                else if (pictureBox2.Left < 970 || pictureBox3.Left < 970)
                {
                    listBox1.Items.Add("Birinci at 2.oldu");
                    timer2.Enabled = false;
                }
                else
                {
                    listBox1.Items.Add("birinci at 3.oldu ");
                    timer2.Enabled = false;
                }    
            }
        }
   

        private void timer3_Tick(object sender, EventArgs e)
        {
            double para = Convert.ToInt32(textBox1.Text);
            double kpara = Convert.ToInt32(textBox2.Text);

            iki = hız.Next(1, 10);
            int a = 0;
            a += iki;
            pictureBox2.Left += a;
            if (pictureBox2.Left >= 970)
            {
                if (pictureBox1.Left < 970 && pictureBox3.Left< 970)
                {
                    listBox1.Items.Add("İkinci at kazandı");
                    timer3.Enabled = false;
                    if (radioButton2.Checked == true)

                    {

                        double fark = para - kpara;
                        kpara *= 0.5;
                        double toplam = kpara + fark;

                        label8.Text = toplam.ToString();
                    }
                }
                else if (pictureBox1.Left < 970 || pictureBox3.Left < 970)
                {
                    listBox1.Items.Add("İkinci at 2.oldu");
                    timer3.Enabled = false;
                }
                else
                {
                    listBox1.Items.Add("İkinci at 3.oldu ");
                    timer3.Enabled = false;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            double para = Convert.ToInt32(textBox1.Text);
            double kpara = Convert.ToInt32(textBox2.Text);
            uc = hız.Next(1, 10);
            int a = 0;
            a += uc;
            pictureBox3.Left += a;
            if (pictureBox3.Left >= 970)
            {
                if (pictureBox1.Left < 970 && pictureBox2.Left < 970)
                {
                    listBox1.Items.Add("Üçüncü at kazandı");
                    timer4.Enabled = false;
                    if (radioButton3.Checked == true)

                    {

                        double fark = para - kpara;
                        kpara *= 0.5;
                        double toplam = kpara + fark;

                        label8.Text = toplam.ToString();
                    }
                    
                }
                else if (pictureBox1.Left < 970 || pictureBox2.Left < 970)
                {
                    listBox1.Items.Add("Üçüncü at 2.oldu");
                    timer4.Enabled = false;
                    
                }
                else
                {
                    listBox1.Items.Add("Üçüncü at 3.oldu ");
                    timer4.Enabled = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(textBox1.Text);
            int kpara = Convert.ToInt32(textBox2.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 48;
            pictureBox2.Left = 48;
            pictureBox3.Left = 48;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;

        }
    }
}
