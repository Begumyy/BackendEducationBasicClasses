namespace HomeWork04;

class Program
{
    static void Main(string[] args)
    {
        // char tipinde bir değişken oluşturuldu ve bir harf atandı
        char harf = 'T';  

        // Bu harfin ASCII değeri int tipinde bir değişkene atandı
        int asciiDegeri = (int)harf;

        // ASCII değerini ekrana yazdır
        Console.WriteLine("Harfin ASCII değeri: " + asciiDegeri);
    }
}
