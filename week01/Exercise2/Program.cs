using System;

class Program
{
    static void Main(string[] args)
    {
        int grades;     
        string input, letter; 

            
        //loop to validate user´s input be a number between 0 and 100    
        while(true)
        {
            
            Console.Write("What is your grade? ");
            input = Console.ReadLine();

            if (int.TryParse(input, out grades) && grades >= 0 && grades <= 100)
                {
                    break;
                }

            else
                {
                Console.WriteLine("Invalid input. Enter a number between 0 and 100.");   
                }
        }
        
        // if else statements to determine the final letter grade 
        if(grades >= 90 )
        {
            letter = "A";
        }
        
        else if (grades >= 80)
        {
            letter = "B";
        }
        
        else if (grades >= 70)
        {
            letter = "C";
        }

        else if (grades >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        // determinating the letter sign
        int gradeSign;
        string letterSign= " ";

        gradeSign = grades % 10;

        if (gradeSign >= 7 && grades>= 60)
        {
            letterSign = "+";
        }
        else if (gradeSign <= 3 && grades>= 60)
        {
            letterSign = "-";
        }

        //Printing results
        Console.WriteLine($"Your grade letter is {letterSign}{letter} ");

        if (grades >= 60 )
        {
            Console.WriteLine("Congratulations!!!!!");
        }

        else
        {
            Console.WriteLine("You can do better next time. Go ahead!");
        }


    }
}