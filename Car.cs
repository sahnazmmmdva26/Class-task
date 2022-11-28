using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask1
{
    internal class Car : Vehicle,IEngine
    {
        public int DoorCount { get; set; }
        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }

        public Car(int doorCount,int driveTime,int drivePath,int oilcapacity,int currentoil)
        {
            DoorCount = doorCount;
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
