namespace HomeWork15;

class Program
{
    static void Main(string[] args)
    {
        // string tipinde bir değişken oluştur ve içine "True" yaz
        string stringDeger = "True";

        // Bu string'i bool tipine dönüştürüp yeni bir değişkene ata
        bool boolDeger;
        
        // String'i bool tipine dönüştürme
        boolDeger = bool.Parse(stringDeger);

        // Sonucu ekrana yazdır
        Console.WriteLine("Boolean değer: " + boolDeger);
    }
}
