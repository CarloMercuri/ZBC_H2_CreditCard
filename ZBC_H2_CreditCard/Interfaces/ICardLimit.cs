using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Interfaces
{
    public interface ICardLimit
    {
        int MonthlyLimit { get; protected set; }
    }
}
