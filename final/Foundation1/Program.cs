using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<string> videoList = new List<string>();
        List<string> commentList = new List<string>();

        string title_video1 = "Cat playing piano";
        string author_video1 = "Sam Steve";
        string length_video1 = "161 seconds";
        string comment1_video1 = "Wow I love cats!";
        string comment1Title_video1 = "catLover123";
        string comment2_video1 = "Is that Beethoven?!";
        string comment2Title_video1 = "KateCat02";
        string comment3_video1 = ":p";
        string comment3Title_video1 = "BobMan";

        Video video1 = new Video();
        string v1 = video1.VideoDisplay(title_video1, author_video1, length_video1);
        Comment comment1_v1 = new Comment(comment1Title_video1, comment1_video1);
        Comment comment2_v1 = new Comment(comment2Title_video1, comment2_video1);
        Comment comment3_v1 = new Comment(comment3Title_video1, comment3_video1);

        videoList.Add(v1);
    }
}