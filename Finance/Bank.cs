using System;
using System.Collections.Generic;

namespace Finance
{
    public abstract class Bank
    {
        protected Dictionary<string, string> userInfo = new Dictionary<string, string>();

        public Bank(User client)
        {
            this.userInfo = client.getInfo();
            //then...We can use <userInfo> in the interest of the bank
        }

        internal string OpenAccount()
        {
            beginToStart: Console.Clear();
            Console.WriteLine("what type of biils do you want to open?");
            Console.WriteLine();

            Console.WriteLine("1:Credit");
            Console.WriteLine("2:Deposit");
            Console.WriteLine("3:Checking");

            string myChoice = Console.ReadLine();
            string bill;
            switch (myChoice)
            {
                case "1":
                    bill = "Credit";
                    break;
                case "2":
                    bill = "Deposit";
                    break;
                case "3":
                    bill = "Checking";
                    break;
                default:
                    goto beginToStart;
                    break;
            }

            return bill;

        }

    }
}
