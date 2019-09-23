using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeetSimpleProductType
{
    class ProductComparer : IComparer<Product>
    { 
      
        public int Compare(Product x, Product y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}
