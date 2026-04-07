public class IYen implements ICurrency, IPrintable {
    private final double amount;
    private static final double RATE = 0.27;

    public IYen(double amount) {
        this.amount = amount;
    }

    @Override
    public double toUAH() {
        return amount * RATE;
    }

    @Override
    public void print() {
        System.out.println("Yen: " + amount + " => " + toUAH() + " UAH");
    }
}