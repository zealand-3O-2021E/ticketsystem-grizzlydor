using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Vehicle
    {
        public StoreBaeltCar(DateTime date, string licensePlate)
            : base(date, licensePlate)
        {
            
        } 
        
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (Brobizz == true)
                {
                    double weekendDiscount = 240 - (240 * 0.2);
                    weekendDiscount = weekendDiscount - (weekendDiscount * 0.05);
                    return weekendDiscount;
                }
                return 240 - (240 * 0.2);
            }

            else if (Brobizz == true)
            {
                return 240 - (240 * 0.05);
            }
            return 240;

        }


        public bool Brobizz { get; set; }

        public override string LicensePlate { get; set; }
        public override DateTime Date { get; set; }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
