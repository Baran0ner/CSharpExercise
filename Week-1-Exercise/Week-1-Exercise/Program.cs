using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region  String




            //string firstName = "Ahmet";
            //string city = "Karabuk";



            //Console.WriteLine(firstName.ToUpper());
            //Console.WriteLine(firstName.ToLower());
            //Console.WriteLine(firstName.Substring(3));
            //Console.WriteLine(firstName.IndexOf("hm"));
            //Console.WriteLine(city.LastIndexOf("k"));
            //Console.WriteLine(firstName.Contains("me"));
            //Console.WriteLine(city.Replace("a", "*"));
            //Console.WriteLine(city.Length);
            //Console.WriteLine(city.Remove(2));
            //Console.WriteLine(city.StartsWith("Ka"));
            //Console.WriteLine(city.EndsWith("uk"));
            //Console.WriteLine(city.Equals("Karabuk"));
            //Console.WriteLine(city.Insert(1, "--"));

            ////split
            //string names = "ahmet,mehmet,ali";
            //string[] namesArray = names.Split(',');
            //for (int i = 0; i < namesArray.Length; i++)
            //    Console.WriteLine(namesArray[i]);


            //Console.ReadLine();




            #endregion  String


            #region Array Definition

            //string[] names = new string[5];

            //string[] cars = { "Volco", "Bnw", "Ford", "Mazda" };

            //int[] myNum = { 10, 20, 30, 45 };



            //Console.WriteLine("The First Car : " + cars[0]);
            //Console.WriteLine("The Second Number : " + myNum[0]);

            //Console.WriteLine("You have " + cars.Length + " Cars");

            //for (int i = 0; i < cars.Length; i++)
            //    Console.WriteLine("Car[" + i.ToString() + "] = " + cars[i]);

            //foreach (string car in cars)
            //    Console.WriteLine(car);




            //int[] randomNumbers = new int[5];
            //Random rnd = new Random();
            //for (int i = 0; i < randomNumbers.Length; i++)
            //    randomNumbers[i] = rnd.Next(0, 101);

            //foreach (int numb in randomNumbers)
            //    Console.WriteLine(numb);




            #endregion


            #region If

            // Console.Write("Age :");

            //int age =int.Parse(Console.ReadLine());

            // if (age >= 18)
            //     Console.WriteLine("Welcome");
            // else
            // {
            //     Console.WriteLine("You can only get in with your parents.");
            // }




            // Console.WriteLine("Grade :");

            // int grade = int.Parse(Console.ReadLine());

            // if (grade >= 75)
            //     Console.WriteLine("A");
            // else if (grade >= 50)
            //     Console.WriteLine("B");
            // else if (grade >= 25)
            //     Console.WriteLine("C");
            // else
            //     Console.WriteLine("D");




            #endregion


            #region For


            // ///
            //string[] names = { "baran", "buse ", "james", "juilan" };

            //int maxLength = 0;

            //string longestName = "";

            //for (int i = 0; i < names.Length; i++)
            //{

            //    if (names[i].Length > maxLength)

            //        maxLength = names[i].Length;
            //    longestName = names[i];


            //    Console.WriteLine("Max Lenght : " + maxLength);
            //    Console.WriteLine("Longest Name : " + longestName);


            //}

            ///// exmaple
            //string[] namess = { "baran", "buse ", "james", "juilan" };

            //for (int i = namess.Length - 1; i >= 0; i--) { 

            //     Console.WriteLine("names [" + i.ToString() + "]= " + namess[i]); 
            //}


            /////exmaple
            //int i;


            //for (char 'a'; i < 'z'; i++)
            //    Console.WriteLine(i);

            /////example

            //for (int i = 0; i < 10; i++)


            //    if (i == 5)
            //        break;
            //Console.WriteLine( i.ToString() ));




            #endregion


            #region foreach
            /////
            //int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //string[] courses = { "Html", "Css", "JavaScript", "C#" };

            //foreach (int digit in digits)
            //{
            //    Console.WriteLine(digit);
            //}

            //foreach (string course in courses)
            //{
            //    Console.WriteLine(course);
            //}

            #endregion


            #region while

            //int i =0;

            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int input = -1;

            //while (input < 0)
            //{

            //    input = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(input);
            

            #endregion



            Console.ReadLine();
            }


        }

    }
}



    

