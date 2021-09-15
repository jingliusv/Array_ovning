using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] personInfo = new string[5, 4];
            int personCount = 0;
            bool running = true;

            while (personCount < 5 && running)
            {
                for (int i = personCount; i < 5; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Write("Mata in ditt namn: ");
                                personInfo[i, j] = Console.ReadLine();
                                break;
                            case 1:
                                Console.Write("Mata in din gatuadress: ");
                                personInfo[i, j] = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Mata in ditt postnummer: ");
                                personInfo[i, j] = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Mata in ditt postort: ");
                                personInfo[i, j] = Console.ReadLine();
                                break;
                        }
                    }

                    Console.Write("Vill mata in en ny person(J/N): ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                    {
                        personCount++;
                        continue;
                    }
                    else if(answer == "n")
                    {
                        running = false;
                        break;
                    }
                }
            }

            foreach(string item in personInfo)
            {
                if (!String.IsNullOrEmpty(item))
                    Console.WriteLine(item);
            }

        }
    }
}
