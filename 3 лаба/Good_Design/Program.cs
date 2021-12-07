using System;

namespace Good_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake second = new Cake("Выпечка", 5);
            second.BakePastry(new Pie());
            Console.WriteLine();
            second.BakePastry(new Tart());
        }
    }
}
