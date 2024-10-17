using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise
{
    internal class Student : Person

    {

        public int studentId;
        public string department;



        public Student(

            string FirstName,
            string LastName,
            int Age,
            int studentId,
            string department

            )
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.age = Age;
            this.studentId = studentId;
            this.department = department;
            // base( firstName, lastName ,age );
        }


        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("StudentId: " + studentId + " Departmant : " + department);

        }


    }
}
