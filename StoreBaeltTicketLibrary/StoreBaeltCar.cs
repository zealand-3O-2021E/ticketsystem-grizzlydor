using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : ClassLibraryTicketSystem.Vehicle
    {
        public StoreBaeltCar(DateTime date, string licensePlate)
            : base(date,licensePlate)
        {
            
        }

        public override double Price( bool brobizz)
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (brobizz = true)
                {
                    double weekendPrice = (240 * 0.80) * 0.95;
                    return weekendPrice;
                }

                return 240 * 0.80;
            }

            if (brobizz = true)
            {
                return 240 * 0.95;
            }

            return 240;

        }
    }
}
