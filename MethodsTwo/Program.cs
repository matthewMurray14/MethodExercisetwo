using System;

namespace methodestwo
{
    class Program
    {
        //Method for addition.Method goes outside main scope.
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        //main scop is below
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Alright, sho nuff, may I have another?");
            int num2 = int.Parse(Console.ReadLine());

            int sumOne = Sum(num1, num2);

            Console.WriteLine($"The answer is {sumOne}.");
            //starts multiplication
            Console.WriteLine("That was addition. Now let's try multiplication. Please give me another number.");

            int xOne = int.Parse(Console.ReadLine());

            Console.WriteLine("And another one.");

            int xTwo = int.Parse(Console.ReadLine());

            int sumTwo = multiply(xOne, xTwo);

            Console.WriteLine($"The answer is, {sumTwo}");

            Console.WriteLine("Now, division. Please enter a number.");

            int dOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number.");

            int dTwo = int.Parse(Console.ReadLine());

            int sumThree = divideOne(dOne, dTwo);

            Console.WriteLine($"Your answer is, {sumThree}");
            //starts substraction



            int difOne = int.Parse(Console.ReadLine());

            Console.WriteLine("One more time. Enter number.");

            int difTwo = int.Parse(Console.ReadLine());

            int sumFour = subtraction(difOne, difTwo);

            Console.WriteLine($"And the answer is, {sumFour}.");

            
        }
        //Outside of main scope. Functions for remaining operations
        //Multiplication function
        public static int multiply(int xOne, int xTwo)
        {
            return xOne * xTwo;
        }
        //Division
        public static int divideOne(int dOne, int dTwo)
        {
            return dOne / dTwo;
        }
        //Subtraction

        public static int subtraction(int difOne, int difTwo)
        {
            return difOne - difTwo;
        }

        

        
    }

}
