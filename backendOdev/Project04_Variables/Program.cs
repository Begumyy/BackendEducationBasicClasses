namespace Project04_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region Intro
      /*int age;
       age=37;
       Console.WriteLine(age);*/

    //    int age=49;
    //    Console.WriteLine(age);
        #endregion

        #region Değer Tipleri(Value Types)
        /*
        yukarıda söz edilen tüm tipler Value Types olarak adlandırılır.
          */  
        #endregion

        #region TamSayılar(Integers)
            sbyte number1= -34; // 8 bir işaretli tam sayılar -128 - +127
            byte studentPoint = 255; //bellekte 8 bit yer kaplar. 0- 255 arasındaki işaretsiz tam sayıları tutar.
            short number2=5000;
            ushort number3= 50000;
            int number4=214000000;
            uint number5 = 200000000;
            long number6 = 323155654534685;
            ulong number7=5468456487845486885;
        #endregion

        #region OndalıklıSayılar(Decimal)

            float number8=34.8f;
            double number9=59.8; //59.8d şeklinde de yazılabilir. Büyük küçük harf farketmez.
            decimal number10=54.8m;   
        #endregion

        #region Diğer Tipler
        char char1='b';
        bool isActive=false;    
        #endregion

        #region Reference Types
           string firstName="Begüm Yünkül";
           Console.WriteLine(firstName);
           object object1="Begüm"; 
        #endregion
    }
}
