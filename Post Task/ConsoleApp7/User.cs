namespace UserNamespace
{
    public class User
    {
        public static int id;

        static User()
        {
            id = 0;
        }

        public User(string username,string name, string surname, byte age, string email, string password)
        {
            Id = ++id;
            Username = username;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

        public int Id { get; }

        public string Username { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public byte Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
