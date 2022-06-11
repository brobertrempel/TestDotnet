using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Models;

namespace TestConsole
{
    internal static class UserLogin
    {
        /// <summary>
        /// Script to login users
        /// </summary>
        /// <param name="users">Existing users</param>
        public static void Login(List<User> users)
        {
            bool isLoggedIn = false;
            var username = "";
            var password = "";

            while (isLoggedIn == false)
            {
                Console.WriteLine("Wie ist dein Username?");
                username = Console.ReadLine();

                Console.WriteLine("Wie ist dein Passwort?");
                password = Console.ReadLine();

                foreach (var user in users)
                {
                    if (username == user.Username && password == user.Password)
                    {
                        Console.Clear();
                        isLoggedIn = true;
                    }
                }

                if (isLoggedIn == false)
                {
                    Console.Clear();
                    Console.WriteLine("Logindaten nicht korrekt!");
                }
            }

            Console.WriteLine("Willkommen " + username);
        }

        /// <summary>
        /// Script to register new user
        /// </summary>
        /// <param name="users">Existing users</param>
        /// <returns></returns>
        public static List<User> Register(List<User> users)
        {
            var newUsername = "";
            var newPassword = "";
            var newPasswordConfirmation = "";

            var isRegistered = false;

            while (isRegistered == false)
            {
                Console.WriteLine("Neuen Benutzernamen eingeben");
                newUsername = Console.ReadLine();

                Console.WriteLine("Passwort für neuen Benutzer eingeben");
                newPassword = Console.ReadLine();

                Console.WriteLine("Passwort für neuen Benutzer wiederholen");
                newPasswordConfirmation = Console.ReadLine();

                if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
                {
                    Console.Clear();
                    Console.WriteLine("Username oder Passwort können nicht leer sein.");
                }
                else
                {
                    if (newPassword != newPasswordConfirmation)
                    {
                        Console.Clear();
                        Console.WriteLine("Passwörter müssen übereinstimmen.");
                    }
                    else
                    {
                        users.Add(new User(newUsername, newPassword));
                        isRegistered = true;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Neuer Benutzer " + newUsername + " registriert");

            return users;
        }
    }
}
