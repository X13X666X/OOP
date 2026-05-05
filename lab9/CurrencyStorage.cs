using System.Collections.Generic;

class CurrencyStorage<T> : IInterface<T> where T : Currency
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public void PrintAll()
    {
        foreach (var item in list)
            item.Print();
    }
}