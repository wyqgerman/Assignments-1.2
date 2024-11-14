namespace Assignments_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }

            //Write a C# Sharp program to find the sum of first 10 natural numbers.
            int n = 10;
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine("The sum of first 10 natural numbers is: " + sum);

            //Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. Call them appropriately when user selects the option. Give the user the option to continue or exit the program.
            int number1, number2, opt;  

            Console.WriteLine("A menu driven calculator:");  

            Console.WriteLine("Enter the first Integer :");  
            number1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter the second Integer :");  
            number2 = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("1-Addition.\n2-Subtraction.\n3-Multiplication.\n4-Division.\n5-Exit.");
            Console.WriteLine("Input your choice :");  
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("The Addition: ", number1 + number2);
                    break;
                case 2:
                    Console.WriteLine("The Subtraction: ", number1 - number2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication:: ", number1 * number2);
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("The second integer is zero. Divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine("The Division: ", number1 / number2);
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input correct option");
                    break;
            }
        }

    }
}
