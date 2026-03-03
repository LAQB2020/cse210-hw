using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbersList = new List<int>();
        List<int> numbersSorted = new List<int>();
        string input;
        int number, sum=0, largestNumber=0, smallestNumber=999999999;
        float average;
        do
        {
            
            Console.Write("Enter a number: ");
            input = Console.ReadLine(); 

            if (int.TryParse(input,out number) ) 
            
            {
                if (number !=0)
                    numbersList.Add(number) ;
            }
            else Console.Write("Please, only numbers. Try again");           

            if (number > largestNumber ) largestNumber=number;
            else if (number < smallestNumber && number >0) smallestNumber = number;

        }while ( number != 0);


        foreach (int item in numbersList)
        {
            sum = sum + item;
        }

        average = sum / (float)(numbersList.Count);
        
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number  is: {largestNumber}");
        Console.WriteLine($"The smallest positive nubmer is is: {smallestNumber}");
        Console.WriteLine($"The sorted list is:");

        numbersList.Sort();

        foreach(int n in numbersList)
        {
            Console.WriteLine(n);
        }
    }
}