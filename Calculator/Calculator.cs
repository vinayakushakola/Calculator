using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        // Method is used for adding two numbers
        public void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);
        }

        public void Sub(int num1, int num2)
        {
            int diff = 0;
            if (num1 >= num2)
            {
                diff = num1 - num2;
            }
            else if (num1 <= num2)
            {
                diff = num2 - num1;
            }
            Console.WriteLine("Subtraction of {0} - {1} = {2}", num1, num2, diff);
        }

        public void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication of {0} x {1} = {2}", num1, num2, num1*num2);
        }

        // Created a Addition method
        //public void Add()
        //{
        //    int num = 20;
        //    int num2 = 40;
        //    int sum = num + num2;
        //    Console.WriteLine("Addition of two numbers is {0}", sum);
        //}

        //public void Addition2()
        //{
        //    Console.WriteLine("Enter 1st number = ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter 2nd number = ");
        //    string num = Console.ReadLine();
        //    int num2 = Convert.ToInt32(num);

        //    int sum = num1 + num2;
        //    Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);
        //}
    }
}
