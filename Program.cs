using System;

namespace LabRab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship1 = new Shipping(50, 100, 70703);
            var drv1 = new Drive(250, 1, 80402);
            var drv2 = new Drive(115, 2, 11113);
            var ship2 = new Shipping(150, 200, 35689);
            var ship3 = new Shipping(100, 150, 23232);
            
            
            var List = new TransportationList {ship1, drv1, drv2, ship2, ship3};
          
            Console.WriteLine("Общая стоимость поездок:");
            Console.WriteLine(drv1.GetTotalCost()+drv2.GetTotalCost());
        
            Console.WriteLine("Общая стоимость перевозок грузов:");
            Console.WriteLine(ship1.GetTotalCost()+ship2.GetTotalCost()+ship3.GetTotalCost());
            
            Console.WriteLine("Общая стоимость всех поездок и перевозок:");
            Console.WriteLine(List.GetTotalCost());
        }
    }
}

