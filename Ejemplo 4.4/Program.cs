namespace promedio_eda_con_ciclo
{
    public class program
    {
        public static void Main()
        {
            int numero;
            int edades;
            int numero_de_personas;
            int total;
            numero = 1;
            total = 0;

            Console.WriteLine("Ingresa el numero de estudiantes");
            numero_de_personas = Convert.ToInt32(Console.ReadLine());

            while (numero <= numero_de_personas)
            {
                Console.WriteLine("Ingresa la edad de los estudiantes");
                edades = Convert.ToInt32(Console.ReadLine());
                total = total + edades;
                numero = numero + 1;
            }
            Console.Write($"el promedio es {total / numero_de_personas}");
        }
    }
}

