using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard
{
    public abstract class BankCard
    {
        string CardNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string AccountNumber { get; set; }
        int MonthlyUsage { get; set; }

        protected string[] cardPrefixes { get; set; }

        public BankCard(string firstName, string lastName, string accountNumber, string[] prefixes)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountNumber = accountNumber;
            this.cardPrefixes = prefixes;            
        }

        public void AddToMonthlyUsage(int amount)
        {
            this.MonthlyUsage += amount;
        }

        /// <summary>
        /// Generates a random card number with the specified prefixes
        /// </summary>
        /// <param name="lenght"></param>
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

        public bool UseMoney(int amount)
        {
            BankController controller = new BankController();
            return controller.UseCard(this, amount);
        }

        public bool OnlinePayment(int amount)
        {
            BankController controller = new BankController();
            return controller.UseCardOnline(this, amount);
        }

        /// <summary>
        /// Returns the type of card (debit or credit)
        /// </summary>
        /// <returns></returns>
        public string GetCardType()
        {
            if(this is IDebitCard)
            {
                return "Debit";
            }
            else if(this is ICreditCard)
            {
                return "Credit";
            }

            return "n/a";
        }

        /// <summary>
        /// Returns the name of the card (Maestro, visa, etc)
        /// </summary>
        /// <returns></returns>
        public string GetCardName()
        {
           return this.GetType().Name;
        }

        /// <summary>
        /// Returns the full name of the owner
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        /// <summary>
        /// Returns the card number
        /// </summary>
        /// <returns></returns>
        public string GetCardNumber()
        {
            return CardNumber;
        }

        public bool CanUseInternationally()
        {
            return (this is ICardInternational);
        }

        public bool IsActive()
        {
            return (this is ICardActive);
        }

        public string GetExpirationDate()
        {
            if(this is ICardExpiration)
            {
                ICardExpiration expiration = (ICardExpiration)this;
                return expiration.ExpirationYear + "-" + expiration.ExpirationMonth;
            }
            else
            {
                return "n/a";
            }
        }

        /// <summary>
        /// Returns the account number connected to this card
        /// </summary>
        /// <returns></returns>
        public string GetAccountNumber()
        {
            return AccountNumber;
        }


        public int GetMonthlyLimitRemaining()
        {
            return 1;
        }
    }
}
