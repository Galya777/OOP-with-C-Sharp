using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
   public class Program
    {
        private static void Main(string[] args)
        {
            List<Product> list = new List<Product>() {
                new Product(){Description = "Desktop computer", Quintity = 1 }
            };
            Console.WriteLine("Create a  store");
            Store store = new Store(list);
            Console.WriteLine("\nShow products in store");
            Console.WriteLine(store);
            Console.WriteLine("Create employees ...");
            Employee e = new Employee("Worker", store);
            Console.WriteLine(e);
            Manager m = new Manager("Manager", store);
            Console.WriteLine(m);

            Console.WriteLine("\nCreate a second store");
            List<Product> list2 = new List<Product>() {
                new Product(){Description = "Christmas tree", Quintity = 2 }
            };
            Store store2 = new Store(list2);
          
            Console.WriteLine("\nTest appointment");
            store2.OnAppointment(e);
            store2.OnAppointment(m);
           
            Console.WriteLine("\nTest change in product list");
            store2.ListOfProducts = list2;
            Console.WriteLine("\nShow products in store");
            Console.WriteLine(store2);
            
            Console.WriteLine("\nTest Quantity updates");
            store2.OnUpdateQuantity(0, 10);
            Console.WriteLine(e);
            Console.WriteLine(e.WorksAt.ListOfProducts[0]);
            e.ManageQty(e.WorksAt.ListOfProducts[0], 100);

        }
    }
}
