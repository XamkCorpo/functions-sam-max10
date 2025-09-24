namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chooseoperation();
            GetNumber();
            Getnumber2();
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
        /// <returns> Returns a valid decimal number</returns>  
        static Decimal GetNumber()
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
        /// <returns> Returns a valid decimal number</returns>
        static Decimal Getnumber2()
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













}
