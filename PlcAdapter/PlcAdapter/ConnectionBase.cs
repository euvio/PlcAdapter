using System;
using System.Collections;

namespace PlcAdapter
{
    public abstract class ConnectionBase
    {
        protected ConnectionBase() { }

        public int Id { get; set; } // 主键
        public string Recognition { get; protected set; } // 品牌/型号
        public string IP { get; protected set; }
        public int Port { get; protected set; }

        public event EventHandler ConnectionClosed;
        public event EventHandler<EventArgs> ConnectionOpened;
        public virtual bool IsConnected { get; protected set; }

        protected abstract void Open(string ip, int port);
        protected abstract void Dispose();

        public void Open()
        {
            Open(IP, Port);
            IsConnected = true;
            ConnectionOpened?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            Dispose();
            IsConnected = false;
            ConnectionClosed?.Invoke(this, EventArgs.Empty);
        }

        #region Read
        public abstract short ReadInt16(string addr);
        public abstract int ReadInt32(string addr);
        public abstract bool ReadBool(string addr);
        public abstract short[] ReadInt16(string addr, int len);
        public abstract int[] ReadInt32(string addr, int len);
        public abstract bool[] ReadBool(string addr, int len);
        #endregion

        #region Write
        public abstract void WriteInt16(string addr, short value);
        public abstract void WriteInt32(string addr, int value);
        public abstract void WriteBool(string addr, bool value);
        public abstract void WriteInt16(string addr, short[] values);
        public abstract void WriteInt32(string addr, int[] values);
        public abstract void WriteBool(string addr, bool[] values);
        #endregion
    }
}
