using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många mätningar som ska registreras:");
            int num = Int32.Parse(Console.ReadLine());
            double[] temperatures = new double[num];
            string[] dates = new string[num];

            int count = 0;
            while (count < num)
            {
                Console.WriteLine("Mata in din värde: ");
                temperatures[count] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ange mätdatum: ");
                dates[count] = Console.ReadLine();
                count++;
            }
            Console.WriteLine("----------------------");
            double maxValue = 0, sum = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i];
                Console.WriteLine(dates[i] + " " + temperatures[i]);

                if (temperatures[i] > maxValue)
                    maxValue = temperatures[i];
            }

            Console.WriteLine($"Max temperatur: {maxValue} \nMedelTemperatur: {sum / temperatures.Length}");
        }
    }
}
