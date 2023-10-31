using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_the_LAST_OnE
{
    public class Pattern
    {
        public double Cost { get; set; }
        public string Name { get; set; }
       
        public Pattern(string name, double cost)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                throw new ArgumentException(null, nameof(name));
            }

            Cost = cost;
        }
    }
}
