namespace burcProgrami;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan doğum gününü ve ayını alma
        Console.Write("Doğum gününüz: ");
        int gun = int.Parse(Console.ReadLine());

        Console.Write("Doğum ayınız: ");
        string ay = Console.ReadLine().ToLower();

        // Burçları belirleme
        string burc = "";

        if ((gun >= 22 && ay == "aralık") || (gun <= 20 && ay == "ocak"))
        {
            burc = "Oğlak";
        }
        else if ((gun >= 21 && ay == "ocak") || (gun <= 19 && ay == "şubat"))
        {
            burc = "Kova";
        }
        else if ((gun >= 20 && ay == "şubat") || (gun <= 20 && ay == "mart"))
        {
            burc = "Balık";
        }
        else if ((gun >= 21 && ay == "mart") || (gun <= 20 && ay == "nisan"))
        {
            burc = "Koç";
        }
        else if ((gun >= 21 && ay == "nisan") || (gun <= 21 && ay == "mayıs"))
        {
            burc = "Boğa";
        }
        else if ((gun >= 22 && ay == "mayıs") || (gun <= 21 && ay == "haziran"))
        {
            burc = "İkizler";
        }
        else if ((gun >= 22 && ay == "haziran") || (gun <= 22 && ay == "temmuz"))
        {
            burc = "Yengeç";
        }
        else if ((gun >= 23 && ay == "temmuz") || (gun <= 23 && ay == "ağustos"))
        {
            burc = "Aslan";
        }
        else if ((gun >= 24 && ay == "ağustos") || (gun <= 23 && ay == "eylül"))
        {
            burc = "Başak";
        }
        else if ((gun >= 24 && ay == "eylül") || (gun <= 23 && ay == "ekim"))
        {
            burc = "Terazi";
        }
        else if ((gun >= 24 && ay == "ekim") || (gun <= 22 && ay == "kasım"))
        {
            burc = "Akrep";
        }
        else if ((gun >= 23 && ay == "kasım") || (gun <= 21 && ay == "aralık"))
        {
            burc = "Yay";
        }
        else
        {
            Console.WriteLine("Geçersiz bir gün veya ay girdiniz.");
            return;
        }

        // Burcu ekrana yazdırma
        Console.WriteLine($"Burcunuz {burc} burcudur.");
    }
}
