using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    class Subject
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Ikke tilladt navn.");
                }
                name = value;
            }
        }

        private string code;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (!char.IsLetter(value[0]))
                {
                    throw new ArgumentException("Ikke tilladt kode.");
                }
                else if (char.IsDigit(value[4]) && value[4] == '0')
                {
                    throw new ArgumentException("Ikke tilladt kode.");
                }
                code = value;
            }
        }
        private string teacher;
        public string Teacher
        {
            get
            {
                return teacher;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Ikke gyldight navn");
                }
                else if (value.Any(c => char.IsDigit(c)))
                {

                }
                teacher = value;
            }
        }





        private int ects;
        public int ECTS
        {
            get
            {
                return ects;
            }
            set
            {
                if (value > 10)
                {
                    throw new ArgumentException("Tallet er for højt");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Tallet er for lavt");
                }
                ects = value;
            }
        }
        private DateTime startdate;
        public DateTime StartDate
        {
            get
            {
                return startdate;
            }
            set
            {
                if (startdate >= enddate)
                {
                    throw new ArgumentException("Fejl");
                }
                else if (startdate == enddate)
                {
                    throw new ArgumentException("Fejl");
                }
                startdate = value;
            }
        }



        private DateTime enddate;
        public DateTime EndDate
        {
            get
            {
                return enddate;
            }
            set
            {
                if (enddate <= startdate)
                {
                    throw new ArgumentException("Tallet skal være højere end startdatoen.");
                }
                else if (enddate == startdate)
                {
                    throw new ArgumentException("Fejl");
                }


                enddate = value;
            }
        }
        private TimeSpan courseDuration()
        {
            return startdate - enddate;
        }
        private TimeSpan daysToCourse()
        {
            return 
        }
    }
}

