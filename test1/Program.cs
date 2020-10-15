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

            Console.Write("Ange antal tecken från vänsterkant: ");
            int left = int.Parse(Console.ReadLine());
            Console.Write("Ange antal tecken från övrekant: ");
            int top = int.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(left, top);
            Console.WriteLine("*********************");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("* {0,-17} *", name);
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("* {0,-17} *", street);
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("* {0,-16} *", zip_city);
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("*********************");
            //stop
            Console.ReadKey();

             




        }
    }
}
