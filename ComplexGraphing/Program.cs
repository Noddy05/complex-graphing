namespace ComplexGraphing
{
    internal class Program
    {
        private static Window? window;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (window = new Window())
            {
                window.Run();
            }
        }
    }
}