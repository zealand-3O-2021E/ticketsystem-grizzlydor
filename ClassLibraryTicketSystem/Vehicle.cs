using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        //This is a base class

        /// <summary>
        /// Constructor that has the license plate limiting functionality
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle</param>
        /// <param name="date">The date when the vehicle crosses the bridge</param>
        public Vehicle(DateTime date, string licensePlate)
        {
            date = Date;
            if (licensePlate.Length <= 7)
            {
                licensePlate = LicensePlate;
            }
            else
            {
                throw new ArgumentException("The license plate has to be no longer than 7 characters");
            }
        }

        public abstract string LicensePlate { get; set; }
        public abstract DateTime Date { get; set; }
        public abstract double Price(bool brobizz);
        public abstract string VehicleType();
    }
}
