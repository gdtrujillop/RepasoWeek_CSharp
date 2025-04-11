namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RETO CALCULADORA
            Console.WriteLine("Dame first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa Operación (+ ,- * /): ");
            char operacion = Console.ReadLine()[0];

            double resul = 0;

            if (operacion == '+')
            {
                resul = n1 + n2;
                Console.WriteLine("La suma de n1 + n2 es: " + resul);
            }
            else if (operacion == '-')
            {
                if (n1 < n2)
                {
                    Console.WriteLine("El numero n1 debe ser mayor a n2");
                }
                else
                {
                    resul = n1 - n2;
                    Console.WriteLine("La resta de n1 - n2 es: " + resul);
                }
            }

            else if (operacion == '*')
            {
                resul = n1 * n2;
                Console.WriteLine("La multiplicacion de n1 * n2 es: " + resul);

            }

            else if (operacion == '/')
            {
                if (n1 < n2)
                {
                    Console.WriteLine("El numero n1 debe ser mayor a n2");
                }
                else
                {
                    resul = n1 / n2;
                    Console.WriteLine("La división de n1 / n2 es: " + resul);
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar opción correcta");
            }
        }
    }
}
