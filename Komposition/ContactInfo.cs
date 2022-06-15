namespace Komposition
{
    public class ContactInfo
    {
        #region Fields
        private int id;
        private string mail;
        private string phoneNumber;
        #endregion


        #region Constructors
        public ContactInfo(int id, string mail, string phoneNumber)
        {
            Id = id;
            Mail = mail;
            PhoneNumber = phoneNumber;
        } 
        #endregion




        #region Properties
        public int Id
        {
            get => id;
                private set
            {   
                id = value;
            }
        }
        public string Mail
        {
            get => mail; set
            {
                
                mail = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber; set
            {
                phoneNumber = value;
            }
        }
        #endregion
        public override string ToString()
        {
            return $"Id {id}, Mail: {mail}, Phone No.: {phoneNumber}";
        }
    }
}
