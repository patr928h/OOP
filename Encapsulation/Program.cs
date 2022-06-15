using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            try
            {
                p.FirstName = "";
                p.LastName = "Hansen";
                p.BirthDate = new DateTime(1501, 01, 02);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            string output = p.GetFullName();
            Console.WriteLine(output);
        }
    }
}
