﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2022_Car_Garage_Program
{
    public abstract class Vehicle
    {
        public int Speed;
        public int TopSpeed;

        // this outline of a method minus its implementation is called a method's SIGNATURE
        public abstract void Accelerate();
        public abstract void Brake();
        public abstract void Tick();
    }
}
