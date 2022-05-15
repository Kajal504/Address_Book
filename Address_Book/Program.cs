// See https://aka.ms/new-console-template for more information
AddContactInput obj = new NewContact();
NewContact cont = new NewContact();
Console.WriteLine("Enter \n1 for CREATE CONTACT IN ADDRESSBOOK PROGRAM \n2 for USER INPUT CONTACT IN ADDRESSBOOK PROGRAM \n3 for EDIT CONTACTS IN ADDRESSBOOK PROGRAM\n4 for DELETING CONTACT PROGRAM\n5 for MULTIPLE PERSON ADDRESS BOOK \n6 for MULTIPLE ADDRESS BOOK DICTIONARY PROGRAM \n");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        cont.createContactMethod();
        cont.printContact();
        break;

    case 2:
        newContact obj2 = new newContact();
        obj2.addContact();
        obj2.printAddedContact();
        break;

    case 3:
        editContact obj3= new editContact();
        obj3.editContacts();
        break;

    case 4:
        DeleteContact obj4 = new DeleteContact();
        obj4.deleteContact();
        break;
}


