using System;

namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string username = "Semenov Igor Andreevish";
            string pasportNumber = "FA 295102";

            User user = new User(username, pasportNumber);
            user.StartMenu();
        }
    }
}
