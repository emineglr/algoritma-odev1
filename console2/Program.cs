// See https://aka.ms/new-console-template for more information

int m = 0;
int n = 0;
while (n <= 0)
{
    Console.Write("n sayısını giriniz : ");
    n = Convert.ToInt32(Console.ReadLine());
}

while (m <= 0)
{
    Console.Write("m sayısını giriniz : ");
    m = Convert.ToInt32(Console.ReadLine());
}

int sayi;
for (int i = 1; i <= n; i++)
{
    Console.Write(i + ". sayıyı giriniz:");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == m || sayi % m == 0)
        Console.WriteLine(sayi);
}

