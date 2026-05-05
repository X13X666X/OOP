class Euro extends Currency {
    public Euro(double amount) {
        super(amount);
    }

    @Override
    public double toUAH() {
        return amount * 42;
    }

    @Override
    public void print() {
        System.out.println(amount + " Euro = " + toUAH() + " UAH");
    }
}
