namespace FunctionAssigment
{
    internal class Program
    {
        /// <summary>
        ///     ask for the name and validate the input
        /// </summary>
        /// <returns> Returns valid input </returns>
        static string KysyNimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                String? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }
        /// <summary>
        /// Kysytään ikä 
        /// </summary>
        /// <returns></returns>
        static int KysyIka()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }
        /// <summary>
        /// Tulostetaan nimi ja ika
        /// </summary>
        /// <returns></returns>
        static void TulostaNimiJAika(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// tarkistetaan että syöte on positiivinen kokonaisluku
        /// </summary>
        /// <retuns></retuns>
        static bool TarkistaTaysiIkainen(int age)
        {
            return age >= 18;

        }
        /// <summary>
        /// verrataan nimeä
        /// </summary>
        /// <retuns></retuns>
        static void VertaaNimi(string name, string compareTo)
        {
            if (name.Equals(compareTo))
            {
                Console.WriteLine($"Your name is exactly 'Matti'{compareTo} (case-sensitive).");
            }

            // vertaa nimi tarkkavertailu
            if (name.Equals(compareTo))
            {
                Console.WriteLine($"Your name is exactly '{compareTo}' {compareTo} (case-insensitive).");

            }
        }






        static void Main(string[] args)
        {
            // selkeä, luettava koodi
            string name = KysyNimi();
            int age = KysyIka();

            TulostaNimiJAika(name, age);
            bool isAdult = TarkistaTaysiIkainen(age);

            if (isAdult)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
            VertaaNimi(name, "Matti");







        }
    }
}