using System.Collections.Concurrent;

namespace account_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to account management tool");
            Console.WriteLine();
            Console.WriteLine("type action that you want to make...");

            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();

            string[] actions = new[] 
                                { "type \\'add\\' if you want to add an account\"",
                                  "type 'view' if you want to view the account",
                                  "type 'verify' if you want to verify if an account is existing.",
                                  "type search if you want to search an user account",
                                  "type \'exit\' if you want to exit"};


            //actions.SetValue("DICT NEW ACTION", 2);

            //var indexNum = Array.IndexOf(actions, "type 'verify' if you want to verify if an account is existing.");

            //Console.WriteLine("the index is " + indexNum);

            //for (int i = 0; i < actions.Length; i++)
            //{
            //    Console.WriteLine(actions[i]);
            //}

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }


            Console.WriteLine();

            Console.Write("type action: ");
            string useraction = Console.ReadLine();

            string username = string.Empty;
            string password = string.Empty;

            //int usercounter = 0;

            while (useraction != "exit")
            {

                switch (useraction)
                {
                    case "add" or "ADD":
                        Console.WriteLine("ADD USER ACCOUNT");
                        Console.Write("enter username: ");
                        username = Console.ReadLine();
                        Console.Write("enter password: ");
                        password = Console.ReadLine();

                        usernames.Add(username);
                        passwords.Add(password);


                        Console.WriteLine("successfully added user " + username);

                        Console.WriteLine();

                        for (int i = 0; i < actions.Length; i++)
                        {
                            Console.WriteLine(actions[i]);
                        }
                        Console.WriteLine();

                        Console.Write("type action: ");

                        useraction = Console.ReadLine();

                        break;
                    case "search" or "SEARCH":
                        Console.Write("input the username you want to search: ");

                        string toSearch = Console.ReadLine();
                        bool isExisting =  usernames.Contains(toSearch);

                        if (isExisting)
                        {
                            Console.WriteLine("user exists!!!");
                        }
                        else
                        {
                            Console.WriteLine(toSearch + " is not existing..");
                        }


                        Console.WriteLine();    
                        for (int i = 0; i < actions.Length; i++)
                        {
                            Console.WriteLine(actions[i]);
                        }
                        Console.WriteLine();

                        Console.Write("type action: ");

                        useraction = Console.ReadLine();

                        break;
                    case "view" or "VIEW":
                        //Console.WriteLine("USER DETAILS");
                        //Console.WriteLine("username: " + username);

                        for (int i = 0; i < usernames.Count; i++)
                        {
                            Console.WriteLine("username: " + usernames[i]);
                            Console.WriteLine("password: " + passwords[i]);
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        for (int i = 0; i < actions.Length; i++)
                        {
                            Console.WriteLine(actions[i]);
                        }
                        Console.WriteLine();

                        Console.Write("type action: ");

                        useraction = Console.ReadLine();

                        break;
                    case "verify" or "VERIFY":
                        Console.WriteLine("Verify account details");

                        Console.Write("Enter username: ");
                        string usernameguess = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string passwordguess = Console.ReadLine();

                        if (usernameguess.Equals(username) && passwordguess.Equals(password))
                        {
                            Console.WriteLine("account verified. account is existing.");
                        }
                        else
                        {
                            Console.WriteLine("incorrect username or password.");
                        }


                        Console.WriteLine();
                        for (int i = 0; i < actions.Length; i++)
                        {
                            Console.WriteLine(actions[i]);
                        }
                        Console.WriteLine();

                        Console.Write("type action: ");

                        useraction = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("incorrect input. try again.");
                        break;
                }
            }

            Console.WriteLine("thank you.. ");

            Environment.Exit(0);
        }
    }
}