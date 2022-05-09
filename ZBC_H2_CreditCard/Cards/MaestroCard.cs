using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard
{
    public class MaestroCard : BankCard, IBankCard
    {
        public MaestroCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "Maestro";

            base.GenerateCardNumber(19);
        }
    }
}
