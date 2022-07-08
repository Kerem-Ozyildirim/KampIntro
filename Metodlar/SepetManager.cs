using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //Syntax
        public void Ekle1(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, double stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi + " : " + aciklama + " : "  + fiyat + " : " + stokAdedi);
        }
    }
}
