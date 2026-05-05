using System;

class Euro : Currency
{
    public Euro(double amount) : base(amount) { }

    public override double ToUAH() => Amount * 42;

    public override void Print()
    {
        Console.WriteLine($"{Amount} Euro = {ToUAH()} UAH");
    }
}