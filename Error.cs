using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab5
{
    public class MissingProductException: Exception
    {
        public MissingProductException() : base("Отсутствует необходимый товар")
        { 
        }

    }
}

