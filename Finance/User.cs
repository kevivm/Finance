using System;
using System.Collections.Generic;
using System.Linq;

namespace Finance
{
    public class User
    {
        private Dictionary<string, string> myInfo = new Dictionary<string, string>();

        private List<string> billsPrivat24 = new List<string>();
        private List<string> billsPumb = new List<string>();
        private List<string> billsAlfabank = new List<string>();

        internal User(string name, string pasportNumber)
        {
            myInfo.Add("Name", name);
            myInfo.Add("pasportNumber", pasportNumber);
        }

        //Show Start Menu. endless cycle 
        internal void StartMenu()
        {
            beginToStart: Console.Clear();

            Console.WriteLine("Menu:");
            Console.WriteLine("1:Open account of bank");
            Console.WriteLine("0:Info");
            Console.WriteLine("9:Exit Programm");

            string myChoice = Console.ReadLine();

            switch (myChoice)
            {
                case "1":
                    IWantToOpenAccountInBank();
                    break;
                case "0":
                    GetInfoAboutMe();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    goto beginToStart;
                    break;
            }

        }

        internal Dictionary<string, string> getInfo()
        {
            return this.myInfo;
        }

        // register account in Privat24 overload method
        private void IWantToBank(Bank I, string typeBill)
        {
            string bill = I.OpenAccount();
            SetBills(typeBill, bill);
            ShowMessageStartMenu();
        }

        // register account in Pumb overload method
        private void IWantToBank(Pumb I, string typeBill)
        {
            string bill = I.OpenAccount();
            SetBills(typeBill, bill);
            ShowMessageStartMenu();
        }

        // register account in AlfaBank overload method
        private void IWantToBank(AlfaBank I, string typeBill)
        {
            string bill = I.OpenAccount();
            SetBills(typeBill, bill);
            ShowMessageStartMenu();
        }

        private void IWantToOpenAccountInBank()
        {
            beginToStart: Console.Clear();

            Console.WriteLine("Hi. If you want to open account of bank you need do your choice:");
            Console.WriteLine();
            Console.WriteLine("1:Privat24");
            Console.WriteLine("2:Pumb");
            Console.WriteLine("3:AlfaBank");
            Console.WriteLine("0:Start Menu");

            string myChoice = Console.ReadLine();

            switch (myChoice)
            {
                case "1":
                    Privat24 Privat24 = new Privat24(this);
                    IWantToBank(Privat24, "Privat24");
                    break;
                case "2":
                    Pumb Pumb = new Pumb(this);
                    IWantToBank(Pumb, "Pumb");
                    break;
                case "3":
                    AlfaBank AlfaBank = new AlfaBank(this);
                    IWantToBank(AlfaBank, "AlfaBank");
                    break;
                case "0":
                    StartMenu();
                    break;
                default:
                    goto beginToStart;
                    break;
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
                        Console.WriteLine("arg <string selectBank> is not correct");
                        break;
                }
            }
        }


        private void ShowMessageStartMenu()
        {
            Console.WriteLine("Please press ENTER to start menu");
            Console.ReadLine();
            StartMenu();
        }

    }
}