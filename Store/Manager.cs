using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
    public class Manager : Employee
    {
        public Manager(string name, Store store) : base(name, store)
        {
            store.PropertyChanged += ManageProductQuantity;
        }
        internal void ManageProductQuantity(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "ProductQuantity")
            {
                Console.WriteLine(this.GetType());
                Console.WriteLine("Product {0} quantity changed", args.PropertyName);
            }
        }
        public override void GetAppointed(object sender, EventArgs args)
        {

            if (args is Manager)
            {
                Manager m = args as Manager;
                WorksAt = (Store)sender;
                Console.WriteLine("Manager: {0} appointed to {1}.", m.Name, ((Store)sender).STORE_NAME);
            }
        }

        public override string ToString()
        {
            return $"Manager: {WorksAt} {(string.Join(", ", WorksAt.ListOfProducts))}";
        }


    }
}
