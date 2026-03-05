using System;

class Program
{
    static void Main(string[] args)
    {
        string name, lastName;

        //Ask the user´s name
        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();

        // Ask the user´s last name 
        Console.WriteLine("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}");
    }
}