namespace StrategyMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Multiply multiply = new Multiply();

            Add add = new Add();

            calculator.operation = multiply;

            Console.WriteLine(calculator.PerformOperation(2, 3));
            

            calculator.operation = add;

            
            Console.WriteLine(calculator.PerformOperation(2, 3));
        }
    }
}