using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class VisaCard : BankCard
    {
        public VisaCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            MonthlyLimit = 20000;

            base.GenerateCardNumber(16);
        }

    }
}
