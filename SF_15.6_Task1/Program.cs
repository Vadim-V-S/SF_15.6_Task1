using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));



            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {

            //return (from cl in classes from st in cl.Students select st).ToArray();
            return classes.SelectMany(x => x.Students).ToArray();

        }


        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
