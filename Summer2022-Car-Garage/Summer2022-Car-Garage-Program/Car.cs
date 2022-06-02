using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2022_Car_Garage_Program
{
    public class Car : Vehicle
    {
        // object's characteristics - properties
        // accessModifier varType varName - syntax
        public string Make;
        public string Model;
        public int MPG;
        public double FuelLevel; // gallons of fuel remaining

        // class's constructor - CONSTRUCTS an instance of our class.
        // we use a constructor to make an object
        // accessModifier ClassName(parameters/inputs) {code we want to run} - syntax
        // empty constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            MPG = 19;
            FuelLevel = 100;
            Speed = 0;
            TopSpeed = 80;
        }

        public Car(string make, string model, int mpg, int fl, int speed, int topSpeed)
        {
            Make = make; // we provide lowercase make and assign it to the PROPERTY uppercase Make
            Model = model;
            MPG = mpg;
            FuelLevel = fl;
            Speed = speed;
            TopSpeed = topSpeed;
        }

        // object's functionality - methods
        // the actions an object can take
        // accessmodifier optionalmodifier returntype name(inputs){code}
        public override void Accelerate()
        {
            if(Speed <= TopSpeed)
            {
                Speed += 5;
            }
        }

        public void Accelerate(int increase)
        {
            if (Speed <= TopSpeed)
            {
                Speed += increase;
            }
        }

        public override void Brake()
        {
            if(Speed >= 5)
            {
                Speed -= 5;
            }
        }

        //What do we want to update every timestep?
        public override void Tick()
        {
            if(Speed > 0)
            {
                Speed--;
            }
            if(FuelLevel > 0)
            {
                FuelLevel -= ((Speed / 60f) / (float)MPG); //type casting
            }
            if(Speed < 0)
            {
                Speed = 0;
            }
            if(FuelLevel < 0)
            {
                FuelLevel = 0;
            }
        }

        public void Refuel()
        {
            FuelLevel = 100;
        }
    }
}
