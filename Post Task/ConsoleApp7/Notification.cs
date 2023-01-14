using UserNamespace;

namespace ConsoleApp7
{
    public class Notification
    {
        public static int id;

        static Notification()
        {
            id = 0;
        }

        public Notification(string text, DateTime dateTime, User fromUser)
        {
            Id = ++id;
            Text = text;
            this.dateTime = dateTime;
            this.fromUser = fromUser;
        }

        public int Id { get; }

        public string Text { get; set; }

        public DateTime dateTime { get; set; }  

        public User fromUser { get; set; }  

        public void ShowNotification()
        {
            Console.WriteLine($"{Id} Notification");
            Console.WriteLine(Text);
            Console.WriteLine($"Date : {dateTime}");
        }

    }
}
