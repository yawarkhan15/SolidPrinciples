using System;

namespace DIP_Problem
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
    public class Customer : ICustomer, IRead
    {
        IErrorHandler errorHandler;

        public Customer()
        {
            if (true) // Reading from Config
            {
                ierr = new FileErrorHandler();
            }
            else
            {
                ierr = new EventErrorHandler();
            }

        }
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
                errorHandler.HandleError(ex.ToString());
            }
        }

        public virtual void Read()
        {

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

    public class ConsoleErrorHandler : IErrorHandler
    {
        public void HandleError(string error)
        {
            Console.WriteLine(error);
        }
    }

    public class EventErrorHandler : IErrorHandler
    {
        public void HandleError(string error)
        {
            //Even Viwer Error Code
        }
    }
}
