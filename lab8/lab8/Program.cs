namespace OOP_Lab9_Variant19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Currency yen = new Yen(1000);
            Currency euro = new Euro(50);

            yen.Print();
            euro.Print();
        }
    }
}