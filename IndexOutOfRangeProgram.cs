namespace ConsoleApp60
{
    class IndexOutOfRangeProgram
    {
       
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            
            Console.WriteLine("Enter the index value");
            int n=int.Parse(Console.ReadLine());
            try
            {
                if (n >= 0 && n <= arr.Length)
                {
                    Console.WriteLine("The given index value:" + arr[n]);
                }
                else
                {
                    throw new IndexOutOfRangeException("IndexOutOfRangeException : Invalid Index");
                }
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }

            
            
        }
    }
}
