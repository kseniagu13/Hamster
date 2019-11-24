using System;

namespace Hamster
{
    class Animal
    {
        public string Name;
        public int Age = 0;
        public double Weight;
        public int Lifespan = 0;

        public void PrintBaseInfo()
        {
            Console.WriteLine($"Your Hamster name is {Name} and it is {Age} year(s) old.");
            Console.WriteLine($"Your pet's weight is {Weight}.");
            Console.WriteLine($"It's lifespan is {Lifespan}.");
        }
        public void Eat()
        {
            Weight += 0.2; //kaal suureneb 0.2 võrra
        }

        public void Exercise()
        {
            Weight -= 0.1; //kaal väheneb 0.2 võrra
        }

    }






}
