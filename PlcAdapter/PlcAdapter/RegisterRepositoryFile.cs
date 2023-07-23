using System.Collections.Generic;

namespace PlcAdapter
{
    public class RegisterRepositoryFile : Dictionary<string, Register>, IRegisterRepository
    {
        private RegisterRepositoryFile()
        { }

        public static RegisterRepositoryFile Instance { get; } = new RegisterRepositoryFile();
    }
}