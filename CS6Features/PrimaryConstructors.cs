using System;
namespace CS6Features
{
    public struct Money(decimal amount, string currency)
    {
        public decimal Amount { get; private set; } = amount;
        public string Currency { get; private set; } = currency;
    }
}
