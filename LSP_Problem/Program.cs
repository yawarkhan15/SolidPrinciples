using System;
using System.Collections.Generic;

namespace LSP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<Customer> customers = new List<Customer>();
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            customers.Add(new EnquiryCustomer());

            foreach (Customer item in customers)
            {
                item.Add();
            }

        }
    }

    //Ordinary Customer Class
    public class Customer // Close for Modification but Open for Extensions
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

    public class EnquiryCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return 2;
        }

        public override void Add()
        {
            throw new NotImplementedException("For Enquiry type of Customer");
        }
    }


    public interface IErrorHandler
    {
        void HandleError(string error);
    }
    public class FileErrorHandler : IErrorHandler
    {
        public void HandleError(string error)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", error);
        }
    }

        public class EventErrorHandler : IErrorHandler
        {
            public void HandleError(string error)
            {
                // Event Viewer Code
            }
        }
    public class EventErrorHandler : IErrorHandler
    {
        public void HandleError(string error)
        {
            // Event Viewer Code
        }
    }
}
