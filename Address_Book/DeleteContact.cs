using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class DeleteContact
    {
        DeleteContact ObjAdd = new DeleteContact();
        public void deleteContact()
        {
            Console.WriteLine("First Here provide contact information \n");
            ObjAdd.deleteContact();
            Console.WriteLine("\nEnter the First name of the contact that you want to delete");
            string name = Console.ReadLine().ToLower();
            foreach (var info in ObjAdd. deleteContact)
            {
                if (info.FirstName == name)
                {
                    ObjAdd.DeleteContact.Remove(info);
                    Console.WriteLine("Contact removed successfully ");
                    break;
                }
                else
                {
                    Console.WriteLine("\nName doesn't match, No Contact present with this FirstName");
                }
            }
        }
    }
}
