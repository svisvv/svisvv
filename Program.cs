using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_the_LAST_OnE
{
    class Program
    {
        static void Main(string[] args)
        {        
            var listOfPatterns = new CMS<Pattern>();

            listOfPatterns.PatternsList.Add(new Pattern("Шаблон главной страницы", 804));
            listOfPatterns.PatternsList.Add(new Pattern("Шаблон меню", 707));
            listOfPatterns.PatternsList.Add(new Pattern("Шаблон всплывающего окна", 23));

            listOfPatterns.PatternsPrint();

            Console.ReadKey();
        }
        
    }
}
