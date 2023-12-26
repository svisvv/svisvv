using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите значения сопротивлений, разделив их пробелом/ами:");
            string input = Console.ReadLine();
            string[] resistanceStrings = input.Split(' ');
            double[] resistances = new double[resistanceStrings.Length];
            for (int i = 0; i < resistanceStrings.Length; i++)
            {
                resistances[i] = double.Parse(resistanceStrings[i]);
            }

            Console.WriteLine("Выберите тип соединения (1 - параллельное, 2 - последовательное):");
            int choice = int.Parse(Console.ReadLine());

            IResistanceCalculationStrategy calculationStrategy;
            if (choice == 1)
            {
                calculationStrategy = new ParallelResistanceCalculationStrategy();
            }
            else if (choice == 2)
            {
                calculationStrategy = new SerialResistanceCalculationStrategy();
            }
            else
            {
                Console.WriteLine("Некорректный выбор.");
                return;
            }

            double totalResistance = calculationStrategy.CalculateResistance(resistances);
            Console.WriteLine("Сопротивление на участке электрической цепи: " + totalResistance);
            Console.Read();

        }
    }
}
