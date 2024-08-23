namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Por favor ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            if (num%2 == 0) 
            {
                Console.WriteLine($" {num} Es un número par");
            }
            else
            
                Console.WriteLine($" {num} Es un número impar");
            }
        }
    }
