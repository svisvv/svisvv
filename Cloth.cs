using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public abstract class OutfitBase
    {
        public decimal Cost { get; set; }
        public double Size { get; set; }

        protected OutfitBase(decimal cost, double size)
         {
            if (cost != null)
           {
                Cost = cost; 
            }
            else
            {
                throw new ArgumentException(null, nameof(cost));
            }
        
            if (size != null)
            {
                Size = size;
            }
            else
            {
                throw new ArgumentException(null, nameof(size));
            }
        }
    }
}
