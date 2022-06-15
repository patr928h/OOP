using System;

namespace Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s = new();
            try
            {
                s.Name = "Oldgræsk filosofihistorie";
                s.Code = "ABC-142";
                s.Teacher = "Henry";
                s.StartDate = new DateTime(2022, 05, 12);
                s.EndDate = new DateTime(2022, 05, 16);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
