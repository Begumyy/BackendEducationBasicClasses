namespace Project13_Loops_While;

class Program
{
    static void Main(string[] args)
    {
         // int i = 1;
        // while (i <= 5)
        // {
        //     Console.WriteLine("Merhaba Dünya!");
        //     i++;
        // }

        /* KULLANICININ GİRECEĞİ SAYILARI TOPLAYAN BİR KOD YAZALIM. ANCAK KULLANICI SAYI GİRMEK YERİNE exit İFADESİNİ GİRERSE, TOPLAM EKRANA YAZDIRILIP PROGRAM SONA ERSİN.*/

        // int total = 0;
        // string input = "";
        // int counter = 1;
        // string message = "Bir sayı giriniz";
        // while (input.ToLower() != "exit")
        // {
        //     Console.Write($"{message}({counter}.Sayı)(Çıkış için 'exit' yazınız):");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total += inputNumber;
        //         message = "Bir sayı giriniz";
        //         counter++;
        //     }
        //     else if (input.ToLower() != "exit")
        //     {
        //         message = "Lütfen geçerli bir sayı giriniz!";
        //     }
        // }
        // Console.WriteLine($"Toplam: {total}");

        /* KULLANICININ GİRECEĞİ SAYILARI TOPLAYAN BİR KOD YAZALIM. ANCAK GİRİLEN SAYILARIN TOPLAMI 100'DEN BÜYÜK OLURSA, TOPLAM EKRANA YAZDIRILIP PROGRAM SONA ERSİN.*/
        //     int total = 0;
        //     string message = "Bir sayı giriniz";
        //     string input = "";
        //     int i = 1;
        //     while (total <= 100)
        //     {
        //         string totalMessage = i > 1 ? $"## Geçerli Toplam: {total} ##" : "";
        //         Console.Write($"{message}{totalMessage}({i}.Sayı):");
        //         input = Console.ReadLine();
        //         if (int.TryParse(input, out int inputNumber))
        //         {
        //             total += inputNumber;
        //             message = "Bir sayı giriniz";
        //             i++;
        //         }
        //         else
        //         {
        //             message = "HATA -> Lütfen geçerli bir sayı giriniz!";
        //         }
        //     }
        //     Console.WriteLine($"Toplam: {total}");

        /* KULLANICININ GİRECEĞİ SAYILARI TOPLAYAN BİR KOD YAZALIM. ANCAK GİRİLEN SAYILARIN TOPLAMI 100'DEN BÜYÜK OLURSA YA DA KULLANICI exit GİRERSE, TOPLAM EKRANA YAZDIRILIP PROGRAM SONA ERSİN.*/

        // int total = 0;
        // string input = "";
        // int counter = 1;
        // string message = "Bir sayı giriniz";
        // while (input.ToLower() != "exit" && total<=100)
        // {
        //     Console.Write($"{message}({counter}.Sayı)(Çıkış için 'exit' yazınız):");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total += inputNumber;
        //         message = "Bir sayı giriniz";
        //         counter++;
        //     }
        //     else if (input.ToLower() != "exit")
        //     {
        //         message = "Lütfen geçerli bir sayı giriniz!";
        //     }
        // }
        // Console.WriteLine($"Toplam: {total}");

        // do
        // {
        //     Console.WriteLine("İşte do while'ın farkı");
        // } while (1 == 2);


        // int total = 0;
        // string input;
        // int counter = 1;
        // string message = "Bir sayı giriniz";
        // do
        // {
        //     Console.Write($"{message}({counter}.Sayı)(Çıkış için 'exit' yazınız):");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total += inputNumber;
        //         message = "Bir sayı giriniz";
        //         counter++;
        //     }
        //     else if (input.ToLower() != "exit")
        //     {
        //         message = "Lütfen geçerli bir sayı giriniz!";
        //     }
        // } while (input.ToLower() != "exit" && total <= 100);
        // Console.WriteLine($"Toplam: {total}");

        /* SADECE SAYI GİRİŞİ YAPTIRALIM! */
        // ConsoleKeyInfo input;//Her basılan tuşu bu değişkenler karşılayacağız.
        // string resultNumber = "";
        // Console.Write("Bir sayı giriniz!:");
        // do
        // {
        //     input = Console.ReadKey(true);
        //     if (char.IsDigit(input.KeyChar))
        //     {
        //         Console.Write(input.KeyChar);
        //         resultNumber += input.KeyChar;
        //     }
        //     else
        //     {
        //         if (input.Key == ConsoleKey.Backspace && resultNumber.Length > 0)
        //         {
        //             // 138|<-
        //             // 13|
        //             resultNumber = resultNumber.Substring(0, resultNumber.Length - 1);
        //             Console.Write("\b \b");
        //         }
        //     }
        // } while (input.Key != ConsoleKey.Enter);

        // Console.WriteLine();
        // bool status = int.TryParse(resultNumber, out int result);
        // Console.WriteLine(status ? result * 2 : 0);

        /* GİRİLEN SAYININ ASAL SAYI OLUP OLMADIĞINI TESPİT EDİP EKRANA YAZDIRALIM! TEKRAR DENEMEK İSTEYİP İSTEMEDİĞİMİZİ SORSUN, E/H , E DERSEK YENİDEN BİR SAYIYI KONTROL EDEBİLELİM, H DERSEK PROGRAMI BİTİRSİN */
        string answer;
        do
        {
            bool isPrime = true; //varsayılan olarak kontrol edeceğim sayıyı asal kabul ettim!
            Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                int i = 3;
                while (i <= number - 1)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
            }
            Console.WriteLine(isPrime ? "Asal" : "Asal değil");
            Console.Write("Tekrar denemek ister misiniz?(E/H):");
            answer = Console.ReadLine();
        } while (answer != "H");
        Console.WriteLine("Uygulama sona erdi...");
    }
    
}



