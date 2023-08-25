using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringToPatterns.ChainConstructors.Before;
using System;

namespace UnitTest
{
    [TestClass]
    public class Before
    {
        [TestMethod]
        public void TestCreateVehicle()
        {
            Vehicle vehicle = new Vehicle("Toyota", "Camry", 2022, "Blue");
            Console.WriteLine(vehicle);
            Vehicle electricVehicle = new Vehicle("Toyota", "Camry", 2022, "Blue", 10, true);
            Console.WriteLine(electricVehicle);
        }
    }
}
