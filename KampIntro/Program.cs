﻿//type safety - Tip güvenliği
//Do not repeat yourself - Kendini tekrarlama

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 735;
double dolarBugun = 7.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}


if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanici ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);
