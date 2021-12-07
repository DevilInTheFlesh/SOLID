using System;

namespace Good_Design
{
    class Program
    {
        static void Main(string[] args)
        {   
            Bakery bakery = new Bakery(new CakeReader(), new CakeBinder(), new CakeValidator());
            bakery.Process();
        }
    }
}
