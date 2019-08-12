using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class Pins : IPin
    {
        private readonly Dictionary<string,IConnection> _pins = new Dictionary<string,IConnection>();

        public IConnection this[string name] => _pins[name];

        public IConnection Add(string name)
        {
            IConnection result = new Connection(name);
            _pins.Add(name, result);
            return result;
        }
    }
}
