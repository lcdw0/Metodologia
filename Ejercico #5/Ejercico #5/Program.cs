namespace Ejercico__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir las variables
            string nombre, cargo;
            double salr, result;
            
            //Bienvenida
            Console.WriteLine("Bienvenido");

            //Registrar datos
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su cargo");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite su salario sin comas");
            salr = double.Parse(Console.ReadLine());
            result = salr*1.10;

            //Resultados
            Console.WriteLine("Su nombre es: " + nombre );
            Console.WriteLine("Su cargo es: " + cargo );
            Console.WriteLine("Su salario mas el 10 por ciento aplicado es: "+ result);
        }
    }
}
