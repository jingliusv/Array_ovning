using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange hur många tal du vill mata in:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int questionNum = 0;
            int[] numbers = new int[inputNum];
            int maximum = 0;
            while (questionNum < inputNum)
            {
                Console.WriteLine("Mata in ett tal: ");
                numbers[questionNum] = Int32.Parse(Console.ReadLine());
                questionNum++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                    maximum = numbers[i];
            }
            Console.WriteLine("Det största talet: " + maximum);
        }
    }
}
