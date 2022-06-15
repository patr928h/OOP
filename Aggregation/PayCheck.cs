using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class PayCheck
    {
        #region Fields
        private (DateTime start, DateTime end) interval;
        private double taxPercentage;
        private decimal hoursWorked;
        private decimal hourlyRate;
        #endregion

        #region Constants
        private readonly DateTime minimumIntervalDate = new DateTime(2000, 1, 1);
        private readonly DateTime maximumIntervalDate = new DateTime(2050, 1, 1);
    #endregion

        #region Constructor
        public PayCheck((DateTime start, DateTime end) interval, double taxPercentage, decimal hoursWorked, decimal hourlyRate)
        {
            Interval = interval;
            TaxPercentage = taxPercentage;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate; 
        }
            #endregion

        #region Properties

        public (DateTime start, DateTime end) Interval
        {
            get => interval; 
            set
            {
                //Extract tuble elements:
                DateTime start = value.start;
                DateTime end = value.end;
                interval = value;

                if(start < minimumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("Start date is too early");
                }
                else if(end > maximumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("End date is too long");
                }
                else if(end < start)
                {
                    throw new ArgumentOutOfRangeException("End is earlier than start");
                }
                

                //Validate business rules:
                if(start.AddDays(13) == end.Date)
                {
                    if(start.DayOfWeek == DayOfWeek.Monday)
                    {
                        interval = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("14 day interval does not start on a monday");
                    }
                }
                else // monthly
                {
                    if(start.Day != 1)
                    {
                        throw new ArgumentOutOfRangeException("First day of provided monthly interval is not day 1 in that month");
                    }
                    else
                    {
                        int daysInMonth = DateTime.DaysInMonth  (start.Year, start.Month);
                        if(start.AddDays(daysInMonth - 1) != end.Date)
                        {
                            throw new ArgumentOutOfRangeException("End date must be the last date in the month of the start date");
                        }
                        else
                        {
                            interval = value;
                        }
                    }
                }

                interval = value;
            }
        }
        public double TaxPercentage
        {
            get => taxPercentage; 
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Fejl");
                }
                taxPercentage = value;
            }
        }
        public decimal HoursWorked
        {
            get => hoursWorked; 
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Fejl");
                }
            }
        }
        public decimal HourlyRate
        {
            get => hourlyRate; 
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Fejl");
                }
            }
        }
        #endregion

        #region Methods
        public decimal GetGrossSalary()
        {
            return hoursWorked * hourlyRate;
        }
        public decimal GetNetSalary()
        {
            return GetGrossSalary() - GetTaxAmount();
        }
        public decimal GetTaxAmount()
        {
            return GetGrossSalary() * (decimal)taxPercentage;
        }

        public override string ToString()
        {
            return $"Gross:\t{GetGrossSalary():c2}\nNet: {GetNetSalary():c2}\nTax: {GetTaxAmount():c2}";
        }
        #endregion
    }
}
