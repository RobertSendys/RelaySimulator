using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class DeviceBase :IDevice
    {
        protected string _name;
        protected readonly Pins _pins = new Pins();

        public string Name => _name;

        public IPin Pin => _pins;

        public virtual bool Run()
        {
            return false;
        }
    }
}
