using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeOdevi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        projeEntities ent = new projeEntities();
        kullanıcılar k = new kullanıcılar();
        kayitol frm2 = new kayitol();
        admin frm3 = new admin();
        kullanici frm4 = new kullanici();

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
                /*Uygulamadan çıkmak istediğinizde diğer forma eğer daha önce geçiş yapmışsanız o gizlenmiştir (hide) ve arka planda çalışıyodur.
                * Formu kapatma eventine uygulamadan tamamen çıkma metotunu ekledim.*/
            }

            private void btnGirisYap_Click(object sender, EventArgs e)
            {
                string kAdi = txtKullaniciAdi.Text; //textboxtaki değerleri string değişkenlere atadım
                string sifre = txtSifre.Text;
                if (kAdi == "" || sifre == "") //Eğer textboxlardan biri boşsa beni uyarsın ve işlem yapmasın
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun");
                    return;
                }
                dataBase db = new dataBase();

                var loginState = db.KullaniciGiris(kAdi,sifre);

                if (loginState) //Dönen değer true ise yani bilgiler veritabanındaki kayıtlarda mevcutsa if kod bloğu çalışsın
                {
                    MessageBox.Show("Giriş Doğrulandı.");
                    if(txtKullaniciAdi.Text == "admin")
                    {

                        this.Hide();
                        frm2.Hide();
                        frm4.Hide();
                        frm3.Show();
                        frm3.TopMost = true;
                    }
                    if(!(txtKullaniciAdi.Text == "admin"))
                    {
                        this.Hide();
                        frm2.Hide();
                        frm3.Hide();
                        var degerler = (from item in ent.kullanıcılar
                                       where item.ad.Contains(kAdi)
                                       select item.id).FirstOrDefault();

                        frm4.label48.Text = degerler.ToString();
                        frm4.label1.Text = txtKullaniciAdi.Text;
                        frm4.Show();
                        frm4.TopMost = true;
                    }
                
                }
                else //Dönen değer true değilse yani false ise bu kod bloğu çalışsın
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void pictureBox5_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/fahadms1106"); 
            }

            private void pictureBox6_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/merttgvvn");
            }

            private void pictureBox7_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("https://twitter.com/merttgvvn");
            }

            private void pictureBox8_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/mert-güven-8a0006177/");
            }

            private void txtKullaniciAdi_Click(object sender, EventArgs e)
            {
                txtKullaniciAdi.Text = "";
            }

            private void txtSifre_Click(object sender, EventArgs e)
            {
                txtSifre.Text = "";
            }

            private void btnKayitOl_Click(object sender, EventArgs e)
            {
                this.Hide();
                frm2.Show();
            }
    }
}
