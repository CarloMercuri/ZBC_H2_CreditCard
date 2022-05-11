using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard.Cards
{
    public class MasterCard : BankCard, ICardActive, ICreditCard, ICardInternational, ICardOnlineUse, ICardMonthlyLimit, ICardExpiration
    {  

        public MasterCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            MonthlyLimit = 40000;
            DateTime exp = DateTime.Now.AddYears(5);
            ExpirationYear = exp.Year;
            ExpirationMonth = exp.Month;
            base.GenerateCardNumber(16);
        }

        public int MonthlyLimit { get; }

        public int ExpirationYear { get; }

        public int ExpirationMonth { get; }
    }
}
