using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise
{
    internal class Program
    {
        #region Method Overloading
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static Double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        #endregion

        static void Main(string[] args)
        {

            #region Method Overloading
           
            int myNum1 = PlusMethodInt(1, 2);

            double myNum2= PlusMethodDouble(1.1, 2.2);

            Console.WriteLine(myNum1);
            Console.WriteLine(myNum2);

            #endregion


            #region  Class


            Person p1 = new Person( "baran" , "oner",22);
            Person p2 = new Person();

            Console.WriteLine("Year " + p1.birthYear);



            Student s1 = new Student("selin", "demir ", 2, 2, "engineering");

            p1.getInfo();

            s1.getInfo();






            #endregion




            Console.Read();





        }

        
    }
}
