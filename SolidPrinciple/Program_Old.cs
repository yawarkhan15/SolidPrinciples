using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Customer
    {
        public void Add()
        {
            try
            {
                // Adds the Customer class to Database Logic 

            }
            catch(Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }
    }
}
