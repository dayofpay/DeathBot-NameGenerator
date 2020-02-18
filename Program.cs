using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoticMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ExoticMC | Bots "; // Program Title
            Console.WriteLine("Bots to generate: "); // The number of names to generate ( Example : 2 )
            var bots = int.Parse(Console.ReadLine());
            Console.WriteLine("Bot Name: "); // Example : ExoticMC
            var botname = Console.ReadLine();
            Console.WriteLine("Should We Add # After The Bot Name ?: Y/N"); // if Y the result will be printed as yourtext#1 , if you set it to 'N' the result will be printed as yourtext1
            var quest = Console.ReadLine();
            if (quest == "y")
            {
                for (int i = 1; i <= bots; i++)
                    Console.WriteLine(botname + "#" + i); // The Result will be printed as yourtext#number
            }
            else
                for (int i = 1; i <= bots; i++)
                    Console.WriteLine(botname + i); // The Result will be printed as (#BotName + #Number of Bots ) - Example : ExoticMC1
            var quit = Console.ReadLine();  // Quit Listener
        }
    }
}
//####################################################
// CREATED BY DAYOFPAY //                            #
//####################################################
// CREATED FOR mc.exoticmc.eu
