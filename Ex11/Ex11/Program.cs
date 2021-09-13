using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int[] talArray = new int[1];
            int raknare = 0;
            while (continueLoop)
            {
                Console.WriteLine("Mata in ett tal");
                int retur = int.Parse(Console.ReadLine());
                if (retur == 10)
                {
                    Console.WriteLine("Du har matat in rätt tal");
                    continueLoop = false;
                }
                else
                {
                    if (retur < 10)
                    {
                        Console.WriteLine("Värdet är för lågt");
                    }
                    else if (retur > 10)
                    {
                        Console.WriteLine("Värdet är för högt");
                    }
                    talArray[raknare] = retur;
                    Array.Resize(ref talArray, talArray.Length + 1);
                    raknare++;
                }
            }
            //Skriver ut värdena på skärmen
            for (raknare = 0; raknare < talArray.Length; raknare++)
            {
                Console.WriteLine(talArray[raknare]);
            }

            //bool isRunning = true;
            //Console.WriteLine("Mata in hur många gånger vill du prova det: ");
            //int times = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int[] wrongNumbers = new int[times];

            //while (isRunning && count < times)
            //{
            //    Console.WriteLine("Mata in ett tal: ");
            //    int input = Int32.Parse(Console.ReadLine());                           

            //    if (input > 10)
            //    {
            //        Console.WriteLine("Värdet är för högt.");
            //        wrongNumbers[count] = input;
            //        count++;
            //        continue;
            //    }
            //    else if (input == 10)
            //    {
            //        Console.WriteLine("Du matade in rätt tal.");
            //        isRunning = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Värdet är för lågt.");
            //        wrongNumbers[count] = input;
            //        count++;
            //        continue;
            //    }
            //}

            //foreach (int num in wrongNumbers)
            //{
            //    if(num != 0)
            //        Console.WriteLine(num);
            //}




            //bool isRunning = true;
            ////int count = 1;
            //List<int> wrongNumbers = new List<int>();

            //while (isRunning)
            //{
            //    Console.WriteLine("Mata in ett tal: ");
            //    int input = Int32.Parse(Console.ReadLine());
            //    //int[] wrongNumbers = new int[count];               


            //    if (input > 10)
            //    {
            //        Console.WriteLine("Värdet är för högt.");
            //        wrongNumbers.Add(input);
            //        continue;
            //    }
            //    else if(input == 10)
            //    {
            //        Console.WriteLine("Du matade in rätt tal.");
            //        isRunning = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Värdet är för lågt.");
            //        wrongNumbers.Add(input);
            //        continue;
            //    }
            //}

            //foreach(int num in wrongNumbers)
            //    Console.WriteLine(num);
        }
    }
}
