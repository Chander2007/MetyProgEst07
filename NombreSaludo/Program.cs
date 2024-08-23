namespace NombreSaludo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double resultado;
            Console.Write("Proporciona el radio: ");
            radio = float.Parse(Console.ReadLine());

            resultado = Math.PI * Math.Pow(2, radio);

            Console.WriteLine($"El área del círculo es {resultado}");
        }
    }
}
