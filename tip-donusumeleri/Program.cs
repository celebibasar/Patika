// See https://aka.ms/new-console-template for more information
// Bilincsiz Donusum (Implicit)
byte a = 5;
sbyte b = 25;
short c = 10;

int d = a+b+c;

Console.WriteLine("d: " + d);

string e = "Basar";
char f = 'c';

object g = e+f+d;
Console.WriteLine("g: " + g);

// Bilincli Donusum (Explicit)

int x = 4;
byte y = (byte)x;
Console.WriteLine("y: " + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t: " + t);

float w = 21.3f;
byte r = (byte)w;

Console.WriteLine("r: " + r);

// ToString


//System.Convert
string s1 ="10", s2 ="20";
int sayi1, sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1+sayi2;

Console.WriteLine("Toplam: " + Toplam);

//Parse

string metin1 = "10";
string metin2 = "10.25";
int rakam1;
double double1;

rakam1 = Int32.Parse(metin1);
double1 = Double.Parse(metin2);

Console.WriteLine("rakam1: " + rakam1);
Console.WriteLine("double1: " + double1);




