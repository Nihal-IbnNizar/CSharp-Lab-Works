using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAbstract
{
    internal class Smartphone:Mobile
    {
        private string osVersion;
        public Smartphone(string brand, string model, string osVersion) : base(brand,model, batteryLevel) 
        {
            this.osVersion = osVersion;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Switching ON the device..");
        }

        public override void UseDevice()
        {
            Console.WriteLine($"Your {brand} {model} is ready to use!");
        }

        public override void ShowDetails()
        {
            base.ShowDetails();

        }
    }
}
