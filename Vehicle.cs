using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask1
{
    public abstract class Vehicle
    {
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }

        public virtual void AvarageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        }
    }
}
