using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using CSProjeDemo1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Uye : IUye
    {
        public int UyeNo { get ; set ; }
        public string Ad { get; set ; }
        public string Soyad { get; set ; }
        public List<Kitap> OduncKitaplar { get; set ; }

        public Uye(int uyeNo,string ad, string soyad)
        {
            UyeNo = uyeNo;  
            Ad = ad;
            Soyad = soyad;
            OduncKitaplar = new List<Kitap>();
        }
        public void KitapIadeEt(Kitap kitap)
        {
           if(kitap.Durum==Durum.OduncAlabilir)
            {
                OduncKitaplar.Add(kitap);
                kitap.Durum = Durum.OduncVerildi;
            }
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.Durum = Durum.OduncAlabilir;
            }
        }
    }
}
