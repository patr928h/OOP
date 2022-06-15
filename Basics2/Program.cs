using System;

namespace Basics2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Karl";
            p.LastName = "Hansen";
            p.BirthDate = new DateTime(1946, 01, 02);
            DateTime date = new DateTime(1955, 05, 06);
            int dateage = p.GetAgeAt(date);
            string output = p.GetInitials();
            Console.WriteLine(output);
            int age = p.GetAgeToday();
            Console.WriteLine(age);
            Console.WriteLine(dateage);


        }
    }
}
