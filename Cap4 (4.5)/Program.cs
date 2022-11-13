namespace dias
{
    public class program
    {
        public static void Main()
        {
            int dias = 0;
            int mes = 0;
            int anyo = 0;
            int reciduo;

            Console.WriteLine("ingrese el anyo");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el dia");
            dias = Convert.ToInt32(Console.ReadLine());

            reciduo = anyo % 4;

            if (reciduo == 0)
            {

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dias <= 31)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 31)
                    {
                        Console.WriteLine("digite correctamente el dia, no puede pasar de 31");
                    }
                }
                else if (mes > 12)
                {
                    Console.WriteLine("Digite correctamente el mes, el mes no puede pasar de 12");
                }

                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dias <= 30)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 30)
                    {
                        Console.WriteLine("digite correctamente el dia, no puede pasar de 30");
                    }
                }


                if (mes == 2)
                {
                    if (dias <= 29)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 29)
                    {
                        Console.WriteLine("digite correctamente el dia, no puede pasar de 29");
                    }
                }
            }

            else if (reciduo != 0)
            {

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dias <= 31)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 31)
                    {
                        Console.WriteLine("digite correctamente el dia,no puede pasar de 31");
                    }
                }
                else if (mes > 12)
                {
                    Console.WriteLine("Digite correctamente el mes, el mes no puede pasar de 12");
                }

                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dias <= 30)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 30)
                    {
                        Console.WriteLine("digite correctamente el dia, no puede pasar de 30");
                    }
                }


                if (mes == 2)
                {
                    if (dias <= 28)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 28)
                    {
                        Console.WriteLine("digite correctamente el dia, no puede pasar de 28");
                    }
                }
            }
        }
    }
}
