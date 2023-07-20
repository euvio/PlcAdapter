using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public interface IConnectionRepository
    {
        #region Get
        ConnectionBase GetConnection(int id);
        ConnectionBase[] GetConnections(string recognition);
        ConnectionBase[] GetConnections(string ip, int port);
        ConnectionBase[] GetAllConnections();
        #endregion

        #region Add
        bool AddConnection(ConnectionBase connection);
        bool RemoveConnection(ConnectionBase connection);
        #endregion
    }
}
