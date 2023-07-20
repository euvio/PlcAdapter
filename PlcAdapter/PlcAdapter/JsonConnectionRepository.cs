using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlcAdapter
{
    public class JsonConnectionRepository : IConnectionRepository
    {
        private JsonConnectionRepository() { }
        public static JsonConnectionRepository Instance { get; } = new JsonConnectionRepository();
        private readonly List<ConnectionBase> _connections = new List<ConnectionBase>();

        #region Get
        public ConnectionBase GetConnection(int id) => _connections.SingleOrDefault(it => it.Id == id);

        public ConnectionBase[] GetConnections(string recognition) => _connections.Where(it => it.Recognition == recognition).ToArray();

        public ConnectionBase[] GetConnections(string ip, int port) => _connections.Where(it => it.IP == ip && it.Port == port).ToArray();

        public ConnectionBase[] GetAllConnections() => _connections.ToArray();

        #endregion

        public bool AddConnection(ConnectionBase connection)
        {
            if (IsDuplicate(connection)) return false;
            _connections.Add(connection);
            return true;
        }

        public bool RemoveConnection(ConnectionBase connection)
        {
            var index = _connections.FindIndex(it => connection.Id == it.Id);
            if (index == -1) return false;
            _connections.RemoveAt(index);
            return true;
        }

        public bool IsDuplicate(int id) => _connections.Any(it => it.Id == id);

        public bool IsDuplicate(ConnectionBase connection) => _connections.Any(it => it.Id == connection.Id);
    }
}
