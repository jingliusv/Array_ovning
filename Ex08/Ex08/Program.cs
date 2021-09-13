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
            //Console.WriteLine("Mata in ditt namn, gatuadress, postnummer, postort: ");
            //string personInfo = Console.ReadLine();
            string[,] personInfo = { 
                { "Jing" , "apelgatan", "802 56", "gävle"}, 
                {"felix" , "solvägen", "801 45", "valbo" }, 
                {"malin" , "skogstigen", "814 23", "falun" }, 
                { "emil" , "furumovägen", "802 69", "gävle"}, 
                { "anna" , "moravägen", "801 59", "stockholm" }, 
            };

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine(personInfo[i, j]);
                }
            }

        }
    }
}
