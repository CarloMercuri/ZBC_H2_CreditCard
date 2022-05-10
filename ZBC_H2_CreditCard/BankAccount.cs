using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard
{
    public class BankAccount
    {
        private string accountNumber;

        /// <summary>
        /// The account number
        /// </summary>
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private int balance;
        /// <summary>
        /// The current balance of the account
        /// </summary>
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private string firstName;

        /// <summary>
        /// First name of the owner of the account
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        /// <summary>
        /// Last name of the owner of the account
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// The cards connected to this account
        /// </summary>
        private List<BankCard> cards;

        public BankAccount(string firstName, string lastName, string accountNumber)
        {
            cards = new List<BankCard>();
            this.firstName = firstName;
            this.lastName = lastName;
            this.accountNumber = accountNumber;
        }

        /// <summary>
        /// Adds a card to the account
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(BankCard card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// Adds the specified funds to the account
        /// </summary>
        /// <param name="amount"></param>
        public void AddFunds(int amount)
        {
            balance += amount;
        }        

        /// <summary>
        /// Returns true if the operation was successful (aka if there are enough funds)
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool WithdrawFunds(int amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Account holder: {firstName} {lastName}. Konto number: {accountNumber}\n\r");
            sb.Append($"Cards: {cards.Count}\n\r");
            sb.Append($"Balance: Kr. {balance}\n\r");
            sb.Append($"\n\r");
            sb.Append($"// CARDS //\n\r");
            sb.Append("\n\r");

            foreach(BankCard card in cards)
            {
                sb.Append($"Card name: {card.GetCardName()}\n\r");
                sb.Append($"Card type: {card.GetCardType()}\n\r");
                sb.Append($"Card number: {card.GetCardNumber()}\n\r");
                sb.Append($"Card withdrawal remaining: " + (card.GetMonthlyLimitRemaining() == -1? balance : card.GetMonthlyLimitRemaining()) + "\n\r");
                sb.Append("\n\r");
                sb.Append("-----------");
                sb.Append("\n\r");
            }

            return sb.ToString();
        }

    }
}
