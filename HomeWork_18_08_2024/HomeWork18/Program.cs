namespace HomeWork18;

class Program
{
    static void Main(string[] args)
    {
         // byte, short, int, ve long tiplerinde değişkenler oluştur ve her birine aynı sayısal değeri ata
        byte byteDeger = 42;
        short shortDeger = 42;
        int intDeger = 42;
        long longDeger = 42;

        // Bu değişkenlerin bellekte kapladıkları alanı sizeof() operatörü ile öğren
        Console.WriteLine("byte tipinde değişkenin bellek alanı: " + sizeof(byte) + " byte");
        Console.WriteLine("short tipinde değişkenin bellek alanı: " + sizeof(short) + " byte");
        Console.WriteLine("int tipinde değişkenin bellek alanı: " + sizeof(int) + " byte");
        Console.WriteLine("long tipinde değişkenin bellek alanı: " + sizeof(long) + " byte");
    }
}
