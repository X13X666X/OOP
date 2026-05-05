class Info : IInterfaceNonGeneric
{
    public string GetInfo<T1, T2>(T1 value1, T2 value2)
    {
        return $"Type1: {typeof(T1).Name}, Value1: {value1}; " +
               $"Type2: {typeof(T2).Name}, Value2: {value2}";
    }
}