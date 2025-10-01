namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation = Chooseoperation();
            decimal num1 = GetNumber();
            decimal num2 = Getnumber2();
            decimal result = 0;

            switch (operation)
            {
                case 1:
                    result = plus(num1, num2);
                    break;
                case 2:
                    result = minus(num1, num2);
                    break;
                case 3:
                    result = multiplication(num1, num2);
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine(" number cannot divide by zero");
                    else
                    {
                        result = division(num1, num2);
                    }

                    break;

            }
            Tulos(result);
        }

        /// <summary>
        /// Lets user chooce an operation
        /// </summary>
        /// <returns>Returns a valid input between 1-4</returns>
        static int Chooseoperation()
        {
            Console.WriteLine("choose an operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            while (true)
            {
                String? input = Console.ReadLine();
                if (int.TryParse(input, out int operation) && operation >= 0 && operation <= 4)
                {
                    Console.WriteLine($"You chose operation {operation}");
                    return operation;
                }

                else
                    Console.WriteLine("Choose number between 1-4");
            }

        }
        /// <summary>
        /// User enters the first number
        /// </summary>
        /// <returns> Returns a valid  number</returns>  
        static decimal GetNumber()
        {
            Console.WriteLine("enter first number");
            while (true)
            {
                String? input = Console.ReadLine();
                if (Decimal.TryParse(input, out Decimal number1))
                {
                    Console.WriteLine($"You entered {number1}");
                    return number1;
                }
                else
                    Console.WriteLine("Please enter a valid number");


            }


        }

        /// <summary>
        /// User enters he second number
        /// </summary>
        /// <returns> Returns a valid number</returns>
        static decimal Getnumber2()
        {
            Console.WriteLine("enter second number");
            while (true)
            {
                String? input = Console.ReadLine();
                if (Decimal.TryParse(input, out Decimal number2))
                {
                    Console.WriteLine($"You entered {number2}");
                    return number2;
                }
                else
                    Console.WriteLine("Please enter a valid number");









            }

        }

        /// <summary>
        /// program makes + calculation
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static decimal plus(decimal num1, decimal num2)
        {
            return num1 + num2;







        }

        /// <summary>
        /// program makes minus calculation
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static decimal minus(decimal num1, decimal num2)
        {
            return num1 - num2;

        }

        /// <summary>
        /// program makes multiplication
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static decimal multiplication(decimal num1, decimal num2)
        {
            return num1 * num2;

        }
        /// <summary>
        /// program makes division
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static decimal division(decimal num1, decimal num2)
        {


            return num1 * num2;
        }


        static void Tulos(decimal result)
        {
            Console.WriteLine($"tulos on: {result}");
        }


















    }
}
