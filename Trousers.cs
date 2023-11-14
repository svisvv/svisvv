using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public class Trousers : OutfitBase
    {
        public string Material { get; set; }

        public Trousers(string material, decimal cost, double size) : base(cost, size)
        {
            if (material != null)
            {
                Material = material;
            }
            else
            {
                throw new ArgumentException(null, nameof(material));
            }
        }

    }
}
