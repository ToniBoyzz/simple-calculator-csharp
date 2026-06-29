namespace Calculadora;

public class Program
{
    static void Main()
    {
        // Controls the main application loop
        int exit = 1;
        while(exit == 1)
        {   
            // Clears the console screen at the start of each iteration
            Console.Clear();

            Console.WriteLine("================Calculator================");

            // Initiating the menu options
            Console.WriteLine("Which operation do you want?");

            Console.WriteLine("1-Sum");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Division");
            Console.WriteLine("4-Modulo");
            Console.WriteLine("5-Quadratic Equation:");

            try
            {
                 // Reads the user's menu choice
                int resp = int.Parse(Console.ReadLine()!);
                switch (resp)
                {
                    case 1:
                        // Asking for the input numbers
                        Console.WriteLine("First Number:");
                        int num1 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Second Number:");
                        int num2= int.Parse(Console.ReadLine()!);

                        // Performing the addition
                        int result = num1 + num2;

                        Console.WriteLine($"The solution is: {result}");
                        break;

                    case 2:
                        Console.WriteLine("First Number:");
                        num1 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Second Number:");
                        num2 = int.Parse(Console.ReadLine()!);

                        // Performing the subtraction
                        result = num1 - num2;

                        Console.WriteLine($"The solution is: {result}");
                        break;

                    case 3:
                        Console.WriteLine("First Number:");
                        num1 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Second Number:");
                        num2 = int.Parse(Console.ReadLine()!);

                        // Performing the division
                        result = num1 / num2;

                        Console.WriteLine($"The solution is: {result}");
                        break;

                    case 4:
                        Console.WriteLine("First Number:");
                        num1 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Second Number:");
                        num2 = int.Parse(Console.ReadLine()!);

                        // Performing the modulo operation (remainder)
                        result = num1 % num2;

                        Console.WriteLine($"The solution is: {result}");
                        break;

                    case 5:
                        // Asking for the quadratic equation coefficients (ax² + bx + c = 0)
                        Console.WriteLine("Number (n*x²):");
                        double a = double.Parse(Console.ReadLine()!);

                        Console.WriteLine("Number (n*x):");
                        double b = double.Parse(Console.ReadLine()!);

                        Console.WriteLine("Constant:");
                        double c = double.Parse(Console.ReadLine()!);

                        // Calculating the discriminant (Delta)
                        double delta = (b * b) - 4 * a * c; 

                        // Checking if real roots exist
                        if(delta < 0)
                        {
                            Console.WriteLine("This equation doesn't have real roots.");
                            break;
                        }
                        else
                        {
                            // Calculating the roots using Bhaskara's formula
                            double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                            double x2 = (-b - Math.Sqrt(delta)) / (2*a);

                            // Checking if the two roots are identical
                            if(x1 == x2)
                            {
                                Console.WriteLine($"It has one root: x = {x1}");
                            }
                            else
                            {
                                Console.WriteLine($"The roots are: x = {x1} or x = {x2}");
                            }
                        }
                        break;

                    default:
                        // Handles invalid menu numbers
                        Console.WriteLine("Option not found in menu.");
                        break;
                }   
            }
            catch (FormatException)
            {
                // Handles invalid non-numeric inputs in the math operations
                Console.WriteLine("Please, use only numbers.");
            }              

            Console.WriteLine("Try again (1=Yes, any other number=No):");

            // Safely reading the exit choice
            try
            {
                exit = int.Parse(Console.ReadLine()!);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid option. Exiting...");
                exit = 2;
            }
        }

        Console.WriteLine("Bye");
    }
}