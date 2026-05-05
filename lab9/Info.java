class Info implements IInterfaceNonGeneric {

    @Override
    public <T1, T2> String getInfo(T1 value1, T2 value2, Class<T1> c1, Class<T2> c2) {
        return "Type1: " + c1.getSimpleName() + ", Value1: " + value1 +
               "; Type2: " + c2.getSimpleName() + ", Value2: " + value2;
    }
}
