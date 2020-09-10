using System;

namespace SRP_Solution
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
                // Adds the Customer class to Database

            }
            catch (Exception ex)
            {
                ErrorHandler objHandler = new ErrorHandler();
                objHandler.HandleError(ex.ToString());
            }
        }
    }


    public class ErrorHandler
    {
        public void HandleError(string error)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", error);
        }
    }
}
