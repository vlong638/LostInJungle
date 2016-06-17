using VL.Common.DAS.Objects;

namespace ConsoleManager.Utilities
{
    public class DbHelper
    {
        public static string DbNameOfLostInJungle = "LostInJungle";
        public static DbSession DbSessionOfLostInJungle { get { return ServiceContext.DatabaseConfig.GetDbConfigItem(DbNameOfLostInJungle).GetDbSession(); } }
    }
}
