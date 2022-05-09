using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard
{
    public abstract class BankCard
    {
        protected string CardNumber { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string AccountNumber { get; set; }
        protected string CardName { get; set; }

        protected string[] cardPrefixes { get; set; }

        public BankCard(string firstName, string lastName, string accountNumber, string[] prefixes)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountNumber = accountNumber;
            this.cardPrefixes = prefixes;            
        }

        public void GenerateCardNumber(int lenght)
        {
            Random rand = new Random();
            string tempNumber = cardPrefixes[rand.Next(0, cardPrefixes.Length)];

            StringBuilder builder = new StringBuilder(tempNumber);
            
            while(builder.Length < lenght)
            {
                builder.Append(rand.Next(0, 10).ToString());
            }

            CardNumber = builder.ToString();
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetCardNumber()
        {
            return CardNumber;
        }

        public string GetCardName()
        {
            return CardName;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

    }
}
