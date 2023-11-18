using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringToPatterns.CreationMethods.Before;
using System;

namespace UnitTest.CreationMethods
{
    [TestClass]
    public class Before
    {
        [TestMethod]
        public void TestCreateVehicle()
        {
            Vehicle bicycle = new Vehicle("Urban Terran", "BOLT", 2023, "White");
            Console.WriteLine(bicycle);
            Vehicle bike = new Vehicle("Honda", "Unicorn", 2023, "Black", 50);
            Console.WriteLine(bike);
            Vehicle electricCar = new Vehicle("Hyundai", "Kona", 2023, "White", 20);
            Console.WriteLine(electricCar);
        }
    }
}
