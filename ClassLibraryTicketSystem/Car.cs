using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        
        //Class that represents a car object? (I'm bad at adding comments to the code....sorry)
        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        //Returns a set price of 240
        public override double Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
