public class Main {
    public static void main(String[] args) {
        Currency yen = new Yen(1000);
        Currency euro = new Euro(50);

        yen.print();
        euro.print();
    }
}