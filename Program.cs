// See https://aka.ms/new-console-template for more information
using System;


try
{
    int a = int.Parse(null);
    int b = int.Parse("text");
    int c = int.Parse("2000000000000000000000");
    Console.Read();
}
catch(ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
    Console.Read();
}
catch(FormatException ex)
{
    Console.WriteLine("veri tipi uygun değil");
    Console.WriteLine(ex);
    Console.Read();
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok küçük yada çok Büyük bir değer  girdiniz.");
    Console.WriteLine(ex);
    Console.Read();
}
finally
{
    Console.WriteLine("İşlem Başarıyla Tamamlandı.");
    Console.Read();
}