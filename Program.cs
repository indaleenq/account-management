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

            Console.WriteLine("type \'add\' if you want to add an account");
            Console.WriteLine("type \'view\' if you want to view the account");
            Console.WriteLine("type \'verify\' if you want to verify if an account is existing.");
            Console.WriteLine("type \'exit\' if you want to exit");

            Console.WriteLine();

            Console.Write("type action: ");
            string useraction = Console.ReadLine();

            string username = string.Empty;
            string password = string.Empty;

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

                        Console.WriteLine("successfully added user " + username);

                        Console.WriteLine();
                        Console.WriteLine("type \'add\' if you want to add an account");
                        Console.WriteLine("type \'view\' if you want to view the account");
                        Console.WriteLine("type \'verify\' if you want to verify if an account is existing.");
                        Console.WriteLine("type \'exit\' if you want to exit");
                        Console.WriteLine();

                        Console.Write("type action: ");

                        useraction = Console.ReadLine();

                        break;
                    case "view" or "VIEW":
                        Console.WriteLine("USER DETAILS");
                        Console.WriteLine("username: " + username);


                        Console.WriteLine();
                        Console.WriteLine("type \'add\' if you want to add an account");
                        Console.WriteLine("type \'view\' if you want to view the account");
                        Console.WriteLine("type \'verify\' if you want to verify if an account is existing.");
                        Console.WriteLine("type \'exit\' if you want to exit");
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
                        Console.WriteLine("type \'add\' if you want to add an account");
                        Console.WriteLine("type \'view\' if you want to view the account");
                        Console.WriteLine("type \'verify\' if you want to verify if an account is existing.");
                        Console.WriteLine("type \'exit\' if you want to exit");
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