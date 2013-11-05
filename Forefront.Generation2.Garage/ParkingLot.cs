using System;

namespace Forefront.Generation2.Garage
{
    public class ParkingLot
    {
        public bool IsOccupied { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public Car CarParkedOnThisLot { get; set; }

        public ParkingLot()
        {
            IsOccupied = false;
        }

        public void ParkCar(Car car)
        {
            IsOccupied = true;
            CarParkedOnThisLot = car;
        }
    }
}