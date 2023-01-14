using ConsoleApp7;
using PostNamespace;

namespace AdminNamespace
{
    public class Admin
    {
        public static byte id;

        static Admin()
        {
            id = 0;
        }

        public Admin(string username, string password, string email)
        {
            Id = ++id;
            Username = username;
            Password = password;
            Email = email;
        }

        public List<Notification> notifications = new();

        public List<Post> posts = new();
        public byte Id { get; }

        public string Username { get; set; }   

        public string Password { get; set; }

        public string Email { get; set; }   

    }
}
