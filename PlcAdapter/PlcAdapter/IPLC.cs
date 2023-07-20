using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public interface IPLC
    {
        #region Read
        short ReadInt16(string id);
        int ReadInt32(string id);
        bool ReadBool(string id);
        short[] ReadInt16(params string[] ids);
        int[] ReadInt32(params string[] ids);
        bool[] ReadBool(params string[] ids);
        #endregion

        #region Write
        void WriteInt16(string id, short value);
        void WriteInt32(string id, int value);
        void WriteBool(string id, bool value);
        void WriteInt16((string id, Int16 value) idValuePairs);
        void WriteInt32((string id, Int32 value) idValuePairs);
        void WriteBool((string id, bool value) idValuePairs);
        #endregion
    }
}
