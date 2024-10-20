using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3._1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Collections /ArryList


            ArrayList arrayList = new ArrayList();
            ArrayList myList = arrayList;

            Console.WriteLine("Capacity :", +myList.Capacity);
            Console.WriteLine("Count : " + myList.Count);


            // Add to list

            myList.Add("Daniel");
            myList.Add("Max");


            //Cpacity & Count 

            Console.WriteLine("Capacitiy : " + myList.Capacity);
            Console.WriteLine("Count : " + myList.Count);

             /


            myList.Add(100);
            myList.Add(200);
            myList.Add(234);
            myList.Add(100);
            myList.Add(200);
            myList.Add(234);
            myList.Add(234);


            Console.WriteLine("Capacitiy : " + myList.Capacity);
            Console.WriteLine("Count : " + myList.Count);


            Console.WriteLine("index 3  : ", myList[4]);


            Console.WriteLine("Search : ");
            string key = Console.ReadLine();


            // IndexOf function


            int idex1 = myList.IndexOf(key);

            if (idex1 != -1)
            {
                Console.WriteLine("No");
            }

            else
            {
                Console.WriteLine("Yes");
            }


            //Remove functionc

            myList.RemoveAt(4);
            myList.Remove(100);

            myList.Insert(1, myList);

            foreach (var i in myList)
            {


                Console.WriteLine(i);
            }

            // Reverse function

            myList.Reverse();


            ArrayList myList2 = arrayList;

            myList2.Add(11);
            myList2.Add(13);
            myList2.Add(12);



            // AddRange function

            myList.AddRange(myList2);

            //InsertRange function

            myList.InsertRange(1, myList2);


             // Contains function

           if (myList.Contains(200))
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }

            // Clear function

           myList.Clear();



            #endregion


            Console.ReadLine();


        }
    }
}
