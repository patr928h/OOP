using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposition
{
    class ContactInfo2
    {
        #region Fields
        private int id;
        private string mail;
        private string phoneNumber;
        #endregion

        #region Constructors
        public ContactInfo2(int id, string mail, string phoneNumber)
        {
            Id = id;
            Mail = mail;
            PhoneNumber = phoneNumber;
        } 
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        #endregion


        public override string ToString()
        {
            return $"id {id}, mail: {mail}, Phone No.: {phoneNumber}";
        }
    }
}
