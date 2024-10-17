using System;
class Exception
{
    static void Main(String[] args)

    {
        try
        {
            Console.WriteLine("Enter the Number1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 > 0)
            {
                Console.WriteLine(n1 / n2);
            }
            else
            {
                throw new DivideByZeroException("Divide by zero exception");

            }
        }catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

	}
}
