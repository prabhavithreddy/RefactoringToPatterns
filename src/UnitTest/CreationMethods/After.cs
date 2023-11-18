using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringToPatterns.CreationMethods.After;
using System;

namespace UnitTest.CreationMethods
{
    [TestClass]
    public class After
    {
        [TestMethod]
        public void TestCreateVehicle()
        {
            Vehicle bicycle = Vehicle.CreateBiCycle("Urban Terran", "BOLT", 2023);
            Console.WriteLine(bicycle);
            Vehicle bike = Vehicle.CreateBike("Honda", "Unicorn", 2023, "Black", 50);
            Console.WriteLine(bike);
            Vehicle electricCar = Vehicle.CreateElectricCar("Hyundai", "Kona", 2023, "White", 20);
            Console.WriteLine(electricCar);
        }
    }
}
