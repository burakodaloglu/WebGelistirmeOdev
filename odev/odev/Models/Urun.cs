using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odev.Models
{
    public class Urun
    {

        public int Id { get; set; }
        public string Ürün_Adı { get; set; }
        public int Ürün_kodu { get; set; }
        public double Fiyatı { get; set; }
        public string Türü { get; set; }

    }
}
