using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public static class StdConn
    {
        public static IConnection GND { get; private set; }
        public static IConnection VCC { get; private set; }

        static StdConn()
        {
            GND = new GndConnection();
            VCC = new VccConnection();
        }

    }
}
