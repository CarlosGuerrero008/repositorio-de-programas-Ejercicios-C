namespace sueldo_semanal
{
    public class program
    {
        public static void Main()
        {
            double horaT, pagoH, pagoS;

            Console.WriteLine("digite la catidad de horas");
            horaT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite la catidad de paga por hora");
            pagoH = Convert.ToDouble(Console.ReadLine());

            pagoS = horaT * pagoH;

            Console.Write($"el sueldo semanar es {pagoS}");
        }
    }
}