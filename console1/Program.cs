// See https://aka.ms/new-console-template for more information
int i = 1;
while (true)
{
    Console.Write(i + ". sayıyı giriniz(çıkmak için 0 a basınız) :");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi > 0 && sayi % 2 == 0)
    {
        Console.WriteLine(sayi + " çift sayıdır");
    }
    else if (sayi == 0)
        break;
    i++;
}


