using System;
using System.Collections.Generic;

namespace FormatException
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }
     class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.Write("enter account holder name:");
            account.AccountHolderName=Console.ReadLine();
            Console.Write("ENter account number:");
            account.AccountNumber=int.Parse(Console.ReadLine());
            Console.Write("Enter current balance:");
            account.CurrentBalance=double.Parse(Console.ReadLine());
            Console.WriteLine("\n New bank account details");
            Console.WriteLine("Account holder name:"+account.AccountHolderName);
            Console.WriteLine("Account number:"+account.AccountNumber);
            Console.WriteLine("Current Balance:"+account.CurrentBalance);

            Console.ReadKey();
        }
    }
}
