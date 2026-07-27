using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning Encapsulation", "Fernanda", 620);

        // Comments
        Comment com11 = new Comment("Caspian", "This is awesome!");
        Comment com12 = new Comment("Sarah", "Now I can understand, Thank you!");
        Comment com13 = new Comment("Lucian", "Great video :)");

        // Add the comments to the videos
        video1.AddComment(com11);
        video1.AddComment(com12);
        video1.AddComment(com13);

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How does abstraction works?", "Anne", 400);

        // Comments
        Comment com21 = new Comment("Robbie", "Excellent video");
        Comment com22 = new Comment("Donna", "Very helpful");
        Comment com23 = new Comment("Megan", "Good examples!)");

        // Add the comments to the videos
        video2.AddComment(com21);
        video2.AddComment(com22);
        video2.AddComment(com23);

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Programming Basics", "Marie", 750);

        // Comments
        Comment com31 = new Comment("Red", "Awesome!");
        Comment com32 = new Comment("Luis", "Thanks for sharing!");
        Comment com33 = new Comment("Felix", "Great video :)");

        // Add the comments to the videos
        video1.AddComment(com31);
        video1.AddComment(com32);
        video1.AddComment(com33);

        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Understanding Classes in C#", "Archie", 870);

        // Comments
        Comment com41 = new Comment("Michael", "This explanation finally made classes easy to understand");
        Comment com42 = new Comment("Emily", "The examples were great!");
        Comment com43 = new Comment("Felix", "Now I understand the difference between classes and objects :)");

        // Add the comments to the videos
        video1.AddComment(com41);
        video1.AddComment(com42);
        video1.AddComment(com43);

        videos.Add(video4);


        foreach (Video video in videos)
        {
            video.GetDisplayVideos();
        }
    }
}