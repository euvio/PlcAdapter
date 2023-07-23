using System.Collections.Generic;

namespace PlcAdapter
{
    public interface IPlcRepository
    {
        void Add(IPlc plc);

        IEnumerable<IPlc> GetAllPlcs();

        IPlc GetPlcById(int id);

        IEnumerable<IPlc> GetPlcsByIp(string ip);

        IEnumerable<IPlc> GetPlcsByIpPort(string ip, int port);

        IEnumerable<IPlc> GetPlcsByRecognition(string recognition);

        bool IsDuplicated(IPlc plc);

        bool IsDuplicated(int plcId);

        void Remove(IPlc plc);
    }
}