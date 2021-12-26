using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static Invoice[] invoices =
       {
                         new Invoice( 83, "Electric sander", 7, 57.98M ),
                         new Invoice( 24, "Power saw", 18, 99.99M ),
                         new Invoice( 7, "Sledge hammer", 11, 21.5M ),
                         new Invoice( 77, "Hammer", 76, 11.99M ),
                         new Invoice( 39, "Lawn mower", 3, 79.5M ),
                         new Invoice( 68, "Screwdriver", 106, 6.99M ),
                         new Invoice( 7, "Sledge hammer", 11, 21.5M ),
                         new Invoice( 77, "Hammer", 80, 11.99M ),
                         new Invoice( 39, "Lawn mower", 5, 79.5M ),
                         new Invoice( 68, "Screwdriver", 60, 6.99M ),
                         new Invoice( 56, "Jig saw", 21, 11M ),
                         new Invoice( 3, "Wrench", 34, 7.5M )
        };

        public static  void SortInvoicesByDescription(Invoice[] invoices)
        {
            var sortedInvoices = invoices
                .OrderByDescending((invoice) => invoice.PartDescription)
                .ThenBy((invoice) => invoice.Quantity);
            Console.WriteLine( "{0,20}{1,20}" ,
                               "Description", "Quantity");
            foreach (var item in sortedInvoices)
            {
                Console.WriteLine($"{item.PartDescription, 20}," +
                    $"{item.Quantity, 20}");
            }
        }
        public static void FindPriceByDescription(Invoice[] invoices)
        {
            var selectPrice =
                from invoice in invoices
                let value = invoice.Quantity * invoice.Price
                orderby value, invoice.PartDescription
                select new { invoice.PartDescription, Value = value };
            Console.WriteLine("{0,20}{1,20}",
                               "Description", "Invoice Value");
            foreach (var invoice in selectPrice)
            {
                Console.WriteLine($"{invoice.PartDescription,20}," +
                    $"{invoice.Value,20:C}");
            }
        }

        public static void FindPriceByDescriptionTuple(Invoice[] invoices)
        {  // using Tuples
            var selectPrice =
                from invoice in invoices
                let value = invoice.Quantity * invoice.Price
                orderby value, invoice.PartDescription
                select (invoice.PartDescription,  value );
            Console.WriteLine("{0,20}{1,20}",
                               "Description", "Invoice Value");
            foreach ((string Desc, decimal Value) invoice in selectPrice)
            {
                Console.WriteLine($"{invoice.Desc,20}," +
                    $"{invoice.Value,20:C}");
            }
        }

        public static void FindPriceByDescriptionLambdas(Invoice[] invoices)
        {  // using Tuples
             IEnumerable<(string Desc, decimal InvoiceValue)> selectPrice = invoices
                .Select (invoice => (Desc: invoice.PartDescription, 
                                     Value: invoice.Quantity * invoice.Price))
                .OrderBy(invoice => invoice.Desc).ThenBy(invoice=>invoice.Value);

                 
            Console.WriteLine("{0,20}{1,20}",
                               "Description", "Invoice Value");
            foreach ((string Desc, decimal Value) invoice in selectPrice)
            {
                Console.WriteLine($"{invoice.Desc,20}," +
                    $"{invoice.Value,20:C}");
            }
        }
        private static string GroupTitle(decimal price)
        {
            return price <= 12 ? 
                "Invoice price below 12" : 
                "Invoice price above 12";
        }
        public static void Main(string[] args)
        {
            //IEnumerable<Invoice> sortedByDescription =  //IEnumerable<Invoice>
            //    from invoice in invoices
            //    orderby invoice.PartDescription descending
            //    select invoice;

            //foreach (var item in sortedByDescription)
            //{
            //    Console.WriteLine($"{item.PartDescription}");
            //}

            //SortInvoicesByDescription(invoices);
           //FindPriceByDescription(invoices);
            FindPriceByDescriptionLambdas(invoices);

            var groups =
                from invoice in invoices
                group invoice by GroupTitle(invoice.Price) into groupsByPrice
                select groupsByPrice;

            // Order groups of Invoices by PartDescription,
            // sorted by PartDescription in each group
             var groupsWithLambdas = invoices
                .GroupBy(invoice => GroupTitle(invoice.Price))
                .OrderByDescending(invoice => invoice.Key)
                .Select(invoice => new
                            {
                                Title = invoice.Key,
                    //Sorting invoices based on PartDescription in descending order
                                groupElements = invoice.OrderByDescending(x => x.PartDescription)
                            }); // may use a Tuple as well
            ;
              

            Console.WriteLine();
            foreach (var group in groupsWithLambdas)
            {
                Console.WriteLine("Group: {0}, Items in group: {1}",
                                 group.Title, group.groupElements.Count());
                foreach (var invoice in group.groupElements)
                {
                    Console.WriteLine(invoice);
                }

                //Group invoices in subgroups,
                //where the outer subgroup is defined by the first letter in the part description
                //and the inner group comprises the invoice details of invoices whose part description starts with the corresponding first letter
                var queryNestedGroups =
                from invoice in invoices
                group invoice by ("Start by letter: " + invoice.PartDescription[0]) into letterGroup
                select letterGroup;

                // Execute the query. Note that we only iterate over the groups,
                // not the items in each group
                foreach (var items in queryNestedGroups)
                {
                    Console.WriteLine("{0} has {1} elements.", items.Key, items.Count());
                    foreach (var item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
            }


    }
}
