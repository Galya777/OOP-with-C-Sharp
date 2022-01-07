using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
    public class Product
    {
        private string description;
        private int quintity;

        public string Description { get { return description; } set { description = value ?? "Unnamed product"; } }

        public int Quintity { get { return quintity; } set { quintity = value >= 0 ? value : 0; } }

        public Product(string description, int quintity)
        {
            this.description = description;
            this.quintity = quintity;
        }
        public Product()
        {
            this.description = "";
            this.quintity = 0;
        }
        public Product(Product other)
        {
            this.description = other.description;
            this.quintity = other.quintity;
        }

        public override string ToString()
      => $"Description: {description}\n Quintity: {quintity}";
    }
}
