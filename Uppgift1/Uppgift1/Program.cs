using System;

namespace Vigor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Mina uppgifter:");

            //Uppgift A - Happy path
            //Lagar data, deklarera variabler
            int amount_of_questions = 3;
            string[] food = new string[amount_of_questions];

            //en array är positionsbaserad
            //dvs man räknar med start från (0) [0, 1, 2]
            
            //ställ frågor ett antal gånger

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("Ange en maträtt:");
                food[i] = Console.ReadLine();
            }

            //skriv ut alla maträtterna
            for (int i = 0; i < food.Length; i++)
            {
                Console.Write(food[i] + " ");
            }

            //Skriv ut alla maträtterna med antal tecken, en per rad
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i] + " (" + food[i].Length + ")");
            }


            //Hur hittar jag den längsta maträtten?

            string longest_food = [0];
            if (food[0].Length < food[1].Length)
            {
                longest_food = food[2];
            }
            if (food[1].Length < food[2].Length)
            {
                longest_food = food[2];
            }

            Console.WriteLine("Longest food: " + longest_food);
            Console.ReadLine();

            for (int i = 0; i < food.Length - 1; i++)
            {
                if (food[1].Length < food[i + 1].Length)
                {
                    longest_food = food[i + 1];
                }
            }

        }
    }
}
