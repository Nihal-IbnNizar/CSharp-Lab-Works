namespace MobileAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone sphone = new Smartphone();
            sphone.StartDevice();
            sphone.UseDevice();
        }
    }
}
