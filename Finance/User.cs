using System;
using System.Collections.Generic;
using System.Linq;

namespace Finance
{
    public class User
    {
        public Dictionary<string, string> myInfo = new Dictionary<string, string>();

        private List<string> billsPrivat24 = new List<string>();
        private List<string> billsPumb = new List<string>();
        private List<string> billsAlfabank = new List<string>();

        internal User(Dictionary<string, string> info)
        {
            myInfo = info;
        }

        //Show Start Menu. endless cycle 
        internal void StartMenu()
        {
            bool switchFlag = true;

            while (switchFlag)
            {
                Console.Clear();
                ConsoleHelper.UserStartMenu();

                string myChoice = Console.ReadLine();

                switch (myChoice)
                {
                    case "1":
                        OpenAccountInBank();
                        switchFlag = false;
                        break;
                    case "0":
                        GetInfoAboutMe();
                        switchFlag = false;
                        break;
                    case "9":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        switchFlag = true;
                        break;
                }
            }
        }

        // register account in Privat24 overload method
        private void RegisterInBank(Bank bank, string typeBill)
        {
            string bill = bank.OpenAccount();
            SetBills(typeBill, bill);
            ShowMessageStartMenu();
        }

        private void OpenAccountInBank()
        {
        beginToStart: Console.Clear();

            ConsoleHelper.UserIWantToOpenAccountInBank();

            string myChoice = Console.ReadLine();

            switch (myChoice)
            {
                case "1":
                    Privat24 Privat24 = new Privat24(this);
                    RegisterInBank(Privat24, "Privat24");
                    break;
                case "2":
                    Pumb Pumb = new Pumb(this);
                    RegisterInBank(Pumb, "Pumb");
                    break;
                case "3":
                    AlfaBank AlfaBank = new AlfaBank(this);
                    RegisterInBank(AlfaBank, "AlfaBank");
                    break;
                case "0":
                    StartMenu();
                    break;
                default:
                    goto beginToStart;
                    break;
            }

        }

        //add to LIST bill value
        private void SetBills(string selectBank, string bill)
        {
            if (bill == "Credit" || bill == "Deposit" || bill == "Checking")
            {
                switch (selectBank)
                {
                    case "Privat24":
                        billsPrivat24.Add(bill);
                        billsPrivat24 = billsPrivat24.Distinct().ToList();
                        break;
                    case "Pumb":
                        billsPumb.Add(bill);
                        billsPumb = billsPumb.Distinct().ToList();
                        break;
                    case "AlfaBank":
                        billsAlfabank.Add(bill);
                        billsAlfabank = billsAlfabank.Distinct().ToList();
                        break;
                    default:
                        break;
                }
            }
        }

        //0:Info
        private void GetInfoAboutMe(bool flag = true)
        {
            Console.Clear();

            if (flag)
            {
                Console.WriteLine("Name:" + myInfo["Name"]);
                Console.WriteLine("Passport:" + myInfo["pasportNumber"]);
                Console.WriteLine();
            }

            if (billsPrivat24.Count > 0)
            {
                Console.Write("privat24 bills: ");

                foreach (string privat24 in this.billsPrivat24)
                {
                    Console.Write(privat24 + " | ");
                }

                Console.WriteLine();
            }

            if (billsPumb.Count > 0)
            {
                Console.Write("Pumb bills: ");

                foreach (string pumb in this.billsPumb)
                {
                    Console.Write(pumb + " | ");
                }

                Console.WriteLine();
            }

            if (billsAlfabank.Count > 0)
            {
                Console.Write("AlfaBank bills: ");

                foreach (string alfa in this.billsAlfabank)
                {
                    Console.Write(alfa + " | ");
                }
            }

            Console.WriteLine();
            ShowMessageStartMenu();
        }

        private void ShowMessageStartMenu()
        {
            ConsoleHelper.UserShowMessageStartMenu();
            StartMenu();
        }

    }
}