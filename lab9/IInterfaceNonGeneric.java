interface IInterfaceNonGeneric {
    <T1, T2> String getInfo(T1 value1, T2 value2, Class<T1> c1, Class<T2> c2);
}
