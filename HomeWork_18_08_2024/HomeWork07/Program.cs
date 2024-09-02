namespace HomeWork07;

class Program
{
    static void Main(string[] args)
    {
        // int tipinde bir değişken oluşturuldu ve büyük bir sayı atandı
        int intDeger = 1000000;

        // Bu değeri byte tipine dönüştürmeye çalış
        // Dönüştürme işlemi tehlikeli olabilir, bu yüzden önce sınırları kontrol edelim
        byte byteDeger;

        try
        {
            byteDeger = checked((byte)intDeger);
            Console.WriteLine("Byte değerinin karşılığı: " + byteDeger);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Dönüştürme hatası: " + ex.Message);

            //??????????????
        }
    }
}
