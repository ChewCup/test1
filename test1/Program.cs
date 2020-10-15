using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Viktor";
            string street = "Folkborgsvägen"; 
            string zip_city = "603 80 Norrköping";

            //set background color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(15, 15);
            Console.WriteLine(name);
            Console.SetCursorPosition(15, 16);
            Console.WriteLine(street);
            Console.SetCursorPosition(15, 17);
            Console.WriteLine(zip_city);


            //stop
            Console.ReadKey();

             




        }
    }
}
