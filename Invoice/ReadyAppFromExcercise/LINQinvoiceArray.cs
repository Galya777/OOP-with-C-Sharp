using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Task1
{
    public class LINQinvoiceArray
    {
        static Invoice[] invoices =
               {
            new Invoice(83, "Electric sander", 7, 57.98M),
            new Invoice(24, "Power saw", 18, 99.99M),
            new Invoice(7, "Sledge hammer", 11, 21.5M),
            new Invoice(77, "Hammer", 76, 11.99M),
            new Invoice(39, "Lawn mower", 3, 79.5M),
            new Invoice(68, "Screwdriver", 106, 6.99M)
        };
        static void GroupInvoicesByDescription(Invoice[] invoices)
        {
            var sorted = invoices.OrderByDescending((invoice) => invoice.PartDescription)
                .ThenBy((invoice) => invoice.Quantity);
            foreach(var item in sorted)
            {
                Console.WriteLine($"Description: {item.PartDescription}", $"Quantity: {item.Quantity}");
            }
        }
        public static void FindPriceByDesc(Invoice[] invoices)
        {
            var selectPrice =
                from invoice in invoices
                let price = invoice.Quantity * invoice.Price
                orderby price
                select new { invoice.PartDescription, Price = price };
            foreach (var invoice in selectPrice)
            {
                Console.WriteLine($"Description: {invoice.PartDescription}", $"Quantity: {invoice.Price}");
            }
        }
        public static void FindPriceByDescTuple(Invoice[] invoices)
        {
            var selectPrice =
                from invoice in invoices
                let price = invoice.Quantity * invoice.Price
                orderby price, invoice.PartDescription
                select ( invoice.PartDescription, price );
            foreach (var invoice in selectPrice)
            {
                Console.WriteLine($"Description: {invoice.PartDescription}", $"Quantity: {invoice.price}");
            }
        }
        public static void FindPriceByDescLambdas(Invoice[] invoices)
        {

            var selectPrice = invoices.Select(invoice =>(invoice.PartDescription, invoice.Quantity * invoice.Price))
                .OrderBy(invoice => invoice.PartDescription).ThenBy(invoice=>invoice.Item2);

                
            foreach (var invoice in selectPrice)
            {
                Console.WriteLine($"Description: {invoice.PartDescription}", $"Quantity: {invoice.Item2}");
            }
        }
        private static string GroupTitle(decimal price)
        {
            return price <= 12 ? "Invoice price below 12" : "Invoice price above 12";
        }
        static void Main(string[] args)
        {
            var sortedByDescription =
                from invoice in invoices
                orderby invoice.PartDescription descending
                select invoice;

            foreach(var item in sortedByDescription)
            {
                Console.WriteLine($"{item.PartDescription}");
            }
            var groups =
                from invoice in invoices
                group invoice by GroupTitle(invoice.Price) into groupsByPrice
                select groupsByPrice;
            var groupsWithLambdas = invoices.GroupBy(invoice => GroupTitle(invoice.Price), (tile, items) => items
             .OrderBy(item => item.PartDescription)).Select(i=>1);
                
            Console.WriteLine();
            foreach (var group in groups)
            {
                Console.WriteLine($"Group: {0}, Items in group: {1}",group.Key, group.Count());
                foreach (var invoice in group)
                {
                    Console.WriteLine(invoice);
                }
            }
        }
    }
}
