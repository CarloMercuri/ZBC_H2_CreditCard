using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_CreditCard.Interfaces
{
    internal interface ICardExpiration
    {
        public int ExpirationYear { get; }
        public int ExpirationMonth { get; }
    }
}
