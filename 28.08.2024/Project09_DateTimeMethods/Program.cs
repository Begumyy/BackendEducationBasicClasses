namespace Project09_DateTimeMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Today);
        DateTime birthDay = new DateTime(1975, 7, 16);
        Console.WriteLine(birthDay);
        Console.Clear();

        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToLongTimeString());

        Console.Clear();
        int year = birthDay.Year;
        Console.WriteLine(year);
        int month = birthDay.Month;
        Console.WriteLine(month);
        int day = birthDay.Day;
        Console.WriteLine(day);

        Console.Clear();
        TimeSpan span = now.Subtract(birthDay);
        Console.WriteLine(Math.Round(span.TotalDays));

        Console.Clear();
        DateTime orderDate = new DateTime(2024, 7, 3);
        DateTime checkoutDate = orderDate.AddDays(5);
        Console.WriteLine(checkoutDate);

        Console.Clear();
        DateTime orderDate2 = new DateTime(2024, 5, 5);
        DateTime checkoutDate2 = orderDate2.AddDays(3);
        TimeSpan delayDay = now.Subtract(checkoutDate2);
        Console.WriteLine($"Ödemeniz {Math.Floor(delayDay.TotalDays)} gün gecikmiştir.");

        Console.Clear();
        //Gelecek yılın ilk gününün tarihini ekrana 1 Ocak 2025 Çarşamba formatında yazdıran kodu hazırlayınız.
        DateTime today = DateTime.Today;//28.08.2024 (1.01.2025)
        int nextYear = today.Year + 1; //2025
        DateTime nextYearFirstDay = new DateTime(nextYear, 1, 1);
        Console.WriteLine(nextYearFirstDay.ToLongDateString());
    }
}
