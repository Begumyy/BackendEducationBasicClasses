namespace HomeWork14;

class Program
{
    static void Main(string[] args)
    {
        // long tipinde bir değişken oluştur ve içine büyük bir sayı ata
        long longDeger = 500000000000L;

        // Bu değeri int tipine dönüştürmeye çalış
        // Dönüştürme işlemi tip dönüşüm hatası (overflow) oluşturabilir
        int intDeger;

        try
        {
            intDeger = checked((int)longDeger); // checked bloğu, overflow hatalarını kontrol eder
            Console.WriteLine("Dönüştürülmüş int değer: " + intDeger);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hata: long değer int türünden daha büyük. Dönüştürme mümkün değil.");
        }
    }
}
