using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Hiking mountains", "Raul Perez", 300),
            new Video("Camping on the mountain", "Jessica Jex", 600),
            new Video("How to survive in mountains", "Erick Cadillo", 900)
        };

        videos[0].AddComment(new Comment("Juan", "Great video!"));
        videos[0].AddComment(new Comment("Luis", "I loved it!"));
        videos[0].AddComment(new Comment("Teresa", "Awesome content!"));

        videos[1].AddComment(new Comment("Alice", "Interesting video."));
        videos[1].AddComment(new Comment("Jean", "Well done!"));
        videos[1].AddComment(new Comment("Fransisco", "Informative and engaging."));

        videos[2].AddComment(new Comment("Mike", "Excellent work!"));
        videos[2].AddComment(new Comment("Waite", "I learned a lot."));
        videos[2].AddComment(new Comment("Leo", "Keep up the good work!"));

        foreach (Video video in videos)
        {
            video.DisplayAllInformation();
            Console.WriteLine();
        }
    }
}