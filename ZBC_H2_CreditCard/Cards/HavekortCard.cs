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

            base.GenerateCardNumber(16);
        }
    }
}
