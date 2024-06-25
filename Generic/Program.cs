namespace Generic
{
    internal class Program
    {
        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a=b; 
            b=temp;
            Console.WriteLine($"Inside swap method: a={a},b={b}");
        }
        static void Main()
        {
            int x = 1;
            int y = 2;
            Console.WriteLine($"Before calling swap method: x={x} y={y}");
            Swap(x, y);
            Console.WriteLine($"After calling swap method: x={x} y={y}");

        }
    }
}
