using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask1
{
    internal class Plane : Vehicle,IEngine
    {
        public int WingLength { get; set; }
        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }

        public string FuelType { get; set; }
        public Plane(int winglength, int driveTime, int drivePath, int oilcapacity, int currentoil)
        {
            WingLength = winglength;
            DriveTime = driveTime;
            DrivePath = drivePath;
            OilCapacity = oilcapacity;
            CurrentOil = currentoil;
        }
       public void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity-CurrentOil);
        }
    }
}
