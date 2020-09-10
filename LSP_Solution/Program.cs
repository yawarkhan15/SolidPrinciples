using System;
using System.Collections.Generic;

namespace LSP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            //customers.Add(new EnquiryCustomer());

            foreach (Customer item in customers)
            {
                item.Add();
            }


            //List<IEnquiry> enquiries = new List<IEnquiry>();
            //enquiries.Add(new GoldCustomer());
            //enquiries.Add(new SilverCustomer());
            //enquiries.Add(new EnquiryCustomer());

            //foreach (IEnquiry item in customers)
            //{
            //    item.CalculateDiscount();
            //}
        }
    }
    public interface IEnquiry
    {
        double CalculateDiscount();
    }

    public interface ICustomer :IEnquiry    {
        void Add();
    }
    //Ordinary Customer Class
    public class Customer : ICustomer 
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
