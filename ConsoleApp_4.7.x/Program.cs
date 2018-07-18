using NetStandardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4._7.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //code illustrating new string concatenation

            var today = Helper.GetDate();
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
