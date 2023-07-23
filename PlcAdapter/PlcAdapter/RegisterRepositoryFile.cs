using System;
using System.Collections.Generic;
using System.Text;

namespace PlcAdapter
{
    public class RegisterRepositoryFile : Dictionary<string, Register<ushort>>, IRegisterRepository
    {
        private RegisterRepositoryFile() { }
        public static RegisterRepositoryFile Instance { get; } = new RegisterRepositoryFile();

    }
}
