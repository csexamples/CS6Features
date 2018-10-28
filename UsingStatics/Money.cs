using System;
using static UsingStatics.StringExtensions;

namespace UsingStatics
{
    public struct Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

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

        public static Money operator +(Money m1, Money m2)
        {
            if (AreNotSameSymbols(m1.Currency, m2.Currency))
            {
                var template = "Cannot add currency {0} to currency {1}";
                var message = Format(template, m1.Currency, m2.Currency);
                throw new InvalidOperationException(message);
            }

            return new Money(m1.Amount + m2.Amount, m1.Currency);
        }
    }
}
