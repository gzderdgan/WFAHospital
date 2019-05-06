using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHospital.model
{
    public class Randevu :  Hasta
    {
        public DateTime RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string RandevuDakika { get; set; }

        public string DoktorAdSoyad { get; set; }
        public Branslar DoktorBransi { get; set; }

        public override string ToString()
        {
            return $"{ this.DoktorAdSoyad}{ this.HastaAdSoyad}";
        }

    }
}
