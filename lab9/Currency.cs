abstract class Currency
{
    public double Amount { get; set; }

    public Currency(double amount)
    {
        Amount = amount;
    }

    public abstract double ToUAH();
    public abstract void Print();

    public override string ToString()
    {
        return $"{Amount} ({GetType().Name})";
    }
}