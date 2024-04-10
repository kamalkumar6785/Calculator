namespace Assignment
{
    //   Entry point of the program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instanc of Calculator_Implementation

            Calculator_Implementation cal_obj = new Calculator_Implementation();

            // Create an instance of CalculatorRunner which passes  the calculator implementation 
            CalculatorRunner Calculator_runner = new CalculatorRunner(cal_obj); 

            // Run the calculator program
            Calculator_runner.Run();
        }
    }
}
