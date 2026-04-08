using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
             
        
        Square s1 = new Square("white",5);
        Rectangle r1 = new Rectangle("blue", 5, 4 );
        Circle c1 = new Circle ("orange",3 );

        List<Shape> list = new List<Shape>();

        list.Add(s1);
        list.Add(r1);
        list.Add(c1);

        foreach (var shape in list)
        {
            Console.WriteLine($"The figure color {shape.GetColor()} has an area equal to {shape.GetArea()} units ^ 2");
        }

        
    }
}