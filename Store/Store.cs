using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
    public class Store: INotifyPropertyChanged
    {
        public event EventHandler Appoint;
        public event PropertyChangedEventHandler PropertyChanged;

        public readonly string STORE_NAME;
       private static int cnt=1;
       private Employee worker;
       private Manager manager;
       private List<Product> listOfProducts;

        public Store(List<Product> list)
        {
            STORE_NAME = $"Store {(cnt++)}";
            ListOfProducts = list;
        }
        public List<Product> ListOfProducts
        {
            get { return listOfProducts; }
            set
            {
                if (value != null)
                {
                    listOfProducts = new List<Product>();
                    for (int i = 0; i < value.Count; i++)
                    {
                        listOfProducts.Add(new Product(value[i]));
                    }
                    Console.WriteLine($"{STORE_NAME}: New list of products assigned to store.");
                    Console.WriteLine(string.Join(",", listOfProducts));
                    PropertyChanged?.Invoke(this,
                                      new PropertyChangedEventArgs("ListOfProducts"));
                }
                else
                    throw new ArgumentNullException("Store: ListOfProducts cannot be initialized to null");
            }
        }
        public Employee Worker { get { return worker; } set {worker=value; } }

        public void OnUpdateQuantity(int index, int newQty)
        {
            if (index >= 0 && index < listOfProducts.Count)
            {
                Console.WriteLine("Qty changed..");
                Console.WriteLine("{0}: new Qty: {1}", listOfProducts[index], newQty);
                listOfProducts[index].Quintity = newQty;
                PropertyChanged?.Invoke(this,
                                       new PropertyChangedEventArgs("ProductQuantity"));
            }
        }

        public void OnAppointment(Employee employee)
        {
            if (employee is Manager)
            {
                // appoint manager
                manager = employee as Manager;
                Console.WriteLine("Appoint manager." + this);
                Appoint += manager.GetAppointed;
                //Notify Manager for changes in list of products and Product quantity
                PropertyChanged += manager.ManageProductQuantity;
                PropertyChanged += manager.ManageListOfProducts;
                Appoint?.Invoke(this, employee);
            }
            else

            {
                Console.WriteLine("Appoint employee." + this);
                worker = employee;
                Appoint += worker.GetAppointed;
                //Notify Manager for changes in list of products 
                PropertyChanged += worker.ManageListOfProducts;
                Appoint?.Invoke(this, employee);
            }
        }

        public override string ToString()
        {
            return $"{STORE_NAME}: {(string.Join(",", listOfProducts))}";
        }
    }
}

