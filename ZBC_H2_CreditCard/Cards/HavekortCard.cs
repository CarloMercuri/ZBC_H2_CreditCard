using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class HavekortCard : BankCard
    {
        public HavekortCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
          
            MonthlyLimit = 0;


            base.GenerateCardNumber(16);
        }

    }
}
