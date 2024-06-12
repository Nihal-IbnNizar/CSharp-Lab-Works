using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileClass
{
    internal class Android:Mobile
    {
        public string OSVersion;
        public Android(String brand,String model, String OSVersion):base(brand,model)
        {
            this.OSVersion = OSVersion;
        }

        public override void PrintDetails()     //use 'override' while inheriting
        {
            base.PrintDetails();
            Console.WriteLine("Operating System: " +OSVersion);
        }
    }
}
