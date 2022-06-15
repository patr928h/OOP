using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            (DateTime start, DateTime end) interval = new(new(2022, 4, 1), new(2022, 4, 30));
            double tp = 0.37;
            decimal hw = 160.33m;
            decimal hr = 140m;

            PayCheck p = new(interval: interval,taxPercentage: tp, hoursWorked: hw, hourlyRate: hr);
            Console.WriteLine(p);
        }
    }
}
