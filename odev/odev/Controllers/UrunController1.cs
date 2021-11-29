using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odev.Controllers
{
    public class UrunController1 : Controller
    {
        public IActionResult Liste()
        {
            return View(Models.Urunveri.Urunler);
        }



        public IActionResult Yeni()
        {
            return View();
        }


        
        [HttpPost]
        public IActionResult Yeni(Models.Urun yeniUrun)
        {
            Models.Urunveri.Urunler.Add(yeniUrun);
            return RedirectToAction("Liste");

        }
        public IActionResult Guncelle(int id)
        {
            var b = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == id);
            return View(b);
        }

        [HttpPost]
        public IActionResult Guncelle(Models.Urun urun)
        {
            var a = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == urun.Id);

            var b = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == urun.Id);
            b.Ürün_Adı = urun.Ürün_Adı;
            b.Ürün_kodu = urun.Ürün_kodu;
            b.Fiyatı = urun.Fiyatı;
            b.Türü = urun.Türü;

            Models.Urunveri.Urunler.Remove(a);

            Models.Urunveri.Urunler.Add(b);




            return RedirectToAction("Liste");
        }
        public IActionResult Detay(int id)
        {
            var b = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == id);
            return View(b);
        }
        public IActionResult Sil(int id)
        {
            var b = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == id);
            return View(b);
        }
        [HttpPost]
        public IActionResult Sil(Models.Urun urun)
        {
            var urun1 = Models.Urunveri.Urunler.FirstOrDefault(x => x.Id == urun.Id);
            Models.Urunveri.Urunler.Remove(urun1);
            return RedirectToAction("Liste");
        }














        //public IActionResult Index()
        //{
        //  return View();
        //}
    }
}
