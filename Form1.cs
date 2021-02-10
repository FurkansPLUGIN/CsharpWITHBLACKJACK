using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21
{
    public partial class Form1 : Form
    {
        int baslangic = 50;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            label24.Text = baslangic.ToString();
        }
        int siyahCip = 10;
        int maviCip = 15;
        int yesilCip = 35;
        int kirmiziCip = 45;
        int toplamPara = 0;
        int yatırılanPara = 0;
        
        string bir = AppDomain.CurrentDomain.BaseDirectory + "cardSpadesA.png";
        string iki = AppDomain.CurrentDomain.BaseDirectory + "cardSpades2.png";
        string uc = AppDomain.CurrentDomain.BaseDirectory + "cardSpades3.png";
        string dort = AppDomain.CurrentDomain.BaseDirectory + "cardSpades4.png";
        string bes = AppDomain.CurrentDomain.BaseDirectory + "cardSpades5.png";
        string altı = AppDomain.CurrentDomain.BaseDirectory + "cardSpades6.png";
        string yedi = AppDomain.CurrentDomain.BaseDirectory + "cardSpades7.png";
        string sekiz = AppDomain.CurrentDomain.BaseDirectory + "cardSpades8.png";
        string dokuz = AppDomain.CurrentDomain.BaseDirectory + "cardSpades9.png";
        string on = AppDomain.CurrentDomain.BaseDirectory + "cardSpades10.png";
        string onbir = AppDomain.CurrentDomain.BaseDirectory + "cardSpadesJ.png";
        string oniki = AppDomain.CurrentDomain.BaseDirectory + "cardSpadesQ.png";
        string onuc = AppDomain.CurrentDomain.BaseDirectory + "cardSpadesK.png";
        int oyuncuPuan = 0;
        int pcPuan = 0;
        Random rnd = new Random();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                int a1, a2, toplam;

                a1 = rnd.Next(1, 11);
                a2 = rnd.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rnd.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text)+Convert.ToInt32(label2.Text)+a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rnd.Next(1, 11);
                label4.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) +
                    Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }
          
           
            if (label1.Text == "1")
            { pictureBox1.ImageLocation = bir; }
            if (label1.Text == "2")
            { pictureBox1.ImageLocation = iki;}
            if (label1.Text == "3")
            { pictureBox1.ImageLocation = uc;}
            if (label1.Text == "4")
            { pictureBox1.ImageLocation = dort;}
            if (label1.Text == "5")
            { pictureBox1.ImageLocation = bes; }
            if (label1.Text == "6")
            { pictureBox1.ImageLocation = altı; }
            if (label1.Text == "7")
            { pictureBox1.ImageLocation = yedi; }
            if (label1.Text == "8")
            { pictureBox1.ImageLocation = sekiz; }
            if (label1.Text == "9")
            {pictureBox1.ImageLocation = dokuz;  }
            if (label1.Text == "10")
            { pictureBox1.ImageLocation = on; }


            if (label2.Text == "1")
            { pictureBox2.ImageLocation = bir; }
            if (label2.Text == "2")
            { pictureBox2.ImageLocation = iki; }
            if (label2.Text == "3")
            { pictureBox2.ImageLocation = uc; }
            if (label2.Text == "4")
            { pictureBox2.ImageLocation = dort; }
            if (label2.Text == "5")
            { pictureBox2.ImageLocation = bes; }
            if (label2.Text == "6")
            { pictureBox2.ImageLocation = altı; }
            if (label2.Text == "7")
            { pictureBox2.ImageLocation = yedi; }
            if (label2.Text == "8")
            { pictureBox2.ImageLocation = sekiz; }
            if (label2.Text == "9")
            { pictureBox2.ImageLocation = dokuz; }
            if (label2.Text == "10")
            { pictureBox2.ImageLocation = onbir; }

            if (label3.Text == "1")
            { pictureBox3.ImageLocation = bir; }
            if (label3.Text == "2")
            { pictureBox3.ImageLocation = iki; }
            if (label3.Text == "3")
            { pictureBox3.ImageLocation = uc; }
            if (label3.Text == "4")
            { pictureBox3.ImageLocation = dort; }
            if (label3.Text == "5")
            { pictureBox3.ImageLocation = bes; }
            if (label3.Text == "6")
            { pictureBox3.ImageLocation = altı; }
            if (label3.Text == "7")
            { pictureBox3.ImageLocation = yedi; }
            if (label3.Text == "8")
            { pictureBox3.ImageLocation = sekiz; }
            if (label3.Text == "9")
            { pictureBox3.ImageLocation = dokuz; }
            if (label3.Text == "10")
            { pictureBox3.ImageLocation = oniki; }

            if (label4.Text == "1")
            { pictureBox4.ImageLocation = bir; }
            if (label4.Text == "2")
            { pictureBox4.ImageLocation = iki; }
            if (label4.Text == "3")
            { pictureBox4.ImageLocation = uc; }
            if (label4.Text == "4")
            { pictureBox4.ImageLocation = dort; }
            if (label4.Text == "5")
            { pictureBox4.ImageLocation = bes; }
            if (label4.Text == "6")
            { pictureBox4.ImageLocation = altı; }
            if (label4.Text == "7")
            { pictureBox4.ImageLocation = yedi; }
            if (label4.Text == "8")
            { pictureBox4.ImageLocation = sekiz; }
            if (label4.Text == "9")
            { pictureBox4.ImageLocation = dokuz; }
            if (label4.Text == "10")
            { pictureBox4.ImageLocation = onuc; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int b1, b2, toplam;
            b1 = rnd.Next(1, 11);
            b2 = rnd.Next(1, 11);
            toplam = b1 + b2;

            label8.Text = b1.ToString();
            label7.Text = b2.ToString();
            label11.Text = toplam.ToString();
            if (toplam < 16)
            {
                int b3;
                b3 = rnd.Next(1, 11);
                label6.Text = b3.ToString();

                toplam += b3;
                label11.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4;
                b4 = rnd.Next(1, 11);
                label5.Text = b4.ToString();
                toplam += b4;
                label11.Text = toplam.ToString();
            }
            if (label8.Text == "1")
            { pictureBox8.ImageLocation = bir; }
            if (label8.Text == "2")
            { pictureBox8.ImageLocation = iki; }
            if (label8.Text == "3")
            { pictureBox8.ImageLocation = uc; }
            if (label8.Text == "4")
            { pictureBox8.ImageLocation = dort; }
            if (label8.Text == "5")
            { pictureBox8.ImageLocation = bes; }
            if (label8.Text == "6")
            { pictureBox8.ImageLocation = altı; }
            if (label8.Text == "7")
            { pictureBox8.ImageLocation = yedi; }
            if (label8.Text == "8")
            { pictureBox8.ImageLocation = sekiz; }
            if (label8.Text == "9")
            { pictureBox8.ImageLocation = dokuz; }
            if (label8.Text == "10")
            { pictureBox8.ImageLocation = on; }


            if (label7.Text == "1")
            { pictureBox7.ImageLocation = bir; }
            if (label7.Text == "2")
            { pictureBox7.ImageLocation = iki; }
            if (label7.Text == "3")
            { pictureBox7.ImageLocation = uc; }
            if (label7.Text == "4")
            { pictureBox7.ImageLocation = dort; }
            if (label7.Text == "5")
            { pictureBox7.ImageLocation = bes; }
            if (label7.Text == "6")
            { pictureBox7.ImageLocation = altı; }
            if (label7.Text == "7")
            { pictureBox7.ImageLocation = yedi; }
            if (label7.Text == "8")
            { pictureBox7.ImageLocation = sekiz; }
            if (label7.Text == "9")
            { pictureBox7.ImageLocation = dokuz; }
            if (label7.Text == "10")
            { pictureBox7.ImageLocation = onbir; }

            if (label6.Text == "1")
            { pictureBox6.ImageLocation = bir; }
            if (label6.Text == "2")
            { pictureBox6.ImageLocation = iki; }
            if (label6.Text == "3")
            { pictureBox6.ImageLocation = uc; }
            if (label6.Text == "4")
            { pictureBox6.ImageLocation = dort; }
            if (label6.Text == "5")
            { pictureBox6.ImageLocation = bes; }
            if (label6.Text == "6")
            { pictureBox6.ImageLocation = altı; }
            if (label6.Text == "7")
            { pictureBox6.ImageLocation = yedi; }
            if (label6.Text == "8")
            { pictureBox6.ImageLocation = sekiz; }
            if (label6.Text == "9")
            { pictureBox6.ImageLocation = dokuz; }
            if (label6.Text == "10")
            { pictureBox6.ImageLocation = oniki; }

            if (label5.Text == "1")
            { pictureBox5.ImageLocation = bir; }
            if (label5.Text == "2")
            { pictureBox5.ImageLocation = iki; }
            if (label5.Text == "3")
            { pictureBox5.ImageLocation = uc; }
            if (label5.Text == "4")
            { pictureBox5.ImageLocation = dort; }
            if (label5.Text == "5")
            { pictureBox5.ImageLocation = bes; }
            if (label5.Text == "6")
            { pictureBox5.ImageLocation = altı; }
            if (label5.Text == "7")
            { pictureBox5.ImageLocation = yedi; }
            if (label5.Text == "8")
            { pictureBox5.ImageLocation = sekiz; }
            if (label5.Text == "9")
            { pictureBox5.ImageLocation = dokuz; }
            if (label5.Text == "10")
            { pictureBox5.ImageLocation = onuc; }
        }
        int oyunSayısı = 0;
        bool kayıp;
        int param;
        private void button3_Click(object sender, EventArgs e)
        {
            oyunSayısı++;
            button3.Enabled = false;
            button4.Enabled = true;
            int oyuncuTop, pcTop;
            oyuncuTop = Convert.ToInt32(label10.Text);
            pcTop = Convert.ToInt32(label11.Text);

            if (oyuncuTop>pcTop && oyuncuTop<=21)
            {
                //oyuncuPuan+=10;
                label20.Text = yatırılanPara.ToString();

            }

            if (pcTop > oyuncuTop && pcTop <= 21)
            {
                //pcPuan += 10;
                yatırılanPara -= 50;
                // label21.Text = pcPuan.ToString();
                label20.Text = yatırılanPara.ToString();
            }
            if(pcTop>21 && oyuncuTop > 21)
            {
                MessageBox.Show("Berabere", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (pcTop == oyuncuTop && pcTop <= 21 && oyuncuTop <= 21
                && pcTop>0 && oyuncuTop>0)
            {
                // oyuncuPuan += 10;
               // yatırılanPara += 50;
                //pcPuan += 10;
                label20.Text = yatırılanPara.ToString();
                //label21.Text = pcPuan.ToString();
            }
            
            if(pcTop>21 && oyuncuTop > 21)
            {
                int kazanan1 = 0;
                int kazanan2 = 0;
                kazanan1 = pcTop - 21;
                kazanan2 = oyuncuTop - 21;
                if (kazanan1 > kazanan2)
                {
                    //oyuncuPuan += 10;
                    label20.Text = yatırılanPara.ToString();
                }
                if (kazanan2 > kazanan1)
                {
                    yatırılanPara -= 50;
                    label20.Text = yatırılanPara.ToString();
                }
            }
            if (oyuncuTop > 21 && pcTop <= 21)
            {
                //pcPuan += 10;
                //label21.Text = pcPuan.ToString();
                yatırılanPara -= 50;
                label20.Text = yatırılanPara.ToString();

            }
            if (pcTop > 21 && oyuncuTop <= 21)
            {
                yatırılanPara += Convert.ToInt32(label20.Text);
                label20.Text = yatırılanPara.ToString();
            }
             param = Convert.ToInt32(label20.Text);
            if (param < 50)
            {
                kayıp = false;
                MessageBox.Show("Kaybettiniz", "Malesef", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (oyunSayısı == 5 && param>50)
            {
                toplamPara = yatırılanPara;
                label24.Text = toplamPara.ToString();
                kayıp = true;
                MessageBox.Show("Kazandınız", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if (oyuncuPuan >= 50)
            //{
            //    MessageBox.Show("Kazandınız", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //if (pcPuan >= 50)
            //{
            //    MessageBox.Show("Kaybettiniz", "Malesef", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yatırılanPara = 0;
            label25.Text = "0";
            pictureBox1.ImageLocation= AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox2.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox3.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox4.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";

            pictureBox5.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox6.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox7.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";
            pictureBox8.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "yenikart.png";

            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            button2.Enabled = true;
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            if (param<50)
            {
                label25.Text = "0";
                toplamPara = 0;
                yatırılanPara = 0;
                label20.Text = "0";
            }
            if (oyunSayısı > 5)
            {
                label25.Text = "0";
                toplamPara = 0;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            yatırılanPara += siyahCip+baslangic;
            label25.Text = yatırılanPara.ToString();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            yatırılanPara += maviCip+ baslangic;
            label25.Text = yatırılanPara.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            yatırılanPara += yesilCip+baslangic;
            label25.Text = yatırılanPara.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            yatırılanPara += kirmiziCip+ baslangic;
            label25.Text = yatırılanPara.ToString();
        }
    }
}
