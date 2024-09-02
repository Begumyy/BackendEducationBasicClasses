namespace _01_string_methods_homework;

class Program
{
    static void Main(string[] args)
    {
        #region hw1
            // Kullanıcıdan cümle alma
        //Console.WriteLine("Bir cümle girin:");
        //string cumle = Console.ReadLine();

            // Cümledeki kelime sayısını bulma
        //int kelimeSayisi = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            // Sonucu ekrana yazdırma
        //Console.WriteLine($"Girdiğiniz cümledeki kelime sayisi: {kelimeSayisi}");
        #endregion

       #region hw2
            // Kullanıcıdan metin alma
        //Console.WriteLine("Bir metin girin:");
        //string metin = Console.ReadLine();

             // Metni tüm harfleri büyük ve küçük hale getirme
        //string buyukHarfliMetin = metin.ToUpper();
        //string kucukHarfliMetin = metin.ToLower();

              // Sonuçları alt alta tek bir Console.Write ile yazdırma
        //Console.Write($"{buyukHarfliMetin}\n{kucukHarfliMetin}");
       #endregion

        #region hw3
            // Kullanıcıdan cümle alma
        //Console.WriteLine("Bir cümle girin:");
        //string cumle1 = Console.ReadLine();

           // Kullanıcıdan aranacak kelimeyi alma
        //Console.WriteLine("Aranacak kelimeyi girin:");
        //string kelime = Console.ReadLine();

            // Cümleyi kelimelere ayırma
        //string[] kelimeler = cumle1.Split(' ', StringSplitOptions.RemoveEmptyEntries);

             // Aranan kelimenin kaç kez geçtiğini sayma
        //int kelimeSayisi1 = 0;
        /*foreach (string k in kelimeler)
        {
            if (k.Equals(kelime, StringComparison.OrdinalIgnoreCase))
            {
                kelimeSayisi1++;
            }
        }*/

             // Sonucu ekrana yazdırma
        //Console.WriteLine($"'{kelime}' kelimesi cümlede {kelimeSayisi1} kez geçiyor.");
        #endregion

        #region hw4
            // Kullanıcıdan cümle alma
        //Console.WriteLine("Bir cümle girin (başında ve sonunda boşluklar olabilir):");
        //string cumle = Console.ReadLine();

            // Başındaki ve sonundaki boşlukları kaldırma
        //string trimliCumle = cumle.Trim();

            // Sonucu ekrana yazdırma
        //Console.WriteLine($"Düzeltilmiş cümle: '{trimliCumle}'");
        #endregion
     
         #region hw5
            // Kullanıcıdan ana metni alma
        //Console.WriteLine("Ana metni girin:");
        //string anaMetin = Console.ReadLine();

            // Kullanıcıdan aranacak metni alma
        //Console.WriteLine("Aranacak metni girin:");
        //string aranacakMetin = Console.ReadLine();

            // Aranacak metni ana metinde arama
        //int indeks = anaMetin.IndexOf(aranacakMetin, StringComparison.OrdinalIgnoreCase);

            // Sonucu ekrana yazdırma
        /*if (indeks >= 0)
        {
            Console.WriteLine($"Aranan metin ilk olarak {indeks} indeksinde bulunuyor.");
        }
        else
        {
            Console.WriteLine("Aranan metin ana metinde bulunamadı.");
        }*/
         #endregion
        

    }
}
