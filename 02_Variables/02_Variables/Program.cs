using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   Double Değişkenler

            //double number;

            //number = 4.56;  // . koyarsan virgül olarak konsol ekranın yansıtır

            //Console.WriteLine(number);



            //Console.WriteLine("*********Fiyat Listesi ******");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;


            //applePrice = 10.2;
            //orangePrice = 20.34;
            //strawberryPrice = 12.33;
            //potatoPrice = 23.323;
            //tomatoPrice = 12.34;


            //Console.WriteLine("-----Elma birim fiyat : " + applePrice);
            //Console.WriteLine("-----Portakal birim fiyat : " + orangePrice);
            //Console.WriteLine("-----Çilek birim fiyat : " +  strawberryPrice);
            //Console.WriteLine("-----Patates birim fiyat : " + potatoPrice);
            //Console.WriteLine("-----Domates birim fiyat : " + tomatoPrice);

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.234;
            //orangeGram = 1.234;
            //strawGram = 1.234;
            //potatoGram = 1.234;
            //tomatoGram = 1.234;

            //double appleTotalPrice = appleGram * applePrice;
            //double orageTotalPrice = orangeGram * orangePrice;
            //double strawbarryTotalPrice = strawGram * strawberryPrice;
            //double potatosTotalPrice = potatoGram * potatoPrice;
            //double tomatosTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün Tutarı - " + "Birim Fiyatı : " + applePrice "" + appleGram + " - Toplam Tutar " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün Tutarı - " + "Birim Fiyatı : " + orangePrice "" + orangeGram + " - Toplam Tutar " + orageTotalPrice);
            //Console.WriteLine("Alınan Ürün Tutarı - " + "Birim Fiyatı : " + strawbarryTotalPrice "" + strawGram + " - Toplam Tutar " + strawbarryTotalPrice);  
            //Console.WriteLine("Alınan Ürün Tutarı - " + "Birim Fiyatı : " + potatoPrice "" + potatoGram + " - Toplam Tutar " + potatosTotalPrice);  
            //Console.WriteLine("Alınan Ürün Tutarı - " + "Birim Fiyatı : " + tomatoPrice "" + tomatoGram + " - Toplam Tutar " + tomatosTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orageTotalPrice + strawbarryTotalPrice + potatosTotalPrice + tomatosTotalPrice;

            //Console.WriteLine(shoppingTotalPrice);



            #endregion


            #region Char değişkenler

            //Sezar şifreleme her harfin 3 sonrakinin yerine yazıyor.A yerine c yazıyor

            // cha değişkenler tek tırnak ' '


            //char symbol;

            //symbol = 'b';

            //Console.WriteLine(symbol);

            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi ******");

            //Console.WriteLine();

            //// ctrl f oka tıklarsan ilk bulmak istetidiğin şey sonra değiştirmek istediğin şeyi yazıp hesini aynı anda değiştirebilisin

            //String passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentitiyNumber;

            //Console.Write("Yolcı Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Soyadı Adı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi  : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi  : ");
            //passengerCity = Console.ReadLine();


            //Console.Write("Yaş Bilgisi  : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Bilgisi : ");
            //passengerIdentitiyNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");

            //Console.WriteLine(" Yolcu Tc : " + passengerIdentitiyNumber + "    Yolcu Adi Soyadı : " + passengerName + " " + passengerSurname + "  " + passengerDistrict + " / " + passengerCity + " " + passengerAge  );


            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 3000;
            //tvPrice = 4000;

            //int shoeCount, computerCount, chairCount, tvCount;


            //// c# başlangıçta bütün veri girişlerini STRİNG KABUL EDER

            //Console.Write("Ayakkabı sayısını girin : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar sayısını girin : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye Sayısını girin : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("TV Sayısını girin : ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoeCount * shoePrice + computerPrice*+computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine("Toplam ücret : " + totalPrice);









            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2 ,result ;

            //Console.Write("1.sınav not : ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("2.sınav not :");
            //exam2 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2) / 2;

            //Console.WriteLine("Sınav Ortalaması :  " + result);






            #endregion


            #region Kavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Cinsiyet Seç ");
            //gender = char.Parse(Console.ReadLine()); 

            //Console.WriteLine(gender);





            #endregion




            Console.Read();

        }
    }
}
