namespace RepasoBoocles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Repaso bucles");
            /*
             * *
             * * *
             * * * *
             * * * * *
             */

            // For loop:
            int i, j, filas;
            Console.WriteLine("Ingresa el numero de filas");
            filas = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");

            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             */

            int x, y, filas2;
            Console.WriteLine("Ingresa el numero de filas 2:");
            filas2 = Convert.ToInt32(Console.ReadLine());

            for (x = 1; x <= filas2; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");
        }
    }
}
