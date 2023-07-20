using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public class JsonAddressEntityRepository : IAddressEntityRepository
    {
        private JsonAddressEntityRepository() { }
        public static JsonAddressEntityRepository Instance { get; } = new JsonAddressEntityRepository();

        public AddressEntity GetAddressEntity(string id)
        {
            return null;
        }
    }
}
