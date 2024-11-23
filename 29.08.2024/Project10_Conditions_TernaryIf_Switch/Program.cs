namespace Project10_Conditions_TernaryIf_Switch;

class Program
{
    static void Main(string[] args)
    {
        #region Ternary If

        // Console.Write("Bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());
        // string result;
        // if (number > 50)
        // {
        //     result = "İndirim hakkınız bulunmaktadır, lütfen yöneticiyle görüşünüz.";
        // }
        // else
        // {
        //     result = "İndirim yok!";
        // }
        // Console.WriteLine(result);


        // Console.Write("Bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());
        // string result = number > 50 ?
        //                     "İndirim hakkınız bulunmaktadır, lütfen yöneticiyle görüşünüz." :
        //                     "İndirim yok!";
        // Console.WriteLine(result);

        // Console.Clear();
        // Console.Write("Adınızı Giriniz: ");
        // string name = Console.ReadLine();
        // int lengthName = name.Length;
        // // string result = lengthName > 10 ? "Uygun!" : "Uygun değil";
        // // Console.WriteLine($"Sevgili {name}, adınızın uzunluğu {lengthName} karakterdir. Durum: {result}");
        // string constMessage = $"Sevgili {name}, adınızın uzunluğu {name.Length} karakter olduğu için";
        // string result = lengthName > 10
        //             ? $"{constMessage} uygunsunuz!"
        //             : $"{constMessage} uygun değilsiniz!";
        // Console.WriteLine(result);

        /*
            Eğer name uygun bir name ise mesaj: 
                - Sevgili Engin Niyazi, adınızın uzunluğu 12 karakter olduğu için uygunsunuz.
            Eğer name uygun bir mesaj değilse: 
                - Sevigli Engin, adınızın uzunluğu 5 karakter olduğu için uygun değilsiniz.
        */

        /*
            Kullanıcıdan 1-12 arasında ay bilgisi alan ve bu ay bilgisine bakarak hangi mevsimde olduğumuzu tespit edip konsola bunu sonuç olarak yazdıran programı if ile hazırlayınız.

            Lütfen ay bilgisini giriniz(1-12): 1
            Mevsim: Kış
        */

        //if ile çözüm

        // Console.Clear();
        // Console.Write("Lütfen ay bilgisini giriniz(1-12): ");
        // byte monthNumber = byte.Parse(Console.ReadLine());

        // string result;
        // if (monthNumber == 12 || monthNumber < 3)
        // {
        //     result = "Kış";
        // }
        // else if (monthNumber < 6)
        // {
        //     result = "İlkbahar";
        // }
        // else if (monthNumber < 9)
        // {
        //     result = "Yaz";
        // }
        // else
        // {
        //     result = "Sonbahar";
        // }

        // Console.WriteLine($"Mevsim: {result}");


        /*
            Kullanıcıdan 1-12 arasında ay bilgisi alan ve bu ay bilgisine bakarak hangi mevsimde olduğumuzu tespit edip konsola bunu sonuç olarak yazdıran programı ternary if ile hazırlayınız.

            Lütfen ay bilgisini giriniz(1-12): 1
            Mevsim: Kış
        */

        //ternary if ile çözüm
        // Console.Clear();
        // Console.Write("Lütfen ay bilgisini giriniz(1-12): ");
        // byte monthNumber = byte.Parse(Console.ReadLine());

        // string result = monthNumber == 12 || monthNumber < 3 ? "Kış"
        //                     : monthNumber < 6 ? "İlkbahar"
        //                         : monthNumber < 9 ? "Yaz" : "Sonbahar";

        // Console.WriteLine($"Mevsim: {result}");

        /*
            Kullanıcının gireceği tarih bilgisine göre (gün.ay.yıl) içinde bulunulan ayın adını konsola yazdırın. Ternary if kullanın.

            Tarih giriniz: 4.12.2000
            Sonuç: Aralık
        */

        // Console.Clear();
        // Console.Write("Lütfen geçerli bir tarih giriniz(gg.aa.yyyy): ");
        // DateTime inputDate = DateTime.Parse(Console.ReadLine());
        // int monthNumber = inputDate.Month;
        // string monthName = monthNumber == 1 ? "Ocak" :
        //                     monthNumber == 2 ? "Şubat" :
        //                     monthNumber == 3 ? "Mart" :
        //                     monthNumber == 4 ? "Nisan" :
        //                     monthNumber == 5 ? "Mayıs" :
        //                     monthNumber == 6 ? "Haziran" :
        //                     monthNumber == 7 ? "Temmuz" :
        //                     monthNumber == 8 ? "Ağustos" :
        //                     monthNumber == 9 ? "Eylül" :
        //                     monthNumber == 10 ? "Ekim" :
        //                     monthNumber == 11 ? "Kasım" : "Aralık";
        // Console.WriteLine($"Ay adı: {monthName}");

        // Console.Clear();
        // Console.Write("Lütfen geçerli bir tarih giriniz(gg.aa.yyyy): ");
        // string input = Console.ReadLine();
        // if (DateTime.TryParse(input, out DateTime inputDate))
        // {
        //     int monthNumber = inputDate.Month;
        //     string monthName = monthNumber == 1 ? "Ocak" :
        //                         monthNumber == 2 ? "Şubat" :
        //                         monthNumber == 3 ? "Mart" :
        //                         monthNumber == 4 ? "Nisan" :
        //                         monthNumber == 5 ? "Mayıs" :
        //                         monthNumber == 6 ? "Haziran" :
        //                         monthNumber == 7 ? "Temmuz" :
        //                         monthNumber == 8 ? "Ağustos" :
        //                         monthNumber == 9 ? "Eylül" :
        //                         monthNumber == 10 ? "Ekim" :
        //                         monthNumber == 11 ? "Kasım" : "Aralık";
        //     Console.WriteLine($"Ay adı: {monthName}");
        //     // Console.WriteLine($"Orjinal Ay Adı: {inputDate.ToString("MMMM")}");
        // }
        // else
        // {
        //     Console.WriteLine("Geçersiz tarih formatı!");
        // }
        #endregion

        #region Switch
        // switch (monthNumber)
        // {

        //     default:
        // }

        //Kullanıcıdan alınan 0-100 arasındaki puanın geçer not olup olmadığına bakıp(50 ve üstü geçer not), ekrana Geçti ya da Kaldı yazdıran kodu hazırlayalım.
        // Console.Write("1-100 arasında puanı giriniz: ");
        // byte point = byte.Parse(Console.ReadLine());
        // string resultMessage;
        // switch (point)
        // {
        //     case >= 50:
        //         resultMessage = "Geçti";
        //         break;
        //     default:
        //         resultMessage = "Kaldı";
        //         break;
        // }
        // Console.WriteLine($"Sonuç: {resultMessage}");

        /*
            0-44: 1
            45-54:2
            55-69:3
            70-84:4
            85-100:5
        */
        // Console.Clear();
        // string result;
        // Console.Write("1-100 arasında puanı giriniz: ");
        // string point = Console.ReadLine();
        // if (byte.TryParse(point, out byte pointResult))
        // {
        //     switch (pointResult)
        //     {
        //         case <= 0 or > 100:
        //             result = "Lütfen 1-100 aralığında bir puan girin!";
        //             break;
        //         case < 45:
        //             result = "1";
        //             break;
        //         case < 55:
        //             result = "2";
        //             break;
        //         case < 70:
        //             result = "3";
        //             break;
        //         case < 85:
        //             result = "4";
        //             break;
        //         default:
        //             result = "5";
        //             break;
        //     }
        // }
        // else
        // {
        //     result = "Lütfen 1-100 aralığında sayısal bir değer giriniz!";
        // }
        // Console.WriteLine(result);

        //Girilen bir tarihin hafta içine mi yoksa hafta sonuna mı denk geldiğini tespit edip ekrana "Hafta içi" ya da "Hafta sonu" şeklinde bir mesaj yazdıran programı hazırlayınız.
        // Console.Clear();
        // Console.Write("Lütfen bir tarih giriniz(gg.aa.yyyy): ");
        // string inputString = Console.ReadLine();
        // bool isConvertStatus = DateTime.TryParse(inputString, out DateTime inputDate);
        // //if içndeki (isConvertStatus), isConvertStatus==true ile aynı. Eğer isConvertStatus==false denmek istenirse !isConvertStatus kullanılır
        // string result;
        // if (isConvertStatus)
        // {
        //     DayOfWeek dayOfWeek = inputDate.DayOfWeek;
        //     switch (dayOfWeek)
        //     {
        //         case DayOfWeek.Saturday:
        //         case DayOfWeek.Sunday:
        //             result = "Hafta sonu";
        //             break;
        //         default:
        //             result = "Hafta içi";
        //             break;
        //     }
        //     Console.WriteLine(result);
        // }


        /*
            Kullanıcıdan 1-12 arasında ay bilgisi alan ve bu ay bilgisine bakarak hangi mevsimde olduğumuzu tespit edip konsola bunu sonuç olarak yazdıran programı switch ile hazırlayınız.

            Lütfen ay bilgisini giriniz(1-12): 1
            Mevsim: Kış
        */


        Console.Clear();
        string result;
        Console.Write("Lütfen ay numarasını giriniz(1-12): ");
        string monthNumberString = Console.ReadLine();
        if (byte.TryParse(monthNumberString, out byte monthNumber))
        {
            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    result = "Kış";
                    break;
                case 3:
                case 4:
                case 5:
                    result = "İlkbahar";
                    break;
                case 6:
                case 7:
                case 8:
                    result = "Yaz";
                    break;
                case 9:
                case 10:
                case 11:
                    result = "Sonbahar";
                    break;
                default:
                    result = "HATA: 1-12 arasında bir ay numarası giriniz!";
                    break;
            }
        }
        else
        {
            result = "Hatalı veri girişi!";
        }
        Console.WriteLine(result);
        #endregion
    }
}
