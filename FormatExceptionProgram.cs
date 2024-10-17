namespace ConsoleApp63
{
    
    class FormatExceptionProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value");
                int n = int.Parse(Console.ReadLine());
                if (n is int)
                {
                    Console.WriteLine("result : "+n);
                }
                else
                {
                    throw new FormatException("Input is not a valid number");
                }
             
            }catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
               
            
        }
    }
}
