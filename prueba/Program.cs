using System;


class Program
{ 
    static Random random = new Random();
    static void Main()
    {
        do
        {
            PlayGame();
            Console.WriteLine("\n ¿jugar de nuevo? (Y/N)");
        } while (Console.ReadLine().Trim().ToUpper() == "Y");
    }

    static void PlayGame()
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);
        
        Console.WriteLine($"! Lanza un numero mayor que {target} para ganar!");
        Console.WriteLine($"Haz lanzado un {roll}");
        Console.WriteLine(roll > target ?   "!Ganaste" : "Perdiste");
    }
} 