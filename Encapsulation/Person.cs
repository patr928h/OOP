using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ikke tilladt fornavn.");
                }
                firstName = value;
            }
        }

            public string LastName { get; set; }



        private DateTime birthdate;
        public DateTime BirthDate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        }
    }
