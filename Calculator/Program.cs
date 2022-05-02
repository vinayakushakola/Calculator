using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            Console.WriteLine("Enter 1st number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number = ");
            string num = Console.ReadLine();
            int num2 = Convert.ToInt32(num);

            int sum = num1 + num2;
            Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);

            objCalc.Addition(num1, num2);
        }
    }
}
