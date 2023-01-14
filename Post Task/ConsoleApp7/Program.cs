using PostNamespace;
using UserNamespace;
using AdminNamespace;
using ConsoleApp7;
using DatabaseNamespace;


#region Initialize
Post post1 = new("Hello World", DateTime.Now );
Post post2 = new("Ikinci post", DateTime.Now);
Post post3 = new("Ucuncu post", new DateTime(2023, 1, 14, 2, 59, 45));

User islam = new("isii555", "Islam", "Salamzade", 21, "islam.salamzade.191@gmail.com", "islam123");

Admin islam1 = new("isii555", "islam123", "islam.salamzade.191@gmail.com");

Database dt = new();

islam1.posts.Add(post1);
islam1.posts.Add(post2);
islam1.posts.Add(post3);

dt.users.Add(islam);
dt.admins.Add(islam1);
#endregion

#region Functions
bool CheckUser(string input,string password,List<User> list)
{
    if(input.Contains("@")) 
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (input == list[i].Email)
            {
                if (password == list[i].Password)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }
    else
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (input == list[i].Username)
            {
                if (password == list[i].Password)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }
}

bool CheckAdmin(string input,string password, List<Admin> list)
{
    if (input.Contains("@"))
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (input == list[i].Email)
            {
                if (password == list[i].Password)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }
    else
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (input == list[i].Username)
            {
                if (password == list[i].Password)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }
}

bool CheckPost(int index,List<Post> list)
{
        for (int i = 0; i < list.Count; i++)
        {
            if (index == list[i].Id)
            {
                return true;
            }
        }
        return false;
}

User? User(string username,List<User> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (username == list[i].Username)
        {
            return list[i];
        }
    }
    return null;
}

void AdminMenu()
{
    labellogin:
    Console.Clear();
    Console.WriteLine("Please enter username or email");
    string? userinput = Console.ReadLine();
    Console.WriteLine("Please enter password");
    string? userinput2 = Console.ReadLine();
    if (CheckAdmin(userinput ?? "null", userinput2 ?? "null", dt.admins))
    {
        labelmenu:
        Console.Clear();
        Console.WriteLine("1.Posts");
        Console.WriteLine("2.Notifications");
        Console.WriteLine("0.Back");
        userinput = Console.ReadLine();
        if(userinput == "1")
        {
            labelposts:
            Console.Clear();
            for (int i = 0; i < dt.admins[0].posts.Count; i++)
            {
                dt.admins[0].posts[i].ShowPost();
            }
            Console.WriteLine("Enter post id for action");
            Console.WriteLine("0.Back");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == 0)
            {
                goto labelmenu;
            }
            else if (CheckPost(id, dt.admins[0].posts))
            {
                Console.Clear();
                dt.admins[0].posts[id - 1].viewCount++;
                dt.admins[0].posts[id - 1].ShowPost();
                Console.WriteLine("1.Remove post");
                Console.WriteLine("0.Back");
                userinput = Console.ReadLine();
                if (userinput == "1")
                {
                    dt.admins[0].posts.Remove(dt.admins[0].posts[id - 1]);
                    Console.Clear();
                    Console.WriteLine("Post removed");
                    Thread.Sleep(1000);
                    goto labelposts;
                }
                else if (userinput == "0")
                    goto labelmenu;
                else
                {
                    Console.WriteLine("Wrong choice,try again");
                    goto labelposts;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong choice,try again");
                Thread.Sleep(1000);
                goto labelposts;
            }
        }
        else if(userinput == "2")
        {
            labelnotifications:
            Console.Clear();
            for (int i = 0; i < dt.admins[0].notifications.Count; i++)
            {
                dt.admins[0].notifications[i].ShowNotification();
            }
            Console.WriteLine("1.Clear notifications");
            Console.WriteLine("0.Back");
            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                dt.admins[0].notifications.Clear();
                Console.Clear();
                Console.WriteLine("Notifications removed");
                Thread.Sleep(1000);
                goto labelnotifications;
            }
            else if(userinput == "0")
            {
                goto labelmenu;
            }
            else
            {
                Console.WriteLine("Wrong choice,try again");
                goto labelnotifications;
            }
        }
        else if(userinput == "0")
        {
            Main();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong choice,try again");
            Thread.Sleep(1000);
            goto labellogin;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Wrong username(email) or password");
        Thread.Sleep(1000);
        goto labellogin;
    }
}

void UserMenu()
{
    labellogin:
    Console.Clear();
    Console.WriteLine("Please enter username or email");
    string? username = Console.ReadLine();
    Console.WriteLine("Please enter password");
    string? userinput2 = Console.ReadLine();
    if (CheckUser(username ?? "null", userinput2 ?? "null" , dt.users))
    {
        labelposts:
        Console.Clear();
        for (int i = 0; i < dt.admins.Count; i++)
        {
            for (int j = 0; j < dt.admins[i].posts.Count; j++)
            {
                dt.admins[i].posts[j].ShowPost();
            }
        }
        Console.WriteLine("Enter post id for view");
        Console.WriteLine("0.Back");
        int id = Convert.ToInt32(Console.ReadLine());
        if (id == 0)
        {
            Main();
        }
        else if (CheckPost(id, dt.admins[0].posts))
        {
            Console.Clear();
            dt.admins[0].posts[id - 1].viewCount++;
            dt.admins[0].posts[id - 1].ShowPost();
            Console.WriteLine("1.Like");
            Console.WriteLine("0.Back");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                dt.admins[0].posts[id - 1].likeCount += 1;
                Console.Clear();
                Console.WriteLine("You liked this post!");
                Thread.Sleep(1000);
                dt.admins[0].notifications.Add(new Notification($"{username} liked {id} post", DateTime.Now, User(username, dt.users)));
                goto labelposts;
            }
            else
                goto labelposts;
        }
        else
        {
            Console.Clear();    
            Console.WriteLine("Wrong choice,try again");
            Thread.Sleep(1000);
            goto labelposts;
        }

    }
    else
    {
        Console.Clear();
        Console.WriteLine("Wrong username(email) or password");
        Thread.Sleep(1000);
        goto labellogin;
    }
}

#endregion

void Main()
{
    Console.Clear();
    Console.WriteLine("1.Admin");
    Console.WriteLine("2.User");
    string? userinput = Console.ReadLine();
    if (userinput == "1")
    {
        AdminMenu();
    }
    else if(userinput == "2")
    {
        UserMenu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Wrong choice,try again");
        Thread.Sleep(1000);
        Main();
    }
}

Main();

