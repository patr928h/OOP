using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Karl";
            p.LastName = "Hansen";
            p.BirthDate = new DateTime(1946, 01, 02);

            string output = p.GetFullName();
            Console.WriteLine(output);
        }
    }
}
