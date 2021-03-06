using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {

        public Car(DateTime date, string licensePlate)
            :base (date, licensePlate)
        {
            Brobizz = false;
        }
        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        

        //Returns a set price of 240
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            }

            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
