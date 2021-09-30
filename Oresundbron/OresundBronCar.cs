using System;
using ClassLibraryTicketSystem;


namespace Oresundbron
{
    public class OresundBronCar : Vehicle
    {
        public OresundBronCar(DateTime date, string licensePlate)
            :base(date, licensePlate)
        {
            
        }
        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        public override double Price()
        {
            if (Brobizz == true)
            {
                return 161;
            }

            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
