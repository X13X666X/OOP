using System;

namespace OOP_Lab9_Variant19_Interface
{
    public class Euro : ICurrency, IPrintable
    {
        private double amount;
        private const double rate = 42.0;

        public Euro(double amount)
        {
            this.amount = amount;
        }

        public double ToUAH()
        {
            return amount * rate;
        }

        public void Print()
        {
            Console.WriteLine($"Euro: {amount} => {ToUAH()} UAH");
        }
    }
}