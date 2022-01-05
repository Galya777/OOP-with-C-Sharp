using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
   public enum YearlyQuarter
    {
        First, 
        Second, 
        Third,
        Fourth
    }
   public enum Type
    {
        M, 
        F
    }
    public class Product
    {
        long cnt;
        public string ID;
        Random rnd= new Random();
        public List<int> WeeklyPurchases=new List<int>();

        public Product()
        {
          ID=string.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000);
        }

        public Type Cathegory { get { return (Type)(YearlyQuarter)rnd.Next(1, 2); } set { rnd.Next(1, 2); } }
        public string Description { get; set; }
        public decimal Price { get { return cnt; } set { cnt = (long)value; } }
        public YearlyQuarter Quarter { get { return (YearlyQuarter)rnd.Next(1, 4); } set { rnd.Next(1, 4); } }

        

       
        public override string ToString()
        {
            return string.Format("ID: \nWeekly Punchases: ", ID, WeeklyPurchases);
        }

        
    }
}
