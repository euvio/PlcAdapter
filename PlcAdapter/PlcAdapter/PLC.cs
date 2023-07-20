using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public class PLC : IPLC
    {
        private PLC() { }
        public static PLC Instance { get; } = new PLC();

        public short ReadInt16(string id)
        {
            var entity = JsonAddressEntityRepository.Instance.GetAddressEntity(id);
            return JsonConnectionRepository.Instance
                .GetConnection(entity.ConnectionId).ReadInt16(entity.Addr);
        }

        public int ReadInt32(string id)
        {
            throw new NotImplementedException();
        }

        public bool ReadBool(string id)
        {
            throw new NotImplementedException();
        }

        public short[] ReadInt16(params string[] ids) // 判断参数传入的地址的是不是使用的同一个IP，Port，品牌，类型，自动诊断是不是连续的，然后一次性写入。
        {
            throw new NotImplementedException(); // 为了保证原子性，必须传入的参数能够一次性读取完毕。如果需要分批连续读写，第一次成功，第二次失败，破坏了原子性。
        } // 读不必保证原子性，写必须要保证原子性。

        public int[] ReadInt32(params string[] ids)
        {
            throw new NotImplementedException();
        }

        public bool[] ReadBool(params string[] ids)
        {
            throw new NotImplementedException();
        }

        public void WriteInt16(string id, short value)
        {
            throw new NotImplementedException();
        }

        public void WriteInt32(string id, int value)
        {
            throw new NotImplementedException();
        }

        public void WriteBool(string id, bool value)
        {
            throw new NotImplementedException();
        }

        public void WriteInt16((string id, short value) idValuePairs)
        {
            throw new NotImplementedException();
        }

        public void WriteInt32((string id, int value) idValuePairs)
        {
            throw new NotImplementedException();
        }

        public void WriteBool((string id, bool value) idValuePairs)
        {
            throw new NotImplementedException();
        }
    }
}
