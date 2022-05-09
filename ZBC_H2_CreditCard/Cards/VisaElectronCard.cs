using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Cards
{
    public class VisaElectronCard : BankCard, IBankCard
    {
        public VisaElectronCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardName = "VISA Electron";

            base.GenerateCardNumber(16);
        }
    }
}
