using System;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;

namespace OresundBronTest
{
    [TestClass]
    public class OresundBronCarTest
    {
        [TestMethod]
        public void CarPriceTestMethod()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new OresundBronCar(datetime, "1234567");
            theCar.Brobizz = false;
            var actualPrice = theCar.Price();
            Assert.AreEqual(410, actualPrice);

        }
        [TestMethod]
        public void DiscountPriceTest()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new OresundBronCar(datetime, "1234567");
            theCar.Brobizz = true;
            var actualPrice = theCar.Price();
            Assert.AreEqual(161, actualPrice);
        }

        [TestMethod]
        public void CarTestMethod()
        {
            var datetime = new DateTime(2021, 09, 01);
            var theCar = new OresundBronCar(datetime, "1234567");
            var vehicleType = theCar.VehicleType();
            theCar.Brobizz = false;
            Assert.AreEqual("Oresund car", vehicleType);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateLimiterTest()
        {
            var datetime = new DateTime(2021, 09, 01);
            OresundBronCar car = new(datetime, "12345678");
            car.Brobizz = false;
            Assert.Fail();
        }
    }
}
