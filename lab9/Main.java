public class Main {
    public static void main(String[] args) {

        // Завдання 1
        CurrencyStorage<Currency> storage = new CurrencyStorage<>();
        storage.add(new Yen(1000));
        storage.add(new Euro(50));
        storage.printAll();

        System.out.println();

        // Завдання 2
        IInterfaceNonGeneric info = new Info();

        System.out.println(info.getInfo(10, 5.5, Integer.class, Double.class));
        System.out.println(info.getInfo(new Yen(100), new Euro(20), Yen.class, Euro.class));
    }
}
