using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created the objec/instance of calculator class
            Calculator objCalc = new Calculator();

            // Taking inputs from user
            Console.WriteLine("Enter 1st number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Taking inputs from user
            Console.WriteLine("Enter 2nd number = ");
            string num = Console.ReadLine();
            int num2 = Convert.ToInt32(num);

            objCalc.Addition(num1, num2);
            objCalc.Sub(30, 12);
        }
    }
}
