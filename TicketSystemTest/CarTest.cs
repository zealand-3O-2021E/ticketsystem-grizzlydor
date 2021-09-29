using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketSystemTest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace TicketSystemTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void CarPriceTestMethod()
        {
            var theCar = new Car();
            var actualPrice = theCar.Price();
            Assert.AreEqual(240, actualPrice);

        }
        [TestMethod]
        public void CarTestMethod()
        {
            var theCar = new Car();
            var vehicleType = theCar.VehicleType();
            Assert.AreEqual("Car", vehicleType);

        }
        
    }
}
