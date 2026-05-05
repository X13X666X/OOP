using System;

class Yen : Currency
{
    public Yen(double amount) : base(amount) { }

    public override double ToUAH() => Amount * 0.25;

    public override void Print()
    {
        Console.WriteLine($"{Amount} Yen = {ToUAH()} UAH");
    }
}