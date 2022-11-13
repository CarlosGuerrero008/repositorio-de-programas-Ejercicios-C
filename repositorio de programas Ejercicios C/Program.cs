namespace doblar_numero_multilplicarlo_por_veinticinco
{
    public class Program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doblado;
            Console.WriteLine("Por favor ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine($"el resultado de la operación es: {resultado}");
        }
    }
}
