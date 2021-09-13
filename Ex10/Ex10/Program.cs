using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] words = new string[5];

            while(count < 5)
            {
                Console.WriteLine("Mata in 5 ord: ");
                string input = Console.ReadLine();
                
                if (!String.IsNullOrEmpty(input))
                {
                    words[count] = input;
                    count++;
                }
            }

            string longWord = "";
            int charNum = 0;
            foreach(string word in words)
            {
                if (word.Length > longWord.Length || charNum > word.Distinct().Count())
                    longWord = word;
            }

            Console.WriteLine("Det längsta ordet är " + longWord + ".");
        }
    }
}
