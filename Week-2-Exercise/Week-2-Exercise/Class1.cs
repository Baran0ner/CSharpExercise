using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise
{
   internal class Person
    {
        public string firstName;
        public string lastName;
        public int age;



        

        public int birthYear
        {

            get
            {
                return (DateTime.Now.Year - age);
            }
        }


        public Person()
        {

            this.firstName = "";
            this.lastName = "";
            this.age = 0;

        }

        public Person(string firsName, string lastName, int age)
        {

            this.firstName = firsName;
            this.lastName = lastName;
            this.age = age;
        }



        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }



        public virtual void getInfo()
        {
            Console.WriteLine("First Name : " + firstName + "Last Name :  " + lastName + "Age : " + age);
        }
    }




}
