using System;
using System.Collections.Generic;

namespace Forefront.Generation.Garage
{
    public class Garage
    {
        public List<ParkingLot> ParkingLots { get; set; }

        public Garage()
        {
            ParkingLots = new List<ParkingLot>();
        }

        public void AddParkingLots(int numberOfSpotsToAdd)
        {
            for (int i = 0; i < numberOfSpotsToAdd; i++)
            {
                var parkingSport = new ParkingLot();
                ParkingLots.Add(parkingSport);
            }
        }

        public void ParkCar(Car car)
        {
            foreach (var parkingSpot in ParkingLots)
            {
                if (parkingSpot.CarParkedOnThisLot == null)
                {
                    parkingSpot.ParkCar(car);
                    return;
                }
            }
        }

        public void WriteGarageLayoutToTheUser()
        {
            int lotNumber = 1;
            foreach (var parkingLot in ParkingLots)
            {
                Console.Write("Parking lot {0}: ", lotNumber);
                if (parkingLot.IsOccupied)
                    Console.WriteLine("{0} - {1} - {2}", parkingLot.CarParkedOnThisLot.Model,
                                      parkingLot.CarParkedOnThisLot.RegistrationNumber,
                                      parkingLot.CarParkedOnThisLot.Color);
                
                else
                    Console.WriteLine("Emtpy");
                
                lotNumber++;
            }
        }
    }
}