using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class KitapTarih:Kitap
    {
        public string Donem { get; set; }
        public override Durum Durum { get; set; }

        public KitapTarih(string isbn, string baslik, string yazar, int yayinYili, string donem) : base(isbn, baslik, yazar, yayinYili)
        {
            Donem = donem;
            Durum = Durum.OduncAlabilir;
        }

    }
}
