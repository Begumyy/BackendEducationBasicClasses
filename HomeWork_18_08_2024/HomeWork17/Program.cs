namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
        // double tipinde pi sayısını temsil eden bir değişken oluştur
        double piDouble = 3.14159;

        // Bu değeri float tipine dönüştürüp yeni bir değişkene ata
        float piFloat = (float)piDouble;

        // Her iki değeri de ekrana yazdır
        Console.WriteLine("Double değer: " + piDouble);
        Console.WriteLine("Float değer: " + piFloat);
    }
}
