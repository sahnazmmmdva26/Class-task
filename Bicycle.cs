using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask1
{
    internal class Bicycle : Vehicle,IEngine
    {
        public string PedalKind { get; set; }
        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }

        public Bicycle(string pedalkind, int driveTime, int drivePath,int oilcapacity,int currentoil)
        {
            PedalKind = pedalkind;
            DriveTime = driveTime;
            DrivePath = drivePath;
            OilCapacity = oilcapacity;
            CurrentOil = currentoil;
        }
        public void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity - CurrentOil);
        }
    }
}
