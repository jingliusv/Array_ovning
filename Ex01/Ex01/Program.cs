using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = new string[6];
            Console.WriteLine("Mata in förnamn:");
            info[0] = Console.ReadLine();
            Console.WriteLine("Mata in efternamn:");
            info[1] = Console.ReadLine();
            Console.WriteLine("Mata in adress:");
            info[2] = Console.ReadLine();
            Console.WriteLine("Mata in postort:");
            info[3] = Console.ReadLine();
            Console.WriteLine("Mata in telefon:");
            info[4] = Console.ReadLine();
            Console.WriteLine("Mata in email:");
            info[5] = Console.ReadLine();

            Console.WriteLine("Du har matat in följande uppgifter……stämmer det?");
            foreach(string item in info)
                Console.WriteLine(item);
        }
    }
}
