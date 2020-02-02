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
using MySql.Data;


namespace projeOdevi
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        projeEntities ent = new projeEntities();
        kullanıcılar k = new kullanıcılar();
        urunler u = new urunler();
        dataBase db = new dataBase();
        

        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=proje; Uid=root; Pwd=1234;");

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            panel11.Visible = true;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            panel11.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/fahadms1106");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/merttgvvn");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/merttgvvn");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mert-güven-8a0006177/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdemePnl.Visible = false;
            SiparisDetayPnl.Visible = false;
            MagazaPnl.Visible = false;
            SiparisPnl.Visible = true;
            panel17.Visible = false;
            panel5.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int MamaSiparis = Int32.Parse(MamaSiparisTxt.Text);
            MamaSiparis = MamaSiparis + 1;
            MamaSiparisTxt.Text = MamaSiparis.ToString();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int MamaSiparis = Int32.Parse(MamaSiparisTxt.Text);
            
            if (!(MamaSiparis <= 0))
            { 
                
                MamaSiparis = MamaSiparis - 1;
                MamaSiparisTxt.Text = MamaSiparis.ToString();
            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int OyuncakSiparis = Int32.Parse(OyuncakSiparisTxt.Text);
            OyuncakSiparis = OyuncakSiparis + 1;
            OyuncakSiparisTxt.Text = OyuncakSiparis.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int OyuncakSiparis = Int32.Parse(OyuncakSiparisTxt.Text);
            if (!(OyuncakSiparis <= 0))
            { 
                
                OyuncakSiparis = OyuncakSiparis - 1;
                OyuncakSiparisTxt.Text = OyuncakSiparis.ToString();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int AksesuarSiparis = Int32.Parse(AksesuarSiparisTxt.Text);
            AksesuarSiparis = AksesuarSiparis + 1;
            AksesuarSiparisTxt.Text = AksesuarSiparis.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int AksesuarSiparis = Int32.Parse(AksesuarSiparisTxt.Text);
            if(!(AksesuarSiparis <= 0))
            { 
                AksesuarSiparis = AksesuarSiparis - 1;
                AksesuarSiparisTxt.Text = AksesuarSiparis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel7.Visible = false;
            button9.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            OdemePnl.Visible = false;
            SiparisDetayPnl.Visible = false;
            SiparisPnl.Visible = false;
            MagazaPnl.Visible = true;
            panel5.Visible = false;
            panel17.Visible = true;

        }


        private void SiparisBtn_Click(object sender, EventArgs e)
        {
            SiparisPnl.Visible = false;
            SiparisDetayPnl.Visible = true;
            panel9.Visible = true;
            button8.Visible = true;
            label30.Text = MamaSiparisTxt.Text + " ADET";
            label26.Text = OyuncakSiparisTxt.Text + " ADET";
            label23.Text = AksesuarSiparisTxt.Text + " ADET";
            tarihLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void OdemeBtn_Click(object sender, EventArgs e)
        {
            
            panel7.Visible = true;
            button6.Visible = true;
            OdemePnl.Visible = true;
            SiparisDetayPnl.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OdemePnl.Visible = true;
            
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            panel21.BackColor = Color.Silver;
            KapıdaPnl.Visible = false;
            KartlaPnl.Visible = true;
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            panel28.BackColor = Color.Silver;
            KartlaPnl.Visible = false;
            KapıdaPnl.Visible = true;
        }

        private void panel21_MouseMove(object sender, MouseEventArgs e)
        {
            panel21.BackColor = Color.Silver;
        }

        private void panel21_MouseLeave(object sender, EventArgs e)
        {
            panel21.BackColor = Color.Transparent;
        }

        private void label34_MouseMove(object sender, MouseEventArgs e)
        {
            panel21.BackColor = Color.Silver;
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            panel21.BackColor = Color.Transparent;
        }

        private void label32_MouseMove(object sender, MouseEventArgs e)
        {
            panel21.BackColor = Color.Silver;
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            panel21.BackColor = Color.Transparent;
        }

        private void panel28_MouseMove(object sender, MouseEventArgs e)
        {
            panel28.BackColor = Color.Silver;
        }

        private void panel28_MouseLeave(object sender, EventArgs e)
        {
            panel28.BackColor = Color.Transparent;
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            panel28.BackColor = Color.Silver;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            panel28.BackColor = Color.Transparent;
        }

        private void label35_MouseMove(object sender, MouseEventArgs e)
        {
            panel28.BackColor = Color.Silver;
        }

        private void label35_MouseLeave(object sender, EventArgs e)
        {
            panel28.BackColor = Color.Transparent;
        }

        private void label33_MouseMove(object sender, MouseEventArgs e)
        {
            panel28.BackColor = Color.Silver;
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            panel28.BackColor = Color.Transparent;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            panel21.BackColor = Color.Silver;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            panel21.BackColor = Color.Transparent;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            KapıdaPnl.Visible = false;
            KartlaPnl.Visible = true;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            KapıdaPnl.Visible = false;
            KartlaPnl.Visible = true;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            KapıdaPnl.Visible = false;
            KartlaPnl.Visible = true;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            KartlaPnl.Visible = false;
            KapıdaPnl.Visible = true;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            KartlaPnl.Visible = false;
            KapıdaPnl.Visible = true;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            KartlaPnl.Visible = false;
            KapıdaPnl.Visible = true;
        }

        private void OdemePnl_Paint(object sender, PaintEventArgs e)
        {
            int MamaSiparis = Int32.Parse(MamaSiparisTxt.Text);
            int OyuncakSiparis = Int32.Parse(OyuncakSiparisTxt.Text);
            int AksesuarSiparis = Int32.Parse(AksesuarSiparisTxt.Text);
            int ToplamMama = MamaSiparis * 250;
            int ToplamOyuncak = OyuncakSiparis * 550;
            int ToplamAksesuar = AksesuarSiparis * 75;
            label45.Text = "TOPLAM: " + (ToplamMama + ToplamOyuncak + ToplamAksesuar).ToString() + "TL";
            label46.Text = "TOPLAM: " + (ToplamMama + ToplamOyuncak + ToplamAksesuar + 15).ToString() + "TL";
            if (KartlaPnl.Visible == true)
            {
                panel28.BackColor = Color.Transparent;
                panel21.BackColor = Color.Silver;
            }
            if (KapıdaPnl.Visible == true)
            {
                panel21.BackColor = Color.Transparent;
                panel28.BackColor = Color.Silver;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            OdemePnl.Visible = false;
            SiparisAlindiPnl.Visible = true;
            int MamaST = Convert.ToInt32(MamaSiparisTxt.Text);
            int OyuncakST = Convert.ToInt32(OyuncakSiparisTxt.Text);
            int AksesuarST = Convert.ToInt32(AksesuarSiparisTxt.Text);
            int siparisID = Convert.ToInt32(label48.Text);
            string adres = adresTxt.Text;
            
            bool od = on_dogrulama(MamaSiparisTxt.Text, OyuncakSiparisTxt.Text, AksesuarSiparisTxt.Text);
            if (od)
            {
                db.SiparisEkle(MamaST, OyuncakST, AksesuarST, siparisID, adres);
                db.StokSil(MamaST, OyuncakST, AksesuarST);
                MessageBox.Show("Sipariş alındı!");
            }

            bool on_dogrulama(string mst, string ost, string ast) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
            {
                if (mst == "" || mst == "ADET" || ost == "" || ost == "ADET" || ast == "" || ast == "ADET") //Eğer herhangi bir textbox boşsa false değeri döndürsün
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun");
                    return false;
                }
                else //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                    return true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CvvTxt.Text == "" || KartNoTxt.Text == "" || ayCB.Text == "AY" || yılCB.Text == "YIL") //Eğer herhangi bir textbox boşsa false değeri döndürsün
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                int MamaST = Convert.ToInt32(MamaSiparisTxt.Text);
                int OyuncakST = Convert.ToInt32(OyuncakSiparisTxt.Text);
                int AksesuarST = Convert.ToInt32(AksesuarSiparisTxt.Text);
                int siparisID = Convert.ToInt32(label48.Text);
                string adres = adresTxt.Text;
                Int64 kartNT = Convert.ToInt64(KartNoTxt.Text);
                bool od = on_dogrulama(MamaSiparisTxt.Text, OyuncakSiparisTxt.Text, AksesuarSiparisTxt.Text);
                if (od)
                {
                    bool odm = db.Odeme(kartNT, ayCB.Text, yılCB.Text, CvvTxt.Text);
                    if(odm)
                    {
                        db.SiparisEkle(MamaST, OyuncakST, AksesuarST, siparisID, adres);
                        db.StokSil(MamaST, OyuncakST, AksesuarST);
                        MessageBox.Show("Sipariş alındı!");
                        button9.Visible = true;
                        OdemePnl.Visible = false;
                        SiparisAlindiPnl.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Kart bilgileri yanlış!", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                
                bool on_dogrulama(string mst, string ost, string ast) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
                {
                    if (mst == "" || mst == "ADET" || ost == "" || ost == "ADET" || ast == "" || ast == "ADET") //Eğer herhangi bir textbox boşsa false değeri döndürsün
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun");
                        return false;
                    }
                    else //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                        return true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button8.Visible = false;
            button6.Visible = false;
            panel7.Visible = false;
            panel9.Visible = false;
            panel5.Visible = false;
            panel17.Visible = true;
            panel17.Visible = true;
            MagazaPnl.Visible = true;
            SiparisAlindiPnl.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SiparisDetayPnl.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int sayi1 = Int32.Parse(label44.Text);
            int sayi = Int32.Parse(label44.Text);
            if (e.KeyChar == 8 && !(sayi1 == 300))
            {
                
                sayi1 = sayi1 + 1;
                label44.Text = sayi1.ToString();
            }
            else
            {
                sayi = sayi - 1;
                label44.Text = sayi.ToString();
            }
                    
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MagazaPnl.Visible = false;
            SiparisPnl.Visible = false;
            SiparisDetayPnl.Visible = false;
            OdemePnl.Visible = false;
            SiparisAlindiPnl.Visible = false;
            HesapSilPnl.Visible = true;

            var mama = (from item in ent.urunler
                        where item.KullanıcıId.ToString() == label48.Text
                        select item.Mama).FirstOrDefault();
            var oyuncak = (from item in ent.urunler
                       where item.KullanıcıId.ToString() == label48.Text
                       select item.Oyuncak).FirstOrDefault();
            var aksesuar = (from item in ent.urunler
                       where item.KullanıcıId.ToString() == label48.Text
                       select item.Aksesuar).FirstOrDefault();

            
            if (mama != 0 || oyuncak != 0 || aksesuar != 0)
            {
                unlem.Visible = true;
                
                bulunmakta.Text = "Siparişiniz Bulunmakta";
                hesap.Text = "(İşleme devam ederseniz siparişleriniz ve hesabınız silinecek)";
            }
            else
            {
                unlem.Visible = true;
                
                bulunmakta.Text = "Siparişiniz Bulunmamakta";
                hesap.Text = "(İşleme devam ederseniz hesabınız silinecek)";
            }
        }

        private void HesabiSilBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesabınız Silinmiştir", "Hesap Silme",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            kullanici kkullanici = new kullanici();
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
