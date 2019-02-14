using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleguete_APP1
{
    public class Program
    {
        delegate bool IsTeenAger(Student stud);

        public static void Main()
        {
            IsTeenAger isTeenAger = delegate (Student s)
            {
                return s.Age > 12 && s.Age < 20;
            };

            Student stud = new Student()
            {
                Age = 19
            };

            Console.WriteLine(isTeenAger(stud));
            Console.ReadKey();

        }
    }
}