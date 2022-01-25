// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Bir sayı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayı: " + sayi);
    
}
catch(Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());

}


try
{
    int a = int.Parse("-2000000000000000000");


}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş bir değer girdiniz.");
    Console.WriteLine(ex);
    
}
catch (FormatException ex)
{
    Console.WriteLine("Yanlış formatta girildi.");
    Console.WriteLine(ex);

}
catch (OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da çok büyük değer girildi.");
    Console.WriteLine(ex);
}
finally {
    Console.Write("İşlem başarıyla tamamlandı.");
}




