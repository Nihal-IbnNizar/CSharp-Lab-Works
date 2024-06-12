using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileClass
{
    internal class Mobile
    {
        public string brand;
        public string model;
        public int batterylevel;

        public Mobile(String brand, String model) 
        {
            this.brand = brand;
            this.model = model;
            this.batterylevel = 0;
        }
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine("Phone number: " +phoneNumber);
        }

        public void ChargeBattery(int amount)
        {
            batterylevel = batterylevel + amount;
            if (batterylevel < 100)
            {
                Console.WriteLine("Initial Battery Level: " +batterylevel);
            }
        }

        public void UseBattery(int amount)
        {
            batterylevel = batterylevel - amount;
            Console.WriteLine("Battery After Usage: " +batterylevel);
        }

        public virtual void PrintDetails()      //add 'virtual' if we're inheriting
        {
            Console.WriteLine("Brand :" +brand);
            Console.WriteLine("Model: " +model);
            //Console.WriteLine(batterylevel);
        }
    }
}
