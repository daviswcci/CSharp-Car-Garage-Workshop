using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2022_Car_Garage_Program
{
    public class Garage
    {
        // property declaration
        public int Capacity;
        public List<Vehicle> Vehicles;
        public bool HasBikeRacks;
        public bool HasGas;
        public bool IsDoorOpen;

        public Garage(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
            HasBikeRacks = true;
            HasGas = true;
            IsDoorOpen = true;
        }

        public Garage(List<Vehicle> vehicles)
        {
            Capacity = vehicles.Count;
            Vehicles = vehicles;
            HasBikeRacks = true;
            HasGas = true;
            IsDoorOpen = false;
        }

        public void OpenDoor()
        {
            Console.WriteLine("The Garage door opened!");
            IsDoorOpen = true;
        }

        public void ClosingDoor()
        {
            Console.WriteLine("The Garage door closed!");
            IsDoorOpen = false;
        }

        public void ToggleDoor()
        {
            // if IsDoorOpen == true
            //       true == true
            //           true
            //         IsDoorOpen

            // if IsDoorOpen == false
            //         true == false
            //              false
            //           !IsDoorOpen

            if(IsDoorOpen) // true represents open
            {
                IsDoorOpen = false;
            } 
            else
            {
                IsDoorOpen = true;
            }
        }

        // benefits: shorter/less code to write
        // cons: more complex to print out a message / do more than toggle that state
        public void ShortToggleDoor()
        {
            IsDoorOpen = !IsDoorOpen;
        }

        private void TernaryExample()
        {
            // variable declaration
            // type name;

            // assignment/reassignment
            // name = value;

            bool isSunny = true;

            // temperature setting without ternary statements
            int temperature;

            if (isSunny) // condition 
            {
                temperature = 90;
            }
            else
            {
                temperature = 60;
            }

            // however, we can rewrite that all to be on one line.
            // type variable = condition ? valT : valF; - ternary statements simplify to a value, and could be used anywhere where a value is used
            int ternaryTemp = isSunny ? 90 : 60;

            Console.WriteLine(temperature);
            Console.WriteLine(ternaryTemp);



            // How do we call a method?
            Car gavinCar = new Car();
            gavinCar.Accelerate(10); // increase speed from 0 to 10
            Console.WriteLine(gavinCar.Speed);
        }
    }
}
