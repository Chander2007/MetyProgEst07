namespace DimeNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            Console.WriteLine("Hola, me gustaría saber tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre}");
            Console.WriteLine("Me gustaría saber tu apellido");
            apellido = Console.ReadLine();
            Console.WriteLine($"Mucho gusto {nombre} {apellido}");


        }
    }
}
