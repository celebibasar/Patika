//While
// 1 den başlayarak console'da girilen sayıya kadar sayı dahil ort hesaplayıp console'a yazdıran döngü
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;

}
Console.WriteLine(toplam/sayi);


// a'dan z'ye kadar tüm harfler
char karakter = 'a';
while (karakter < 'z')
{
    Console.Write(karakter);
    karakter ++;
}
// foreach
string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
    
}