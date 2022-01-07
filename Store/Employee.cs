using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
    public class Employee:EventArgs
    {
        private string name;
        private Store worksAt;

       
    
        public Employee(string name, Store store)
        {
            Name = name;
            worksAt = store;
            worksAt.Appoint += GetAppointed;
            worksAt.PropertyChanged += ManageListOfProducts;

        }

        public virtual void GetAppointed(object sender, EventArgs args)
        {
            Console.WriteLine("GetAppointed");
            if (args is Manager) return;
            Employee e = args as Employee;
            worksAt = (Store)sender;

            Console.WriteLine("Employee: {0} appointed to {1}", e.Name, ((Store)sender).STORE_NAME);
        }
        public Store WorksAt
        {
            get { return worksAt; }
            set { worksAt = value; }
        }
        /// <summary>
        /// Delegate Qty update task to a method of the store, where the Employee works
        /// </summary>
        /// <param name="p"></param>
        /// <param name="qty"></param>
        public void ManageQty(Product p, int qty)
        {
            WorksAt.OnUpdateQuantity(worksAt.ListOfProducts.IndexOf(p), qty);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal void ManageListOfProducts(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "ListOfProducts")
            {
                Console.WriteLine(this.GetType());// note this and all derived classes are notified
                Console.WriteLine("{0} list changed", args.PropertyName);
            }

        }

        public override string ToString()
        {
            return $"Employee {worksAt}: {(string.Join(", ", worksAt.ListOfProducts))}";
        }
    }
}
