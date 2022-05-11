using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard.Cards
{
    public class HavekortCard : BankCard, ICardActive, IDebitCard
    {
        public HavekortCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            base.GenerateCardNumber(16);
        }
    }
}
