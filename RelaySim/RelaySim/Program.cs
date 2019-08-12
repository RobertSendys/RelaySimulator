using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bulb("b1");
            b.Pin["c1"].Connect(StdConn.VCC);
            b.Pin["c2"].Connect(StdConn.GND);
            b.Run();
            Console.WriteLine("Bulb {0} is {1}", b.Name, b.IsOn);
            Console.ReadKey();
        }
    }
}
