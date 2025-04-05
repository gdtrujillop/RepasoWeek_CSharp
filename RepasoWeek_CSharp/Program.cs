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

            if (n1 > n2 && n2 < n3)
            {
                Console.WriteLine("El mayor número es el número: " + n1);
            }
            else if (n2 > n1 && n1 < n3) { 
            Console.WriteLine("El mayor número es el número: " + n2);
             }
            else{
               Console.WriteLine("El mayor número es el número: " + n3);}
        }
    }
}
