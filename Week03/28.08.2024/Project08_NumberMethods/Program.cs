namespace Project08_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        // int a = 14;
        // int b = 2;
        // int result;

        // result = a + b;
        // result = a - b;
        // result = a * b;
        // result = a / b;
        // result = a % b; //mod

        // result = Math.Abs(-5);
        // result = (int)Math.Pow(2, 8);

        // double result2;
        // result2 = Math.Sqrt(15);

        // result2 = Math.Round(7.76);
        // result2 = Math.Ceiling(7.05);
        // result2 = Math.Floor(7.99);


        // Console.Clear();
        // Console.WriteLine(result2);

        Random rnd = new Random();
        int randomNumber = rnd.Next();
        randomNumber = rnd.Next(10); //10 hariç
        randomNumber = rnd.Next(5, 10); //20 hariç

        Console.Clear();
        Console.WriteLine(randomNumber);
    }
}
