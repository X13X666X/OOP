public class IMain {
    public static void main(String[] args) {
        ICurrency yen = new IYen(2000);
        ICurrency euro = new IEuro(100);

        ((IPrintable) yen).print();
        ((IPrintable) euro).print();
    }
}