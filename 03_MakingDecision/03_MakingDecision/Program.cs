using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If else


            //EXERCİSE1

            //Console.WriteLine("Please enter the password");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abc")
            //{

            //    Console.WriteLine("şifre doğru");

            //}

            //else
            //{
            //    Console.WriteLine("şifre yanlıl");
            //}

            //EXERCİSE2

            //string capital, county;
            //Console.WriteLine("Enter capital ;");

            //capital = Console.ReadLine();
            //Console.WriteLine("enter country ;");
            //county = Console.ReadLine();

            //if (capital == "ankara" && county == "turkey")
            //{

            //    Console.WriteLine("Matching");

            //}

            //else {
            //    Console.WriteLine(" Not Matching ");


            // 

            //EXERCİE3

            //Console.WriteLine("Please enter the 1.number");
            //int number1 = int.Parse(Console.ReadLine());


            //Console.WriteLine("Please enter the 2.number");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine(result);


            // exercise4

            //Console.WriteLine("ENTER NUMBER");

            //int NUMBER = Console.ReadLine();

            //if (NUMBER % 2 == 0)
            //{

            //    Console.WriteLine("The number equal");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}









            #endregion

            #region Sampe Project Application

            Console.WriteLine("****** Reaturant Menü*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1-Main courses");
            Console.WriteLine("2-Soups");
            Console.WriteLine("3-Pizzas");
            Console.WriteLine("4-Drinks");
            Console.WriteLine("5-Desert");
            Console.WriteLine("****************************");

            string manuItem;

            Console.WriteLine("Detayı Görmek İstediğiniz Menü Seçimi: ");
            manuItem = Console.ReadLine();

            if (manuItem == "2")
            {


                Console.WriteLine(" --- Soups ---");
                Console.WriteLine("Ezogelin");
                Console.WriteLine("Yayla");
                Console.WriteLine("Tarhana");
                Console.WriteLine("Domates");

            }

            if (manuItem == "1")
            {


                Console.WriteLine(" --- Main Course ---");
                Console.WriteLine("kıymalı yumurta");
                Console.WriteLine("makarna");
                Console.WriteLine("tavuk");
                Console.WriteLine("et");

            }

            if (manuItem == "3")
            {


                Console.WriteLine(" --- Piazzas ---");
                Console.WriteLine("kıymalı yumurta");
                Console.WriteLine("makarna");
                Console.WriteLine("tavuk");
                Console.WriteLine("et");

            }

            if (manuItem == "4")
            {


                Console.WriteLine(" ---Drinks ---");
                Console.WriteLine("kıymalı yumurta");
                Console.WriteLine("makarna");
                Console.WriteLine("tavuk");
                Console.WriteLine("et");

            }

            if (manuItem == "5")
            {


                Console.WriteLine(" --- Desert ---");
                Console.WriteLine("kıymalı yumurta");
                Console.WriteLine("makarna");
                Console.WriteLine("tavuk");
                Console.WriteLine("et");

            }



            #endregion




            Console.Read();
        }

    }
}
