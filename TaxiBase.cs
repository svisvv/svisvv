using System;
using System.Collections.Generic;
using System.Text;

namespace LabRab2
{
    public abstract class TaxiBase
    {
        public int NumCar { get; set; }
        

        public TaxiBase(int numCar)
        {
            NumCar = numCar;
        }
        
    }
}

