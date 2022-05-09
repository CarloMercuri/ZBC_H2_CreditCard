using System;
using ZBC_H2_CreditCard.Cards;

namespace ZBC_H2_CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CardGenerator generator = new CardGenerator();

            for (int i = 1; i < 6; i++)
            {
                BankCard c = generator.GenerateCard((CardType)i);
                Console.WriteLine(c.GetCardName());
                Console.WriteLine(c.GetCardNumber());
                Console.WriteLine();
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
