using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2022_Car_Garage_Program
{
    public class Bicycle : Vehicle
    {
        public string Brand;
        public bool TrainingWheels;
        public BikeType BikeType;
        public int Speed;
        public int TopSpeed;

        public Bicycle(string brand, bool trainingWheels, BikeType bikeType)
        {
            Brand = brand;
            TrainingWheels = trainingWheels;
            BikeType = bikeType;
            Speed = 0;
            switch (bikeType)
            {
                case BikeType.Road:
                    TopSpeed = 20;
                    break;
                case BikeType.Mountain:
                    TopSpeed = 17;
                    break;
                case BikeType.Hybrid:
                    TopSpeed = 15;
                    break;
                case BikeType.Electric:
                    TopSpeed = 20;
                    break;
            }
        }

        public override void Accelerate()
        {
            if(Speed < TopSpeed)
            {
                Speed++;
            }
        }

        public override void Brake()
        {
            if(Speed > 0)
            {
                Speed--;
            }
        }

        public override void Tick()
        {
            if(Speed > 0)
            {
                Speed--;
            }
        }
    }

    public enum BikeType
    {
        Road,
        Mountain,
        Hybrid,
        Electric
    }
}
