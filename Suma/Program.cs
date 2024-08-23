namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;
            Console.WriteLine("Ingrese un número entero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número entero: ");
            num2 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            
            Console.WriteLine($"La suma es {suma}");

            

        }   
    }
}
