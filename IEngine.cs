using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask1
{
    internal interface IEngine
    {
        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }

        void RemainOilAmount();
    }
}
