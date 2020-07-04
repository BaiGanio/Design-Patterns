using System;

namespace Prototype.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Jack Daniels",
                IdInfo = new IdInfo(666)
            };

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.DeepCopy();

            DisplayValues(p2);

            p1.Age = 10;
            DisplayValues(p2);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
