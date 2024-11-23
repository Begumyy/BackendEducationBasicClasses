namespace Project10_Conditions;

class Program
{
    static void Main(string[] args)
    {
        #region if
        // if (5 > 4)
        // {
        //     Console.WriteLine("İşlem tamamlandı!");
        // }

        // if (5 > 4)
        // {
        //     Console.WriteLine("İşlem tamamlandı!");
        // }
        // else
        // {
        //     Console.WriteLine("İşlem tamamlanmadı!");
        // }

        // int a = 5;
        // int b = 7;
        // Console.Clear();
        // if (a > b)
        // {
        //     Console.WriteLine("Büyük");
        // }
        // else if (a == b)
        // {
        //     Console.WriteLine("Eşit");
        // }
        // else
        // {
        //     Console.WriteLine("Küçük");
        // }

        #endregion

        #region if samples
        // Kullanıcının girdiği yaş bilgisine göre eğer reşit değilse "Reşit değilsiniz, X sene sonra reşit olacaksınız şeklinde bir mesaj yazsın. Ama eğer kullanıcı reşit ise, kayıt olabilirsiniz mesajını versin. Sınır:18
        // Console.Clear();
        // Console.Write("Yaşınızı giriniz: ");
        // byte age = byte.Parse(Console.ReadLine());
        // if (age >= 18)
        // {
        //     Console.WriteLine("Kayıt olabilirsiniz!");
        // }
        // else
        // {
        //     Console.WriteLine($"Reşit değilsiniz, {18 - age} sene sonra reşit olacaksınız!");
        // }

        // Kullanıcının girdiği yaş ve isim bilgisine göre eğer reşit değilse "Sayın isim, reşit değilsiniz, X sene sonra reşit olacaksınız" şeklinde bir mesaj yazsın. Ama eğer kullanıcı reşit ise, "Sayın isim, sistemimize kayıt olabilirsiniz, hoş geldiniz" mesajını versin. Sınır:18

        Console.Clear();
        string resultMessage;

        Console.Write("Adınızı giriniz: ");
        string name = Console.ReadLine();

        Console.Write("Yaşınızı giriniz: ");
        byte age = byte.Parse(Console.ReadLine());

        if (age >= 18)
        {
            resultMessage = $"Sayın {name}, sistemimize kayıt olabilirsiniz, hoş geldiniz";
        }
        else
        {
            resultMessage = $"Sayın {name}, reşit değilsiniz. {18 - age} sene sonra reşit olacaksınız!";
        }
        Console.WriteLine(resultMessage);
        #endregion
    }
}
