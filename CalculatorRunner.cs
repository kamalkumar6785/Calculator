
namespace Assignment
{
    internal class CalculatorRunner
    {

        
        private readonly Calculator_Interface _calculator;
        // _calculator is the instance of Calculator_Interface

        public CalculatorRunner(Calculator_Interface calculator)
        {

            // Constructor to initialize the CalculatorRunner with a calculator implementation which will be provided in the main class
            _calculator = calculator;
        }

        public void Run()
        {
            double num1, num2;


             // taking first number from the user 
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

              // Using Double.TryParse to convert input to double
            if (!double.TryParse(input1, out num1))
            {
             
                Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
                return; // Exit the program
              }

            // taking first number from the user 

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            // Using Double.TryParse to convert input to double
            if (!double.TryParse(input2, out num2))
            {

                Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
                return; // Exit the program
           }



            Console.WriteLine();

            Console.WriteLine($"num1 is {num1}  and num2  is {num2} \n");

            // Addition
            Console.WriteLine($"Addition of num1 and num2 : {num1} + {num2} = {_calculator.Add(num1, num2)}");

            // Subtraction
            Console.WriteLine($"Subtraction of num1 and num2 : {num1} - {num2} = {_calculator.Subtract(num1, num2)}");

            // Multiplication
            Console.WriteLine($"Multiplication of num1 and num2 : {num1} * {num2} = {_calculator.Multiply(num1, num2)}");

            // Division
            Console.WriteLine($"Division of num1 and num2  : {num1} / {num2} = {_calculator.Divide(num1, num2)}");

        }
    }
}
