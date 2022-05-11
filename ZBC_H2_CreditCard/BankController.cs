using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard
{
    public class BankController
    {
        private CardGenerator _cardGenerator;
        private List<BankAccount> _bankAccounts;
        private RandomNameGenerator _randomNameGenerator;

        public BankController()
        {
            _cardGenerator = new CardGenerator();
            _bankAccounts = new List<BankAccount>();
            _randomNameGenerator = new RandomNameGenerator();
        }

        /// <summary>
        /// Generates a new bank account, with randomly generated name and surname
        /// </summary>
        public void CreateNewBankAccount()
        {
            string firstName = _randomNameGenerator.GenerateRandomFirstName();
            string lastName = _randomNameGenerator.GenerateRandomLastName();

            bool numberSuccess = false;
            string accountNumber = "";

            // No duplicates
            while (!numberSuccess)
            {
                accountNumber = GenerateAccountNumber();
                if(_bankAccounts.Find(x => x.AccountNumber == accountNumber) == null)
                {
                    numberSuccess = true;
                }
            }

            BankAccount bankAccount = new BankAccount(firstName, lastName, accountNumber);
            _bankAccounts.Add(bankAccount);

        }

        /// <summary>
        /// Generates and adds a card to the specified account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="cardName"></param>
        public void GenerateCardForAccount(BankAccount account, CardName cardName)
        {
            BankCard card = _cardGenerator.GenerateCard(cardName, account.AccountNumber, account.FirstName, account.LastName);
            account.AddCard(card);
        }

        public string GetCardExpiration(BankCard card)
        {
            if(card is ICardExpiration)
            {
                ICardExpiration expiration = (ICardExpiration)card;
                return expiration.ExpirationYear + "-" + expiration.ExpirationMonth;
            }
            else
            {
                return "n/a";
            }
        }

        public bool UseCardOnline(BankCard card, int amount)
        {
            bool active = card is ICardActive;
            bool international = card is ICardInternational;

            if (!active || !international)
            {
                return false;
            }

            BankAccount account = _bankAccounts.Find(x => x.AccountNumber == card.GetAccountNumber());

            if (card is IDebitCard)
            {
                if (amount < account.Balance)
                {
                    account.Balance -= amount;
                    return true;
                }

                return false;
            }

            if (card is ICreditCard)
            {
                if (card is ICardMonthlyLimit)
                {
                    ICardMonthlyLimit cardLimit = card as ICardMonthlyLimit;

                    if (cardLimit.MonthlyLimit - amount > 0)
                    {
                        card.AddToMonthlyUsage(amount);
                        account.Balance -= amount;
                        return true;
                    }

                    return false;
                }
                else
                {
                    account.Balance -= amount;
                    return true;
                }
            }

            return false;
        }

        public bool UseCard(BankCard card, int amount)
        {
            bool active = card is ICardActive;

            if(!active)
            {
                return false;
            }

            BankAccount account = _bankAccounts.Find(x => x.AccountNumber == card.GetAccountNumber());

            if (card is IDebitCard)
            {
                if (amount < account.Balance)
                {
                    account.Balance -= amount;
                    return true;
                }

                return false;
            }

            if(card is ICreditCard)
            {
                if(card is ICardMonthlyLimit)
                {
                    ICardMonthlyLimit cardLimit = card as ICardMonthlyLimit;

                    if(cardLimit.MonthlyLimit - amount > 0)
                    {
                        account.Balance -= amount;
                        card.AddToMonthlyUsage(amount);
                        return true;
                    }

                    return false;
                }
                else
                {
                    account.Balance -= amount;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Generates a random account number
        /// </summary>
        /// <returns></returns>
        private string GenerateAccountNumber()
        {            
            string tempNumber = "3520";           
            Random rand = new Random();
            StringBuilder builder = new StringBuilder(tempNumber);

            while (builder.Length < 14)
            {
                builder.Append(rand.Next(0, 10).ToString());
            }           

            return builder.ToString();
        }

        /// <summary>
        /// Returns a list of all the bank accounts
        /// </summary>
        /// <returns></returns>
        public List<BankAccount> GetBankAccounts()
        {
            return _bankAccounts;
        }
    }
}
