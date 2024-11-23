namespace Project05_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
         #region ImplicitConvert
            byte number1 =123;
            int number2=number1;

            float number =123.45f;
            double number4=number1;

            int number5=4556;
            float number6=number5;
         #endregion

         #region ExplicitConvert
            float number7=456.5f;
            int number8=(int)number7; //casting (cast etme)

            long number9 =446564564L;
            int number10= (int)number9;

            int number11 =255;
            byte number12=(byte)number11;
            //Console.WriteLine(number12);


            //Boxing-Unboxing
            int number13=123;
            object boxedNumber13= number13;//Boxing

            object number14=123;
            int unboxedNumber14=(int)number14;//Unboxing

             //Convert
             string number15String ="123";
             int convertedNumber15= Convert.ToInt32(number15String);
             Console.Write(convertedNumber15 + 4);

             bool isDeleted =true;
             string isDeletedString =Convert.ToString(isDeleted);
             Console.Write(isDeletedString);

             //Parse-TryParse
             string age = "45";
             int parsedAge = int.Parse(age);

             string doubleString ="123.45";
             double parsedDouble;
             bool result = double.TryParse(doubleString, out parsedDouble);
             if(result == true)
             {
                Console.WriteLine(parsedDouble);
             }
             else
             {
                  Console.WriteLine("Bir hata oluştu");
             }
         #endregion

        
    }
}
