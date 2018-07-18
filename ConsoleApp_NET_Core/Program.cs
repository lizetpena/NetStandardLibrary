using NetStandardLibrary;
using System;

namespace ConsoleApp_NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //code illustrating new string concatenation

            var today=Helper.GetDate();
            Console.WriteLine($@"Today's date is {today}");

            //code illustrating new way to invoke constructors/instantiate an object
            var foo = new Helper
            {
                Number = 8
            };

            Console.WriteLine($@"The 'lucky' number is: {foo.Number}");

            Console.ReadLine();
        }
    }
}
