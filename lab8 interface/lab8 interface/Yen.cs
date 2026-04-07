using System;

namespace OOP_Lab9_Variant19_Interface
{
    public class Yen : ICurrency, IPrintable
    {
        private double amount;
        private const double rate = 0.27;

        public Yen(double amount)
        {
            this.amount = amount;
        }

        public double ToUAH()
        {
            return amount * rate;
        }

        public void Print()
        {
            Console.WriteLine($"Yen: {amount} => {ToUAH()} UAH");
        }
    }
}