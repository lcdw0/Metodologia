using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");
            Factura fact = new Factura();
            string producto = null;
            double precio = 0, monto;
            int cantidad = 0;
            Console.WriteLine($"{producto}");
            Console.WriteLine($"{precio}");
            Console.WriteLine($"{cantidad}");
            //Console.WriteLine($"{monto}");
        }
    }
}
