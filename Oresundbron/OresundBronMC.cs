using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class OresundBronMC : Vehicle
    {
        public OresundBronMC(DateTime date, string licensePlate)
            :base(date, licensePlate)
        {
            
        }
        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        public override double Price()
        {
            if (Brobizz == true)
            {
                return 73;
            }

            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
