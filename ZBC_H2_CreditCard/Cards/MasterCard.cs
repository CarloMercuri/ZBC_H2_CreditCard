using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class MasterCard : BankCard
    {  

        public MasterCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            MonthlyLimit = 40000;


            base.GenerateCardNumber(16);
        }

    }
}
