using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Cook Burgers", "Bobby Flay", 1000m);  
        video1.AddComment(new Comment("Anonymous1235", "That looks delicious!"));
        video1.AddComment(new Comment("FlavorTownGuy35", "I want to try making that!"));
        video1.AddComment(new Comment("John Smith", "I think Gordon Ramsey made it better."));

        Video video2 = new Video("Best Popcorn Ever", "Alton Brown", 1500m);  
        video2.AddComment(new Comment("AnnieRuOk", "I don't like popcorn >:("));
        video2.AddComment(new Comment("Super Smeller", "@AnnieRuOk then why are you here?"));
        video2.AddComment(new Comment("Steven with a P", "I like popcorn"));

        Video video3 = new Video("Your New Favorite Pasta", "Giada", 2000m);  
        video3.AddComment(new Comment("Bighead Burton", "This looks amazing! I love your channel!"));
        video3.AddComment(new Comment("MC ClapYoHandz", "Can't wait to make it myself"));
        video3.AddComment(new Comment("Lavender Gooms", "Is there a substitute for garlic?"));

        List<Video> videos = new List<Video>() { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title());
            Console.WriteLine("Author: " + video.Author());
            Console.WriteLine("Length: " + video.Length() + " seconds");
            Console.WriteLine("Number of Comments: " + video.NumberOfComments());
            Console.WriteLine("Comments: ");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
