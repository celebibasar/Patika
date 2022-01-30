int[] sayıDizisi = {3, 45, 21, 2, 5, 7};
//Sırasız Liste Dizimi
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
    
}
//Sıralı Liste Dizimi
Array.Sort(sayıDizisi);
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
    
}

//Clear
Array.Clear(sayıDizisi,2,2);
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
    
}

//Reverse

Array.Reverse(sayıDizisi);
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
    
}

//IndexOf

Array.IndexOf(sayıDizisi,23);

Console.WriteLine(Array.IndexOf(sayıDizisi,23));


//Resize
Array.Resize<int>(ref sayıDizisi,7);
sayıDizisi[6] = 99;
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
    
}

