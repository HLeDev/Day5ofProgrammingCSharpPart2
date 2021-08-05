using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day3Ex1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char yes = 'y';
            while (yes == 'y')
            {
                int AddResult, MultResult, SubtResult, DivResult, choice, num1, num2;
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                choice = Int32.Parse(Console.ReadLine());

                Calculator Result = new Calculator();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Let's do some adding!");
                        int[] addArray;
                        Console.WriteLine("Please enter how many number you would like to enter:");
                        int size = Int32.Parse(Console.ReadLine());
                        addArray = new int[size];
                        for (int i = 0; i < addArray.Length; i++)
                        {
                            Console.WriteLine($"Please enter your number starting with number {i}:");
                            int num = Int32.Parse(Console.ReadLine());
                            addArray[i] = num;
                        }
                        AddResult = Result.Add(addArray);
                        Console.WriteLine($"The result of this problem is {AddResult}");
                        break;

                    case 2:
                        Console.WriteLine("Lets subtract 2 numbers");
                        Console.WriteLine("Please enter the first number:");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the second number:");
                        num2 = Int32.Parse(Console.ReadLine());
                        SubtResult = Result.Subtract(num1, num2);
                        Console.WriteLine($"The result of this problem is {SubtResult}");
                        break;
                    case 3:
                        Console.WriteLine("Lets multiple 2 numbers");
                        Console.WriteLine("Please enter the first number:");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the second number:");
                        num2 = Int32.Parse(Console.ReadLine());
                        MultResult = Result.Multiply(num1, num2);
                        Console.WriteLine($"The result of this problem is {MultResult}");
                        break;
                    case 4:
                        Console.WriteLine("Lets divide 2 numbers");
                        Console.WriteLine("Please enter the first number:");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the second number:");
                        num2 = Int32.Parse(Console.ReadLine());
                        DivResult = Result.Divide(num1, num2);
                        Console.WriteLine($"The result of this problem is {DivResult}");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Press Y for Yes and N for No");
                yes = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Application is closing... Please press enter 2x");
            Console.ReadLine();
        }
    }
}
