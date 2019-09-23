using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeetSimpleProductType
{
    class Product
    {
        public string Name{ get; private set; }
        decimal? price;
        public decimal? Price { get; private set; }

        public Product()
        {
        }

        public Product(string Name, decimal? Price = null)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public static List<Product> GetSampleProducte()
        {
            List<Product> list = new List<Product>()
            {
                new Product{Name="Мивина", Price = 5.50m},
                new Product{Name="Доширак", Price = 12.50m},
                new Product{Name="Ролтон", Price = 10.9M}

            };
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Name, Price);
        }
    }
}
