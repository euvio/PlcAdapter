using System;
using System.Collections.Generic;
using System.Linq;

namespace PlcAdapter
{
    public class PlcRespositoryFile : List<IPlc>, IPlcRepository
    {
        #region Singleton

        private PlcRespositoryFile()
        {
        }

        public static PlcRespositoryFile Instance { get; } = new PlcRespositoryFile();

        #endregion Singleton

        public new void Add(IPlc plc)
        {
            if ((this as IPlcRepository).IsDuplicated(plc))
            {
                throw new ArgumentException("Duplicated PLC ID.", nameof(plc));
            }
            base.Add(plc);
        }

        public new void AddRange(IEnumerable<IPlc> plcs)
        {
            foreach (var plc in plcs)
            {
                Add(plc);
            }
        }

        public IEnumerable<IPlc> GetAllPlcs()
                   => this;

        IPlc IPlcRepository.GetPlcById(int id) => this.Single(it => it.Id == id);

        IEnumerable<IPlc> IPlcRepository.GetPlcsByIp(string ip)
           => this.Where(it => it.IP == ip);

        IEnumerable<IPlc> IPlcRepository.GetPlcsByIpPort(string ip, int port)
           => this.Where(it => it.IP == ip && it.Port == port);

        IEnumerable<IPlc> IPlcRepository.GetPlcsByRecognition(string recognition)

          => this.Where(it => it.Recognition == recognition);

        bool IPlcRepository.IsDuplicated(IPlc plc)
       => this.Any(it => it.Id == plc.Id);

        bool IPlcRepository.IsDuplicated(int plcId)
           => this.Any(it => it.Id == plcId);

        public new void Remove(IPlc plc) => this.RemoveAll(it => it.Id == plc.Id);
    }
}