
namespace Assignment
{
    internal class Calculator_Implementation : Calculator_Interface
    {
        double Calculator_Interface.Add(double num1, double num2)
        {
            return num1 + num2;
        }

        double Calculator_Interface.Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        double Calculator_Interface.Multiply(double num1, double num2)
        {
            return num1 * num2;
        
        }

        double Calculator_Interface.Divide(double num1, double num2)
        {
            if (num2 == 0)
            {

                throw new ArgumentException("Cannot divide by zero.");
            }

            return num1 / num2;
        }
    }
}
