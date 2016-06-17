using VL.Common.DAS.Utilities;
using VL.Common.Logger.Objects;
using VL.Common.Protocol;

namespace ConsoleManager.Contexts
{
    public class ServiceContext : VL.Common.Protocol.IService.ServiceContext
    {
        public ServiceContext(DbConfigEntity databaseConfig, ProtocolConfig protocolConfig, ILogger serviceLogger) : base(databaseConfig, protocolConfig, serviceLogger)
        {
        }

        protected override bool InitOthers()
        {
            return true;
        }
    }
}
