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
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new Car(datetime, "1234567");
            theCar.Brobizz = false;
            var actualPrice = theCar.Price();
            Assert.AreEqual(240, actualPrice);

        }
        [TestMethod]
        public void DiscountPriceTest()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new Car(datetime, "1234567");
            theCar.Brobizz = true;
            var actualPrice = theCar.Price();
            Assert.AreEqual(228, actualPrice);
            Assert.AreNotEqual(240,actualPrice);
        }

        [TestMethod]
        public void CarTestMethod()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new Car(datetime, "1234567");
            theCar.Brobizz = false;
            var vehicleType = theCar.VehicleType();
            Assert.AreEqual("Car", vehicleType);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateLimiterTest()
        {
            var datetime = new DateTime(2021, 09, 01);
            Car car = new(datetime, "12345678");
            car.Brobizz = false;
            Assert.Fail();
        }
        
    }
}
