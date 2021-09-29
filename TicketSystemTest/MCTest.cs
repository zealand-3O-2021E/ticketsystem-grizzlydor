using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace TicketSystemTest
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void MCPriceTestMethod()
        {
            var datetime = new DateTime(2021, 09, 29);
            var motorcycle = new MC(datetime, "7654321");
            var actualPrice = motorcycle.Price(false);
            Assert.AreEqual(125, actualPrice);
            Assert.AreNotEqual(240,actualPrice);
        }
        public void DiscountPriceTest()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new Car(datetime, "1234567");
            var actualPrice = theCar.Price(true);
            Assert.AreEqual(118.75, actualPrice);
        }

        [TestMethod]
        public void MCTestMethod()
        {
            var datetime = new DateTime(2021, 09, 29);
            var motorcycle = new MC(datetime, "7654321");
            var vehicleType = motorcycle.VehicleType();
            Assert.AreEqual("MC", vehicleType);
            Assert.AreNotEqual("Car",vehicleType);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateLimiterTest()
        {
            var datetime = new DateTime(2021, 09, 29);
            MC motorcycle = new(datetime, "87654321");
            Assert.Fail();
        }

    }
}
