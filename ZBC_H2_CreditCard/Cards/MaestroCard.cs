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
            CardType = CardType.Debit;
            MonthlyLimit = 0;

            DateTime exp = DateTime.Now.AddYears(5).AddMonths(8);
            ExpirationYear = exp.Year;
            ExpirationMonth = exp.Month;

            base.GenerateCardNumber(19);
        }

        public int GetMonthlyLimitRemaining()
        {
            return -1; // Debit
        }
    }
}
