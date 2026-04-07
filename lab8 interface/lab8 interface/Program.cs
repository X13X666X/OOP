namespace OOP_Lab9_Variant19_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICurrency yen = new Yen(2000);
            ICurrency euro = new Euro(100);

            ((IPrintable)yen).Print();
            ((IPrintable)euro).Print();
        }
    }
}