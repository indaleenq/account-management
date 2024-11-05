using System;
using System.Collections.Concurrent;

namespace account_management
{
    internal class Program
    {
        //defined and created container for all menu actions
        static string[] actions = new[]
                            { "type \\'add\\' if you want to add an account\"",
                                  "type 'view' if you want to view the account",
                                  "type search if you want to search an user account",
                                  "type \'exit\' if you want to exit"};
        static List<string> usernames = new List<string>();
        static List<string> passwords = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to account management tool");
            Console.WriteLine();
            Console.WriteLine("type action that you want to make...");

            DisplayActions();

            Console.WriteLine();

            string useraction = GetUserAction();

            while (useraction != "exit")
            {
                switch (useraction)
                {
                    case "add" or "ADD":
                        AddUser();

                        Console.WriteLine();
                        DisplayActions();
                        Console.WriteLine();
                        useraction = GetUserAction();

                        break;
                    case "search" or "SEARCH":
                        
                        if (SearchUser())
                        {
                            Console.WriteLine("user exists!!!");
                        }
                        else
                        {
                            Console.WriteLine("not existing..");
                        }

                        Console.WriteLine();
                        DisplayActions();
                        Console.WriteLine();
                        useraction = GetUserAction();

                        break;
                    case "view" or "VIEW":

                        DisplayUsers(usernames, passwords);

                        Console.WriteLine();
                        DisplayActions();
                        Console.WriteLine();
                        useraction = GetUserAction();

                        break;
                    default:
                        Console.WriteLine("incorrect input. try again.");
                        break;
                }
            }

            Console.WriteLine("thank you.. ");

            Environment.Exit(0);
        }

        static public void DisplayActions()
        {
            //display actions
            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
        }

        public static string GetUserAction()
        {
            Console.Write("type user action: ");
            return Console.ReadLine();
        }

        public static void DisplayUsers(List<string> users, List<string> passes)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("username: " + users[i]);
                Console.WriteLine("password: " + passes[i]);
                Console.WriteLine();
            }
        }

        public static void AddUser()
        {
            string username = string.Empty;
            string password = string.Empty;

            //perform add functionality
            Console.WriteLine("ADD USER ACCOUNT");
            Console.Write("enter username: ");
            username = Console.ReadLine();
            Console.Write("enter password: ");
            password = Console.ReadLine();

            usernames.Add(username);
            passwords.Add(password);

            Console.WriteLine("successfully added user " + username);


        }

        public static bool SearchUser()
        {
            //perform search functionality
            Console.Write("input the username you want to search: ");

            string toSearch = Console.ReadLine();
            bool isExisting = usernames.Contains(toSearch);

            return isExisting;
        }

        //....
    }
}