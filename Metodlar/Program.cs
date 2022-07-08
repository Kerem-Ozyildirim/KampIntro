using Metotlar;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya elması";

string urunAdi2 = "Çilek";
double fiyati2 = 10;
string aciklama2 = "Çilek gibi Çilek";

string urunAdi3 = "Elma";
double fiyati3 = 15;
string aciklama3 = "Amasya elması";

string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1,urun2 };

//type safety - tip güvenliği

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------");
}

Console.WriteLine("--------------Metotlar------------------");

//instance - Örnek
//encapulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle1(urun1);
sepetManager.Ekle1(urun2);

sepetManager.Ekle2("Armut","Yeşil armut", 12, 8 );
sepetManager.Ekle2("Elma","Yeşil elma",12, 8 );
sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12, 8);

//Dont repeat yourself - DRY - Clean Mode - Best Practice
