using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_the_LAST_OnE
{
    public class CMS<T> where T : Pattern

    {
        public List<T> PatternsList = new List<T>();

        public void PatternsPrint()
        {
            var PrintToConcole = new StringBuilder("\n"+"\n");
            foreach (var listOfPatterns in this.PatternsList)
            {
                PrintToConcole.Append("     " + listOfPatterns.Name + " - " + listOfPatterns.Cost + " у.е." + "\n");
            }

            Console.WriteLine(PrintToConcole);
        }

    }
    
}
