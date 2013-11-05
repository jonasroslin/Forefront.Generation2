using System;

namespace Forefront.Generation2.Garage
{
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu();
            Garage garage = new Garage();
            bool isStillRunning = true;

            do
            {
                switch (menu.ShowMenuToTheUserAndReturnSelectedIndex())
                {
                    case 1:
                        {
                            AddParkingLotsToGarage(garage);
                            break;
                        }
                    case 2:
                        {
                            CreateAndParkANewCarInTheGarage(garage);
                            break;
                        }
                    case 3:
                        {
                            garage.WriteGarageLayoutToTheUser();
                            break;
                        }
                    case 4:
                        {
                            isStillRunning = CheckIfTheUserWantsToCloseTheApplication();
                            break;
                        }
                }

            } while (isStillRunning);
           
        }

        private static void CreateAndParkANewCarInTheGarage(Garage garage)
        {
            var newCar = CreateANewCar();
            garage.ParkCar(newCar);
        }

        private static Car CreateANewCar()
        {
            Console.Write("Enter registration number: ");
            string registrationNumber = Console.ReadLine();

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Car car = new Car();
            car.RegistrationNumber = registrationNumber;
            car.Model = model;
            car.Color = color;
            return car;
        }

        private static void AddParkingLotsToGarage(Garage garage)
        {
            Console.Write("Enter number of parking lots: ");
            var numberOfParkingLotsInput = Console.ReadLine();
            var numberOfParkingLots = Convert.ToInt32(numberOfParkingLotsInput);
            garage.AddParkingLots(numberOfParkingLots);
        }

        private static bool CheckIfTheUserWantsToCloseTheApplication()
        {
            Console.Write("Are you sure you want to exit? (Y/N): ");
            var yesOrNo = Console.ReadLine();
            return yesOrNo.ToLower() != "y";
        }
    }
}
