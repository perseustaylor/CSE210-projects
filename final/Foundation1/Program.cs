using System;

class Program
{
    static void Main(string[] args)
    {
        List<UserVideo> UserVideos = new List<UserVideo>();

        UserVideo video1 = new UserVideo("How to Cook Rice", "Chef Brian Lagerstrom", 300);
        video1.AddComment(new Comment("Perseus", "Thank you for the recipe!"));
        video1.AddComment(new Comment("Alice", "Great video, very helpful."));
        UserVideos.Add(video1);

        UserVideo video2 = new UserVideo("Learn C# from Bro Gibbons", "Prof Carl Gibbons", 800);
        video2.AddComment(new Comment("Matthew", "This really helped me understand C#."));
        video2.AddComment(new Comment("Paul", "Great explanation of concepts."));
        video2.AddComment(new Comment("Ryan","Great sense of humor"));
        UserVideos.Add(video2);

        UserVideo video3 = new UserVideo("Programming for Beginners", "Dr. Ricks", 400);
        video3.AddComment(new Comment("Kenneth", "This was a great starting point for me."));
        video3.AddComment(new Comment("Aloy", "Very informative and well presented."));
        video3.AddComment(new Comment("Croft", "Helped me understand the basics."));
        UserVideos.Add(video3);

        foreach (UserVideo Uservid in UserVideos)
        {
            Console.WriteLine(Uservid.GetInfo());
            Console.WriteLine($"Number of Comments: {Uservid.GetCommentCount()}");
            Console.WriteLine("Comments:");

            List<Comment> comments = Uservid.GetComments();
            foreach (Comment comment in comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine();
            



            
        }

    }
}