using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard
{
    public interface IBankCard
    {
        /// <summary>
        /// Returns the remaining funds able to be used with this card. -1 if it's unlimited (or debit)
        /// </summary>
        /// <returns></returns>
        public int GetMonthlyLimitRemaining();
    }
}
