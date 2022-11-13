public class program
{
    public static void Main()
    {
        int numero;
        double estatura;
        int numero_de_personas;
        double total;
        numero = 1;
        total = 0;

        Console.WriteLine("Ingresa el numero de personas");
        numero_de_personas = Convert.ToInt32(Console.ReadLine());

        while (numero <= numero_de_personas)
        {
            Console.WriteLine("Ingresa la estatura");
            estatura = Convert.ToDouble(Console.ReadLine());
            total = total + estatura;
            numero = numero + 1;
        }
        Console.Write($"el promedio es {total / numero_de_personas}");
    }
}