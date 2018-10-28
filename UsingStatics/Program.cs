using System;

namespace UsingStatics
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(60m, "Eur");
            var m2 = new Money(20m, "Eur");
            var m3 = m1 + m2;

            Console.WriteLine($"{m3.Amount} {m3.Currency}");
        }
    }
}
