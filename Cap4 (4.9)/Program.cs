﻿
namespace SumasResta
{
    public class prigram
    {
        public static void Main()
        {
            string SumasResta;
            double NumUno;
            double NumDos;
            double suma;
            double resta;

            Console.WriteLine("Desea hacer una Suma (S) o una Resta(R)");
            SumasResta = Convert.ToString(Console.ReadLine());

            Console.WriteLine("digite el primer numero");
            NumUno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite el segundo numero");
            NumDos = Convert.ToDouble(Console.ReadLine());

            if (SumasResta == "S")
            {
                suma = NumUno + NumDos;
                Console.WriteLine($"La suma de los dos numeros es {suma}");
            }
            else if (SumasResta == "R")
            {
                resta = NumUno - NumDos;
                Console.WriteLine($"La resta de los dos numeros es {resta}");
            }

            if (SumasResta != "S" && SumasResta != "R")
            {
                Console.WriteLine("valor introducido incorrecto, digite (S) o (R)");
            }
        }
    }
}