using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class NewContact
    {
        public List<NewContact> ContactBook = new List<NewContact>();
        private string FirstName;
        private string LastName;
        private string City;
        private string State;
        private string ZipCode;
        private string PhoneNumber;
        private string E_Mail;

        public void createContactMethod()
        {
            NewContact obj = new NewContact();
            obj.FirstName = "Ankush";
            obj.LastName = "Rawat";
            obj.City = "Delhi";
            obj.State = "Delhi";
            obj.ZipCode = "110096";
            obj.PhoneNumber = "9876554321";
            obj.E_Mail = "ankushrwt344@gmail.com";
            ContactBook.Add(obj);
            Console.WriteLine("\nADDRESS BOOK Is Created ");
        }
    }
}
