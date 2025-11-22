using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitleAuthorLength("Rats", "Joe D.", 600);
        video1.AddComment("Virgina", "Great video! Loved the plot!");
        video1.AddComment("Indiana", "Would watch again");
        video1.AddComment("Dakota", "First Comment");
        video1.AddComment("West Virgina", "Good actors, especially the lead");
        //Console.WriteLine(video1.NumberOfComments());

        Video video2 = new Video();
        video2.SetTitleAuthorLength("Cats", "Steve R.", 725);
        video2.AddComment("Mae", "I approve");
        video2.AddComment("April", "Not my cup of tea");
        video2.AddComment("June", "Good sequel");

        Video video3 = new Video();
        video3.SetTitleAuthorLength("Bats", "Joe D.", 750);
        video3.AddComment("Guest_62413", "Good but not as advertised");
        video3.AddComment("User_39780", "Just what I wanted");
        video3.AddComment("User_84229", "Watched it four time already");
        video3.AddComment("Hacker_007", "I'm in! >} ...");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"\n'{video.GetTitle()}' by -{video.GetAuthor()}- Length: {video.GetLength()}\nComments: {video.NumberOfComments()}");
            video.GetComment();
        }

    }
}