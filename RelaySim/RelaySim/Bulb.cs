using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class Bulb :DeviceBase,IDevice
    {
        private bool _ison = false;
        private readonly IConnection c1;
        private readonly IConnection c2;

        public Bulb(string name)
        {
            _name = "Bulb " + name;
            c1 = _pins.Add("c1");
            c2 = _pins.Add("c2");
        }

        public bool IsOn => _ison;

        public override bool Run()
        {
            var v1 = c1.Read();
            var v2 = c2.Read();

            var ison = (v1 == Level.LOW && v2 == Level.HIGH) ||
                       (v1 == Level.HIGH && v2 == Level.LOW);

            if (_ison != ison )
            {
                _ison = ison;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
