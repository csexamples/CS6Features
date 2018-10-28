using System;

namespace DeclarationExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = Money.Parse("60 Eur");

            Console.WriteLine($"Amount: {money.Amount}");
            Console.WriteLine($"Currency: {money.Currency}");
        }
    }
}
