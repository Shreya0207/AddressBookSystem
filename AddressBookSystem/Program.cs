using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Walter", "White", "Bakerstreet", "Raipur", "CG", "heisenberg@gmail.com", 987654, 1234567890);
            addressBook.ViewContact();
        }
    }
}
