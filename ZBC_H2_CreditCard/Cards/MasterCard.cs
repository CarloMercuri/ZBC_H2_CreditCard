using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class MasterCard : BankCard, IBankCard
    {  

        public MasterCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "MasterCard";
            CardType = CardType.Credit;
            MonthlyLimit = 40000;

            ExpirationYear = DateTime.Now.AddYears(5).Year;
            ExpirationMonth = DateTime.Now.Month;

            base.GenerateCardNumber(16);
        }

        public int GetMonthlyLimitRemaining()
        {
            return MonthlyLimit - MonthlyUsage;
        }
    }
}
