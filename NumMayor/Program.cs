namespace NumMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Dime un numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Dime otro numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Dime otro mas ");
            num3 = int.Parse(Console.ReadLine());

            int mayor;

            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            Console.WriteLine("El mayor es: " + mayor);

        }
    }
}
