namespace _03_datetime_methods_homework;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        #region hw1
                 // Kullanıcıdan tarih bilgisi alma
        //Console.WriteLine("Lütfen bir tarih girin (yyyy-MM-dd formatinda):");
        //string tarihInput = Console.ReadLine();

                // Tarihi DateTime türüne dönüştürme
        //DateTime tarih;
        /*if (DateTime.TryParseExact(tarihInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out tarih))
        {
                // Haftanın gününü al
            DayOfWeek gun = tarih.DayOfWeek;

                // Haftanın gününü ekrana yazdırma
            Console.WriteLine($"Girdiğiniz tarih {gun} gününe denk geliyor.");
        }
        else
        {
                  // Geçersiz tarih formatı
            Console.WriteLine("Geçersiz tarih formati. Lütfen yyyy-MM-dd formatinda bir tarih girin.");
        }*/
        #endregion
        

        #region hw2
            // Şu anki tarihi ve saati al
        //DateTime simdikiTarihVeSaat = DateTime.Now;

            // Tarih ve saati ekrana yazdır
        //Console.WriteLine($"Şu anki tarih ve saat: {simdikiTarihVeSaat}");
        #endregion

        #region hw3
            // Kullanıcıdan tarih bilgisi alma
        //Console.WriteLine("Lütfen bir tarih girin (yyyy-MM-dd formatında):");
        //string tarihInput = Console.ReadLine();

             // Tarihi DateTime türüne dönüştürme
        //DateTime tarih;
        /*if (DateTime.TryParseExact(tarihInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out tarih))
        {
                 // Kullanıcıdan gün sayısı alma
            Console.WriteLine("Kaç gün eklemek istersiniz?");
            int gunSayisi;
            if (int.TryParse(Console.ReadLine(), out gunSayisi))
            {
                      // Gün sayısını ekleme
                DateTime yeniTarih = tarih.AddDays(gunSayisi);

                      // Yeni tarihi ekrana yazdırma
                Console.WriteLine($"Yeni tarih: {yeniTarih:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Geçersiz gün sayısı.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen yyyy-MM-dd formatında bir tarih girin.");
        }*/
        #endregion

        #region hw4
            // Kullanıcıdan ilk tarih bilgisi alma
        //Console.WriteLine("Lütfen ilk tarihi girin (yyyy-MM-dd formatında):");
        //string ilkTarihInput = Console.ReadLine();

             // İlk tarihi DateTime türüne dönüştürme
        //DateTime ilkTarih;
        /*if (DateTime.TryParseExact(ilkTarihInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ilkTarih))
        {
                // Kullanıcıdan ikinci tarih bilgisi alma
            Console.WriteLine("Lütfen ikinci tarihi girin (yyyy-MM-dd formatında):");
            string ikinciTarihInput = Console.ReadLine();

                 // İkinci tarihi DateTime türüne dönüştürme
            DateTime ikinciTarih;
            if (DateTime.TryParseExact(ikinciTarihInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ikinciTarih))
            {
                     // İki tarih arasındaki gün farkını hesaplama
                TimeSpan tarihFarki = ikinciTarih - ilkTarih;
                int gunFarki = Math.Abs(tarihFarki.Days);

                     // Gün farkını ekrana yazdırma
                Console.WriteLine($"İki tarih arasındaki gün farkı: {gunFarki} gün.");
            }
            else
            {
                Console.WriteLine("Geçersiz ikinci tarih formatı. Lütfen yyyy-MM-dd formatında bir tarih girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz ilk tarih formatı. Lütfen yyyy-MM-dd formatında bir tarih girin.");
        }*/
        #endregion

        #region hw5
            //Console.WriteLine("Tarihi (gün.ay.yıl) formatında giriniz:");
        //string input = Console.ReadLine();

                 // Tarih formatını kontrol ediyoruz ve geçerli mi diye bakıyoruz
        //DateTime date = DateTime.TryParse(input, out DateTime validDate) ? validDate : DateTime.MinValue;

        /*if (date != DateTime.MinValue)
        {
                  // Yılın kaçıncı günü olduğunu hesaplıyoruz
            int dayOfYear = date.DayOfYear;
            Console.WriteLine($"Girilen tarih, yılın {dayOfYear}. günüdür.");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı!");
        }*/
        #endregion

        #region hw6
       /*  DateTime time = DateTime.Now;
            bool leap = DateTime.IsLeapYear(time.Year);
            string a = leap ? "artık yıl" : "artık yıl değildir";
            Console.WriteLine(a); */



       /*  Console.WriteLine("Bir yıl giriniz:");
        string input = Console.ReadLine();

        // Kullanıcıdan alınan yılın geçerli bir sayı olup olmadığını kontrol ediyoruz
        bool isNumeric = int.TryParse(input, out int year);

        if (isNumeric && year > 0)
        {
            // Artık yıl kontrolü yapıyoruz
            bool isLeapYear = DateTime.IsLeapYear(year);
            string result = isLeapYear ? $"{year} bir artık yıldır." : $"{year} bir artık yıl değildir.";

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Geçersiz yıl girdisi!");
        } */

        #endregion

        #region hw7
           /*  Console.WriteLine("Tarihi 'dd/MM/yyyy' formatında giriniz:");
        string input = Console.ReadLine();

        // Belirli bir tarih formatını kullanarak girdiği tarihi DateTime'a çevirmek için
        DateTime date;
        bool isValid = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

        if (isValid)
        {
            // Geçerli bir tarihse DateTime nesnesini ekrana yazdırıyoruz
            Console.WriteLine("Girdiğiniz tarih: " + date.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı! Lütfen 'dd/MM/yyyy' formatında bir tarih giriniz.");
        } */
        #endregion

        #region hw8
     /*        // Şu anki tarihi alıyoruz
        DateTime currentDate = DateTime.Now;

        // Ay adını alıp ekrana yazdırıyoruz
        string monthName = currentDate.ToString("MMMM");

        Console.WriteLine("Şu anki ay: " + monthName); */
    }
        #endregion

        
}