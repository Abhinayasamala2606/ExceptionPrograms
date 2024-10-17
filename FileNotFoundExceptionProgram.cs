using System.IO;

namespace ConsoleApp66
{
    class FileNotFoundExceptionProgram
    {
        static void Main(string[] args)
        {
            string path = ".net";
            Console.WriteLine("Enter the file path or file name");
            string s = Console.ReadLine();
            try
            {
                if(s == path)
                {
                    Console.WriteLine(path + " File Found");
                }
                else
                {
                    throw new FileNotFoundException("File not found");
                }
                
            }catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
