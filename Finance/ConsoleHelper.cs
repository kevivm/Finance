using System;

namespace Finance
{
    public class ConsoleHelper
    {
        public static void UserStartMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1:Open account of bank");
            Console.WriteLine("0:Info");
            Console.WriteLine("9:Exit Programm");
        }

        public static void UserIWantToOpenAccountInBank()
        {
            Console.WriteLine("Hi. If you want to open account of bank you need do your choice:");
            Console.WriteLine();
            Console.WriteLine("1:Privat24");
            Console.WriteLine("2:Pumb");
            Console.WriteLine("3:AlfaBank");
            Console.WriteLine("0:Start Menu");
        }

        public static void UserShowMessageStartMenu()
        {
            Console.WriteLine("Please press ENTER to start menu");
            Console.ReadLine();
        }

        public static void BankOpenAccount()
        {
            Console.WriteLine("what type of biils do you want to open?");
            Console.WriteLine();

            Console.WriteLine("1:Credit");
            Console.WriteLine("2:Deposit");
            Console.WriteLine("3:Checking");
        }
    }
}
