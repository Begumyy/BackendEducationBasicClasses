namespace HomeWork19;

class Program
{
    static void Main(string[] args)
    {
        // string tipinde bir değişken oluştur ve içine bir cümle yaz
        string cumle = "Bu bir örnek cümledir.";

        // Cümlenin karakter sayısını int tipinde bir değişkene ata
        int karakterSayisi = cumle.Length;

        // Karakter sayısını ekrana yazdır
        Console.WriteLine("Cümlenin karakter sayısı: " + karakterSayisi);
    }
}
