using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class KitapRoman : Kitap
    {
        public string Tur { get; set; }
        public override Durum Durum { get ; set ; }
        public KitapRoman(string isbn,string baslik,string yazar,int yayinYili,string tur):base (isbn, baslik, yazar,yayinYili)
        {
            Tur = tur;
            Durum = Durum.OduncAlabilir;
        }
    }
}
