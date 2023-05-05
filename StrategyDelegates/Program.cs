namespace StrategyDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.PerformOperation((int a, int b) => a + b, 2, 3));

            Console.WriteLine(calculator.PerformOperation((int a , int b) => a * b, 2, 3));



        }
    }
}