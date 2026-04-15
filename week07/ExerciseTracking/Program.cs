using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r1 = new Running(30,4.8);
        Cycling c1 = new Cycling(30,1.1);
        Swimming s1 = new Swimming(30, 5);

        activities.Add(r1);
        activities.Add(c1);
        activities.Add(s1);

        foreach (var activity  in activities)
        {
            Console.WriteLine(activity.GetSumary());
        }

    }
}