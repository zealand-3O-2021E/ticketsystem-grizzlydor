using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        //This is a base class
        public abstract string LicensePlate { get; set; }
        public abstract DateTime Date { get; set; }
        public abstract double Price();
        public abstract string VehicleType();
    }
}
