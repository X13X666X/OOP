import java.util.*;

class CurrencyStorage<T extends Currency> implements IInterface<T> {
    private final List<T> list = new ArrayList<>();

    @Override
    public void add(T item) {
        list.add(item);
    }

    @Override
    public void printAll() {
        for (T item : list) {
            item.print();
        }
    }
}
