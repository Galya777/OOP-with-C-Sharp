using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Program
    {
        static List<int> toList(int n1, int n2, int n3, int n4)
        {
            int[] ints = new[] { n1, n2, n3, n4 };
            return ints.OfType<int>().ToList();
        }
        static Product[] products ={
            new  Product() { Description = "Electric sander", Cathegory = Type.M, WeeklyPurchases=toList(99, 82, 81, 79 ), Price = (decimal)157.98},
            new Product() { Description = "Power saw", Cathegory = Type.M, WeeklyPurchases = toList(99, 86, 90, 94), Price = (decimal)99.99 },
            new Product() { Description = "Sledge hammer", Cathegory = Type.F, WeeklyPurchases = toList(93, 92, 80, 87), Price = (decimal)21.50 },
            new Product() { Description = "Hammer", Cathegory = Type.M, WeeklyPurchases = toList(97, 89, 85, 82), Price = (decimal)11.99 },
            new Product() { Description = "Lawn mower", Cathegory = Type.F, WeeklyPurchases = toList(35, 72, 91, 70), Price = (decimal)139.50 },
            new Product() { Description = "Screwdriver", Cathegory = Type.F, WeeklyPurchases = toList(88, 94, 65, 91), Price = (decimal)56.99 },
            new Product() { Description = "Jig saw", Cathegory = Type.F, WeeklyPurchases = toList(75, 84, 91, 39), Price = (decimal)11.00 },
            new Product() { Description = "Wrench", Cathegory = Type.M, WeeklyPurchases = toList(97, 92, 81, 60), Price = (decimal)17.50 },
            new Product() { Description = "Sledge hammer", Cathegory = Type.M, WeeklyPurchases = toList(75, 84, 91, 39), Price = (decimal)21.50 },
            new Product() { Description = "Hammer", Cathegory = Type.F, WeeklyPurchases = toList(94, 92, 91, 91), Price = (decimal)11.99 },
            new Product() { Description = "Lawn mower", Cathegory = Type.M, WeeklyPurchases = toList(96, 85, 91, 60), Price = (decimal)179.50 },
            new Product() { Description = "Screwdriver", Cathegory = Type.M, WeeklyPurchases = toList(96, 85, 51, 30), Price = (decimal)66.99 },
        };

        private static string GroupTitle(Type type)
        {
            return type == Type.M ?
                "Cathegory goup: M" :
                "Cathegory goup: F";
        }
        
        private static string GroupQuarter(YearlyQuarter Quarter)
        {
            switch (Quarter)
            {
                case YearlyQuarter.First:
                    return "First: ";
                case YearlyQuarter.Second:
                    return "Second: ";
                case YearlyQuarter.Third:
                    return "Third: ";
                case YearlyQuarter.Fourth:
                    return "Fourth: ";
                default:
                    return "";
            }
        }
        public static int average(Product product)
        {
            int average = 0;
            for (int i = 0; i < product.WeeklyPurchases.Count; ++i)
                average += product.WeeklyPurchases.ElementAt(i);

            average/= product.WeeklyPurchases.Count;
            return average;
        }
        public static void GroupByCategoryCountDescending(Product[] products)
        {
            var groups = products
                           .GroupBy(product => GroupTitle(product.Cathegory))
                           .OrderByDescending(product => product.Key)
                           .Select(product => new
                           {
                               Title = product.Key,
                               groupElements = product.OrderByDescending(x => x.Cathegory)
                           });
            ;
            Console.WriteLine();
            foreach (var group in groups)
            {
                Console.WriteLine("Number of products in a group: {0}",
                                  group.groupElements.Count());
                foreach (var product in group.groupElements)
                {
                    Console.WriteLine(product);
                }
            }
        }
        public static void GroupByQtrAndProductPriceAvg(Product[] products)
        {
            var groups =
               from product in products
               group product by GroupQuarter(product.Quarter) into groupsByPrice
            from newGroup2 in
               (from product in groupsByPrice
                group product by average(product))
            group newGroup2 by groupsByPrice.Key;

            foreach (var outerGroup in groups)
            {
                Console.WriteLine($"Quarter Group = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tCategory group: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.ID} {innerGroupElement.WeeklyPurchases} ");

                    }
                }
            }

        }

        public static void GroupByQtrCategoryWeeklySum(Product[] products)
        {
            var groups =
               from product in products
               group product by GroupQuarter(product.Quarter) into groupsByPrice
               from newGroup2 in
               (from product in groupsByPrice
                group product by product.WeeklyPurchases.Sum())
               group newGroup2 by groupsByPrice.Key;
            foreach (var outerGroup in groups)
            {
                Console.WriteLine($"Quarter Group = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tCategory group: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.ID} {innerGroupElement.WeeklyPurchases.Sum()} ");

                    }
                }
            }

        }

        public static void GroupByQtrCategoryAndProducts(Product[] products)
        {
            var queryNestedGroups =
               from product in products
               group product by product.Quarter into newGroup1
               from newGroup2 in
               (from product in newGroup1
                group product by product.Cathegory)
               group newGroup2 by newGroup1.Key;

            foreach (var outerGroup in queryNestedGroups)
            {
                Console.WriteLine($"Quarter Group = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tCategory group: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.ID} {innerGroupElement.WeeklyPurchases.Average()} ");
                                          
                    }
                }
            }
        }
        public static void GroupByQtrMinMaxPrice(Product[] products)
        {
            var groups =
               from product in products
               group product by GroupQuarter(product.Quarter) into groupsByPrice
               from newGroup2 in
               (from product in groupsByPrice
                group product by product.WeeklyPurchases.Min())
               group newGroup2 by groupsByPrice.Key;

            foreach (var outerGroup in groups)
            {
                Console.WriteLine($"Quarter Group = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tCategory group: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.ID} {innerGroupElement.WeeklyPurchases.Min()} ");
                        Console.WriteLine($"\t\t{innerGroupElement.ID} {innerGroupElement.WeeklyPurchases.Max()} ");
                    }
                }
            }

        }
        public static void Main(string[] args)
        {
            GroupByCategoryCountDescending(products);

            GroupByQtrAndProductPriceAvg(products);

            GroupByQtrCategoryWeeklySum(products);

            GroupByQtrCategoryAndProducts(products);

            GroupByQtrMinMaxPrice(products);
        }
    }

}

