namespace ConsoleApp64
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //string s = null;
            try
            {
                Console.WriteLine("Enter the string");
                string s = Console.ReadLine();
                if (s != null)
                {
                    Console.WriteLine(s.ToUpper());
                }
                else
                {
                    throw new NullReferenceException("Null value");
                }
                
            } catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
