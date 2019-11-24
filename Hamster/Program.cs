using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamster
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal hamster = new Animal();//loome objekti hamster
            hamster.Name = "Tiki";
            hamster.Weight = 0.3;
            


            for (int i = 0; i < 10; i++)
            {
                hamster.Lifespan++;
                hamster.Age++;

                if (hamster.Weight <= 0.7)
                {
                    hamster.Eat();
                    Console.WriteLine($"Hamster gains weight {hamster.Weight}");
                }
                else
                {
                    hamster.Exercise();
                    Console.WriteLine($"Hamster looses weight {hamster.Weight}");
                } 
            }

            hamster.PrintBaseInfo();

            if (hamster.Lifespan == 10)
            {
                Console.WriteLine($"Your hamster {hamster.Name} are dead, we can't help it.");
                hamster = null;
            }

            Console.ReadLine();

        }
    }
}
