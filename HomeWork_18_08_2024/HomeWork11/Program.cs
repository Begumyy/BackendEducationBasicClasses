namespace HomeWork11;

class Program
{
    static void Main(string[] args)
    {
        // decimal tipinde iki değişken oluşturuldu ve para miktarları atandı
        decimal para1 = 10.25m;
        decimal para2 = 5.75m;

        // Bu değerleri toplanması ve sonucu yeni bir decimal değişkene atanması
        decimal toplam = para1 + para2;

        // Sonucu ekrana yazdır
        Console.WriteLine("Toplam para miktarı: " + toplam);
    }
}
