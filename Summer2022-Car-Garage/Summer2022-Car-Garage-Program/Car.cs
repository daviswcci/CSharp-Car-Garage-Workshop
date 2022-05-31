using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2022_Car_Garage_Program
{
    public class Car
    {
        // object's characteristics - properties
        // accessModifier varType varName - syntax
        public string OwnerName;
        public string Make;
        public string Model;
        public double Cost;
        public int MPG;
        public double FuelLevel;
        public int TopSpeed;
        public bool IsElectric;

        // class's constructor - CONSTRUCTS an instance of our class.
        // we use a constructor to make an object
        // accessModifier ClassName(parameters/inputs) {code we want to run} - syntax
        // empty constructor
        public Car()
        {
            OwnerName = "DefaultOwner";
            Make = "DefaultMake";
            Model = "DefaultModel";
            Cost = -1;
            MPG = -1;
            FuelLevel = -1;
            TopSpeed = -1;
            IsElectric = true;
        }
        // constructor with many parameters
        public Car(string ownerName)
        {
            OwnerName = ownerName;
            Make = "DefaultMake";
            Model = "DefaultModel";
            Cost = -1;
            MPG = -1;
            FuelLevel = -1;
            TopSpeed = -1;
            IsElectric = true;
        }

        public Car(string ownerName, string make)
        {
            OwnerName = ownerName;
            Make = make;
            Model = "DefaultModel";
            Cost = -1;
            MPG = -1;
            FuelLevel = -1;
            TopSpeed = -1;
            IsElectric = true;
        }

        public Car(string ownerName, string make, string model, double cost, int mpg, double fuelLevel, int topSpeed, bool isElectric)
        {
            OwnerName = ownerName;
            Make = make;
            Model = model;
            Cost = cost;
            MPG = mpg;
            FuelLevel = fuelLevel;
            TopSpeed = topSpeed;
            IsElectric = isElectric;
        }
    }
}
