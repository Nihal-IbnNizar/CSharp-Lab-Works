using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAbstract
{
    public abstract class Mobile
    {
        protected string brand;
        protected string model;
        protected int batteryLevel;

        public Mobile(String brand, String model, int batteryLevel)
        {
            this.brand = brand;
            this.model = model;
            this.batteryLevel = batteryLevel;
        }
        public abstract void StartDevice();
        public abstract void UseDevice();
        

        public virtual void ShowDetails()      
        {
            Console.WriteLine($"Brand : {brand}");
            Console.WriteLine("Model: " + model);
            Console.WriteLine(batteryLevel);
        }
    }
}

