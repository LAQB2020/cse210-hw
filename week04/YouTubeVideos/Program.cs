using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Intro to Programming", "Luis", 300);
        v1.AddComment(new Comment("Ana", "Great video!"));
        v1.AddComment(new Comment("Carlos", "It helped me a lot"));
        v1.AddComment(new Comment("Sofia", "Can you explain it slower? 😅"));

        // Video 2
        Video v2 = new Video("C# Basics", "Pedro", 450);
        v2.AddComment(new Comment("John", "Excellent explanation"));
        v2.AddComment(new Comment("Maria", "Thanks for sharing"));
        v2.AddComment(new Comment("Diego", "Very clear content"));

        // Video 3
        Video v3 = new Video("OOP in C#", "Andrea", 600);
        v3.AddComment(new Comment("Luis", "Now I understand classes"));
        v3.AddComment(new Comment("Fernanda", "Awesome 👏"));
        v3.AddComment(new Comment("Raul", "More examples please"));

        // Video 4 (optional but recommended)
        Video v4 = new Video("Data Structures", "Miguel", 520);
        v4.AddComment(new Comment("Laura", "Very useful"));
        v4.AddComment(new Comment("Andres", "Well explained"));
        v4.AddComment(new Comment("Sergio", "I learned a lot"));

        // Add videos to the list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        // Iterate and display
        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
            }

            Console.WriteLine();
            }
    }
}