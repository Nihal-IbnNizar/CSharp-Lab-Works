using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobileClass
{
    public interface ICamera
    {
        void TakePhoto();
    }

    public interface IGPS
    {
        void GetLocation();
    }
    internal class Android:Mobile,ICamera,IGPS
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

        public void TakePhoto()
        {
            Console.WriteLine("Photo is clicked!");
        }

        public void GetLocation()
        {
            Console.WriteLine("Location is being tracked!");
        }
    }

}