public class Euro extends Currency {
    private static final double RATE = 42.0;

    public Euro(double amount) {
        super(amount);
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