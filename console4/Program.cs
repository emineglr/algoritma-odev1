// See https://aka.ms/new-console-template for more information

Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int kelimesayisi = kelimeler.Length;

int harfsayisi = 0;
foreach (char c in cumle)
{
    if (char.IsLetter(c))
    {
        harfsayisi++;
    }
}
Console.WriteLine("Cümledeki toplam kelime sayısı : " + kelimesayisi);
Console.WriteLine("Cümledeki toplam harf sayısı : " + harfsayisi);



