using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odev.Models
{
    public class Urunveri
    {
        public static List<Urun> Urunler = new()
        {
            new Urun()
                        {
                            Id = 1,
                            Ürün_Adı = "Kasap Köfte",
                            Ürün_kodu = 123,
                            Fiyatı = 75,
                Türü = "Dana"
                        },
            new Urun()
                        {
                            Id = 2,
                            Ürün_Adı = "Kaşarlı Köfte",
                            Ürün_kodu = 12345,
                            Fiyatı = 80,
                            Türü= "Dana"
                        },
            new Urun()
                        {
                            Id = 3,
                            Ürün_Adı = "Adana Kebap",
                            Ürün_kodu = 1234567,
                            Fiyatı = 25,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id = 4,
                            Ürün_Adı = "Urfa Kebap",
                            Ürün_kodu = 123456789,
                            Fiyatı = 25,
                            Türü= "Kuzu"
                        },
            new Urun()
                        {
                            Id = 5,
                            Ürün_Adı = "Sucuk",
                            Ürün_kodu = 12345789,
                            Fiyatı = 70,
                            Türü= "Dana"
                        },
            new Urun()
                        {
                            Id = 6,
                            Ürün_Adı = "Yarın Ekmek Köfte",
                            Ürün_kodu = 123456789,
                            Fiyatı = 50,
                            Türü= "Dana"
                        },
            new Urun()
                        {
                            Id = 7,
                            Ürün_Adı = "Tavuk Pirzola",
                            Ürün_kodu = 123456789,
                            Fiyatı = 45,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id = 8,
                            Ürün_Adı = "Tavuk Kanat",
                            Ürün_kodu = 123456789,
                            Fiyatı = 50,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id = 9,
                            Ürün_Adı = "Tavuk Şiş",
                            Ürün_kodu = 123456789,
                            Fiyatı = 40,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id = 10,
                            Ürün_Adı = "Çıtır Pirzola",
                            Ürün_kodu = 123456789,
                            Fiyatı = 50,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id = 11,
                            Ürün_Adı = "Tavuk Şinitzel",
                            Ürün_kodu = 123456789,
                            Fiyatı = 45,
                            Türü= "Tavuk"
                        },
            new Urun()
                        {
                            Id =12,
                            Ürün_Adı = "Ciğer",
                            Ürün_kodu = 123456789,
                            Fiyatı = 120,
                            Türü= "Dana"
                        }

        };


    }
}
