using System;
using System.Collections.Generic;

namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string username = "Semenov Igor Andreevish";
            string pasportNumber = "FA295102";

            Dictionary<string, string> myInfo = new Dictionary<string, string>();

            myInfo.Add("Name", username);
            myInfo.Add("pasportNumber", pasportNumber);

            User user = new User(myInfo);
            user.StartMenu();
        }
    }
}
