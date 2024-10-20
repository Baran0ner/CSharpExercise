using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3._2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }



            //Create a Hashtable

            Hashtable ht = new Hashtable
            {
                { "0", "Baran" },
                { "1", "Barann" },
                { "2", "Barannn" },
                { "3", "Barannnn" },
                { "4", "Barannnnn" }
            };

            Console.WriteLine("which Key : ");
            string k1 = Console.ReadLine();


            //Constains Function

            if (ht.ContainsKey(k1))
            {

                Console.WriteLine("This key is already in the list");
            }

            else
            {

                ht.Add("0", "alex");
            }

            // print values ​​to screen

            ICollection values = ht.Values;

            ArrayList list1 = new ArrayList();


            list1.AddRange(Values);


           // print keys ​​to screen

            ICollection key = ht.Keys;

            foreach (string k in key) {

                {
                    Console.WriteLine(k + ":" + ht[k]);
                }



            Console.ReadLine();

        }


    }
}
