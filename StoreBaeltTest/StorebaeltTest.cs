using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace StoreBaeltTest
{
    [TestClass]
    public class StorebaeltTest
    {
        //absolutely no clue why this isn't working....
        [TestMethod]
        public void SBCarPrice()
        {
            var datetime = new DateTime(2021, 09, 04);
            StoreBaeltCar sbcar = new StoreBaeltCar(datetime, "7654321");
            sbcar.Brobizz = true;
            double actualValue = sbcar.Price();
            Assert.AreEqual(182.4, actualValue);
        }
    }
}
