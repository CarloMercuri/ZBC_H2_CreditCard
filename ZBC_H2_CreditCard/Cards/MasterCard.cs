using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class MasterCard : BankCard, IBankCard
    {  

        public MasterCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "MasterCard";
                        
            base.GenerateCardNumber(16);
        }
    }
}
