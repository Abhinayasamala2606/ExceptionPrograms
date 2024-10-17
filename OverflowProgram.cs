namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Exception Overflow");
            }
        }
    }
}
