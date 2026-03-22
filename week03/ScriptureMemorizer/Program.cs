using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
            {
                //Bible
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all thine heart and lean not unto thine own understanding"
                ),

                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world that he gave his only begotten Son"
                ),

                new Scripture(
                    new Reference("Philippians", 4, 13),
                    "I can do all things through Christ which strengtheneth me"
                ),

                // Book of Mormon
                new Scripture(
                    new Reference("1 Nephi", 3, 7),
                    "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way"
                ),

                new Scripture(
                    new Reference("Mosiah", 2, 17),
                    "When ye are in the service of your fellow beings ye are only in the service of your God"
                ),

                new Scripture(
                    new Reference("Alma", 37, 6),
                    "By small and simple things are great things brought to pass"
                ),

                new Scripture(
                    new Reference("Ether", 12, 27),
                    "If men come unto me I will show unto them their weakness"
                ),

                // (DyC)
                new Scripture(
                    new Reference("Doctrine and Covenants", 6, 36),
                    "Look unto me in every thought doubt not fear not"
                ),

                new Scripture(
                    new Reference("Doctrine and Covenants", 18, 10),
                    "Remember the worth of souls is great in the sight of God"
                ),

                new Scripture(
                    new Reference("Doctrine and Covenants", 58, 27),
                    "Men should be anxiously engaged in a good cause and do many things of their own free will"
                )
            };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)]; 
        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            
            scripture.HideRandomWords(3);
        }
    }
}