using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        // Create some example videos
        Video video1 = new Video("C# Tutorial for Beginners", "Efita Joe", 3600);
        video1.AddComment("Jane Smith", "Great video! Very helpful for getting started with C#.");
        video1.AddComment("Bob Etim", "Thanks for the tutorial!");

        Video video2 = new Video("Python Crash Course", "Alice Effiong", 5400);
        video2.AddComment("Ama Asuquo", "Awesome tutorial, Alice! You explained everything so clearly.");
        video2.AddComment("Musa Adeleke", "This helped me understand Python so much better. Thank you!");

        Video video3 = new Video("JavaScript Fundamentals", "Idriss Kimanzi", 4800);
        video3.AddComment("Amy Patel", "Idriss, you're an amazing teacher. Thanks for making JS easy to understand!");
        video3.AddComment("Jack Brown", "Really informative video. Thanks for sharing!");

        // Put the videos in a list
        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        // Display information about each video and its comments
        foreach (Video video in videoList)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("Comment from " + comment.CommenterName + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
