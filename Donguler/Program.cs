string kurs1 = "Yazılım Gelitirici Yetirtirme Kamp";
string kurs2 = "Programalamaya başlangıç için temel kurs";
string kurs3 = "Java";
string kurs4 = "Python";
string kurs5 = "C++";
string kurs6= "C#";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine(kurs4);
Console.WriteLine(kurs5);
Console.WriteLine(kurs6);

//array - Dizi

string[] kurslar = new string[] { "Yazılım Gelitirici Yetirtirme Kamp", 
    "Programalamaya başlangıç için temel kurs", "Java", "Python", "C++", "C#" };

for (int i = 0; i< kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa sonu - footer");