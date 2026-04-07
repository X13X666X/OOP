using System;

namespace OOP_Lab9_Variant19
{
    public class Euro : Currency
    {
        private const double rate = 42.0; // 1 євро ≈ 42 грн

        public Euro(double amount) : base(amount) { }

        public override double ToUAH()
        {
            return amount * rate;
        }

        public override void Print()
        {
            Console.WriteLine($"Euro: {amount} => {ToUAH()} UAH");
        }
    }
}