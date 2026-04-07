public class Yen extends Currency {
    private static final double RATE = 0.27;

    public Yen(double amount) {
        super(amount);
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