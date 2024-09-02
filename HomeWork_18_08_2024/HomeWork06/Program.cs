namespace HomeWork06;

class Program
{
    static void Main(string[] args)
    {
         // byte tipinde bir değişken oluşturuldu ve 255 değeri atandı
        byte byteDeger = 255;

        // Bu değeri int tipine dönüştürüp yeni bir değişkene atandı
        int intDeger = byteDeger;

        // int değeri ekrana yazdır
        Console.WriteLine("Byte değerinin int karşılığı: " + intDeger);
    }
}
