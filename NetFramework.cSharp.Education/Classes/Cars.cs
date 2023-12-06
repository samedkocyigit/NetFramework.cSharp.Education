using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Education.Classes
{
    class CarInformation
    {
        public string? CarModel;
        public string? CarType;
        public int CarAge;
        public int CarDistance;
        public string? CarFuel;
        public string? CarGear;
        public int CarBuyPrice;
        public int CarSellPrice;
        public int CarMaxDiscount;
        int CarPrice;
        public int price
        {
            get { return this.CarPrice; }

            set { this.CarPrice = value; }
        }

        public CarInformation()
        {

        }

        CarInformation(string CarModel, string CarType)
        {
            CarModel = this.CarModel; CarType = this.CarType;
        }
        CarInformation(string CarModel, string CarType, int CarAge)
        {
            CarModel = this.CarModel; CarType = this.CarType; CarAge = this.CarAge;
        }
        CarInformation(string CarModel, string CarType, int CarAge, int CarDistance)
        {
            CarModel = this.CarModel; CarType = this.CarType; CarAge = this.CarAge; CarDistance = this.CarDistance;
        }

        void SetPrice(int Price)
        {

        }

        void ListTheInfoOfTheVehicle()
        {
            Console.WriteLine("Here is the Vehicle Information:  ");
            Console.WriteLine("Car Model: {0}", this.CarModel);
            Console.WriteLine("Car Type: {0}", this.CarType);
            Console.WriteLine("Car Age: {0}", this.CarAge);
            Console.WriteLine("Car Fuel: {0}", this.CarFuel);
            Console.WriteLine("Car Gear: {0}", this.CarGear);
            Console.WriteLine("Car Price: {0}", this.CarPrice);
        }



    }
}
