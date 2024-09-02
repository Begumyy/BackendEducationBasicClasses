namespace HomeWork08;

class Program
{
    static void Main(string[] args)
    {
        // double tipinde bir değişken oluşturuldu ve 3.14 değeri atandı
        double doubleDeger = 3.14;

        // Bu değeri int tipine dönüştürüp yeni bir değişkene atandı
        int intDeger = (int)doubleDeger;

        // int değeri ekrana yazdır
        Console.WriteLine("Double değerinin int karşılığı: " + intDeger);
    }
}
