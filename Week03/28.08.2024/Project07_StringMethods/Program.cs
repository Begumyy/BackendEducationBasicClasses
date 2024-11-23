// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


 //DateTime firstDayOfNextYear = new DateTime(DateTime.Now.Year + 1, 1, 1);
 namespace Project07_StringMethods;

 class Program
 {
    static void Main(string[] args)
    {
        // string fullName="yusuf Ziya KELKİT";
        // int uzunluk = fullName.Length;
        // Console.WriteLine(uzunluk);
        // Console.WriteLine(fullName.ToLower());
        // Console.WriteLine(fullName.ToUpper());

        // string address1="Yeni Umut Sitesi F Blok";
        // string address2="No:18 D.9";
        // string district="Kadıköy";
        // string province ="İstanbul";

        // string fullAddress1= address1 + " " + address2 +" " + district + " / " + province;
        // Console.WriteLine(fullAddress1);


        // string fullAddress2= String.Concat(address1," ", address2, " ", district, "/",province);
        // Console.WriteLine( fullAddress2);

        // string fullAddress3 = $"{address1} {address2} {district}/{province}";
        // Console.WriteLine(fullAddress3);


        // string fullAddress4 = String.Format("{0} {1} {2}/{3}",address1,address2,district,province);
        // Console.WriteLine(fullAddress4);


        //Örnek:
        string text1 = "Nişantaşı";
        string text2="Üniversitesi";
        string oldLocation ="Bayrampaşa";
        string currentLocation ="Sarıyer";
        string date1="09.09.2009";
        string date2 = "05.05.2018";

        //Hedef:
        /*
             Nişantaşı Üniversitesi, 09.09.2009 tarihinde İstanbul'un Bayrampaşa ilçesinde faaliyetlerine başladı. Ardından 05.05.2018 tarihinde yine İstanbul'un sSarıyer ilçesinde kurulan TechCampus'e taşındı.
        */
        
        // //Çözüm1
        // string result1 = text1 + " " + text2 + " ," + date1 + " tarihinde İstanbul'un " + oldLocation  + " ilçesinde faaliyetlerine başladı. Ardından " + date2 + " tarihinde yine İstanbul'un " + currentLocation + " ilçesinde kurulan TechCamppus'e taşındı.";
        // Console.WriteLine(result1);

        // //Çözüm2
        // string result2 = String.Concat(text1, ", ", date1, " tarihinde İstanbul'un ", oldLocation, " ilçesinde faaliyetlerine başladı. Ardından ", "TechCampus'e taşındı. ");
        // Console.WriteLine(result2);


        // //Çözüm3
        // string result3=$"{text1} {text2}, {date1} tarihinde İstanbul'un {oldLocation} ilçesinde kurulan TechCampus'e taşındı.";
        // Console.WriteLine(result3);

         

        //Çözüm4 SİZE BIRAKIYORUMM!!



        string fullName="yusuf Ziya KELKİT";
        string searchText ="u";
        //bool response =fullName.Contains(searchText);
        bool response = fullName.ToLower().Contains(searchText.ToLower());
        Console.WriteLine(response);


        string firstName ="Begüm";
        int index = firstName.IndexOf("g");
        Console.WriteLine(index);


        Console.Clear();
        // string firstName1="Umay";
        // Console.WriteLine(firstName1.StartsWith("U"));
        // Console.WriteLine(firstName1.EndsWith("U"));

        // string courseName ="FullStack Web Developer Eğitimi";
        // courseName = courseName.Replace("FullStack", "Tam Donanımlı");
        // courseName = courseName.Replace("e","X");
        // Console.WriteLine(courseName);

        // string message = "İstanbul'un Sarıyer'inin en güzel yeri.";
        // message = message.Replace("'", "");
        // Console.WriteLine(message);

        // string text = "AspNetCore Yazılım Uzmanlığı Eğitimi";
        // // Console.WriteLine(text.Substring(8, 7));
        // Console.WriteLine(text.Substring(0, text.IndexOf(" ")));
    }
 }