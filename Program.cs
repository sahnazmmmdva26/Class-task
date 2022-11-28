namespace classtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,3,15,30,20);
            Bicycle bicycle = new Bicycle("****",2,16,20,3);
            Plane plane = new Plane(100,4,24,44,32);
            car.AvarageSpeed();
            car.RemainOilAmount(); 
        }
    }
}