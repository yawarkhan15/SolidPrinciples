using System;

namespace OCP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Ordinary Customer Class
    public class Customer // Close for Modification but Open for Extensions
    {
        public virtual double CalculateDiscount()
        {
            return 0;
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
    public class GoldCustomer : Customer
    {
        public override  double CalculateDiscount()
        {
            return base.CalculateDiscount()  + 10;
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
