using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while (option != "4")
        {
            // Mostrar menú
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect an option: ");
            option = Console.ReadLine();

            // Ejecutar opción
            if (option == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (option == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (option == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (option == "4")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option.");
                System.Threading.Thread.Sleep(1500);
            }
        }
    
    }
}