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
        protected CardType CardType { get; set; }
        protected int MonthlyLimit { get; set; }
        protected int MonthlyUsage { get; set; }
        protected int ExpirationYear { get; set; }
        protected int ExpirationMonth { get; set; }

        protected string[] cardPrefixes { get; set; }

        public BankCard(string firstName, string lastName, string accountNumber, string[] prefixes)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountNumber = accountNumber;
            this.cardPrefixes = prefixes;            
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

        /// <summary>
        /// Returns the type of card (debit or credit)
        /// </summary>
        /// <returns></returns>
        public string GetCardType()
        {
            return Enum.GetName(typeof(CardType), CardType);
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

        /// <summary>
        /// Returns the name of the card (Maestro, Mastercard, etc...)
        /// </summary>
        /// <returns></returns>
        public string GetCardName()
        {
            return CardName;
        }

        /// <summary>
        /// Returns the account number connected to this card
        /// </summary>
        /// <returns></returns>
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        /// <summary>
        /// Returns the expiration date in yyyy-MM format
        /// </summary>
        /// <returns></returns>
        public virtual string GetExpirationDate()
        {
            return $"{ExpirationYear}-{ExpirationMonth}";
        }

    }
}
