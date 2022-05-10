using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_CreditCard.Cards;

namespace ZBC_H2_CreditCard
{
    public class CardGenerator
    {
        public CardGenerator()
        {
        }


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

        /// <summary>
        /// Generates a card, based on the type, and connected to an account
        /// </summary>
        /// <param name="type"></param>
        /// <param name="accountNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public BankCard GenerateCard(CardName type, string accountNumber, string firstName, string lastName)
        {
            BankCard card = null;

            switch (type)
            {
                case CardName.VISAElectron:
                    card = new VisaElectronCard(firstName, lastName, accountNumber, visaElectron_Prefixes);
                    break;

                    case CardName.VISA:
                    card = new VisaCard(firstName, lastName, accountNumber, visa_Prefixes);
                    break;

                case CardName.MASTERCARD:
                    card = new MasterCard(firstName, lastName, accountNumber, masterCard_Prefixes);
                    break;

                case CardName.MAESTRO:
                    card = new MaestroCard(firstName, lastName, accountNumber, maestro_Prefixes);
                    break;

                case CardName.HAVE:
                    card = new HavekortCard(firstName, lastName, accountNumber, haveKort_Prefixes);
                    break;
            }

            return card;
            
        }     
    }
}
