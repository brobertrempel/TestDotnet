using TestConsole;
using TestConsole.Models;

var users = new List<User>
{
    new User("sa", "g"),
    new User("Robert", "trobert")
};

Console.WriteLine("Hallo!");

while (true)
{
    Console.WriteLine("Willst du dich [E]inloggen, oder neu [R]egistrieren");
    var action = Console.ReadLine();

    if (action == "e" || action == "E")
    {
        UserLogin.Login(users);
    }
    if (action == "r" || action == "R")
    {
        users = UserLogin.Register(users);
    }
}

