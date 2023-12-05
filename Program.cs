using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock peachStock = new Stock(80);
            try
            {
                peachStock.WriteOfProduct(47);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(peachStock.GetProductCount());
            }

            Console.Read();
        }
    }
}
