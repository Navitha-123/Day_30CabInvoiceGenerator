using System.Linq.Expressions;

namespace Day_30CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double Fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare for Normal ride is " +Fare);


            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator(RideType.PREMIUM);
            double Fare1 = invoiceGenerator.CalculateFare(2.0, 20);
            Console.WriteLine("Total fare for premium ride is " + Fare1);




        }
    }
}