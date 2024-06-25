namespace Generic2
{
    internal class Program
    {

        static void Add<T>(T a, T b)
        {

            Console.WriteLine("inside  Method");
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine($"Result of adding {a} and {b}: {sum}");
        }

        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            Console.WriteLine($"Before calling Add method: x={x} y={y}");
            Program obj = new Program();
            obj.Add(x,y);
            Console.WriteLine($"AfterSwap: x={x} y={y}");
        }
    }
}

