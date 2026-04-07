public abstract class Currency {
    protected double amount;

    public Currency(double amount) {
        this.amount = amount;
    }

    // переведення в гривні
    public abstract double toUAH();

    // вивід
    public void print() {
        System.out.println("Amount: " + amount);
    }
}