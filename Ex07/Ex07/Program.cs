using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många varor den skall ha på din lista: ");
            int num = Int32.Parse(Console.ReadLine());

            string[] products = new string[num];
            double[] price = new double[num];
            string[] serialNum = new string[num];

            int count = 0;
            while(count < num)
            {
                Console.WriteLine("Vilken vara: ");
                products[count] = Console.ReadLine();
                Console.WriteLine("Vilket pris: ");
                price[count] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Vilket produktnummer: ");
                serialNum[count] = Console.ReadLine();
                count++;
            }
            Console.WriteLine("------------------------------------");
            for(int i = 0; i < products.Length; i++)
                Console.WriteLine($"{products[i]} - {serialNum[i]} - {price[i]}kr");
        }
    }
}
