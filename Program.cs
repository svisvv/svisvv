using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            var outfit1 = new Trousers("Хлопок", 3300, 31);
            var outfit2 = new Shirt(34, 2500, 48);
            var outfit3 = new Shirt(15, 5000, 44);
            var outfit4 = new Shirt(50, 8400, 46);
            var outfit5 = new Trousers("Вискоза", 2750, 28);
            var outfit6 = new Trousers("Лён", 10250, 30);
            var outfit7 = new Shirt(40, 4100, 42);

            var List = new OutfitsList { outfit1, outfit5, outfit6, outfit2, outfit3, outfit4, outfit7 };

            var result = List.GetTotalCostEachType();
            foreach (KeyValuePair<string, decimal> keyValuePair in result)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }
            Console.Read();
        }
    }
}
