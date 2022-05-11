using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard
{
    public class MaestroCard : BankCard, ICardActive, ICardExpiration, ICardInternational, IDebitCard, ICardOnlineUse
    {
        public MaestroCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {            
            DateTime exp = DateTime.Now.AddYears(5).AddMonths(8);
            ExpirationYear = exp.Year;
            ExpirationMonth = exp.Month;
            base.GenerateCardNumber(19);            
        }

        public int ExpirationYear { get; }
        public int ExpirationMonth { get; }
    }
}
