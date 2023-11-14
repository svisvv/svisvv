using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public class Shirt : OutfitBase
    {
        public double LengthSleeve { get; set; }

        public Shirt(double lengthSleeve, decimal cost, double size) : base(cost, size)
        {
            if (lengthSleeve != null)
            {
                LengthSleeve = lengthSleeve;
            }
            else
            {
               throw new ArgumentException(null, nameof(lengthSleeve));
            }
        }
    }
}
