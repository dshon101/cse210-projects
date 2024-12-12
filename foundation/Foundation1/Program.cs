using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();  

        // Creating video objects  
        Video video1 = new Video("Learning C#", "John Doe", 300);  
        video1.AddComment(new Comment("Alice", "Great video!"));  
        video1.AddComment(new Comment("Bob", "Very informative, thanks!"));  
        video1.AddComment(new Comment("Charlie", "Loved it!"));  

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);  
        video2.AddComment(new Comment("David", "This helped me a lot!"));  
        video2.AddComment(new Comment("Eve", "Nice examples!"));  

        Video video3 = new Video("C# Best Practices", "Mike Lee", 240);  
        video3.AddComment(new Comment("Sara", "Helpful, thank you!"));  
        video3.AddComment(new Comment("Tom", "I will implement these!"));  
        video3.AddComment(new Comment("Anna", "Excellent tips!"));  

        // Add the videos to the list  
        videoList.Add(video1);  
        videoList.Add(video2);  
        videoList.Add(video3);  

        // Displaying video details and comments  
        foreach (var video in videoList)  
        {  
            Console.WriteLine(video.GetVideoDetails());  
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");  
            foreach (var comment in video.GetComments())  
            {  
                Console.WriteLine(comment.GetCommentDetails());  
            }  
            Console.WriteLine(); // Blank line for separation  
        }  
    }  
}
