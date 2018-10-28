using System;

namespace DeclarationExpressions
{
    public struct Money
    {
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money Parse(string input)
        {
            var parts = input.Split(' ');
            var currency = parts[1];

            if (decimal.TryParse(parts[0], out var amount))
            {
                return new Money(amount, currency);
            }

            return new Money(0m, currency);
        }

        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
