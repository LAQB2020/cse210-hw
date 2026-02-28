using System;

class Program
{
    static void Main(string[] args)
    {
        string name, last_name;

        //Ask the user´s name
        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();

        // Ask the user´s last name 
        Console.WriteLine("What is your last name? ");
        last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {name} {last_name}");
    }
}