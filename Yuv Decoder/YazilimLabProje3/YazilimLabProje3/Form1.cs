using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimLabProje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int en, boy;
        int temp = 0;
        static int cerceve_sayisi;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            //Bunun icerisinde degerleri sifirlayacagiz.
            try
            {
                txtGenislik.Text = String.Empty;
                txtYukseklik.Text = String.Empty;
                radioBtn420.Checked = false;
                radioBtn422.Checked = false;
                radioBtn444.Checked = false;
                ResimAlani.Image = null;
                MessageBox.Show("Sıfırlanma islemi yapıldı!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sıfırlanma islemi yapılamadı!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoruntuOynat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int frameBoyut = cerceve_sayisi;
            if (temp < frameBoyut)
            {
                ResimAlani.Image = Image.FromFile(@"C:\Users\Ayberk\Desktop\Workspace\yaz lab\resim\resim" + (temp + 1) + ".bmp");
            }
            temp++;            
        }

        private void ResimAlani_Click(object sender, EventArgs e)
        {

        }

        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            //Dosya okuma
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.SafeFileName
            if (DialogResult.OK == ofd.ShowDialog())
            {
                byte[] dosya = File.ReadAllBytes(ofd.FileName);
                //pikselsayisi = en * boy;

                // 4 4 4 Kısmı
                if (radioBtn444.Checked == true)
                {
                    //en = 720;
                    en = Convert.ToInt32(txtGenislik.Text);
                    //boy = 576;
                    boy = Convert.ToInt32(txtYukseklik.Text);

                    double cerceve = dosya.Length / (en * boy * 3);

                    int tekrar = (int)(3 * (en * boy));

                    //Dosya okuma işlemi
                    byte[,] R = new byte[(int)cerceve, en * boy];
                    byte[,] G = new byte[(int)cerceve, en * boy];
                    byte[,] B = new byte[(int)cerceve, en * boy];
                    int count = 0;
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        if (i % tekrar < (en * boy))
                        {
                            int j = 0;
                            for (j = 0; j < (en * boy); j++)
                            {
                                R[count, j] = dosya[i + j];
                            }
                            count++;
                            i += j;
                        }
                    }

                    //Bitmap işlemi
                    int count1 = 0;
                    Bitmap bm = new Bitmap(en, boy);
                    Bitmap[] frames = new Bitmap[(int)cerceve];

                    for (int k = 0; k < cerceve; k++)
                    {
                        for (int i = 0; i < boy; i++)
                        {
                            for (int j = 0; j < en; j++)
                            {
                                int r = R[k, count1];
                                int g = R[k, count1];
                                int b = R[k, count1];
                                bm.SetPixel(j, i, Color.FromArgb(r, g, b));
                                count1++;
                            }                            
                        }
                        bm.Save(@"C:\Users\Ayberk\Desktop\Workspace\yaz lab\resim\resim" + (k + 1) + ".bmp");
                        frames[k] = bm;
                        ResimAlani.Image = bm;
                        count1 = 0;
                        cerceve_sayisi = k + 1;
                    }
                    MessageBox.Show("Resimler klasöre yüklendi!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 4 2 2 Kısmı
                else if (radioBtn422.Checked == true)
                {
                    //en = 720;
                    en = Convert.ToInt32(txtGenislik.Text);
                    //boy = 576;
                    boy = Convert.ToInt32(txtYukseklik.Text);

                    double cerceve = dosya.Length / (en * boy * 2);

                    int tekrar = (int)(2* (en * boy));

                    //Dosya okuma işlemi
                    byte[,] R = new byte[(int)cerceve, en * boy];
                    byte[,] G = new byte[(int)cerceve, en * boy];
                    byte[,] B = new byte[(int)cerceve, en * boy];
                    int count = 0;
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        if (i % tekrar < (en*boy))
                        {
                            int j = 0;
                            for (j = 0; j < (en * boy); j++)
                            {
                                R[count, j] = dosya[i+j];
                            }
                            count++;
                            i += j;
                        }
                    }
                    
                    //Bitmap işlemi
                    int count1 = 0;
                    Bitmap bm = new Bitmap(en, boy);
                    Bitmap[] frames = new Bitmap[(int)cerceve];

                    for (int k = 0; k < cerceve; k++)
                    {
                        for (int i = 0; i < boy; i++)
                        {
                            for (int j = 0; j < en; j++)
                            {
                                int r = R[k, count1];
                                int g = R[k, count1];
                                int b = R[k, count1];
                                bm.SetPixel(j, i, Color.FromArgb(r, g, b));
                                count1++;
                            }                            
                        }
                        bm.Save(@"C:\Users\Ayberk\Desktop\Workspace\yaz lab\resim\resim" + (k + 1) + ".bmp");
                        frames[k] = bm;
                        ResimAlani.Image = bm;
                        count1 = 0;
                        cerceve_sayisi = k + 1;
                    }
                }

                // 4 2 0 Kısmı
                else if (radioBtn420.Checked == true)
                {
                    //en = 352;
                    en = Convert.ToInt32(txtGenislik.Text);
                    //boy = 288;
                    boy = Convert.ToInt32(txtYukseklik.Text);

                   double cerceve = dosya.Length / (en * boy * 1.5);
                    
                    int tekrar = (int)(1.5* (en * boy));

                    //Dosya okuma işlemi
                    byte[,] R = new byte[(int)cerceve, en * boy];
                    byte[,] G = new byte[(int)cerceve, en * boy];
                    byte[,] B = new byte[(int)cerceve, en * boy];
                    int count = 0;
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        if (i % tekrar < (en*boy))
                        {
                            int j = 0;
                            for (j = 0; j < (en * boy); j++)
                            {
                                R[count, j] = dosya[i+j];
                            }
                            count++;
                            i += j;
                        }
                    }

                    //Bitmap işlemi
                    int count1 = 0;
                    Bitmap bm = new Bitmap(en, boy);
                    Bitmap[] frames = new Bitmap[(int)cerceve];

                    for (int k = 0; k < cerceve; k++)
                    {
                        for (int i = 0; i < boy; i++)
                        {
                            for (int j = 0; j < en; j++)
                            {
                                int r = R[k, count1];
                                int g = R[k, count1];
                                int b = R[k, count1];
                                bm.SetPixel(j, i, Color.FromArgb(r, g, b));
                                count1++;
                            }                            
                        }
                        bm.Save(@"C:\Users\Ayberk\Desktop\Workspace\yaz lab\resim\resim" + (k + 1) + ".bmp");
                        frames[k] = bm;
                        ResimAlani.Image = bm;
                        count1 = 0;
                        cerceve_sayisi = k + 1;
                    }
                }
            }
        }
    }
}