// See https://aka.ms/new-console-template for more information


int n = 0;
while (n <= 0)
{
    Console.Write("Pozitif bir sayı girin:");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(n + " adet kelime girin.");
string[] kelimeler = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write((i + 1) + ". kelimeyi girin: ");
    kelimeler[i] = Console.ReadLine();
}
for (int k = n - 1; k >= 0; k--)
{
    Console.Write(kelimeler[k] + " ");
}

