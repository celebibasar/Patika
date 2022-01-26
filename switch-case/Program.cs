// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;
//Expression
switch (month)
{
    case 1:
    Console.WriteLine("Ocak ayındasınız");
    break;
    case 2:
    Console.WriteLine("Şubat");
    break;

    
    default:
    Console.WriteLine("Yanlış veri tabanındasınız.");
    break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
    Console.WriteLine("Kış ayındasınız.");
    break;
    case 3:
    case 4:
    case 5:
    Console.WriteLine("İlkbahar ayındasınız");
    break;
    
    default:
    break;
}