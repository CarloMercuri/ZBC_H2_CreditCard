using System;
using System.Collections.Generic;
using System.IO;
using ZBC_H2_CreditCard.Cards;

namespace ZBC_H2_CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankController bankController = new BankController();
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                bankController.CreateNewBankAccount();

            }

            List<BankAccount> accounts = bankController.GetBankAccounts();

            foreach (BankAccount account in accounts)
            {
                account.AddFunds(rand.Next(5000, 56000));

                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    bankController.GenerateCardForAccount(account, (CardName)rand.Next(1, 6));
                }

                
            }

            foreach(BankAccount account in accounts)
            {
                Console.WriteLine(account.ToString());
                Console.WriteLine("-------");
            }

            Console.ReadKey();
        }
    }
}
