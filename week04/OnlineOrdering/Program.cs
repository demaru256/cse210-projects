using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Intro to Programming", "John Doe", 300);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Ema", "Loved it!"));

        // Video 2
        Video v2 = new Video("OOP Concepts", "Jane Smith", 420);
        v2.AddComment(new Comment("Mike", "Clear and simple."));
        v2.AddComment(new Comment("Sara", "Nice examples."));
        v2.AddComment(new Comment("Tom", "Helped me a lot."));

        // Video 3
        Video v3 = new Video("C# Basics", "Chris Lee", 360);
        v3.AddComment(new Comment("Anna", "Well explained."));
        v3.AddComment(new Comment("David", "Good pacing."));
        v3.AddComment(new Comment("Lucy", "Easy to follow."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}