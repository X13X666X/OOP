import java.io.*;

public class Main {

    public static void main(String[] args) {

        // 🔷 ЗАВДАННЯ 1 — Binary (аналог FileStream)
        try {
            // запис
            DataOutputStream dos = new DataOutputStream(
                    new FileOutputStream("test.dat"));

            dos.writeInt(123);
            dos.writeDouble(45.6);
            dos.close();

            System.out.println("Binary записано");

            // читання
            DataInputStream dis = new DataInputStream(
                    new FileInputStream("test.dat"));

            int i = dis.readInt();
            double d = dis.readDouble();

            System.out.println("int: " + i + ", double: " + d);

            dis.close();

        } catch (IOException e) {
            e.printStackTrace();
        }

        System.out.println();

        // 🔷 ЗАВДАННЯ 3 — Text
        try {
            // запис (дописування)
            BufferedWriter bw = new BufferedWriter(
                    new FileWriter("text.txt", true));

            bw.write("Hello\n");
            bw.write("World\n");
            bw.close();

            System.out.println("Текст записано");

            // читання
            BufferedReader br = new BufferedReader(
                    new FileReader("text.txt"));

            String line;
            System.out.println("Читання файлу:");

            while ((line = br.readLine()) != null) {
                System.out.println(line);
            }

            br.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
