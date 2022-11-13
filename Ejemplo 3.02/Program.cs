namespace negativo_o_positivo
{
    public class program
    {
        public static void Main()
        {
            double num1;

            Console.WriteLine("digite el numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            if (0 > num1)
            {
                Console.WriteLine($"el numero es negativo {num1}");
            }
            else if (0 <= num1)
            {
                Console.WriteLine($"el numero es positivo {num1}");
            }
        }
    }
}
