using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public class AddressEntity
    {
        public string Id { get; set; }  // 主键
        public string Addr { get; set; }
        public string Description { get; set; }
        public AddressType AddressType { get; set; }
        public int ConnectionId { get; set; }
    }
}
