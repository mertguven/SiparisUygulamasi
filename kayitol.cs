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
    public partial class kayitol : Form
    {
        
        public kayitol()
        {
            InitializeComponent();
        }
        dataBase db = new dataBase();

        private void txtKullaniciAdiKayit_Click(object sender, EventArgs e)
        {
            txtKullaniciAdiKayit.Text = "";
        }

        private void txtSifreKayit_Click(object sender, EventArgs e)
        {
            txtSifreKayit.Text = "";
        }

        private void txtSifreKayit2_Click(object sender, EventArgs e)
        {
            txtSifreKayit2.Text = "";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            if(!(txtSifreKayit.Text == txtSifreKayit2.Text))
            {
                MessageBox.Show("Şifreler aynı değil!");
            }

            string yeniKullanici = txtKullaniciAdiKayit.Text;
            string sifre = txtSifreKayit.Text;
            string sifreTekrar = txtSifreKayit2.Text;
            db.KullaniciEkle(yeniKullanici,sifre);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/fahadms1106");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/merttgvvn");
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/merttgvvn");
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mert-güven-8a0006177/");
        }
    }
}
