namespace MobileClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile cls = new Mobile("Samsung", "A52");
            cls.MakeCall("9544252302");
            cls.ChargeBattery(80);
            cls.UseBattery(20);
            //cls.PrintDetails();

            Android andr = new Android("Samsung", "A52", "Android 12");
            andr.PrintDetails();
            andr.TakePhoto();
            andr.GetLocation();

        }
    }
}
