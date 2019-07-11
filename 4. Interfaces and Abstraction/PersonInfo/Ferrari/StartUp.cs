using System;

namespace Ferrari
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            iCar driver = new Ferrari(driverName);

            Console.WriteLine(driver.ToString());
        }
    }
}
