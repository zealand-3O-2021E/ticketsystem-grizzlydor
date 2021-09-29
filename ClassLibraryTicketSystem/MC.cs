using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {
        public MC(DateTime date, string licensePlate)
            : base(date, licensePlate)
        {

        }
        //Class that represents the motorcycle object
        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        public override double Price(bool brobizz)
        {
            if (brobizz == true)
            {
                return 125 * 0.95;
            }

            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
