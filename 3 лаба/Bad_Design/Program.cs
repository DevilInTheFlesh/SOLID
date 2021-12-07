using System;

namespace Bad_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake first = new Cake("Napoleon", 2);
            first.BakeCake();
        }
    }
}
