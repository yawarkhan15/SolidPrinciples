using System;

namespace ISP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICustomer oldClient = new Customer();
            oldClient.Add();

            IRead newClient = new Customer();
            newClient.Add();
            newClient.Read();
        }
    }

    public interface IEnquiry
    {
        double CalculateDiscount();
    }

    public interface ICustomer : IEnquiry
    {
        void Add();
    }
    public interface IRead : ICustomer
    {
        void Read();
    }

    //Ordinary Customer Class
    public class Customer : ICustomer , IRead
    {
        public virtual double CalculateDiscount()
        {
            return 0;
        }
        public virtual void Add()
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

        public virtual void Read()
        {
            
        }
    }
    public class GoldCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
    }
    public class SilverCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
    }
    public class EnquiryCustomer : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
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
