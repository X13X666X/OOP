abstract class Currency {
    protected double amount;

    public Currency(double amount) {
        this.amount = amount;
    }

    public abstract double toUAH();
    public abstract void print();

    @Override
    public String toString() {
        return amount + " " + this.getClass().getSimpleName();
    }
}
