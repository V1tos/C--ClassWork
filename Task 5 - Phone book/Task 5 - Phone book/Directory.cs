using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5___Phone_book
{
    class Directory
    {
        public string Name { get; set; }
        public string Date { get; private set; }
        Contact[] contacts;


        public Directory(string name, string date,int size)
        {
            Name = name;
            Date = date;
            contacts = new Contact[size];
            FillDir();
        }

        private void FillDir()
        {
            Random random = new Random();
            for (int i = 0; i < contacts.Length/2; i++)
            {              
                string name = Path.GetRandomFileName();
                int number = random.Next(111111111, 999999999);
                contacts[i] = new Contact(name, number);
            }
        }

        public Contact this[int index]
        {
            get
            {
                return contacts[index];
            }
            set
            {
                contacts[index] = value;
            }
        }

        public void CreateContact()
        {
            for (int i=0; i<contacts.Length;i++)
            {
                if (contacts[i]==null)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    contacts[i] = new Contact(name, number);
                    break;
                }
            }
        }

        public void DeleteContact(int numerable)
        {
            this[numerable]=null;         
        }

        public void EditContact(int numerable)
        {
            Console.Write("Enter new name: ");
            this[numerable].Name = Console.ReadLine();
            Console.Write("Enter new number: ");
            this[numerable].Number = int.Parse(Console.ReadLine());
        }

        public void ShowContacts()
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i]!=null)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine($"Contact N{i + 1}");
                    contacts[i].Show();
                    Console.WriteLine("********************");
                }
            }
        }             
    }
}
