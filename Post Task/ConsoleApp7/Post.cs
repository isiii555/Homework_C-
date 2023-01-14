namespace PostNamespace
{
    public class Post
    {
        public static int id;

        static Post()
        {
            id = 0;
        }

        public Post(string content, DateTime creationDateTime)
        {
            likeCount = default;
            viewCount = default;
            Id = ++id;
            Content = content;
            this.creationDateTime = creationDateTime;
        }

        public int Id { get; } 

        public string Content { get; set; }

        public DateTime creationDateTime { get; set; }

        public int likeCount { get; set; } = default;

        public int viewCount { get; set; } = default;

        public void ShowPost()
        {
            Console.WriteLine($"{Id} Post ");
            Console.WriteLine(Content);
            Console.WriteLine($"Views : {viewCount} ");
            Console.WriteLine($"Likes : {likeCount} ");
            Console.WriteLine($"Date : {creationDateTime}");
        }

    }
}
