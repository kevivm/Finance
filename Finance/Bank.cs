using System;
using System.Collections.Generic;

namespace Finance
{
    internal class Bank
    {
        protected Dictionary<string, string> UserInfo = new Dictionary<string, string>();

        public string BankName;

        public Bank(User client)
        {
            this.UserInfo = client.Myinfo;
            //then...We can use <userInfo> in the interest of the bank
        }

        /**
         * Open user account Credit? || Deposit? || Checking?
         * 
         *@return string bill
         **/
        internal string OpenAccount()
        {
        beginToStart: Console.Clear();

            ConsoleHelper.BankOpenAccount();

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

            Console.Clear();
            Console.WriteLine($"You have been open {bill} bill in {BankName}");

            return bill;

        }

    }
}
