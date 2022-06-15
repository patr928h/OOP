using System;

namespace Encapsulation3
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI p = new();
            try
            {
                p.Height = "1.79";
                p.Weight = "71";
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            string output = p.Getbmi();
            Console.WriteLine(output);
        }
    }
}
