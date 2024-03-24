using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class KitapBilim:Kitap
    {
        public string AltAlan { get; set; }
        public override Durum Durum { get ; set ; }

        public KitapBilim(string isbn, string baslik,string yazar,int yayinYili,string altAlan):base(isbn, baslik,yazar, yayinYili)
        {
            AltAlan = altAlan;
            Durum = Durum.OduncAlabilir;
        }
    }
}
