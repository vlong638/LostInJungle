using ConsoleManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Common.DAS.Utilities;

namespace ConsoleManager.Configs
{
    public class LostInJungleDataConfig : DbConfigEntity
    {
        public LostInJungleDataConfig(string fileName = nameof(LostInJungleDataConfig)) : base(fileName)
        {
        }

        protected override List<DbConfigItem> GetDbConfigItems()
        {
            List<DbConfigItem> result = new List<DbConfigItem>()
            {
                new DbConfigItem(DbHelper.DbNameOfLostInJungle),
            };
            return result;
        }
    }
}
