using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class VisaElectronCard : BankCard
    {
        public VisaElectronCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "VISA Electron";
            CardType = CardType.Debit;
            MonthlyLimit = 10000;
            ExpirationYear = DateTime.Now.AddYears(5).Year;
            ExpirationMonth = DateTime.Now.Month;

            base.GenerateCardNumber(16);
        }

        public override int GetMonthlyLimitRemaining()
        {
            return MonthlyLimit - MonthlyUsage;
        }
    }
}
