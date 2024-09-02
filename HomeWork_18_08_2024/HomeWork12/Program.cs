namespace HomeWork12;

class Program
{
    static void Main(string[] args)
    {
         // float tipinde bir değişken oluşturuldu
        float floatDeger = 1.23f;

        // Bu değeri double tipine dönüştürüp yeni bir değişkene atandı
        double doubleDeger = (double)floatDeger;

        // Her iki değeri de ekrana yazdır
        Console.WriteLine("Float değer: " + floatDeger);
        Console.WriteLine("Double değer: " + doubleDeger);

        // Karşılaştırma
        Console.WriteLine("Float ve Double değerler eşit mi? " + (floatDeger == doubleDeger));
    }
}
