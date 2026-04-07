using System;

namespace OOP_Lab9_Variant19
{
    public class Yen : Currency
    {
        private const double rate = 0.27; // 1 єна ≈ 0.27 грн

        public Yen(double amount) : base(amount) { }

        public override double ToUAH()
        {
            return amount * rate;
        }

        public override void Print()
        {
            Console.WriteLine($"Yen: {amount} => {ToUAH()} UAH");
        }
    }
}