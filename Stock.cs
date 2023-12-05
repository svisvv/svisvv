using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab5
{
    public class Stock
    {
        public int ProductCount { get; set; }

        public Stock(int productCount)
        {
            ProductCount = productCount;
        }

        public int WriteOfProduct(int necessaryProduct)
        {
            if (necessaryProduct > ProductCount)
            {
                ProductCount = 0;
                throw new MissingProductException();
            }
            else
            {
                ProductCount -= necessaryProduct;
            }

            return ProductCount;
        }

        public int GetProductCount()
        {
            return ProductCount;
        }
    }
}
