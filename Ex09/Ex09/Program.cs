using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int times = 10;
            int[] numbers = new int[times];
            while(count < times)
            {
                Console.WriteLine("Mata in ett tal: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 30)
                {
                    numbers[count] = input;
                    count++;
                }                  
                else
                    continue;
            }
            Console.WriteLine("------------------");
            foreach(int num in numbers)
                Console.WriteLine(num);
        }
    }
}
