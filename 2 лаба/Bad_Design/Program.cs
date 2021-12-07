using System;

namespace Bad_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake NewCake = new Cake("", "", 0);
            NewCake.Process();
        }
    }
}
