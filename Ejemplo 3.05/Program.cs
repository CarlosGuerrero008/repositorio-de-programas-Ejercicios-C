namespace numero_mayor_con_tres_digitos
{
    public class program
    {
        public static void Main()
        {
            double num1;
            double num2;
            double num3;
            Console.WriteLine("digite el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite el tercer numero");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"el numero mayor es {num2}");
            }
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"el numero mayor es {num1}");
            }
            if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine($"el numero mayor es {num3}");
            }
        }
    }
}