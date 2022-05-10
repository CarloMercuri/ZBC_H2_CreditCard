using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class HavekortCard : BankCard, IBankCard
    {
        public HavekortCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "HaveKort";
            CardType = CardType.Debit;
            MonthlyLimit = 0;
            ExpirationYear = 2900; // no expiration
            ExpirationMonth = 12;

            base.GenerateCardNumber(16);
        }

        public int GetMonthlyLimitRemaining()
        {
            return -1; // Debit
        }

        public override string GetExpirationDate()
        {
            return "n/a"; 
        }
    }
}
