using System.Security.Cryptography;

namespace VariablesSamples;

class Program
{
    static void Main(string[] args)
    {
        #region Sample1
            // int number1=10;
            // int number2=5;

            // Console.WriteLine(number1 + number2);
            // Console.WriteLine(number1 - number2);
            // Console.WriteLine(number1 * number2);
            // Console.WriteLine(number1 / number2);
            // Console.WriteLine(number1 % number2);
        #endregion

        #region Sample2
            // string word1="Bugün";
            // string word2="hava";
            // string word3="çok";
            // string word4="güzel";
            // //Bugün hava çok güzel.
            // string sentence = word1 + " " + word2 + " " + word3 + " " + word4 + "."; //Bugün hava çok güzel.
            // Console.WriteLine(sentence);
        #endregion

        #region Sample3
            // Console.WriteLine($"int => Min: {int.MinValue}");
            //  Console.WriteLine($"int => Max: {int.MaxValue}");

            //  byte maxByte = byte.MaxValue;
            //  Console.WriteLine(maxByte);
        #endregion

        #region Sample4
            // float f= 0.1f + 0.2f;
            // double d=0.1 + 0.2;
            // decimal m = 0.1m + 0.2m; 
            // Console.WriteLine($"float:{f}");
            // Console.WriteLine($"double:{d}");
            //  Console.WriteLine($"decimal:{m}");
        #endregion

        #region Sample5
            // double number1 =10.5;
            // double number2 =20.3;
            // char op ='+';

            // double result = op switch
            // {
            //     '+'=> number1+number2,
            //     '-'=> number1-number2,
            //     '*'=> number1*number2,
            //     '/'=> number1/number2,
            //     _ => throw new ArgumentException("Geçersiz işlem!")
            // };
            // Console.WriteLine($"{number1} {op} {number2} = {result}");
        #endregion

        #region Sample6
        Console.Write("1.Sayı: ");
        int number1=int.Parse(Console.ReadLine());
         Console.Write("2.Sayı: ");
         int number2=int.Parse(Console.ReadLine());
         Console.Write("İşleminizi giriniz (+,-,*,/)");
         char op= char.Parse(Console.ReadLine());
            double result = op switch
            {
                '+'=> number1+number2,
                '-'=> number1-number2,
                '*'=> number1*number2,
                '/'=> number1/number2,
                _ => throw new ArgumentException("Geçersiz işlem!")
            };
            Console.WriteLine($"{number1} {op} {number2} = {result}");
        #endregion
    }
}
