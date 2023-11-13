namespace HafizaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setImages();
        }

        int baslangicSure = 5;

        Random random = new Random();

        bool ilk = true;



        List<Image> images = new List<Image>();
        List<int> sayilar = new List<int>();



        PictureBox esleme1;
        PictureBox esleme2;
        int secim;

        bool sira = false;
        int puanOyncu1 = 0;
        int puanOyncu2 = 0;

        String path = "../../hayvanlar/";

        private void setImages()
        {
            images.Add(Image.FromFile(@$"{path}kanguru.png"));
            images.Add(Image.FromFile(@$"{path}kaplumbaga.png"));
            images.Add(Image.FromFile(@$"{path}karga.png"));
            images.Add(Image.FromFile(@$"{path}kedi.png"));
            images.Add(Image.FromFile(@$"{path}kirpi.png"));
            images.Add(Image.FromFile(@$"{path}ordek.png"));
            images.Add(Image.FromFile(@$"{path}orumcek.png"));
            images.Add(Image.FromFile(@$"{path}panda.png"));
            images.Add(Image.FromFile(@$"{path}papagan.png"));
            images.Add(Image.FromFile(@$"{path}pelikan.png"));
            images.Add(Image.FromFile(@$"{path}penguen.png"));
            images.Add(Image.FromFile(@$"{path}salyangoz.png"));
            images.Add(Image.FromFile(@$"{path}sincap.png"));
            images.Add(Image.FromFile(@$"{path}tavsan.png"));
            images.Add(Image.FromFile(@$"{path}tavuk.png"));
            images.Add(Image.FromFile(@$"{path}ugurbocegi.png"));
            images.Add(Image.FromFile(@$"{path}yengec.png"));
            images.Add(Image.FromFile(@$"{path}yilan.png"));
            images.Add(Image.FromFile(@$"{path}yunus.png"));
            images.Add(Image.FromFile(@$"{path}zurafa.png"));

        }

        private void setRandomImages(PictureBox comp)
        {
            int sayi = random.Next(0, 20);

            int adet = sayilar.Where(x => x == sayi).Count();

            if (adet < 2)
            {
                sayilar.Add(sayi);
                comp.Image = images[sayi];

            }
            else
            {
                setRandomImages(comp);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            baslangicSure--;
            label2.Text = "Süre : " + baslangicSure.ToString();

            
            if (baslangicSure == 0)
            {
                if (ilk)
                {
                    kartlariGizle();
                    timer1.Stop();
                    ilk = false;
                }
                else
                {
                    sira = !sira;
                    if (sira == false)
                    {
                        label9.Text = "+";
                        label10.Text = "";
                    }
                    else
                    {
                        label10.Text = "+";
                        label9.Text = " ";
                    }

                    esleme1.Visible = false;
                    if(esleme2 != null)
                    {
                        esleme2.Visible = false;

                    }
                    esleme1 = null;
                    esleme2 = null;
                    secim = 0;
                    timer1.Stop();
                    baslangicSure = 5;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setRandomImages(pictureBox1);
            setRandomImages(pictureBox2);
            setRandomImages(pictureBox3);
            setRandomImages(pictureBox4);
            setRandomImages(pictureBox5);
            setRandomImages(pictureBox6);
            setRandomImages(pictureBox7);
            setRandomImages(pictureBox8);
            setRandomImages(pictureBox9);
            setRandomImages(pictureBox10);
            setRandomImages(pictureBox11);
            setRandomImages(pictureBox12);
            setRandomImages(pictureBox13);
            setRandomImages(pictureBox14);
            setRandomImages(pictureBox15);
            setRandomImages(pictureBox16);
            setRandomImages(pictureBox17);
            setRandomImages(pictureBox18);
            setRandomImages(pictureBox19);
            setRandomImages(pictureBox20);
            setRandomImages(pictureBox21);
            setRandomImages(pictureBox22);
            setRandomImages(pictureBox23);
            setRandomImages(pictureBox24);
            setRandomImages(pictureBox25);
            setRandomImages(pictureBox26);
            setRandomImages(pictureBox27);
            setRandomImages(pictureBox28);
            setRandomImages(pictureBox29);
            setRandomImages(pictureBox30);
            setRandomImages(pictureBox31);
            setRandomImages(pictureBox32);
            setRandomImages(pictureBox33);
            setRandomImages(pictureBox34);
            setRandomImages(pictureBox35);
            setRandomImages(pictureBox36);
            setRandomImages(pictureBox37);
            setRandomImages(pictureBox38);
            setRandomImages(pictureBox39);
            setRandomImages(pictureBox40);



            tabControl1.SelectedTab = oyunekrani;
            timer1.Interval = 1000;
            timer1.Start();


            if (baslangicSure == 0)
            {
                timer1.Stop();
            }



        }

        private void kartlariGizle()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;

        }



        private void eslestirme(PictureBox comp)
        {
            baslangicSure = 5;
            timer1.Start();




            if (secim < 2)
            {
                comp.Visible = true;

                if (esleme1 != null)
                {
                    esleme2 = comp;
                    timer1.Stop();
                }
                else
                {
                    esleme1 = comp;
                }
                secim++;
            }

            if (secim == 2)
            {
                esleme2.Visible = true;
                baslangicSure = 2;
                timer1.Start();
                
                if (puanOyncu1 + puanOyncu2 == 20)
                {
                    MessageBox.Show("Kazanan Yok", "Oyun Bitti");
                }

                if (esleme1.Image == esleme2.Image)
                {
                    timer1.Stop();
                    esleme1.Visible = true;
                    esleme2.Visible = true;

                    esleme1 = null;
                    esleme2 = null;

                   

                    if(sira == false)
                    {
                        puanOyncu1++;
                        if(puanOyncu1 >= 11)
                        {
                            MessageBox.Show("Kazanan : Oyuncu 1", "Oyun Bitti");
                        }
                        label7.Text = puanOyncu1.ToString();
                    }
                    else
                    {
                        puanOyncu2++;
                        if (puanOyncu2 >= 11)
                        {
                            MessageBox.Show("Kazanan : Oyuncu 2", "Oyun Bitti");
                        }
                        label8.Text = puanOyncu2.ToString();
                    }

                    label2.Text = "Süre : ";
                    secim = 0;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox15);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox16);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox17);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox18);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox19);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox20);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox21);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox22);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox24);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox25);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox26);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox27);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox28);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox29);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox30);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox31);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox32);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox33);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox34);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox35);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox36);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox37);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox38);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox39);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            eslestirme(pictureBox40);
        }
    }
}