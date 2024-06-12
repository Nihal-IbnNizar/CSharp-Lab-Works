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
            Console.WriteLine(phoneNumber);
        }

        public void ChargeBattery(int amount)
        {
            batterylevel = batterylevel + amount;
            if (batterylevel < 100)
            {
                Console.WriteLine(batterylevel);
            }
        }

        public void UseBattery(int amount)
        {
            batterylevel = batterylevel - amount;
            Console.WriteLine(batterylevel);
        }

        public void PrintDetails()
        {
            Console.WriteLine(brand);
            Console.WriteLine(model);
            Console.WriteLine(batterylevel);
        }
    }
}
