namespace HomeWork09;

class Program
{
    static void Main(string[] args)
    {
        // string tipinde bir değişken oluşturuldu ve içine bir sayı atandı
        string stringSayi = "42";

        // Bu string'i int tipine dönüştürüp yeni bir değişkene atandı
        int intSayi = int.Parse(stringSayi);

        // int değeri ekrana yazdır
        Console.WriteLine("String değerinin int karşılığı: " + intSayi);
    }
}
