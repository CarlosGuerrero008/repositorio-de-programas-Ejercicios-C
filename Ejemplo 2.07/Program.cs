namespace leche
{
    public class program
    {
        public static void Main()
        {
            double L, G, pg, total;
            double LPG = 3.785;

            Console.WriteLine("digite la cantiadd de L");
            L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite el precio del galon");
            pg = Convert.ToDouble(Console.ReadLine());

            G = L / LPG;
            total = G * pg;

            Console.Write($"los galones son {G} la paga es {total}");

        }
    }
}
