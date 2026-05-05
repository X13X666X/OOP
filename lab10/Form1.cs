using System;
using System.IO;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        string filePath = "test.dat";
        string textPath = "text.txt";

        public Form1()
        {
            InitializeComponent();
        }

        // 🔷 Завдання 1 — запис binary
        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                byte[] i = BitConverter.GetBytes(123);
                byte[] d = BitConverter.GetBytes(45.6);

                fs.Write(i, 0, i.Length);
                fs.Write(d, 0, d.Length);
            }

            MessageBox.Show("Binary записано!");
        }

        // 🔷 Завдання 1 — читання binary
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                byte[] i = new byte[4];
                byte[] d = new byte[8];

                fs.Read(i, 0, 4);
                fs.Read(d, 0, 8);

                int a = BitConverter.ToInt32(i, 0);
                double b = BitConverter.ToDouble(d, 0);

                textBox1.Text = $"int: {a}, double: {b}";
            }
        }

        // 🔷 Завдання 3 — запис тексту
        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(textPath, true))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("World");
            }

            MessageBox.Show("Текст записано!");
        }

        // 🔷 Завдання 3 — читання тексту
        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(textPath))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}