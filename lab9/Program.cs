using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        CurrencyStorage<Currency> storage = new CurrencyStorage<Currency>();
        storage.Add(new Yen(1000));
        storage.Add(new Euro(50));
        storage.PrintAll();

        Console.WriteLine();

        // Завдання 2
        IInterfaceNonGeneric info = new Info();
        Console.WriteLine(info.GetInfo<int, double>(10, 5.5));
        Console.WriteLine(info.GetInfo<Yen, Euro>(new Yen(100), new Euro(20)));
    }
}