using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateTimeNow { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public string GetInitials()
        {
            return $"{FirstName.Substring(0, 2)} {LastName.Substring(0,2)}";
        }
        public int GetAgeToday()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public bool IsOlderThan(int age)
        {
            if (GetAgeToday() >= age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetAgeAt(DateTime date)
        {
            return date.Year - BirthDate.Year;
        }
    }
}
