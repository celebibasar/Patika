// Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    //komutlar
    if(i%2 == 1)
    Console.WriteLine(i);


    
}
int tektoplam = 0;
int cifttoplam = 0;
for (int i = 0; i <= 1000; i++)
{
    if(i%2 == 1)
    tektoplam += i;
    else
    cifttoplam += i;
    
}

Console.WriteLine("Tek Toplam: " + tektoplam);
Console.WriteLine("Çift Toplam: " + cifttoplam);

// break, continue

for (int i = 1; i < 10; i++)
{
    if(i == 4)
    break;
    Console.WriteLine(i);
    
}
for (int i = 1; i < 9; i++)
{
    if(i == 4)
    continue;
    Console.WriteLine(i);
    
}