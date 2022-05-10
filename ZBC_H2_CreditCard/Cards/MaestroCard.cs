using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Interfaces;

namespace ZBC_H2_CreditCard
{
    public abstract class MaestroCard : BankCard, ICardLimit
    {
        int CardLimit;

        public MaestroCard(string firstName, string lastName, string accountNumber, string[] prefixes) : base(firstName, lastName, accountNumber, prefixes)
        {
            CardLimit = 15;
            MonthlyLimit = 0;
            DateTime exp = DateTime.Now.AddYears(5).AddMonths(8);

            base.GenerateCardNumber(19);
        }

        int ICardLimit.MonthlyLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
