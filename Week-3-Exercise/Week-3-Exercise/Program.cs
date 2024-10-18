using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;


namespace Week_3_Exercise
{
    internal class Program

    {



        //public int? findPerson(int personId)
        //{

        //    if (personId > 0)
        //        return personId * 5;

        //    else
        //        Console.WriteLine("PeronId is invalid");
        //        return null ;


        //}


        //   public static void validateFullName(string fullName)
        //{
        //    if (fullName.Length < 5)
        //    {

        //        throw new ArgumentException("access denied - Ypur fullName 'S lenght must be at least 5 characters");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Access Granted - Your full name is long enough");
        //    }
        //}



        



        static void Main(string[] args)

        {

            #region Null

            //int? number2 = null;
            //Console.WriteLine(number2);



            //Console.WriteLine("Person Id: ");
            //int personId = int.Parse(Console.ReadLine());

            //Program program = new Program();
            //int? personInfo = program.findPerson(personId);


            // number2 = personInfo ?? -1;

            //string nullCherckStr = personInfo == null ? "personInfo is null" : "persınInfo is not null";


            //Console.WriteLine(personInfo);

            #endregion



            #region Creating and Writing a File

            //string fileName = @"C:\Users\baran\source\repos\Week-3-Exercise\Week-3-Exercise\data.txt";

            //string[] lines = { "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
            //   "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
            //   "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged",
            //   "Contrary to popular belief, Lorem Ipsum is not simply random text." };


            //File.WriteAllLines(fileName, lines);





            //StreamWriter sw  = new StreamWriter(fileName,true);

            //foreach (string line in lines)
            //{
            //    sw.WriteLine(line);
            //}

            //sw.Close();


            #endregion


            #region try catch


            Console.WriteLine("Enter the number : ");
            int number = int.Parse( Console.ReadLine());

            try
            {
                double result = 10 / number;
                Console.WriteLine(result);

            }

            catch (DivideByZeroException exc)

            {
                Console.WriteLine(exc.Message);
            }

            catch (ArithmeticException exc)
            {

                Console.WriteLine(exc.Message);
            }


            catch (ArgumentNullException exc)
            {

                Console.WriteLine(exc.Message);
            }


            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }





            #endregion


            #region Throw Keyword


            // Console.WriteLine("Full Name : ");
            // string fullName = Console.ReadLine();

            // validateFullName (fullName);

            Console.WriteLine("Full Name : ");
            string fullName = Console.ReadLine();
            try
            {
                DivideByZeroException
                validateFullName(fullName);
            }
            catch (FullNameShortException exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.Read();
        }


        public static void validateFullName(string fullName)
        {
            if (fullName.Length < 5)
            {
                throw new FullNameShortException("Access Denied - Your fullname's length must be at leat 5 characters");
            }
            else
            {
                Console.WriteLine("Access Granted - Your full name is long enough");
            }



            #endregion
            Console.Read();
        }
    }

       
    
}
