using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args )

        {


            #region Yadırma Komutları

            //Console.WriteLine("Merhaba Dünya ");

            // Console.WriteLine("----------Yemek Listesi---------");
            //Console.WriteLine();
            // Console.WriteLine("1-Çorba");
            //  Console.WriteLine( "2-salata");

            #endregion

            #region  String Değişkenler

            // string name;
            //name = "Baran";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone, customerEmail;
            //string City;

            //customerName = "Baran";
            //customerSurname = "Öner";
            //customerPhone = " 234234234";
            //customerEmail = "barann0ner@gmail.com";
            //City = "İstanbul";

            //Console.WriteLine("*******Rezervasyon Kartıı*****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + ""  +customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);







            #endregion


            #region

            //int number = 24;
            // Console.WriteLine(number);

            int hamburger = 300;
            int pizza = 200;
            int coke = 30;
            int water = 23;

            Console.WriteLine("----------------Menü Fiyatları---------------");
            Console.WriteLine();
            Console.WriteLine("----------Hamburger " + hamburger + "TL");
            Console.WriteLine("----------Pizza:" + pizza + "TL");
            Console.WriteLine("----------Kola :" + coke + "TL");
            Console.WriteLine("----------Water " + water+ "TL");

            Console.WriteLine();

            int HamburgerCount;
            int cokeCount;
            int waterCount;
            int pizzaCount;

            int totalPrice = 0;

            HamburgerCount = 3;
            cokeCount = 3;
            waterCount =2;
            pizzaCount = 6;

            int totalHamburgerPrice = HamburgerCount * hamburger;
            int totalCokePrice = cokeCount * coke;
            int totalPizzaPrice = pizzaCount * pizza;
            int totalWaterPrice = waterCount *water;



            Console.WriteLine(" Hamburger Tutarı : " +  totalHamburgerPrice +"TL");
            Console.WriteLine(" Pizza Tutarı : " + totalPizzaPrice + "Tl");
            Console.WriteLine(" Coke Tutarı : " + totalCokePrice + "Tl");
            Console.WriteLine(" Water Tutarı : " + totalWaterPrice + "Tl");


            totalPrice = totalCokePrice + totalHamburgerPrice + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine();
            Console.WriteLine( "Toplam Fiyat : " + totalPrice);







            #endregion





            Console.Read();
        }
    }
}
