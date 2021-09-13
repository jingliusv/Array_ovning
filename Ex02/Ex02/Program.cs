using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int questionNum = 0;
            int[] numbers = new int[4];
            int maximum = 0;
            while(questionNum < 4)
            {
                Console.WriteLine("Mata in ett tal: ");
                numbers[questionNum] = Int32.Parse(Console.ReadLine());
                questionNum++;
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                    maximum = numbers[i];
            }
            Console.WriteLine("Det största talet: " + maximum);
        }
    }
}
