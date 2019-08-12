using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class Connection : IConnection
    {
        private List<IConnection> _connections = new List<IConnection>();

        public Connection(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Connect(IConnection value)
        {
            if (_connections.Contains(value))
            {
                throw new Exception("Connection " + value.Name + " already added");
            }

            _connections.Add(value);
        }

        public void Disconnect(IConnection value)
        {
            if (!_connections.Contains(value))
            {
                throw new Exception("Connection " + value.Name + " not exists");
            }

            _connections.Remove(value);
        }

        public Level Read(int dep = 0)
        {
            Level result = Level.HIMPEDANCE;
            foreach(var connection in _connections)
            {
                var value = connection.Read(dep + 1);
                if (result == Level.HIMPEDANCE || result == value)
                {
                    result = value;
                }
                else
                {
                    throw new Exception("Level Conflic in " + Name);
                }
            }

            return result;
        }
    }
}
