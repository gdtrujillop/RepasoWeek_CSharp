namespace RepasoWeek_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer núumero:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo núumero:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer núumero:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El mayor número es el número: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("El mayor número es el número: " + n2);
            }
            else
            {
                Console.WriteLine("El mayor número es el número: " + n3);
            }

            Console.WriteLine("");
            Console.WriteLine("============================");
            Console.WriteLine("Calcular el área de un circulo o rectangulo: ");
            Console.WriteLine("============================");

            Console.WriteLine("Ingresar 1 para calcular el área de un circulo o 2 para calcular");
            int opc = Convert.ToInt16(Console.ReadLine());

            switch (opc)
            {

                case 1:
                    Console.WriteLine("Ingresar el radio: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    double resul = 3.1416 * (radio * 2);

                    Console.WriteLine("El área de un circulo es :" + resul);
                    break;
                case 2:
                    Console.WriteLine("Ingresar ancho: ");
                    double ancho = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresar largo: ");
                    double largo = Convert.ToDouble(Console.ReadLine());

                    double resul2 = (ancho * largo);

                    Console.WriteLine("El área de un rectanculo es es :" + resul2);
                    break;
                default:
                    Console.WriteLine("Ingresar opción correcta :");
                    break;

            }
        }
    }
}
