using System;
using System.Collections;
using System.Threading;

namespace PhoneBookAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList phoneBook = new ArrayList();
            while (true)
            {
                Console.WriteLine("Plesae choose what you want to do\n" +
                    "1- Create Record\n" +
                    "2- Show records\n" +
                    "3- Exit this program\n" +
                    "4- Deete Record");
                //Console.WriteLine(phoneBook.Count);
                int res = int.Parse(Console.ReadLine());
                if (res == 3)
                {
                    Console.WriteLine("Goodbay see you soon.....");
                    Environment.Exit(1);
                }
                else if (res == 1)
                {
                    Console.WriteLine("Please Enter a name to add: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please Enter a number to add: ");
                    string number = Console.ReadLine();
                    int num = phoneBook.Count + 1;
                    phoneBook.Add(Record.CreateRecord(num, name, number));
                }
                else if (res == 2)
                {
                    for (int i = 0; i < phoneBook.Count; i++)
                    {
                        object elm = phoneBook[i];
                        Console.WriteLine(elm);
                    }
                }
                else if (res == 4)
                {
                    Console.WriteLine("Please Enter the number you wish to delete:");
                    int idNumber = int.Parse(Console.ReadLine());
                    int indexNum = idNumber - 1;
                    if (indexNum < phoneBook.Count)
                    {
                        phoneBook.RemoveAt(indexNum);
                        Console.WriteLine($" Record Number ({idNumber}) was deleted ....");
                    }
                    else
                    {
                        Console.WriteLine(" Please waite proccessing ....");
                        Thread.Sleep(1000);// sleep 
                        Console.WriteLine("Invalid Entery Please hit option 2  to see the index you want to Delete");
                    }

                }

            }
        }
    }
}
