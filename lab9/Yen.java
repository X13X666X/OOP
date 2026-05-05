class Yen extends Currency {
    public Yen(double amount) {
        super(amount);
    }

    @Override
    public double toUAH() {
        return amount * 0.25;
    }

    @Override
    public void print() {
        System.out.println(amount + " Yen = " + toUAH() + " UAH");
    }
}
