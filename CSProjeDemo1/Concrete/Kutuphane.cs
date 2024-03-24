using CSProjeDemo1.Abstract;
using CSProjeDemo1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Kutuphane
    {
        private List<Kitap> _kitaplar; 
        private List<IUye> _uyeler;
        public Kutuphane()
        {
            _kitaplar = new List<Kitap>();
            _uyeler = new List<IUye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            _kitaplar.Add(kitap);
        }
        public void UyeEkle(IUye uye)
        {
            _uyeler.Add(uye);
        }
        public void KitapOduncAl(Kitap kitap, IUye uye)
        {
            uye.KitapOduncAl(kitap);
        }
        public void KitapIadeEt(Kitap kitap, IUye uye)
        {
            uye.KitapIadeEt(kitap);
        }
    }
}
