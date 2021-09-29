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
            var motorcycle = new MC();
            var actualPrice = motorcycle.Price();
            Assert.AreEqual(125, actualPrice);
            Assert.AreNotEqual(240,actualPrice);

        }
        [TestMethod]
        public void MCTestMethod()
        {
            var motorcycle = new MC();
            var vehicleType = motorcycle.VehicleType();
            Assert.AreEqual("MC", vehicleType);
            Assert.AreNotEqual("Car",vehicleType);

        }

    }
}
