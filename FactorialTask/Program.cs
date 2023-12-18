namespace FactorialTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine(Factorial(number));

        }

       

     public  static int Factorial(int num)
        {
            if (num == 0 || num ==1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}