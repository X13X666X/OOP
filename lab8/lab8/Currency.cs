using System;

namespace OOP_Lab9_Variant19
{
    public abstract class Currency
    {
        protected double amount;

        public Currency(double amount)
        {
            this.amount = amount;
        }

        public abstract double ToUAH();

        public virtual void Print()
        {
            Console.WriteLine($"Amount: {amount}");
        }
    }
}