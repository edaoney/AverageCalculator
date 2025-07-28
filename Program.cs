Console.WriteLine("Ortalama Hesaplama");

double toplam = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Lütfen {i}. sayıyı  giriniz: ");
    double number = double.Parse(Console.ReadLine());
    toplam += number;
}
double ortalama = toplam / 5;
Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");