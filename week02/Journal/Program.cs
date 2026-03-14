using System;
using System.Reflection.Metadata;


class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int option;

        
        PromptGenerator questions = new PromptGenerator();
        Journal myJournal = new Journal();
        string fileName;

        Console.WriteLine("Welcome to the Journal Program!\n\nPlease select one of the following options:");
       

        while (true)
        {
            fileName="";
            Console.WriteLine("1) Write\n2) Display\n3) Load\n4) Save\n5) Quit\n\nWhat would you like to do?");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput,out option) && (option >= 1) && (option <= 5) ) 
                
                {
                    switch (option)
                    {
                        case 1: //Write
                            Entry myThoughts = new Entry();
                            myThoughts.Display();
                            myThoughts._entryText = Console.ReadLine();
                            myJournal.AddEntry(myThoughts);
                        
                        break;

                        case 2: //Display
                            myJournal.DisplayAll();
                        break;

                        case 3: //Load
                            Console.WriteLine("Whats the file name? ");
                            fileName = Console.ReadLine();
                            myJournal.LoadFromFile(fileName);
                        break;

                        case 4: //Save
                            Console.WriteLine("Whats the file name? ");
                            fileName = Console.ReadLine();
                            myJournal.SaveToFile(fileName);
                        break;

                        case 5: //Quit
                        Console.WriteLine("Goodbye!");
                        return;
                    }        
                
                }
                else Console.Write("Please, select a valid option. Try again");

        }


    }
}