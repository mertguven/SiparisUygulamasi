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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        dataBase db = new dataBase();
        projeEntities ent = new projeEntities();
        kullanıcılar k = new kullanıcılar();
        urunler u = new urunler();

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

        private void MamaAdetTxt_Click(object sender, EventArgs e)
        {
            MamaAdetTxt.Text = "";
        }

        private void OyuncakAdetTxt_Click(object sender, EventArgs e)
        {
            OyuncakAdetTxt.Text = "";
        }

        private void AksesuarAdetTxt_Click(object sender, EventArgs e)
        {
            AksesuarAdetTxt.Text = "";
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            int MamaAdet = Convert.ToInt32(MamaAdetTxt.Text);
            int OyuncakAdet = Convert.ToInt32(OyuncakAdetTxt.Text);
            int AksesuarAdet = Convert.ToInt32(AksesuarAdetTxt.Text);
            
            bool od = on_dogrulama(MamaAdetTxt.Text, OyuncakAdetTxt.Text, AksesuarAdetTxt.Text); //ön doğrulamamı gerçekleştirdim ve değerini od değişkenine atadım
            if(od == true)
            {
                db.UrunEkle(MamaAdet, OyuncakAdet, AksesuarAdet);
                MessageBox.Show("Ürünler Eklendi!");
            }

            bool on_dogrulama(string ma, string oa, string aa) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
            {
                if (ma == "" || ma == "ADET" || oa == "" || oa == "ADET" || aa == "" || aa == "ADET" ) //Eğer herhangi bir textbox boşsa false değeri döndürsün
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun");
                    return false;
                }
                else //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                    return true;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.Visible = true;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            panel11.Visible = true;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            panel11.Visible = false;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BackColor = Color.Silver;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BackColor = Color.Silver;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Transparent;
        }

        private void MamaAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BackColor = Color.Silver;
        }

        private void MamaAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Transparent;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BackColor = Color.Silver;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Transparent;
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            panel14.BackColor = Color.Silver;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            panel14.BackColor = Color.Silver;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Transparent;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            panel14.BackColor = Color.Silver;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Transparent;
        }

        private void OyuncakAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel14.BackColor = Color.Silver;
        }

        private void OyuncakAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Transparent;
        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            panel15.BackColor = Color.Silver;
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            panel15.BackColor = Color.Silver;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Transparent;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            panel15.BackColor = Color.Silver;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Transparent;
        }

        private void AksesuarAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel15.BackColor = Color.Silver;
        }

        private void AksesuarAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Transparent;
        }

        private void button8_Click(object sender, EventArgs e)
        {   
            UrunStokPnl.Visible = false;
            UrunEklePnl.Visible = false;
            UrunCikarPnl.Visible = true;
            HesapSilPnl.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunCikarPnl.Visible = false;
            UrunStokPnl.Visible = false;
            UrunEklePnl.Visible = true;
            HesapSilPnl.Visible = false;
        }

        private void CıkarBtn_Click(object sender, EventArgs e)
        {
            int MamaCıkarAdet = Convert.ToInt32(MamaCıkarAdetTxt.Text);
            int OyuncakCıkarAdet = Convert.ToInt32(OyuncakCıkarAdetTxt.Text);
            int AksesuarCıkarAdet = Convert.ToInt32(AksesuarCıkarAdetTxt.Text);

            bool od = on_dogrulama(MamaCıkarAdetTxt.Text, OyuncakCıkarAdetTxt.Text, AksesuarCıkarAdetTxt.Text);
            if(od == true)
            {
                db.UrunSil(MamaCıkarAdet, OyuncakCıkarAdet, AksesuarCıkarAdet);
                MessageBox.Show("Ürünler Silindi!");
            }
            bool on_dogrulama(string mca, string oca, string aca) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
            {
                if (mca == "" || mca == "ADET" || oca == "" || oca == "ADET" || aca == "" || aca == "ADET") //Eğer herhangi bir textbox boşsa false değeri döndürsün
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return false;
                }
                else //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                    return true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UrunStokPnl.Visible = true;
            UrunEklePnl.Visible = false;
            UrunCikarPnl.Visible = false;
            HesapSilPnl.Visible = false;
        }

        private void StokBtn_Click(object sender, EventArgs e)
        {
            int m = 0;
            int o = 0;
            int a = 0;
            db.UrunStok(ref m, ref o, ref a);
            MamaStokLbl.Text = m.ToString();
            OyuncakStokLbl.Text = o.ToString();
            AksesuarStokLbl.Text = a.ToString();

            if (MamaStokLbl.Text == "0")
            {
                timer1.Start();
            }
            
            if (OyuncakStokLbl.Text == "0")
            {
                timer2.Start();
            }
            
            if (AksesuarStokLbl.Text == "0")
            {
                timer3.Start();
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            panel20.Visible = panel20.Visible ? false : true;
            if(MamaStokLbl.Text != "0")
            {
                timer1.Stop();
                panel20.Visible = true;
            }
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel19.Visible = panel19.Visible ? false : true;
            if (OyuncakStokLbl.Text != "0")
            {
                timer2.Stop();
                panel19.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel18.Visible = panel18.Visible ? false : true;
            if (AksesuarStokLbl.Text != "0")
            {
                timer3.Stop();
                panel18.Visible = true;
            }
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            panel17.BackColor = Color.Silver;
        }
        
        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Transparent;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Transparent;
        }

        private void label16_MouseMove(object sender, MouseEventArgs e)
        {
            panel17.BackColor = Color.Silver;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Transparent;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            panel17.BackColor = Color.Silver;
        }

        private void AksesuarCıkarAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel17.BackColor = Color.Silver;
        }

        private void AksesuarCıkarAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Transparent;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            panel17.BackColor = Color.Silver;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Transparent;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Silver;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Silver;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void OyuncakCıkarAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Silver;
        }

        private void OyuncakCıkarAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Silver;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void MamaCıkarAdetTxt_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void MamaCıkarAdetTxt_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void AksesuarCıkarAdetTxt_Click(object sender, EventArgs e)
        {
            AksesuarCıkarAdetTxt.Text = "";
        }

        private void OyuncakCıkarAdetTxt_Click(object sender, EventArgs e)
        {
            OyuncakCıkarAdetTxt.Text = "";
        }

        private void MamaCıkarAdetTxt_Click(object sender, EventArgs e)
        {
            MamaCıkarAdetTxt.Text = "";
        }
        public void KullaniciListele()
        {
            var query = from k in ent.kullanıcılar
                        join u in ent.urunler
                        on k.id equals u.KullanıcıId
                        select new { k.id, k.ad, k.sifre, u.Mama, u.Oyuncak, u.Aksesuar };
            DGKullaniciList.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapSilPnl.Visible = true;
            UrunStokPnl.Visible = false;
            UrunEklePnl.Visible = false;
            UrunCikarPnl.Visible = false;
            KullaniciListele();
        }

        private void DGKullaniciList_Click(object sender, EventArgs e)
        {
            idtxt.Text = DGKullaniciList.CurrentRow.Cells[0].Value.ToString();
            kaditxt.Text = DGKullaniciList.CurrentRow.Cells[1].Value.ToString();
            sifretxt.Text = DGKullaniciList.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(idtxt.Text);
            if (!(ID == 1))
            {
                db.KullaniciSil(ID);
                MessageBox.Show("Hesap Silindi!");
            }
            else
                MessageBox.Show("Admin Silinemez!");
            KullaniciListele();
        }

        private void MamaAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OyuncakAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AksesuarAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MamaCıkarAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OyuncakCıkarAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AksesuarCıkarAdetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
