using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class dataBase
    {
        projeEntities ent = new projeEntities();
        kullanıcılar k = new kullanıcılar();
        urunler u = new urunler();
        int id = 1;

        public void KullaniciEkle(string YKAdi, string YSifre)
        {
            k.ad = YKAdi;
            k.sifre = YSifre;
            ent.kullanıcılar.Add(k);
            u.KullanıcıId = k.id;
            u.Mama = 0;
            u.Oyuncak = 0;
            u.Aksesuar = 0;
            ent.urunler.Add(u);
            ent.SaveChanges();
        }
        public void KullaniciSil(int id)
        {
            var x = ent.kullanıcılar.Find(id);
            var y = ent.urunler.Find(id);
            ent.kullanıcılar.Remove(x);
            ent.urunler.Remove(y);
            ent.SaveChanges();
        }
        public bool KullaniciGiris(string username, string password)
        {
            var user = (from k in ent.kullanıcılar
                        where k.ad == username &&
                            k.sifre == password
                            select k
                        ).FirstOrDefault();
            if(user != null)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public void UrunEkle(int MamaA, int OyuncakA, int AksesuarA)
        {
            var x = ent.urunler.Find(id);
            x.Mama += MamaA;
            x.Oyuncak += OyuncakA;
            x.Aksesuar += AksesuarA;
            ent.SaveChanges();
        }
        public void UrunSil(int MamaCA, int OyuncakCA, int AksesuarCA)
        {
            var x = ent.urunler.Find(id);
            x.Mama -= MamaCA;
            x.Oyuncak -= OyuncakCA;
            x.Aksesuar -= AksesuarCA;
            ent.SaveChanges();
        }
        public void UrunStok(ref int m, ref int o, ref int a)
        {
            var x = ent.urunler.Find(id);
            m =Convert.ToInt32(x.Mama);
            o = Convert.ToInt32(x.Oyuncak);
            a = Convert.ToInt32(x.Aksesuar);
        }
        public void SiparisEkle(int mst, int ost, int ast, int sid, string adres)
        {
            var x = ent.urunler.Find(sid);
            x.Mama += mst;
            x.Oyuncak += ost;
            x.Aksesuar += ast;
            x.SiparisAdres = adres;
            ent.SaveChanges();
        }
        public void StokSil(int mst, int ost, int ast)
        {
            var x = ent.urunler.Find(id);
            x.Mama -= mst;
            x.Oyuncak -= ost;
            x.Aksesuar -= ast;
            ent.SaveChanges();
        }
        public bool Odeme(Int64 knt, string acb, string ycb, string cvt)
        {
            Int64 kntt = Convert.ToInt64(knt);
            int acbb = Convert.ToInt32(acb);
            int ycbb = Convert.ToInt32(ycb);
            int cvtt = Convert.ToInt32(cvt);
            var x = (from k in ent.kullanıcılar
                     where k.kartNo == kntt &&
                        k.ay == acbb &&
                        k.yıl == ycbb &&
                        k.cvv == cvtt
                     select k).FirstOrDefault();
            if(x != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
