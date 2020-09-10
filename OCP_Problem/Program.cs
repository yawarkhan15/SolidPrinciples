using System;
using System.ComponentModel;

namespace OCP_Problem
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
        private int custType;

        public int CustType
        {
            get => custType; set => custType = value;
        }
        public double CalculateDiscount()
        {
            if (custType == 1)
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }
        public void Add()
        {
            try
            {
                // Adds the Customer class to Database Logic 

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
