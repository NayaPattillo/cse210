using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<string> videoList = new List<string>();
        List<string> commentList = new List<string>();

        Console.WriteLine("Video 1");
        Console.WriteLine("Video 2");
        Console.WriteLine("Video 3");
        string input = Console.ReadLine();

        if (input == "1"){
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
            Comment comment_v1 = new Comment();
            string c1_v1 = comment_v1.CommentDisplay(comment1Title_video1, comment1_video1);
            string c2_v1 = comment_v1.CommentDisplay(comment2Title_video1, comment2_video1);
            string c3_v1 = comment_v1.CommentDisplay(comment3Title_video1, comment3_video1);

            videoList.Add(v1);
            commentList.Add(c1_v1);
            commentList.Add(c2_v1);
            commentList.Add(c3_v1);

            Comment comNum = new Comment();
            int commentAmmount = comNum.CommentAmount();

            foreach (string video in videoList){
                Console.WriteLine(v1);
                Console.WriteLine($"Number of comments: {commentAmmount}");
                foreach (string comment in commentList){
                    Console.WriteLine(comment);
                }
            }
        }

        else if (input == "2"){
            string title_video2 = "Make a Cake In 10 Easy Steps";
            string author_video2 = "Maria Baker";
            string length_video2 = "300 seconds";
            string comment1_video2 = "So easy thank you!";
            string comment1Title_video2 = "EasyBaker";
            string comment2_video2 = "What a good recipe";
            string comment2Title_video2 = "SteveJobs";
            string comment3_video2 = "CAKE!!";
            string comment3Title_video2 = "cakeLover123";

            Video video2 = new Video();
            string v2 = video2.VideoDisplay(title_video2, author_video2, length_video2);
            Comment comment_v2 = new Comment();
            string c1_v2 = comment_v2.CommentDisplay(comment1Title_video2, comment1_video2);
            string c2_v2 = comment_v2.CommentDisplay(comment2Title_video2, comment2_video2);
            string c3_v2 = comment_v2.CommentDisplay(comment3Title_video2, comment3_video2);

            videoList.Add(v2);
            commentList.Add(c1_v2);
            commentList.Add(c2_v2);
            commentList.Add(c3_v2);

            Comment comNum2 = new Comment();
            int commentAmmount2 = comNum2.CommentAmount();

            foreach (string video in videoList){
                Console.WriteLine(v2);
                Console.WriteLine($"Number of comments: {commentAmmount2}");
                foreach (string comment in commentList){
                    Console.WriteLine(comment);
                }
            }
        }

        else if (input == "3"){
            string title_video3 = "The Seven Wonders Of The World";
            string author_video3 = "Adventure Mike";
            string length_video3 = "500 seconds";
            string comment1_video3 = "Wow! Just Wow";
            string comment1Title_video3 = "Brenda Smith";
            string comment2_video3 = "So educational:)";
            string comment2Title_video3 = "Janet Jack";
            string comment3_video3 = "Waterfalls are my favorite!";
            string comment3Title_video3 = "BILL";

            Video video3 = new Video();
            string v3 = video3.VideoDisplay(title_video3, author_video3, length_video3);
            Comment comment_v3 = new Comment();
            string c1_v3 = comment_v3.CommentDisplay(comment1Title_video3, comment1_video3);
            string c2_v3 = comment_v3.CommentDisplay(comment2Title_video3, comment2_video3);
            string c3_v3 = comment_v3.CommentDisplay(comment3Title_video3, comment3_video3);

            videoList.Add(v3);
            commentList.Add(c1_v3);
            commentList.Add(c2_v3);
            commentList.Add(c3_v3);

            Comment comNum3 = new Comment();
            int commentAmmount3 = comNum3.CommentAmount();

            foreach (string video in videoList){
                Console.WriteLine(v3);
                Console.WriteLine($"Number of comments: {commentAmmount3}");
                foreach (string comment in commentList){
                    Console.WriteLine(comment);
                }
            }
        }

        else{
            Console.WriteLine("Invalid input.");
        }

    }
}