using System;

namespace gamealeksejev
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Superman", "Luke Skywalker", "Lara Kroft" };
            string[] villains = { "Volandemort", "Joker", "Venom", "Darth Vader", "Cruella" };


            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            Console.WriteLine($"Your random villain is: {randomVillain}");
            Console.WriteLine($"Your random hero is: {randomHero}");

        }

        public static string GetRandomCharacter(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;
        }
    }
}

