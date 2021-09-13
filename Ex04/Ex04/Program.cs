using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    numbers[i] = 0;
            }

            foreach(int num in numbers)
                Console.WriteLine(num);
        }
    }
}
