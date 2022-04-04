using System;

namespace Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "1", "2", "3" };

            try
            {
                string testString = null;
                Console.WriteLine(array[3]);
                Console.WriteLine(testString.Length);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An error has occured \n {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed!");
            }

            string hello = Console.ReadLine();
            bool helloBool = int.TryParse(hello, out int helloInt);

            try
            {
                if (!helloBool) ;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"This is not working as intended \n {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Hello hello");
            }
            
        }
    }
}
