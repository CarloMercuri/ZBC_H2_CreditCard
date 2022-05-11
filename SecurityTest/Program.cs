using System;
using ZBC_H2_CreditCard;

namespace SecurityTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CardGenerator g = new CardGenerator();
            BankCard card = g.GenerateCard(CardName.MAESTRO, "ss", "ss", "ss");
            BankController controller = new BankController();
            MaestroCard c = card as MaestroCard;
            string s2 = controller.GetCardExpiration(card);
            Console.WriteLine($"Direct: {c.ExpirationYear}");
            Console.WriteLine($"From controller: {s2}");
            Console.ReadKey();
        }
    }
}
