using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard.Cards
{
    public class VisaElectronCard : BankCard, ICardActive, IDebitCard, ICardInternational, ICardOnlineUse, ICardMonthlyLimit, ICardExpiration
    {
        public VisaElectronCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            this.MonthlyLimit = 1000;
            DateTime exp = DateTime.Now.AddYears(5);
            ExpirationYear = exp.Year;
            ExpirationMonth = exp.Month;
            base.GenerateCardNumber(16);
        }

        public int MonthlyLimit { get; set; }

        public int ExpirationYear { get; }

        public int ExpirationMonth { get; }
    }
}
