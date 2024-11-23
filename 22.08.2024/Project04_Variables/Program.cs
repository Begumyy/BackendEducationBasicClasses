namespace Project04_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region Intro
        /*int age;
        age=37;
        Console.WriteLine(age);*/

        // int age =49;
        // Console.WriteLine(age);
        #endregion

        #region TamSayilar(Integers)
        sbyte number1= 34; // 8 bir işaretli tam sayılar -128 - +127
           byte studentPoint=76; //bellekte 8 bit yer kaplar. 0-255 arasındaki işaretsiz tam sayıları tutar.
           short  number2=-5000;
           ushort number3=50000;
           int number4 = 214000000;
           uint number5= 20000000;
           long number6=5654654645654654;
           ulong number7=65676576576576577;
        #endregion

        #region OndalikliSayilar(Decimal)
            float number8= 34.8f;
            double number9=59.8; //59.8d şeklinde de yazılabilir. Büyük küçük harf farketmez.
            decimal number10=54.8m;
        #endregion

        #region DiğerTipler
            char char1='f';
            bool isActive=true;
        #endregion

        #region ReferansTipleri(ReferenceTypes)
           string firstName= "Begüm Yünkül";
           Console.WriteLine(firstName);
           object object1=5453;
        #endregion
    }
}
