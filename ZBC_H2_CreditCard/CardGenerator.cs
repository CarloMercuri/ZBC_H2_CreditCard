using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Cards;

namespace ZBC_H2_CreditCard
{
    public class CardGenerator
    {
        private string[] visaElectron_Prefixes = new string[]
        {
            "4026",
            "4175",
            "4508",
            "4844",
            "4913",
            "4917"
        };

        private string[] visa_Prefixes = new string[]
        {
            "4"
        };

        private string[] masterCard_Prefixes = new string[]
        {
            "51",
            "52",
            "53",
            "54",
            "55"
        };

        private string[] maestro_Prefixes = new string[]
        {
            "5018",
            "5020",
            "5038",
            "5893",
            "6304",
            "6759",
            "6761",
            "6762",
            "6763"
        };


        private string[] haveKort_Prefixes = new string[]
        {
            "2400"
        };

        public BankCard GenerateCard(CardType type)
        {
            BankCard card = null;

            switch (type)
            {
                case CardType.VISAElectron:
                    card = new VisaElectronCard("Carlo", "Mercuri", "2020", visaElectron_Prefixes);
                    break;

                    case CardType.VISA:
                    card = new VisaCard("Carlo", "Mercuri", "2020", visa_Prefixes);
                    break;

                case CardType.MASTERCARD:
                    card = new MasterCard("Carlo", "Mercuri", "2020", masterCard_Prefixes);
                    break;

                case CardType.MAESTRO:
                    card = new MaestroCard("Carlo", "Mercuri", "2020", maestro_Prefixes);
                    break;

                case CardType.HAVE:
                    card = new HavekortCard("Carlo", "Mercuri", "2020", haveKort_Prefixes);
                    break;
            }

            return card;
            
        }

    }
}
