namespace ej_210
{
    public class program
    {
        public static void Main()
        {
            double Metro;
            double Pulgada = 0.0254;
            double totalp;

            Console.WriteLine("cuantos metros requiere");
            Metro = Convert.ToDouble(Console.ReadLine());

            totalp = Metro / Pulgada;

            Console.Write($"las pulada que debe pedir {totalp}");
        }
    }
}
