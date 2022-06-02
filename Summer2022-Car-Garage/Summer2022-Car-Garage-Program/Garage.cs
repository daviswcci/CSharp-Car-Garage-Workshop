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
    }
}
