public class IEuro implements ICurrency, IPrintable {
    private final double amount;
    private static final double RATE = 42.0;

    public IEuro(double amount) {
        this.amount = amount;
    }

    @Override
    public double toUAH() {
        return amount * RATE;
    }

    @Override
    public void print() {
        System.out.println("Euro: " + amount + " => " + toUAH() + " UAH");
    }
}